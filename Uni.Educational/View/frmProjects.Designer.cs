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
            this.colProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssignee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupervisingProfessor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanguage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechnology = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.DataSource = this.projectBindingSource;
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
            this.colProjectID,
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
            // colProjectID
            // 
            this.colProjectID.FieldName = "ProjectID";
            this.colProjectID.Name = "colProjectID";
            this.colProjectID.Visible = true;
            this.colProjectID.VisibleIndex = 0;
            // 
            // colAssignee
            // 
            this.colAssignee.FieldName = "Assignee";
            this.colAssignee.Name = "colAssignee";
            this.colAssignee.Visible = true;
            this.colAssignee.VisibleIndex = 1;
            // 
            // colSupervisingProfessor
            // 
            this.colSupervisingProfessor.FieldName = "SupervisingProfessor";
            this.colSupervisingProfessor.Name = "colSupervisingProfessor";
            this.colSupervisingProfessor.Visible = true;
            this.colSupervisingProfessor.VisibleIndex = 2;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 3;
            // 
            // colLanguage
            // 
            this.colLanguage.FieldName = "Language";
            this.colLanguage.Name = "colLanguage";
            this.colLanguage.Visible = true;
            this.colLanguage.VisibleIndex = 4;
            // 
            // colTechnology
            // 
            this.colTechnology.FieldName = "Technology";
            this.colTechnology.Name = "colTechnology";
            this.colTechnology.Visible = true;
            this.colTechnology.VisibleIndex = 5;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource projectBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssignee;
        private DevExpress.XtraGrid.Columns.GridColumn colSupervisingProfessor;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colLanguage;
        private DevExpress.XtraGrid.Columns.GridColumn colTechnology;
    }
}