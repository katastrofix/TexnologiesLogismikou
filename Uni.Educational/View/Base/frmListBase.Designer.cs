namespace Uni.Educational.View.Base
{
    partial class frmListBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListBase));
            this.ribbonControlMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.rbCRUD = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.ExpandCollapseItem.Id = 0;
            this.ribbonControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMain.ExpandCollapseItem,
            this.bbtnAdd,
            this.bbtnEdit,
            this.bbtnRefresh,
            this.bbtnDelete});
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.MaxItemId = 6;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbCRUD});
            this.ribbonControlMain.Size = new System.Drawing.Size(883, 140);
            // 
            // bbtnAdd
            // 
            this.bbtnAdd.Caption = "Add";
            this.bbtnAdd.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnAdd.Glyph")));
            this.bbtnAdd.Id = 1;
            this.bbtnAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnAdd.LargeGlyph")));
            this.bbtnAdd.Name = "bbtnAdd";
            this.bbtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnAdd_ItemClick);
            // 
            // bbtnEdit
            // 
            this.bbtnEdit.Caption = "Edit";
            this.bbtnEdit.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnEdit.Glyph")));
            this.bbtnEdit.Id = 3;
            this.bbtnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnEdit.LargeGlyph")));
            this.bbtnEdit.Name = "bbtnEdit";
            this.bbtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnEdit_ItemClick);
            // 
            // bbtnRefresh
            // 
            this.bbtnRefresh.Caption = "Refresh";
            this.bbtnRefresh.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnRefresh.Glyph")));
            this.bbtnRefresh.Id = 4;
            this.bbtnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnRefresh.LargeGlyph")));
            this.bbtnRefresh.Name = "bbtnRefresh";
            this.bbtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRefresh_ItemClick);
            // 
            // bbtnDelete
            // 
            this.bbtnDelete.Caption = "Delete";
            this.bbtnDelete.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnDelete.Glyph")));
            this.bbtnDelete.Id = 5;
            this.bbtnDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnDelete.LargeGlyph")));
            this.bbtnDelete.Name = "bbtnDelete";
            this.bbtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDelete_ItemClick);
            // 
            // rbCRUD
            // 
            this.rbCRUD.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbCRUD.Name = "rbCRUD";
            this.rbCRUD.Text = "Actions";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.gcList);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 140);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.Root = this.lcgMain;
            this.layoutControlMain.Size = new System.Drawing.Size(883, 386);
            this.layoutControlMain.TabIndex = 1;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // gcList
            // 
            this.gcList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcList.Location = new System.Drawing.Point(12, 12);
            this.gcList.MainView = this.gvList;
            this.gcList.MenuManager = this.ribbonControlMain;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(859, 362);
            this.gcList.TabIndex = 4;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // gvList
            // 
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.Editable = false;
            this.gvList.DoubleClick += new System.EventHandler(this.gvList_DoubleClick);
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "lcgMain";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(883, 386);
            this.lcgMain.Text = "lcgMain";
            this.lcgMain.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(863, 366);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmListBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 526);
            this.Controls.Add(this.layoutControlMain);
            this.Controls.Add(this.ribbonControlMain);
            this.Name = "frmListBase";
            this.Text = "frmBase";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage rbCRUD;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        protected DevExpress.XtraGrid.GridControl gcList;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMain;
        protected DevExpress.XtraBars.BarButtonItem bbtnAdd;
        protected DevExpress.XtraBars.BarButtonItem bbtnEdit;
        protected DevExpress.XtraBars.BarButtonItem bbtnRefresh;
        protected DevExpress.XtraBars.BarButtonItem bbtnDelete;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvList;
    }
}