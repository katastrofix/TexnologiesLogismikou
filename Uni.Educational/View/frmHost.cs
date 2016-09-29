using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Uni.Educational.IoC.Services;
using Uni.Educational.View.Base;
using Uni.Educational.IoC.Activation;
using System.Data.SqlClient;

namespace Uni.Educational.View
{
    public partial class frmHost : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private Uni.Educational.IoC.ApplicationContext m_applicationContext;

        private WindowManager m_wndMgr;

        public frmHost()
        {
            InitializeComponent();

            m_applicationContext = (new ApplicationContextFactory()).CreateContext();

            m_wndMgr = new WindowManager(this, m_applicationContext);

            m_applicationContext.WindowManager = m_wndMgr;

        }

        private void frmHost_Shown(object sender, EventArgs e)
        {
        }

        private void bbtnStudents_ItemClick(object sender, ItemClickEventArgs e)
        {
            m_wndMgr.ShowWindow("Students", "StudentsList", null);
        }

        private void bbtnProfessors_ItemClick(object sender, ItemClickEventArgs e)
        {
            m_wndMgr.ShowWindow("Professors", "ProfessorsList", null);
        }

        private void bbtnProjects_ItemClick(object sender, ItemClickEventArgs e)
        {
            m_wndMgr.ShowWindow("Projects", "ProjectsList", null);
        }

        private void bbtnFields_ItemClick(object sender, ItemClickEventArgs e)
        {
            m_wndMgr.ShowWindow("EntityConfiguration", "FieldArray", null);
        }

        private void bbtnLang_ItemClick(object sender, ItemClickEventArgs e)
        {
            m_wndMgr.ShowWindow("EntityConfiguration", "LangArray", null);
        }

        private void bbtnTech_ItemClick(object sender, ItemClickEventArgs e)
        {
            m_wndMgr.ShowWindow("EntityConfiguration", "Technologies", null);
        }

        private void bbtnDbConfig_ItemClick(object sender, ItemClickEventArgs e)
        {
            m_wndMgr.ShowWindow("System", "DbConfig", null);
        }
    }
}