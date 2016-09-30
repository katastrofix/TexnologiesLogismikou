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
            m_context.Professors.Load();
            m_context.Students.Load();
            m_context.Technologies.Load();
            m_context.ProgrammingLanguages.Load();
            m_context.Projects.Load();

            projectBindingSource.DataSource = m_context.Projects.Local.ToBindingList();

            studentBindingSource.DataSource = m_context
            .Students
            .Local
            .ToBindingList()
            .Select(s => new { StudentID = s, LastName = string.Concat(s.FirstName, " ", s.LastName) });

            professorBindingSource.DataSource = m_context
                .Professors
                .Local
                .ToBindingList()
                .Select(p => new { ProfessorID = p, LastName = string.Concat(p.FirstName, " ", p.LastName) });

            programmingLanguageBindingSource.DataSource = m_context
                .ProgrammingLanguages
                .Local
                .ToBindingList()
                .Select(lang => new { ProgrammingLanguageID = lang, Name = lang.Name });

            technologyStackBindingSource.DataSource = m_context
                .Technologies
                .Local
                .ToBindingList()
                .Select(t => new { TechnologyStackID = t, Description = t.Description });
        }

        protected override void OnEdit()
        {
            var project = gvList.GetFocusedRow() as Project;

            var args = new Dictionary<String, object>() { { "ID", project.ProjectID } };

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