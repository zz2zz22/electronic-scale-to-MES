﻿
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
            this.xuibtn_scale2MES = new XanderUI.XUIButton();
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
            this.xuibtn_scale2MES.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuibtn_scale2MES.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_scale2MES.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xuibtn_scale2MES.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scale2MES.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuibtn_scale2MES.Location = new System.Drawing.Point(13, 13);
            this.xuibtn_scale2MES.Name = "xuibtn_scale2MES";
            this.xuibtn_scale2MES.Size = new System.Drawing.Size(282, 80);
            this.xuibtn_scale2MES.TabIndex = 0;
            this.xuibtn_scale2MES.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scale2MES.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_scale2MES.Click += new System.EventHandler(this.xuibtn_scale2MES_Click);
            // 
            // MainTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 231);
            this.Controls.Add(this.xuibtn_scale2MES);
            this.Name = "MainTask";
            this.Text = "MainTask";
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton xuibtn_scale2MES;
    }
}