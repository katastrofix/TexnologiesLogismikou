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
using Uni.Educational.IoC.Attribute;
using Uni.Educational.Model;
using System.Data.Entity;

namespace Uni.Educational.View
{
    [RegisterView("Professors", "ProfessorsList")]
    public partial class frmProfessors : frmListBase
    {

        private SchemaContext m_context;
        public frmProfessors()
        {
            InitializeComponent();

            m_context = SchemaContext.Create();
        }

        protected override void OnAdd()
        {
            var args = new Dictionary<String, object>() { { "NEWID", null } };

            ApplicationContext.WindowManager.ShowWindow("Professors", "ProfessorEditor", args);
        }

        protected override void OnRefresh()
        {
            m_context.Professors.Load();

            professorBindingSource.DataSource = m_context.Professors.Local.ToBindingList();
        }

        protected override void OnEdit()
        {
            var professor = gvList.GetFocusedRow() as Professor;

            var args = new Dictionary<String, object>() { { "ID", professor.ProfessorID } };

            ApplicationContext.WindowManager.ShowWindow("Professors", "ProfessorEditor", args);

        }

        protected override void OnDelete()
        {
            gvList.DeleteSelectedRows();
            m_context.SaveChanges();
            OnRefresh();
        }
    }
}