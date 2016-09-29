using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uni.Educational.IoC;
using Uni.Educational.IoC.Activation;
using Uni.Educational.IoC.Attribute;
using Uni.Educational.IoC.Services;

namespace Uni.Educational.View.Base
{
    public class WindowManager
    {
        private Form m_owner;

        private IoC.ApplicationContext m_applicationContext;

        private List<Form> m_openForms;

        public WindowManager(Form owner, IoC.ApplicationContext context)
        {
            m_openForms = new List<Form>();
            m_applicationContext = context;
            m_owner = owner;
        }

        public void ShowWindow(string domain, string name, Dictionary<string, object> arguments)
        {
            var frm = m_applicationContext
                .Locator
                .GetService<IViewActivator>()
                .CreateForm(domain, name, arguments);

            var showAsModal = m_applicationContext
               .Locator
               .GetService<IObjectManager>()
               .GetAttributeForObjectType<RegisterView>(ObjectType.UIElement, domain, name)
               .Modal;


            (frm as IViewBase).Initialize(m_applicationContext, arguments);

            m_openForms.Add(frm);

            if (showAsModal)
            {
                frm.ShowDialog(m_owner);
                frm.Dispose();
            }
            else
            {
                frm.MdiParent = m_owner;
                frm.Show();
            }

        }

        public void CloseAllWindows()
        {
            m_openForms.ForEach(frm => frm.Close());
        }
    }
}
