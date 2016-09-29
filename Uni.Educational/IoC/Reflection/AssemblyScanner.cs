using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Uni.Educational.IoC.Activation;
using Uni.Educational.IoC.Attribute;
using Uni.Educational.IoC.Services;

namespace Uni.Educational.IoC.Reflection
{
    public class AssemblyScanner
    {
        public Dictionary<string, Type> RegisteredObjects { get; set; }

        public List<Type> RegisteredServices { get; set; }


        public AssemblyScanner()
        {
            RegisteredServices = new List<Type>();
            RegisteredObjects = new Dictionary<string, Type>();
        }

        public void LoadMetadata()
        {
            GetAllRegisteredObjects();
        }


        private void GetAllRegisteredObjects()
        {
            var assembly = Assembly.GetExecutingAssembly();

            foreach (var type in assembly.GetTypes())
            {

                if (type.GetInterface(typeof(IService).FullName) != null)
                {
                    RegisteredServices.Add(type);
                }
                else if (type.GetInterface(typeof(IViewBase).FullName) != null)
                {
                    var registerAttribute = type.GetCustomAttribute<RegisterView>();
                    if (registerAttribute != null)
                    {
                        var mangledName = string.Concat(ObjectHelpers.GetObjectTypeLiteral(ObjectType.UIElement),
                              ":",
                              registerAttribute.Domain,
                              ":",
                              registerAttribute.Name);

                        RegisteredObjects.Add(mangledName, type);
                    }
                }
                else
                {
                    var registerObjectAttribute = type.GetCustomAttribute<RegisterObject>();
                    if (registerObjectAttribute != null)
                    {
                        var mangledName = string.Concat(ObjectHelpers.GetObjectTypeLiteral(registerObjectAttribute.ObjectType),
                             ":",
                             registerObjectAttribute.Domain,
                             ":",
                             registerObjectAttribute.Name);

                        RegisteredObjects.Add(mangledName, type);
                    }
                }
            }
        }

    }
}
