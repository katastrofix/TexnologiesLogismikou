using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.IoC.Attribute
{
    public class RegisterView : RegisterObject
    {
        public bool Modal { get; set; }
        public RegisterView(string domain, string name, bool modal = false)
        {
            Domain = domain;
            Name = name;
            Modal = modal;
            base.ObjectType = Activation.ObjectType.UIElement;
        }

    }
}
