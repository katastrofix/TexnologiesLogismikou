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
using Uni.Educational.File;

namespace Uni.Educational.View
{
    [RegisterView("Projects", "ProjectEditor")]
    public partial class frmProject : frmEntityBase
    {
        SchemaContext m_context;
        NtfsUtils m_ntfsUtils;

        public frmProject()
        {
            InitializeComponent();
            m_context = SchemaContext.Create();
            m_ntfsUtils = new NtfsUtils();
        }

        public override void Initialize(IoC.ApplicationContext context, Dictionary<string, object> arguments)
        {
            base.Initialize(context, arguments);

            Project project = null;

            if (arguments.ContainsKey("NEWID"))
            {
                project = m_context.Projects.Create();
                project.ProjectID = Guid.NewGuid();
                m_context.Projects.Add(project);
            }
            else
            {
                var id = (Guid)arguments["ID"];
                project = m_context
                    .Projects
                    .SingleOrDefault(p => p.ProjectID == id);
            }
            projectBindingSource.DataSource = project;

            Text = string.Concat("Project: ", project.Title);
   
            LoadLookups();

            LoadFiles();
        }


        private void LoadLookups()
        {

            m_context.Students.Load();
            m_context.Professors.Load();
            m_context.ProgrammingLanguages.Load();
            m_context.Technologies.Load();

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


        protected override void OnSave()
        {
            professorBindingSource.EndEdit();
            m_context.SaveChanges();
        }


        private void LoadFiles()
        {
            var project = projectBindingSource.DataSource as Project;
            var bindingSource = new BindingSource();
            bindingSource.DataSource = (from fi in m_ntfsUtils.EnumerateArchive(project.ProjectID)
                                        select new { Filename = fi.Name, Extension = fi.Extension, Timestamp = fi.CreationTime }).ToList();
            gcFiles.DataSource = bindingSource;
            gcFiles.RefreshDataSource();
        }
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (var sfd = new OpenFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var project = projectBindingSource.DataSource as Project;
                    m_ntfsUtils.Store(project.ProjectID, sfd.FileName);
                }
            }

            LoadFiles();
        }
    }
}