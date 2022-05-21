
namespace ElectronicScale2MES
{
    partial class SettingTask
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
            this.xuibtn_changeDTB = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // xuibtn_changeDTB
            // 
            this.xuibtn_changeDTB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuibtn_changeDTB.ButtonImage = global::ElectronicScale2MES.Properties.Resources.geography;
            this.xuibtn_changeDTB.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuibtn_changeDTB.ButtonText = "CHANGE DATABASE";
            this.xuibtn_changeDTB.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuibtn_changeDTB.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_changeDTB.CornerRadius = 10;
            this.xuibtn_changeDTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuibtn_changeDTB.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_changeDTB.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xuibtn_changeDTB.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_changeDTB.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuibtn_changeDTB.Location = new System.Drawing.Point(57, 19);
            this.xuibtn_changeDTB.Name = "xuibtn_changeDTB";
            this.xuibtn_changeDTB.Size = new System.Drawing.Size(282, 80);
            this.xuibtn_changeDTB.TabIndex = 4;
            this.xuibtn_changeDTB.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_changeDTB.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_changeDTB.Click += new System.EventHandler(this.xuibtn_changeDTB_Click);
            // 
            // SettingTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(791, 231);
            this.Controls.Add(this.xuibtn_changeDTB);
            this.Name = "SettingTask";
            this.Text = "SettingTask";
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUIButton xuibtn_changeDTB;
    }
}