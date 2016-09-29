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

namespace Uni.Educational.View.Base
{
    public partial class frmEntityBase : XtraForm, IViewBase
    {
        public Dictionary<string, object> Arguments { get; set; }

        public IoC.ApplicationContext ApplicationContext { get; set; }

        protected IoC.ApplicationContext m_appContext;

        protected Dictionary<string, object> m_arguments;

        public frmEntityBase()
        {
            InitializeComponent();
        }

        public virtual void Initialize(IoC.ApplicationContext context, Dictionary<string, object> arguments)
        {
            m_appContext = context;
            m_arguments = arguments;
        }

        private void bbtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OnSave();
                XtraMessageBox.Show("Saved entity");
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        protected virtual void OnSave()
        {

        }
    }
}