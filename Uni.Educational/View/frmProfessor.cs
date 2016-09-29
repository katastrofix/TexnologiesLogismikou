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
using Uni.Educational.IoC.Attribute;
using System.Data.Entity;

namespace Uni.Educational.View
{
    [RegisterView("Professors", "ProfessorEditor")]
    public partial class frmProfessor : frmEntityBase
    {

        SchemaContext m_context;

        public frmProfessor()
        {
            InitializeComponent();
            m_context = SchemaContext.Create();
        }


        public override void Initialize(IoC.ApplicationContext context, Dictionary<string, object> arguments)
        {
            base.Initialize(context, arguments);

            Professor professor = null;

            if (arguments.ContainsKey("NEWID"))
            {
                professor = m_context.Professors.Create();
                professor.ProfessorID = Guid.NewGuid();
                m_context.Professors.Add(professor);
            }
            else
            {
                var id = (Guid)arguments["ID"];
                professor = m_context
                    .Professors
                    .SingleOrDefault(p => p.ProfessorID == id);
            }
            professorBindingSource.DataSource = professor;

            Text = string.Concat("Professor: ", professor.FirstName, "", professor.LastName);

            m_context.Fields.Load();
            fieldBindingSource.DataSource = m_context
                .Fields
                .Local
                .ToBindingList()
                .Select(f => new { ID = f, Description = f.Description });
        }

        protected override void OnSave()
        {
            professorBindingSource.EndEdit();
            m_context.SaveChanges();
        }
    }
}