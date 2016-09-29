using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Uni.Educational.IoC.Services;
using Uni.Educational.IoC.Attribute;

namespace Uni.Educational.View
{
    [RegisterView("System", "Login", true)]
    public partial class frmLogin : XtraForm, IViewBase
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Arguments
        {
            get;
            set;
        }

        public IoC.ApplicationContext ApplicationContext
        {
            get;
            set;
        }


        public void Initialize(IoC.ApplicationContext context, Dictionary<string, object> arguments)
        {
            throw new NotImplementedException();
        }
    }
}