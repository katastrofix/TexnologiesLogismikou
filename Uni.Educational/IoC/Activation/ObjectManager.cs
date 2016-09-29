using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using Uni.Educational.IoC.Attribute;
using Uni.Educational.IoC.Services;

namespace Uni.Educational.IoC.Activation
{
    public class ObjectManager : IObjectManager, IDisposable
    {
        Dictionary<string, Type> m_registrationMetadata;
        ReaderWriterLockSlim m_rwlSlim;

        public ApplicationContext ApplicationContext { get; set; }

        public ObjectManager(Dictionary<string, Type> registrationMetadata)
        {
            m_rwlSlim = new ReaderWriterLockSlim();
            m_registrationMetadata = registrationMetadata;
        }

        public Type GetObjectByRegistrationID(string objectId)
        {
            Type ret = null;
            try
            {
                m_rwlSlim.EnterUpgradeableReadLock();

                if (!m_registrationMetadata.ContainsKey(objectId))
                {
                    throw new ObjectNotFoundException("No such object is registered");
                }

                ret = m_registrationMetadata[objectId];
            }
            finally
            {
                m_rwlSlim.ExitUpgradeableReadLock();
            }
            return ret;
        }

        public void RegisterObject(string objectID, Type objectType)
        {
            try
            {
                m_rwlSlim.EnterWriteLock();
                m_registrationMetadata.Add(objectID, objectType);
            }
            finally
            {
                m_rwlSlim.ExitWriteLock();
            }
        }

        public T GetAttributeForObjectType<T>(ObjectType type, string domain, string name) where T : RegisterObject
        {
            try
            {
                m_rwlSlim.EnterUpgradeableReadLock();

                var attribute = default(T);

                var objTypeLiteral = ObjectHelpers.GetObjectTypeLiteral(type);

                var objectID = string.Concat(objTypeLiteral, ":", domain, ":", name);

                if (m_registrationMetadata.ContainsKey(objectID))
                {
                    var reflectedType = m_registrationMetadata[objectID];
                    attribute = reflectedType.GetCustomAttribute<T>();
                }

                return attribute;
            }
            finally
            {
                m_rwlSlim.ExitUpgradeableReadLock();
            }
        }

        public void Dispose()
        {
            m_rwlSlim.Dispose();
        }

        public void Initialize()
        {

        }

        public void Shutdown()
        {

        }
    }
}
