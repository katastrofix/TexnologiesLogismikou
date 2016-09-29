namespace Uni.Educational.View
{
    partial class frmProject
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AssigneeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupervisingProfessorTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLastName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LanguageTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.programmingLanguageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TechnologyTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.technologyStackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAssignee = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSupervisingProfessor = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLanguage = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTechnology = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtpFiles = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAddFile = new DevExpress.XtraEditors.SimpleButton();
            this.gcFiles = new DevExpress.XtraGrid.GridControl();
            this.gvFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtcDetails)).BeginInit();
            this.xtcDetails.SuspendLayout();
            this.xtpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssigneeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupervisingProfessorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingLanguageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechnologyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technologyStackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssignee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupervisingProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTechnology)).BeginInit();
            this.xtpFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtcDetails
            // 
            this.xtcDetails.SelectedTabPage = this.xtpMain;
            this.xtcDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpFiles});
            this.xtcDetails.Controls.SetChildIndex(this.xtpFiles, 0);
            this.xtcDetails.Controls.SetChildIndex(this.xtpMain, 0);
            // 
            // xtpMain
            // 
            this.xtpMain.Controls.Add(this.dataLayoutControl1);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.TitleTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AssigneeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SupervisingProfessorTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LanguageTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TechnologyTextEdit);
            this.dataLayoutControl1.DataSource = this.projectBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(854, 317);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TitleTextEdit
            // 
            this.TitleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectBindingSource, "Title", true));
            this.TitleTextEdit.Location = new System.Drawing.Point(119, 60);
            this.TitleTextEdit.MenuManager = this.ribbonControl1;
            this.TitleTextEdit.Name = "TitleTextEdit";
            this.TitleTextEdit.Size = new System.Drawing.Size(723, 20);
            this.TitleTextEdit.StyleController = this.dataLayoutControl1;
            this.TitleTextEdit.TabIndex = 6;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(Uni.Educational.Model.Project);
            // 
            // AssigneeTextEdit
            // 
            this.AssigneeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectBindingSource, "Assignee", true));
            this.AssigneeTextEdit.Location = new System.Drawing.Point(119, 12);
            this.AssigneeTextEdit.MenuManager = this.ribbonControl1;
            this.AssigneeTextEdit.Name = "AssigneeTextEdit";
            this.AssigneeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AssigneeTextEdit.Properties.DataSource = this.studentBindingSource;
            this.AssigneeTextEdit.Properties.DisplayMember = "LastName";
            this.AssigneeTextEdit.Properties.NullText = "";
            this.AssigneeTextEdit.Properties.ValueMember = "StudentID";
            this.AssigneeTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.AssigneeTextEdit.Size = new System.Drawing.Size(723, 20);
            this.AssigneeTextEdit.StyleController = this.dataLayoutControl1;
            this.AssigneeTextEdit.TabIndex = 4;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Uni.Educational.Model.Student);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLastName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 0;
            // 
            // SupervisingProfessorTextEdit
            // 
            this.SupervisingProfessorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectBindingSource, "SupervisingProfessor", true));
            this.SupervisingProfessorTextEdit.Location = new System.Drawing.Point(119, 36);
            this.SupervisingProfessorTextEdit.MenuManager = this.ribbonControl1;
            this.SupervisingProfessorTextEdit.Name = "SupervisingProfessorTextEdit";
            this.SupervisingProfessorTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SupervisingProfessorTextEdit.Properties.DataSource = this.professorBindingSource;
            this.SupervisingProfessorTextEdit.Properties.DisplayMember = "LastName";
            this.SupervisingProfessorTextEdit.Properties.NullText = "";
            this.SupervisingProfessorTextEdit.Properties.ValueMember = "ProfessorID";
            this.SupervisingProfessorTextEdit.Properties.View = this.gridView1;
            this.SupervisingProfessorTextEdit.Size = new System.Drawing.Size(723, 20);
            this.SupervisingProfessorTextEdit.StyleController = this.dataLayoutControl1;
            this.SupervisingProfessorTextEdit.TabIndex = 5;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(Uni.Educational.Model.Professor);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLastName1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colLastName1
            // 
            this.colLastName1.FieldName = "LastName";
            this.colLastName1.Name = "colLastName1";
            this.colLastName1.Visible = true;
            this.colLastName1.VisibleIndex = 0;
            // 
            // LanguageTextEdit
            // 
            this.LanguageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectBindingSource, "Language", true));
            this.LanguageTextEdit.Location = new System.Drawing.Point(119, 84);
            this.LanguageTextEdit.MenuManager = this.ribbonControl1;
            this.LanguageTextEdit.Name = "LanguageTextEdit";
            this.LanguageTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LanguageTextEdit.Properties.DataSource = this.programmingLanguageBindingSource;
            this.LanguageTextEdit.Properties.DisplayMember = "Name";
            this.LanguageTextEdit.Properties.NullText = "";
            this.LanguageTextEdit.Properties.ValueMember = "ProgrammingLanguageID";
            this.LanguageTextEdit.Properties.View = this.gridView2;
            this.LanguageTextEdit.Size = new System.Drawing.Size(723, 20);
            this.LanguageTextEdit.StyleController = this.dataLayoutControl1;
            this.LanguageTextEdit.TabIndex = 7;
            // 
            // programmingLanguageBindingSource
            // 
            this.programmingLanguageBindingSource.DataSource = typeof(Uni.Educational.Model.ProgrammingLanguage);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // TechnologyTextEdit
            // 
            this.TechnologyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectBindingSource, "Technology", true));
            this.TechnologyTextEdit.Location = new System.Drawing.Point(119, 108);
            this.TechnologyTextEdit.MenuManager = this.ribbonControl1;
            this.TechnologyTextEdit.Name = "TechnologyTextEdit";
            this.TechnologyTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TechnologyTextEdit.Properties.DataSource = this.technologyStackBindingSource;
            this.TechnologyTextEdit.Properties.DisplayMember = "Description";
            this.TechnologyTextEdit.Properties.NullText = "";
            this.TechnologyTextEdit.Properties.ValueMember = "TechnologyStackID";
            this.TechnologyTextEdit.Properties.View = this.gridView3;
            this.TechnologyTextEdit.Size = new System.Drawing.Size(723, 20);
            this.TechnologyTextEdit.StyleController = this.dataLayoutControl1;
            this.TechnologyTextEdit.TabIndex = 8;
            // 
            // technologyStackBindingSource
            // 
            this.technologyStackBindingSource.DataSource = typeof(Uni.Educational.Model.TechnologyStack);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colDescription1
            // 
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(854, 317);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAssignee,
            this.ItemForSupervisingProfessor,
            this.ItemForTitle,
            this.ItemForLanguage,
            this.ItemForTechnology});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(834, 297);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForAssignee
            // 
            this.ItemForAssignee.Control = this.AssigneeTextEdit;
            this.ItemForAssignee.CustomizationFormText = "Assignee";
            this.ItemForAssignee.Location = new System.Drawing.Point(0, 0);
            this.ItemForAssignee.Name = "ItemForAssignee";
            this.ItemForAssignee.Size = new System.Drawing.Size(834, 24);
            this.ItemForAssignee.Text = "Assignee";
            this.ItemForAssignee.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForSupervisingProfessor
            // 
            this.ItemForSupervisingProfessor.Control = this.SupervisingProfessorTextEdit;
            this.ItemForSupervisingProfessor.CustomizationFormText = "Supervising Professor";
            this.ItemForSupervisingProfessor.Location = new System.Drawing.Point(0, 24);
            this.ItemForSupervisingProfessor.Name = "ItemForSupervisingProfessor";
            this.ItemForSupervisingProfessor.Size = new System.Drawing.Size(834, 24);
            this.ItemForSupervisingProfessor.Text = "Supervising Professor";
            this.ItemForSupervisingProfessor.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForTitle
            // 
            this.ItemForTitle.Control = this.TitleTextEdit;
            this.ItemForTitle.CustomizationFormText = "Title";
            this.ItemForTitle.Location = new System.Drawing.Point(0, 48);
            this.ItemForTitle.Name = "ItemForTitle";
            this.ItemForTitle.Size = new System.Drawing.Size(834, 24);
            this.ItemForTitle.Text = "Title";
            this.ItemForTitle.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForLanguage
            // 
            this.ItemForLanguage.Control = this.LanguageTextEdit;
            this.ItemForLanguage.CustomizationFormText = "Language";
            this.ItemForLanguage.Location = new System.Drawing.Point(0, 72);
            this.ItemForLanguage.Name = "ItemForLanguage";
            this.ItemForLanguage.Size = new System.Drawing.Size(834, 24);
            this.ItemForLanguage.Text = "Language";
            this.ItemForLanguage.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForTechnology
            // 
            this.ItemForTechnology.Control = this.TechnologyTextEdit;
            this.ItemForTechnology.CustomizationFormText = "Technology";
            this.ItemForTechnology.Location = new System.Drawing.Point(0, 96);
            this.ItemForTechnology.Name = "ItemForTechnology";
            this.ItemForTechnology.Size = new System.Drawing.Size(834, 201);
            this.ItemForTechnology.Text = "Technology";
            this.ItemForTechnology.TextSize = new System.Drawing.Size(104, 13);
            // 
            // xtpFiles
            // 
            this.xtpFiles.Controls.Add(this.layoutControl1);
            this.xtpFiles.Name = "xtpFiles";
            this.xtpFiles.Size = new System.Drawing.Size(854, 317);
            this.xtpFiles.Text = "Files";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnAddFile);
            this.layoutControl1.Controls.Add(this.gcFiles);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup3;
            this.layoutControl1.Size = new System.Drawing.Size(854, 317);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(12, 12);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(166, 22);
            this.btnAddFile.StyleController = this.layoutControl1;
            this.btnAddFile.TabIndex = 5;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // gcFiles
            // 
            this.gcFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcFiles.Location = new System.Drawing.Point(12, 38);
            this.gcFiles.MainView = this.gvFiles;
            this.gcFiles.MenuManager = this.ribbonControl1;
            this.gcFiles.Name = "gcFiles";
            this.gcFiles.Size = new System.Drawing.Size(830, 267);
            this.gcFiles.TabIndex = 4;
            this.gcFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFiles});
            // 
            // gvFiles
            // 
            this.gvFiles.GridControl = this.gcFiles;
            this.gvFiles.Name = "gvFiles";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(854, 317);
            this.layoutControlGroup3.Text = "layoutControlGroup3";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcFiles;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(834, 271);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAddFile;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(170, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(170, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(664, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 484);
            this.Name = "frmProject";
            this.Text = "frmProject";
            ((System.ComponentModel.ISupportInitialize)(this.xtcDetails)).EndInit();
            this.xtcDetails.ResumeLayout(false);
            this.xtpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssigneeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupervisingProfessorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingLanguageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechnologyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technologyStackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssignee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupervisingProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTechnology)).EndInit();
            this.xtpFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private DevExpress.XtraEditors.TextEdit TitleTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssignee;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSupervisingProfessor;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTitle;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLanguage;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTechnology;
        private DevExpress.XtraEditors.GridLookUpEdit AssigneeTextEdit;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit SupervisingProfessorTextEdit;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit LanguageTextEdit;
        private System.Windows.Forms.BindingSource programmingLanguageBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit TechnologyTextEdit;
        private System.Windows.Forms.BindingSource technologyStackBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName1;
        private DevExpress.XtraTab.XtraTabPage xtpFiles;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.SimpleButton btnAddFile;
        private DevExpress.XtraGrid.GridControl gcFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFiles;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}