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
using Uni.Educational.IoC.Services;
using DevExpress.Utils;

namespace Uni.Educational.View.Base
{
    public partial class frmListBase : XtraForm, IViewBase
    {
        public frmListBase()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Arguments
        {
            get;
            set;
        }

        public IoC.ApplicationContext ApplicationContext
        {
            get;
            set;
        }


        public virtual void Initialize(IoC.ApplicationContext context, Dictionary<string, object> arguments)
        {

        }

        private void gvList_DoubleClick(object sender, EventArgs e)
        {
            var hi = gvList.CalcHitInfo((e as DXMouseEventArgs).Location);
            if (hi.InDataRow)
            {
                OnEdit();
            }
        }

        protected virtual void OnEdit() { }
        protected virtual void OnDelete() { }
        protected virtual void OnRefresh() { }
        protected virtual void OnSave() { }

        protected virtual void OnAdd() { }

        private void bbtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OnAdd();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                ApplicationContext.Locator.GetService<ILogger>().LogException(ex);
            }
        }

        private void bbtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OnEdit();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                ApplicationContext.Locator.GetService<ILogger>().LogException(ex);
            }
        }

        private void bbtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OnRefresh();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                ApplicationContext.Locator.GetService<ILogger>().LogException(ex);
            }
        }

        private void bbtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OnDelete();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                ApplicationContext.Locator.GetService<ILogger>().LogException(ex);
            }
        }
    }
}