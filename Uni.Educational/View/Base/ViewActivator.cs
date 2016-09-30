using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uni.Educational.IoC.Activation;
using Uni.Educational.IoC.Attribute;
using Uni.Educational.IoC.Services;

namespace Uni.Educational.View.Base
{
    public class ViewActivator : IViewActivator
    {
        public Form CreateForm(string domain, string name, Dictionary<string, object> arguments)
        {
            var form = ApplicationContext
                .Locator
                .GetService<IObjectActivator>()
                .CreateObject(ObjectType.UIElement, domain, name);

            (form as IViewBase).ApplicationContext = ApplicationContext;
            (form as IViewBase).Arguments = arguments;
            return form as Form;
        }

        public bool IsModal(string domain, string name)
        {
            return ApplicationContext
            .Locator
            .GetService<IObjectManager>()
            .GetAttributeForObjectType<RegisterView>(ObjectType.UIElement, domain, name)
            .Modal;
        }

        public IoC.ApplicationContext ApplicationContext { get; set; }


        public void Initialize()
        {

        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
