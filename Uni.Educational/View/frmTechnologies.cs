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
using Uni.Educational.IoC.Services;
using Uni.Educational.IoC.Attribute;

namespace Uni.Educational.View
{
    [RegisterView("EntityConfiguration", "Technologies")]
    public partial class frmTechnologies : frmListBase
    {

        SchemaContext m_context;
        public frmTechnologies()
        {
            InitializeComponent();
            m_context = SchemaContext.Create();
        }

        protected override void OnRefresh()
        {
            m_context.Technologies.Load();
            technologyStackBindingSource.DataSource = m_context.Technologies.Local.ToBindingList();
        }
        
        protected override void OnDelete()
        {
            gvList.DeleteSelectedRows();
            m_context.SaveChanges();
            OnRefresh();
        }

        protected override void OnAdd()
        {
            var tech = (TechnologyStack)technologyStackBindingSource.AddNew();
            tech.TechnologyStackID = Guid.NewGuid();
        }

    }
}