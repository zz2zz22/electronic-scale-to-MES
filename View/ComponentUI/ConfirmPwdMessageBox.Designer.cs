
namespace ElectronicScale2MES
{
    partial class ConfirmPwdMessageBox
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
            this.lb_inputPassword = new System.Windows.Forms.Label();
            this.txb_inputPassword = new System.Windows.Forms.TextBox();
            this.btn_confirmPassword = new System.Windows.Forms.Button();
            this.lb_logShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_inputPassword
            // 
            this.lb_inputPassword.AutoSize = true;
            this.lb_inputPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inputPassword.Location = new System.Drawing.Point(12, 28);
            this.lb_inputPassword.Name = "lb_inputPassword";
            this.lb_inputPassword.Size = new System.Drawing.Size(152, 18);
            this.lb_inputPassword.TabIndex = 0;
            this.lb_inputPassword.Text = "Input admin password";
            // 
            // txb_inputPassword
            // 
            this.txb_inputPassword.Location = new System.Drawing.Point(15, 59);
            this.txb_inputPassword.Name = "txb_inputPassword";
            this.txb_inputPassword.PasswordChar = '*';
            this.txb_inputPassword.Size = new System.Drawing.Size(247, 22);
            this.txb_inputPassword.TabIndex = 1;
            this.txb_inputPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_inputPassword_KeyDown);
            // 
            // btn_confirmPassword
            // 
            this.btn_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmPassword.Location = new System.Drawing.Point(73, 118);
            this.btn_confirmPassword.Name = "btn_confirmPassword";
            this.btn_confirmPassword.Size = new System.Drawing.Size(120, 45);
            this.btn_confirmPassword.TabIndex = 2;
            this.btn_confirmPassword.Text = "OK";
            this.btn_confirmPassword.UseVisualStyleBackColor = true;
            this.btn_confirmPassword.Click += new System.EventHandler(this.btn_confirmPassword_Click);
            // 
            // lb_logShow
            // 
            this.lb_logShow.AutoSize = true;
            this.lb_logShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_logShow.Location = new System.Drawing.Point(15, 88);
            this.lb_logShow.Name = "lb_logShow";
            this.lb_logShow.Size = new System.Drawing.Size(0, 17);
            this.lb_logShow.TabIndex = 3;
            // 
            // ConfirmPwdMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 175);
            this.Controls.Add(this.lb_logShow);
            this.Controls.Add(this.btn_confirmPassword);
            this.Controls.Add(this.txb_inputPassword);
            this.Controls.Add(this.lb_inputPassword);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 222);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 222);
            this.Name = "ConfirmPwdMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm admin password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_inputPassword;
        private System.Windows.Forms.TextBox txb_inputPassword;
        private System.Windows.Forms.Button btn_confirmPassword;
        private System.Windows.Forms.Label lb_logShow;
    }
}