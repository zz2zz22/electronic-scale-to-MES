
namespace ElectronicScale2MES
{
    partial class ChangeDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDatabase));
            this.lb_dbType = new System.Windows.Forms.Label();
            this.cbx_dbType = new System.Windows.Forms.ComboBox();
            this.lb_hostType = new System.Windows.Forms.Label();
            this.cbx_hostType = new System.Windows.Forms.ComboBox();
            this.lb_hostName = new System.Windows.Forms.Label();
            this.gb_dbConfig = new System.Windows.Forms.GroupBox();
            this.gb_connConfig = new System.Windows.Forms.GroupBox();
            this.txb_hostPassword = new System.Windows.Forms.TextBox();
            this.txb_hostUsername = new System.Windows.Forms.TextBox();
            this.txb_hostName = new System.Windows.Forms.TextBox();
            this.lb_hostPassword = new System.Windows.Forms.Label();
            this.lb_hostUsername = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.rtb_logShow = new System.Windows.Forms.RichTextBox();
            this.gb_dbConfig.SuspendLayout();
            this.gb_connConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_dbType
            // 
            resources.ApplyResources(this.lb_dbType, "lb_dbType");
            this.lb_dbType.Name = "lb_dbType";
            // 
            // cbx_dbType
            // 
            this.cbx_dbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbx_dbType, "cbx_dbType");
            this.cbx_dbType.FormattingEnabled = true;
            this.cbx_dbType.Items.AddRange(new object[] {
            resources.GetString("cbx_dbType.Items"),
            resources.GetString("cbx_dbType.Items1")});
            this.cbx_dbType.Name = "cbx_dbType";
            this.cbx_dbType.SelectedValueChanged += new System.EventHandler(this.cbx_dbType_SelectedValueChanged);
            // 
            // lb_hostType
            // 
            resources.ApplyResources(this.lb_hostType, "lb_hostType");
            this.lb_hostType.Name = "lb_hostType";
            // 
            // cbx_hostType
            // 
            this.cbx_hostType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbx_hostType, "cbx_hostType");
            this.cbx_hostType.FormattingEnabled = true;
            this.cbx_hostType.Items.AddRange(new object[] {
            resources.GetString("cbx_hostType.Items"),
            resources.GetString("cbx_hostType.Items1")});
            this.cbx_hostType.Name = "cbx_hostType";
            this.cbx_hostType.SelectedValueChanged += new System.EventHandler(this.cbx_hostType_SelectedValueChanged);
            // 
            // lb_hostName
            // 
            resources.ApplyResources(this.lb_hostName, "lb_hostName");
            this.lb_hostName.Name = "lb_hostName";
            // 
            // gb_dbConfig
            // 
            this.gb_dbConfig.Controls.Add(this.lb_dbType);
            this.gb_dbConfig.Controls.Add(this.cbx_dbType);
            this.gb_dbConfig.Controls.Add(this.cbx_hostType);
            this.gb_dbConfig.Controls.Add(this.lb_hostType);
            resources.ApplyResources(this.gb_dbConfig, "gb_dbConfig");
            this.gb_dbConfig.Name = "gb_dbConfig";
            this.gb_dbConfig.TabStop = false;
            // 
            // gb_connConfig
            // 
            this.gb_connConfig.Controls.Add(this.txb_hostPassword);
            this.gb_connConfig.Controls.Add(this.txb_hostUsername);
            this.gb_connConfig.Controls.Add(this.txb_hostName);
            this.gb_connConfig.Controls.Add(this.lb_hostPassword);
            this.gb_connConfig.Controls.Add(this.lb_hostUsername);
            this.gb_connConfig.Controls.Add(this.lb_hostName);
            resources.ApplyResources(this.gb_connConfig, "gb_connConfig");
            this.gb_connConfig.Name = "gb_connConfig";
            this.gb_connConfig.TabStop = false;
            // 
            // txb_hostPassword
            // 
            resources.ApplyResources(this.txb_hostPassword, "txb_hostPassword");
            this.txb_hostPassword.Name = "txb_hostPassword";
            // 
            // txb_hostUsername
            // 
            resources.ApplyResources(this.txb_hostUsername, "txb_hostUsername");
            this.txb_hostUsername.Name = "txb_hostUsername";
            // 
            // txb_hostName
            // 
            resources.ApplyResources(this.txb_hostName, "txb_hostName");
            this.txb_hostName.Name = "txb_hostName";
            // 
            // lb_hostPassword
            // 
            resources.ApplyResources(this.lb_hostPassword, "lb_hostPassword");
            this.lb_hostPassword.Name = "lb_hostPassword";
            // 
            // lb_hostUsername
            // 
            resources.ApplyResources(this.lb_hostUsername, "lb_hostUsername");
            this.lb_hostUsername.Name = "lb_hostUsername";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Yellow;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_save, "btn_save");
            this.btn_save.Name = "btn_save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // rtb_logShow
            // 
            resources.ApplyResources(this.rtb_logShow, "rtb_logShow");
            this.rtb_logShow.Name = "rtb_logShow";
            // 
            // ChangeDatabase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtb_logShow);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gb_connConfig);
            this.Controls.Add(this.gb_dbConfig);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeDatabase";
            this.Load += new System.EventHandler(this.ChangeDatabase_Load);
            this.gb_dbConfig.ResumeLayout(false);
            this.gb_dbConfig.PerformLayout();
            this.gb_connConfig.ResumeLayout(false);
            this.gb_connConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_dbType;
        private System.Windows.Forms.ComboBox cbx_dbType;
        private System.Windows.Forms.Label lb_hostType;
        private System.Windows.Forms.ComboBox cbx_hostType;
        private System.Windows.Forms.Label lb_hostName;
        private System.Windows.Forms.GroupBox gb_dbConfig;
        private System.Windows.Forms.GroupBox gb_connConfig;
        private System.Windows.Forms.Label lb_hostUsername;
        private System.Windows.Forms.TextBox txb_hostPassword;
        private System.Windows.Forms.TextBox txb_hostUsername;
        private System.Windows.Forms.TextBox txb_hostName;
        private System.Windows.Forms.Label lb_hostPassword;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RichTextBox rtb_logShow;
    }
}