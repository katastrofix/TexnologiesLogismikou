using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.Educational.IoC.Services;
using Uni.Educational.IoC.Attribute;


namespace Uni.Educational.IoC.Activation
{
    [RegisterServiceProvider(typeof(ILogger))]
    public class ObjectActivator : IObjectActivator
    {
        ObjectManager m_objectManager;

        ApplicationContext m_context;

        public ObjectActivator(ObjectManager objectManager, ApplicationContext context)
        {
            m_objectManager = objectManager;
            m_context = context;
        }

        private string GetObjectTypeLiteral(ObjectType type)
        {
            return ObjectHelpers.GetObjectTypeLiteral(type);
        }

        public object CreateObject(ObjectType type, string domain, string name)
        {
            object retObj = null;

            Type typeMetadata = null;

            var objTypeLiteral = GetObjectTypeLiteral(type);

            var logger = m_context.Locator.GetService<ILogger>();

            try
            {
                logger.LogInfo(string.Concat("Quering metadata database for object {0}:{1}:{2}", objTypeLiteral, domain, name));

                typeMetadata = m_objectManager.GetObjectByRegistrationID(
                    string.Concat(objTypeLiteral, ":", domain, ":", name));
            }
            catch (ObjectNotFoundException onfe)
            {
                logger.LogException(onfe);
            }

            logger.LogInfo("Found object metadata descriptor.");

            retObj = Activator.CreateInstance(typeMetadata);

            logger.LogInfo(string.Concat("Activated object of concrete type: ", typeMetadata.FullName));

            return retObj;

        }
        public ApplicationContext ApplicationContext
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Initialize()
        {

        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
