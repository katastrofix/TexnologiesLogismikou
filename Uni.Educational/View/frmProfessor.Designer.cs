namespace Uni.Educational.View
{
    partial class frmProfessor
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
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OfficeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FieldTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.fieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOffice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForField = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtcDetails)).BeginInit();
            this.xtcDetails.SuspendLayout();
            this.xtpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForField)).BeginInit();
            this.SuspendLayout();
            // 
            // xtcDetails
            // 
            this.xtcDetails.SelectedTabPage = this.xtpMain;
            // 
            // xtpMain
            // 
            this.xtpMain.Controls.Add(this.dataLayoutControl1);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(Uni.Educational.Model.Professor);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.FirstNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LastNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.OfficeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FieldTextEdit);
            this.dataLayoutControl1.DataSource = this.professorBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(850, 314);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // FirstNameTextEdit
            // 
            this.FirstNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.professorBindingSource, "FirstName", true));
            this.FirstNameTextEdit.Location = new System.Drawing.Point(66, 12);
            this.FirstNameTextEdit.MenuManager = this.ribbonControl1;
            this.FirstNameTextEdit.Name = "FirstNameTextEdit";
            this.FirstNameTextEdit.Size = new System.Drawing.Size(772, 20);
            this.FirstNameTextEdit.StyleController = this.dataLayoutControl1;
            this.FirstNameTextEdit.TabIndex = 4;
            // 
            // LastNameTextEdit
            // 
            this.LastNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.professorBindingSource, "LastName", true));
            this.LastNameTextEdit.Location = new System.Drawing.Point(66, 36);
            this.LastNameTextEdit.MenuManager = this.ribbonControl1;
            this.LastNameTextEdit.Name = "LastNameTextEdit";
            this.LastNameTextEdit.Size = new System.Drawing.Size(772, 20);
            this.LastNameTextEdit.StyleController = this.dataLayoutControl1;
            this.LastNameTextEdit.TabIndex = 5;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.professorBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(66, 60);
            this.EmailTextEdit.MenuManager = this.ribbonControl1;
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(772, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 6;
            // 
            // PhoneTextEdit
            // 
            this.PhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.professorBindingSource, "Phone", true));
            this.PhoneTextEdit.Location = new System.Drawing.Point(66, 84);
            this.PhoneTextEdit.MenuManager = this.ribbonControl1;
            this.PhoneTextEdit.Name = "PhoneTextEdit";
            this.PhoneTextEdit.Size = new System.Drawing.Size(772, 20);
            this.PhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.PhoneTextEdit.TabIndex = 7;
            // 
            // OfficeTextEdit
            // 
            this.OfficeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.professorBindingSource, "Office", true));
            this.OfficeTextEdit.Location = new System.Drawing.Point(66, 108);
            this.OfficeTextEdit.MenuManager = this.ribbonControl1;
            this.OfficeTextEdit.Name = "OfficeTextEdit";
            this.OfficeTextEdit.Size = new System.Drawing.Size(772, 20);
            this.OfficeTextEdit.StyleController = this.dataLayoutControl1;
            this.OfficeTextEdit.TabIndex = 8;
            // 
            // FieldTextEdit
            // 
            this.FieldTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.professorBindingSource, "Field", true));
            this.FieldTextEdit.Location = new System.Drawing.Point(66, 132);
            this.FieldTextEdit.MenuManager = this.ribbonControl1;
            this.FieldTextEdit.Name = "FieldTextEdit";
            this.FieldTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FieldTextEdit.Properties.DataSource = this.fieldBindingSource;
            this.FieldTextEdit.Properties.DisplayMember = "Description";
            this.FieldTextEdit.Properties.NullText = "";
            this.FieldTextEdit.Properties.ValueMember = "ID";
            this.FieldTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.FieldTextEdit.Size = new System.Drawing.Size(772, 20);
            this.FieldTextEdit.StyleController = this.dataLayoutControl1;
            this.FieldTextEdit.TabIndex = 9;
            // 
            // fieldBindingSource
            // 
            this.fieldBindingSource.DataSource = typeof(Uni.Educational.Model.Field);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(850, 314);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFirstName,
            this.ItemForLastName,
            this.ItemForEmail,
            this.ItemForPhone,
            this.ItemForOffice,
            this.ItemForField});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(830, 294);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForFirstName
            // 
            this.ItemForFirstName.Control = this.FirstNameTextEdit;
            this.ItemForFirstName.CustomizationFormText = "First Name";
            this.ItemForFirstName.Location = new System.Drawing.Point(0, 0);
            this.ItemForFirstName.Name = "ItemForFirstName";
            this.ItemForFirstName.Size = new System.Drawing.Size(830, 24);
            this.ItemForFirstName.Text = "First Name";
            this.ItemForFirstName.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForLastName
            // 
            this.ItemForLastName.Control = this.LastNameTextEdit;
            this.ItemForLastName.CustomizationFormText = "Last Name";
            this.ItemForLastName.Location = new System.Drawing.Point(0, 24);
            this.ItemForLastName.Name = "ItemForLastName";
            this.ItemForLastName.Size = new System.Drawing.Size(830, 24);
            this.ItemForLastName.Text = "Last Name";
            this.ItemForLastName.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.CustomizationFormText = "Email";
            this.ItemForEmail.Location = new System.Drawing.Point(0, 48);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(830, 24);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForPhone
            // 
            this.ItemForPhone.Control = this.PhoneTextEdit;
            this.ItemForPhone.CustomizationFormText = "Phone";
            this.ItemForPhone.Location = new System.Drawing.Point(0, 72);
            this.ItemForPhone.Name = "ItemForPhone";
            this.ItemForPhone.Size = new System.Drawing.Size(830, 24);
            this.ItemForPhone.Text = "Phone";
            this.ItemForPhone.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForOffice
            // 
            this.ItemForOffice.Control = this.OfficeTextEdit;
            this.ItemForOffice.CustomizationFormText = "Office";
            this.ItemForOffice.Location = new System.Drawing.Point(0, 96);
            this.ItemForOffice.Name = "ItemForOffice";
            this.ItemForOffice.Size = new System.Drawing.Size(830, 24);
            this.ItemForOffice.Text = "Office";
            this.ItemForOffice.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForField
            // 
            this.ItemForField.Control = this.FieldTextEdit;
            this.ItemForField.CustomizationFormText = "Field";
            this.ItemForField.Location = new System.Drawing.Point(0, 120);
            this.ItemForField.Name = "ItemForField";
            this.ItemForField.Size = new System.Drawing.Size(830, 174);
            this.ItemForField.Text = "Field";
            this.ItemForField.TextSize = new System.Drawing.Size(51, 13);
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 484);
            this.Name = "frmProfessor";
            this.Text = "frmProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.xtcDetails)).EndInit();
            this.xtcDetails.ResumeLayout(false);
            this.xtpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource professorBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit LastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit OfficeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOffice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForField;
        private DevExpress.XtraEditors.GridLookUpEdit FieldTextEdit;
        private System.Windows.Forms.BindingSource fieldBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;


    }
}