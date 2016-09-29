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

namespace Uni.Educational.View
{
    [RegisterView("Students", "StudentEditor")]
    public partial class frmStudent : frmEntityBase
    {
        SchemaContext m_context;

        public frmStudent()
        {
            InitializeComponent();
            m_context = SchemaContext.Create();
        }

        public override void Initialize(IoC.ApplicationContext context, Dictionary<string, object> arguments)
        {
            base.Initialize(context, arguments);

            Student student = null;

            if (arguments.ContainsKey("NEWID"))
            {
                student = m_context.Students.Create();
                student.StudentID = Guid.NewGuid();
                m_context.Students.Add(student);
            }
            else
            {
                var id = (Guid)arguments["ID"];
                student = m_context
                    .Students
                    .SingleOrDefault(s => s.StudentID == id);
            }
            studentBindingSource.DataSource = student;

            Text = string.Concat("Student: ", student.FirstName, " ", student.LastName);
        }

        protected override void OnSave()
        {
            studentBindingSource.EndEdit();
            m_context.SaveChanges();
        }
    }
}