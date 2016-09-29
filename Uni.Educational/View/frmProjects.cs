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
using Uni.Educational.View.Base;
using Uni.Educational.Model;
using System.Data.Entity;
using Uni.Educational.IoC.Attribute;

namespace Uni.Educational.View
{
    [RegisterView("Projects", "ProjectsList")]
    public partial class frmProjects : frmListBase
    {

        SchemaContext m_context;

        public frmProjects()
        {
            InitializeComponent();
            m_context = SchemaContext.Create();
        }

        protected override void OnAdd()
        {
            var args = new Dictionary<String, object>() { { "NEWID", null } };

            ApplicationContext.WindowManager.ShowWindow("Projects", "ProjectEditor", args);
        }

        protected override void OnRefresh()
        {
            m_context.Projects.Load();

            projectBindingSource.DataSource = m_context.Projects.Local.ToBindingList();
        }

        protected override void OnEdit()
        {
            var professor = gvList.GetFocusedRow() as Professor;

            var args = new Dictionary<String, object>() { { "ID", professor.ProfessorID } };

            ApplicationContext.WindowManager.ShowWindow("Projects", "ProjectEditor", args);

        }
        protected override void OnDelete()
        {
            gvList.DeleteSelectedRows();
            m_context.SaveChanges();
            OnRefresh();
        }

    }
}