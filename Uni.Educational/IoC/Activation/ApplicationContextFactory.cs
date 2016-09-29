using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.Educational.IoC.Reflection;
using Uni.Educational.IoC.Services;
using Uni.Educational.View.Base;
using System.Reflection;
using Uni.Educational.IoC.Attribute;

namespace Uni.Educational.IoC.Activation
{
    public class ApplicationContextFactory
    {
        public ApplicationContext CreateContext(string configurationPath = null)
        {
            var applicationContext = new ApplicationContext();

            var scanner = new AssemblyScanner();
            scanner.LoadMetadata();

            var serviceLocator = new ServiceLocator();

            var objectManager = new ObjectManager(scanner.RegisteredObjects);

            var objectActivator = new ObjectActivator(objectManager, applicationContext);

            var viewActivator = new ViewActivator() { ApplicationContext = applicationContext };

            var logger = new Logger() { ApplicationContext = applicationContext };

            serviceLocator.TryRegisterService<IObjectActivator>(objectActivator);
            serviceLocator.TryRegisterService<IViewActivator>(viewActivator);
            serviceLocator.TryRegisterService<ILogger>(logger);
            serviceLocator.TryRegisterService<IObjectManager>(objectManager);

            serviceLocator.InitializeServiceLifetime();

            applicationContext.Locator = serviceLocator;

            return applicationContext;
        }

    }
}
