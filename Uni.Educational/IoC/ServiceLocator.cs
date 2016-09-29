using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.IoC
{
    public class ServiceLocator
    {
        private Dictionary<Type, object> m_services;


        public void InitializeServiceLifetime()
        {
            if (m_services.Any())
            {
                foreach (IService service in m_services.Values)
                {
                    service.Initialize();
                }
            }
        }

        public ServiceLocator()
        {
            m_services = new Dictionary<Type, object>();
        }
        public T GetService<T>() where T : class, IService
        {
            return (T)m_services[typeof(T)];
        }

        public bool TryRegisterService<T>(IService service)
        {
            if (m_services.ContainsKey(typeof(T)))
                return false;

            m_services.Add(typeof(T), service);

            return true;
        }
    }
}
