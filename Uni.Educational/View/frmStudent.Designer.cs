namespace Uni.Educational.View
{
    partial class frmStudent
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
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MobilePhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMobilePhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtcDetails)).BeginInit();
            this.xtcDetails.SuspendLayout();
            this.xtpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobilePhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobilePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
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
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.FirstNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LastNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MobilePhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.DataSource = this.studentBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(850, 314);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Uni.Educational.Model.Student);
            // 
            // FirstNameTextEdit
            // 
            this.FirstNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentBindingSource, "FirstName", true));
            this.FirstNameTextEdit.Location = new System.Drawing.Point(78, 12);
            this.FirstNameTextEdit.MenuManager = this.ribbonControl1;
            this.FirstNameTextEdit.Name = "FirstNameTextEdit";
            this.FirstNameTextEdit.Size = new System.Drawing.Size(760, 20);
            this.FirstNameTextEdit.StyleController = this.dataLayoutControl1;
            this.FirstNameTextEdit.TabIndex = 5;
            // 
            // LastNameTextEdit
            // 
            this.LastNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentBindingSource, "LastName", true));
            this.LastNameTextEdit.Location = new System.Drawing.Point(78, 36);
            this.LastNameTextEdit.MenuManager = this.ribbonControl1;
            this.LastNameTextEdit.Name = "LastNameTextEdit";
            this.LastNameTextEdit.Size = new System.Drawing.Size(760, 20);
            this.LastNameTextEdit.StyleController = this.dataLayoutControl1;
            this.LastNameTextEdit.TabIndex = 6;
            // 
            // MobilePhoneTextEdit
            // 
            this.MobilePhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentBindingSource, "MobilePhone", true));
            this.MobilePhoneTextEdit.Location = new System.Drawing.Point(78, 60);
            this.MobilePhoneTextEdit.MenuManager = this.ribbonControl1;
            this.MobilePhoneTextEdit.Name = "MobilePhoneTextEdit";
            this.MobilePhoneTextEdit.Size = new System.Drawing.Size(760, 20);
            this.MobilePhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.MobilePhoneTextEdit.TabIndex = 7;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(78, 84);
            this.EmailTextEdit.MenuManager = this.ribbonControl1;
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(760, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 8;
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
            this.ItemForMobilePhone,
            this.ItemForEmail});
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
            this.ItemForFirstName.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForLastName
            // 
            this.ItemForLastName.Control = this.LastNameTextEdit;
            this.ItemForLastName.CustomizationFormText = "Last Name";
            this.ItemForLastName.Location = new System.Drawing.Point(0, 24);
            this.ItemForLastName.Name = "ItemForLastName";
            this.ItemForLastName.Size = new System.Drawing.Size(830, 24);
            this.ItemForLastName.Text = "Last Name";
            this.ItemForLastName.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForMobilePhone
            // 
            this.ItemForMobilePhone.Control = this.MobilePhoneTextEdit;
            this.ItemForMobilePhone.CustomizationFormText = "Mobile Phone";
            this.ItemForMobilePhone.Location = new System.Drawing.Point(0, 48);
            this.ItemForMobilePhone.Name = "ItemForMobilePhone";
            this.ItemForMobilePhone.Size = new System.Drawing.Size(830, 24);
            this.ItemForMobilePhone.Text = "Mobile Phone";
            this.ItemForMobilePhone.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.CustomizationFormText = "Email";
            this.ItemForEmail.Location = new System.Drawing.Point(0, 72);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(830, 222);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(63, 13);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 484);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            ((System.ComponentModel.ISupportInitialize)(this.xtcDetails)).EndInit();
            this.xtcDetails.ResumeLayout(false);
            this.xtpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobilePhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobilePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit LastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit MobilePhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMobilePhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
    }
}