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
    [RegisterView("EntityConfiguration", "LangArray")]
    public partial class frmProgrammingLanguage : frmListBase
    {

        SchemaContext m_context;
        public frmProgrammingLanguage()
        {
            InitializeComponent();
            m_context = SchemaContext.Create();
        }

        protected override void OnRefresh()
        {
            m_context.ProgrammingLanguages.Load();
            programmingLanguageBindingSource.DataSource = m_context.ProgrammingLanguages.Local.ToBindingList();
        }

        protected override void OnAdd()
        {
            var lang = (ProgrammingLanguage)programmingLanguageBindingSource.AddNew();
            lang.ProgrammingLanguageID = Guid.NewGuid();
        }

        protected override void OnDelete()
        {
            gvList.DeleteSelectedRows();
            m_context.SaveChanges();
            OnRefresh();
        }

        private void bbtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_context.SaveChanges();
        }
    }
}