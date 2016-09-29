namespace Uni.Educational.View
{
    partial class frmHost
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHost));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnStudents = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnProfessors = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnProjects = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnFields = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnLang = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTech = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDbConfig = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbtnStudents,
            this.bbtnProfessors,
            this.bbtnProjects,
            this.bbtnFields,
            this.bbtnLang,
            this.bbtnTech,
            this.bbtnDbConfig});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1048, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbtnStudents
            // 
            this.bbtnStudents.Caption = "Students";
            this.bbtnStudents.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnStudents.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnStudents.Glyph")));
            this.bbtnStudents.Id = 1;
            this.bbtnStudents.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnStudents.LargeGlyph")));
            this.bbtnStudents.Name = "bbtnStudents";
            this.bbtnStudents.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnStudents_ItemClick);
            // 
            // bbtnProfessors
            // 
            this.bbtnProfessors.Caption = "Professors";
            this.bbtnProfessors.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnProfessors.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnProfessors.Glyph")));
            this.bbtnProfessors.Id = 2;
            this.bbtnProfessors.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnProfessors.LargeGlyph")));
            this.bbtnProfessors.Name = "bbtnProfessors";
            this.bbtnProfessors.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnProfessors_ItemClick);
            // 
            // bbtnProjects
            // 
            this.bbtnProjects.Caption = "Projects";
            this.bbtnProjects.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnProjects.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnProjects.Glyph")));
            this.bbtnProjects.Id = 3;
            this.bbtnProjects.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnProjects.LargeGlyph")));
            this.bbtnProjects.Name = "bbtnProjects";
            this.bbtnProjects.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnProjects_ItemClick);
            // 
            // bbtnFields
            // 
            this.bbtnFields.Caption = "Fields Configuration";
            this.bbtnFields.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnFields.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnFields.Glyph")));
            this.bbtnFields.Id = 4;
            this.bbtnFields.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnFields.LargeGlyph")));
            this.bbtnFields.Name = "bbtnFields";
            this.bbtnFields.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnFields_ItemClick);
            // 
            // bbtnLang
            // 
            this.bbtnLang.Caption = "Languages Configuration";
            this.bbtnLang.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnLang.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnLang.Glyph")));
            this.bbtnLang.Id = 5;
            this.bbtnLang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnLang.LargeGlyph")));
            this.bbtnLang.Name = "bbtnLang";
            this.bbtnLang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnLang_ItemClick);
            // 
            // bbtnTech
            // 
            this.bbtnTech.Caption = "Technologies Definitions";
            this.bbtnTech.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnTech.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnTech.Glyph")));
            this.bbtnTech.Id = 6;
            this.bbtnTech.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnTech.LargeGlyph")));
            this.bbtnTech.Name = "bbtnTech";
            this.bbtnTech.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnTech_ItemClick);
            // 
            // bbtnDbConfig
            // 
            this.bbtnDbConfig.Caption = "Database Configuration";
            this.bbtnDbConfig.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbtnDbConfig.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnDbConfig.Glyph")));
            this.bbtnDbConfig.Id = 1;
            this.bbtnDbConfig.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnDbConfig.LargeGlyph")));
            this.bbtnDbConfig.Name = "bbtnDbConfig";
            this.bbtnDbConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDbConfig_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Entities";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnStudents);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnProfessors);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnProjects);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Array Configuration";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnFields);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnLang);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnTech);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "System Configuration";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnDbConfig);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 579);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1048, 23);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.HeaderButtons = ((DevExpress.XtraTab.TabButtons)((((DevExpress.XtraTab.TabButtons.Prev | DevExpress.XtraTab.TabButtons.Next) 
            | DevExpress.XtraTab.TabButtons.Close) 
            | DevExpress.XtraTab.TabButtons.Default)));
            this.xtraTabbedMdiManager1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Always;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.UseDocumentSelector = DevExpress.Utils.DefaultBoolean.True;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.EnableBonusSkins = true;
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // frmHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 602);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmHost";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Ariadne";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmHost_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem bbtnStudents;
        private DevExpress.XtraBars.BarButtonItem bbtnProfessors;
        private DevExpress.XtraBars.BarButtonItem bbtnProjects;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem bbtnFields;
        private DevExpress.XtraBars.BarButtonItem bbtnLang;
        private DevExpress.XtraBars.BarButtonItem bbtnTech;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbtnDbConfig;
    }
}