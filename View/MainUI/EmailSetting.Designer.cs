namespace ElectronicScale2MES
{
    partial class EmailSetting
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
            this.txb_addReceiver = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_changeSender = new System.Windows.Forms.Button();
            this.txb_sender = new System.Windows.Forms.TextBox();
            this.txb_senderPwd = new System.Windows.Forms.TextBox();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.dtgv_receivers = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lb_sender = new System.Windows.Forms.Label();
            this.lb_senderPwd = new System.Windows.Forms.Label();
            this.lb_addReceiver = new System.Windows.Forms.Label();
            this.lb_search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_receivers)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_addReceiver
            // 
            this.txb_addReceiver.Location = new System.Drawing.Point(115, 109);
            this.txb_addReceiver.Name = "txb_addReceiver";
            this.txb_addReceiver.Size = new System.Drawing.Size(248, 22);
            this.txb_addReceiver.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(380, 95);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 50);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_changeSender
            // 
            this.btn_changeSender.Location = new System.Drawing.Point(379, 24);
            this.btn_changeSender.Name = "btn_changeSender";
            this.btn_changeSender.Size = new System.Drawing.Size(94, 50);
            this.btn_changeSender.TabIndex = 2;
            this.btn_changeSender.Text = "CHANGE";
            this.btn_changeSender.UseVisualStyleBackColor = true;
            this.btn_changeSender.Click += new System.EventHandler(this.btn_changeSender_Click);
            // 
            // txb_sender
            // 
            this.txb_sender.Enabled = false;
            this.txb_sender.Location = new System.Drawing.Point(104, 24);
            this.txb_sender.Name = "txb_sender";
            this.txb_sender.Size = new System.Drawing.Size(259, 22);
            this.txb_sender.TabIndex = 3;
            // 
            // txb_senderPwd
            // 
            this.txb_senderPwd.Enabled = false;
            this.txb_senderPwd.Location = new System.Drawing.Point(104, 52);
            this.txb_senderPwd.Name = "txb_senderPwd";
            this.txb_senderPwd.PasswordChar = '*';
            this.txb_senderPwd.Size = new System.Drawing.Size(190, 22);
            this.txb_senderPwd.TabIndex = 4;
            // 
            // txb_search
            // 
            this.txb_search.Location = new System.Drawing.Point(104, 189);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(259, 22);
            this.txb_search.TabIndex = 5;
            this.txb_search.TextChanged += new System.EventHandler(this.txb_search_TextChanged);
            // 
            // dtgv_receivers
            // 
            this.dtgv_receivers.AllowUserToAddRows = false;
            this.dtgv_receivers.AllowUserToDeleteRows = false;
            this.dtgv_receivers.AllowUserToOrderColumns = true;
            this.dtgv_receivers.AllowUserToResizeColumns = false;
            this.dtgv_receivers.AllowUserToResizeRows = false;
            this.dtgv_receivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_receivers.Location = new System.Drawing.Point(16, 230);
            this.dtgv_receivers.Name = "dtgv_receivers";
            this.dtgv_receivers.ReadOnly = true;
            this.dtgv_receivers.RowHeadersWidth = 51;
            this.dtgv_receivers.RowTemplate.Height = 24;
            this.dtgv_receivers.Size = new System.Drawing.Size(347, 208);
            this.dtgv_receivers.TabIndex = 6;
            this.dtgv_receivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_receivers_CellClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(379, 230);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 53);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lb_sender
            // 
            this.lb_sender.AutoSize = true;
            this.lb_sender.Location = new System.Drawing.Point(13, 24);
            this.lb_sender.Name = "lb_sender";
            this.lb_sender.Size = new System.Drawing.Size(54, 17);
            this.lb_sender.TabIndex = 8;
            this.lb_sender.Text = "Sender";
            // 
            // lb_senderPwd
            // 
            this.lb_senderPwd.AutoSize = true;
            this.lb_senderPwd.Location = new System.Drawing.Point(12, 57);
            this.lb_senderPwd.Name = "lb_senderPwd";
            this.lb_senderPwd.Size = new System.Drawing.Size(84, 17);
            this.lb_senderPwd.TabIndex = 9;
            this.lb_senderPwd.Text = "Sender Pwd";
            // 
            // lb_addReceiver
            // 
            this.lb_addReceiver.AutoSize = true;
            this.lb_addReceiver.Location = new System.Drawing.Point(12, 114);
            this.lb_addReceiver.Name = "lb_addReceiver";
            this.lb_addReceiver.Size = new System.Drawing.Size(92, 17);
            this.lb_addReceiver.TabIndex = 10;
            this.lb_addReceiver.Text = "Receiver add";
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Location = new System.Drawing.Point(13, 192);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(53, 17);
            this.lb_search.TabIndex = 11;
            this.lb_search.Text = "Search";
            // 
            // EmailSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.lb_addReceiver);
            this.Controls.Add(this.lb_senderPwd);
            this.Controls.Add(this.lb_sender);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dtgv_receivers);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.txb_senderPwd);
            this.Controls.Add(this.txb_sender);
            this.Controls.Add(this.btn_changeSender);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txb_addReceiver);
            this.MaximumSize = new System.Drawing.Size(503, 497);
            this.MinimumSize = new System.Drawing.Size(503, 497);
            this.Name = "EmailSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmailSetting";
            this.Load += new System.EventHandler(this.EmailSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_receivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_addReceiver;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_changeSender;
        private System.Windows.Forms.TextBox txb_sender;
        private System.Windows.Forms.TextBox txb_senderPwd;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.DataGridView dtgv_receivers;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lb_sender;
        private System.Windows.Forms.Label lb_senderPwd;
        private System.Windows.Forms.Label lb_addReceiver;
        private System.Windows.Forms.Label lb_search;
    }
}