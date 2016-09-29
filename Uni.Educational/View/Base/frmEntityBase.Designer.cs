namespace Uni.Educational.View.Base
{
    partial class frmEntityBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntityBase));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.A = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtcDetails = new DevExpress.XtraTab.XtraTabControl();
            this.xtpMain = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcDetails)).BeginInit();
            this.xtcDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbtnSave});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.A});
            this.ribbonControl1.Size = new System.Drawing.Size(856, 140);
            // 
            // bbtnSave
            // 
            this.bbtnSave.Caption = "Save";
            this.bbtnSave.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnSave.Glyph")));
            this.bbtnSave.Id = 1;
            this.bbtnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnSave.LargeGlyph")));
            this.bbtnSave.Name = "bbtnSave";
            this.bbtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSave_ItemClick);
            // 
            // A
            // 
            this.A.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.A.Name = "A";
            this.A.Text = "Actions";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtcDetails
            // 
            this.xtcDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcDetails.Location = new System.Drawing.Point(0, 140);
            this.xtcDetails.Name = "xtcDetails";
            this.xtcDetails.SelectedTabPage = this.xtpMain;
            this.xtcDetails.Size = new System.Drawing.Size(856, 344);
            this.xtcDetails.TabIndex = 1;
            this.xtcDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpMain});
            // 
            // xtpMain
            // 
            this.xtpMain.Name = "xtpMain";
            this.xtpMain.Size = new System.Drawing.Size(854, 317);
            this.xtpMain.Text = "Details";
            // 
            // frmEntityBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 484);
            this.Controls.Add(this.xtcDetails);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmEntityBase";
            this.Text = "frmEntityBase";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcDetails)).EndInit();
            this.xtcDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage A;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        protected DevExpress.XtraTab.XtraTabControl xtcDetails;
        protected DevExpress.XtraTab.XtraTabPage xtpMain;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        protected DevExpress.XtraBars.BarButtonItem bbtnSave;

    }
}