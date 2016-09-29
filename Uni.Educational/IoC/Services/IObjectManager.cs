using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using Uni.Educational.IoC.Attribute;
using Uni.Educational.IoC.Activation;

namespace Uni.Educational.IoC.Services
{
    public interface IObjectManager : IService
    {
        Type GetObjectByRegistrationID(string objectId);
        void RegisterObject(string objectID, Type objectType);
        T GetAttributeForObjectType<T>(ObjectType type, string domain, string name)
            where T : RegisterObject;
    }
}
