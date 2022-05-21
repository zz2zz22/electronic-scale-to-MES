
namespace ElectronicScale2MES
{
    partial class MainTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTask));
            this.xuibtn_scale2MES = new XanderUI.XUIButton();
            this.xuibtn_scaleConnect = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // xuibtn_scale2MES
            // 
            this.xuibtn_scale2MES.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.xuibtn_scale2MES.ButtonImage = global::ElectronicScale2MES.Properties.Resources.scale2MESpng;
            this.xuibtn_scale2MES.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuibtn_scale2MES.ButtonText = "SCALE 2 MES";
            this.xuibtn_scale2MES.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuibtn_scale2MES.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scale2MES.CornerRadius = 10;
            resources.ApplyResources(this.xuibtn_scale2MES, "xuibtn_scale2MES");
            this.xuibtn_scale2MES.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_scale2MES.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xuibtn_scale2MES.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scale2MES.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuibtn_scale2MES.Name = "xuibtn_scale2MES";
            this.xuibtn_scale2MES.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scale2MES.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_scale2MES.Click += new System.EventHandler(this.xuibtn_scale2MES_Click);
            // 
            // xuibtn_scaleConnect
            // 
            this.xuibtn_scaleConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuibtn_scaleConnect.ButtonImage = global::ElectronicScale2MES.Properties.Resources.ruler;
            this.xuibtn_scaleConnect.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuibtn_scaleConnect.ButtonText = "SCALE CONNECT";
            this.xuibtn_scaleConnect.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuibtn_scaleConnect.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scaleConnect.CornerRadius = 10;
            resources.ApplyResources(this.xuibtn_scaleConnect, "xuibtn_scaleConnect");
            this.xuibtn_scaleConnect.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_scaleConnect.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xuibtn_scaleConnect.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scaleConnect.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuibtn_scaleConnect.Name = "xuibtn_scaleConnect";
            this.xuibtn_scaleConnect.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scaleConnect.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_scaleConnect.Click += new System.EventHandler(this.xuibtn_scaleConnect_Click);
            // 
            // MainTask
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.xuibtn_scaleConnect);
            this.Controls.Add(this.xuibtn_scale2MES);
            this.Name = "MainTask";
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUIButton xuibtn_scale2MES;
        private XanderUI.XUIButton xuibtn_scaleConnect;
    }
}