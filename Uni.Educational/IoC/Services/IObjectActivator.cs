using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni.Educational.IoC.Activation;

namespace Uni.Educational.IoC.Services
{
    public interface IObjectActivator : IService
    {
        object CreateObject(ObjectType type, string domain, string name);
    }
}
