namespace Uni.Educational.View
{
    partial class frmProjects
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
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colAssignee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riluAssignee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobilePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupervisingProfessor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riluSupervisingProfessor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanguage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riluLanguage = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.programmingLanguageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTechnology = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riluTechnology = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.technologyStackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riluAssignee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riluSupervisingProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riluLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingLanguageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riluTechnology)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technologyStackBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.DataSource = this.projectBindingSource;
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riluAssignee,
            this.riluSupervisingProfessor,
            this.riluLanguage,
            this.riluTechnology,
            this.repositoryItemGridLookUpEdit1});
            this.gcList.Size = new System.Drawing.Size(896, 345);
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.ExpandCollapseItem.Id = 0;
            this.ribbonControlMain.Size = new System.Drawing.Size(920, 140);
            // 
            // gvList
            // 
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAssignee,
            this.colSupervisingProfessor,
            this.colTitle,
            this.colLanguage,
            this.colTechnology});
            this.gvList.OptionsBehavior.Editable = false;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(Uni.Educational.Model.Project);
            // 
            // colAssignee
            // 
            this.colAssignee.ColumnEdit = this.riluAssignee;
            this.colAssignee.FieldName = "Assignee";
            this.colAssignee.Name = "colAssignee";
            this.colAssignee.Visible = true;
            this.colAssignee.VisibleIndex = 0;
            // 
            // riluAssignee
            // 
            this.riluAssignee.AutoHeight = false;
            this.riluAssignee.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riluAssignee.DataSource = this.studentBindingSource;
            this.riluAssignee.DisplayMember = "LastName";
            this.riluAssignee.Name = "riluAssignee";
            this.riluAssignee.ValueMember = "StudentID";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Uni.Educational.Model.Student);
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.studentBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "LastName";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "StudentID";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStudentID,
            this.colFirstName,
            this.colLastName,
            this.colMobilePhone,
            this.colEmail});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colStudentID
            // 
            this.colStudentID.FieldName = "StudentID";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.Visible = true;
            this.colStudentID.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colMobilePhone
            // 
            this.colMobilePhone.FieldName = "MobilePhone";
            this.colMobilePhone.Name = "colMobilePhone";
            this.colMobilePhone.Visible = true;
            this.colMobilePhone.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colSupervisingProfessor
            // 
            this.colSupervisingProfessor.ColumnEdit = this.riluSupervisingProfessor;
            this.colSupervisingProfessor.FieldName = "SupervisingProfessor";
            this.colSupervisingProfessor.Name = "colSupervisingProfessor";
            this.colSupervisingProfessor.Visible = true;
            this.colSupervisingProfessor.VisibleIndex = 1;
            // 
            // riluSupervisingProfessor
            // 
            this.riluSupervisingProfessor.AutoHeight = false;
            this.riluSupervisingProfessor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riluSupervisingProfessor.DataSource = this.professorBindingSource;
            this.riluSupervisingProfessor.DisplayMember = "LastName";
            this.riluSupervisingProfessor.Name = "riluSupervisingProfessor";
            this.riluSupervisingProfessor.ValueMember = "ProfessorID";
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(Uni.Educational.Model.Professor);
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 2;
            // 
            // colLanguage
            // 
            this.colLanguage.ColumnEdit = this.riluLanguage;
            this.colLanguage.FieldName = "Language";
            this.colLanguage.Name = "colLanguage";
            this.colLanguage.Visible = true;
            this.colLanguage.VisibleIndex = 3;
            // 
            // riluLanguage
            // 
            this.riluLanguage.AutoHeight = false;
            this.riluLanguage.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riluLanguage.DataSource = this.programmingLanguageBindingSource;
            this.riluLanguage.DisplayMember = "Name";
            this.riluLanguage.Name = "riluLanguage";
            this.riluLanguage.ValueMember = "ProgrammingLanguageID";
            // 
            // programmingLanguageBindingSource
            // 
            this.programmingLanguageBindingSource.DataSource = typeof(Uni.Educational.Model.ProgrammingLanguage);
            // 
            // colTechnology
            // 
            this.colTechnology.ColumnEdit = this.riluTechnology;
            this.colTechnology.FieldName = "Technology";
            this.colTechnology.Name = "colTechnology";
            this.colTechnology.Visible = true;
            this.colTechnology.VisibleIndex = 4;
            // 
            // riluTechnology
            // 
            this.riluTechnology.AutoHeight = false;
            this.riluTechnology.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riluTechnology.DataSource = this.technologyStackBindingSource;
            this.riluTechnology.DisplayMember = "Description";
            this.riluTechnology.Name = "riluTechnology";
            this.riluTechnology.ValidateOnEnterKey = true;
            this.riluTechnology.ValueMember = "TechnologyStackID";
            // 
            // technologyStackBindingSource
            // 
            this.technologyStackBindingSource.DataSource = typeof(Uni.Educational.Model.TechnologyStack);
            // 
            // frmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 509);
            this.Name = "frmProjects";
            this.Text = "Projects";
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riluAssignee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riluSupervisingProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riluLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingLanguageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riluTechnology)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technologyStackBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource projectBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riluSupervisingProfessor;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riluLanguage;
        private System.Windows.Forms.BindingSource programmingLanguageBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riluTechnology;
        private System.Windows.Forms.BindingSource technologyStackBindingSource;
        protected DevExpress.XtraGrid.Columns.GridColumn colAssignee;
        protected DevExpress.XtraGrid.Columns.GridColumn colSupervisingProfessor;
        protected DevExpress.XtraGrid.Columns.GridColumn colLanguage;
        protected DevExpress.XtraGrid.Columns.GridColumn colTechnology;
        protected DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riluAssignee;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colMobilePhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
    }
}