using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.IoC.Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    class RegisterServiceProvider : System.Attribute
    {
        public IEnumerable<Type> Dependencies { get; set; }

        public RegisterServiceProvider(params Type[] DependsOn)
        {
            Dependencies = DependsOn;
        }
    }
}
