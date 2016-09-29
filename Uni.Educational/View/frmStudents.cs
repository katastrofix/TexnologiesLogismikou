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
    [RegisterView("Students", "StudentsList")]
    public partial class frmStudents : frmListBase
    {

        SchemaContext m_context;

        public frmStudents()
        {
            InitializeComponent();
            m_context = SchemaContext.Create();
        }

        protected override void OnEdit()
        {
            var student = gvList.GetFocusedRow() as Student;

            var args = new Dictionary<String, object>() { { "ID", student.StudentID } };

            ApplicationContext.WindowManager.ShowWindow("Students", "StudentEditor", args);
        }

        protected override void OnRefresh()
        {
            m_context.Students.Load();
            studentBindingSource.DataSource = m_context.Students.Local.ToBindingList();
        }

        protected override void OnAdd()
        {
            var args = new Dictionary<String, object>() { { "NEWID", null } };

            ApplicationContext.WindowManager.ShowWindow("Students", "StudentEditor", args);
        }

        protected override void OnDelete()
        {
            gvList.DeleteSelectedRows();
            m_context.SaveChanges();
            OnRefresh();
        }

    }
}