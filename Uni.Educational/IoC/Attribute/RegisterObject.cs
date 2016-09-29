using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.IoC.Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RegisterObject : System.Attribute
    {
        public Activation.ObjectType ObjectType { get; set; }
        public string Domain { get; set; }
        public string Name { get; set; }
    }
}
