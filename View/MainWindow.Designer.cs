
namespace ElectronicScale2MES
{
    partial class MainWindow
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
            this.xuiWifiPercentageAPI1 = new XanderUI.XUIWifiPercentageAPI();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuibtn_scaleConnect = new XanderUI.XUIButton();
            this.tlp_mainWindow = new System.Windows.Forms.TableLayoutPanel();
            this.xuiWidgetPanel1 = new XanderUI.XUIWidgetPanel();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlp_mainWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiWifiPercentageAPI1
            // 
            this.xuiWifiPercentageAPI1.Enabled = true;
            this.xuiWifiPercentageAPI1.Interval = 3000;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.xuiButton3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.xuiButton2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.xuibtn_scaleConnect, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(812, 175);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton3.ButtonImage = global::ElectronicScale2MES.Properties.Resources.key_person;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "SETTINGS";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(3, 90);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(400, 82);
            this.xuiButton3.TabIndex = 2;
            this.xuiButton3.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton2.ButtonImage = global::ElectronicScale2MES.Properties.Resources.list;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "MAIN TASKS";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(409, 3);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(400, 81);
            this.xuiButton2.TabIndex = 1;
            this.xuiButton2.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuibtn_scaleConnect
            // 
            this.xuibtn_scaleConnect.BackgroundColor = System.Drawing.Color.White;
            this.xuibtn_scaleConnect.ButtonImage = global::ElectronicScale2MES.Properties.Resources.puzzle;
            this.xuibtn_scaleConnect.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuibtn_scaleConnect.ButtonText = "SCALE CONNECT";
            this.xuibtn_scaleConnect.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuibtn_scaleConnect.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scaleConnect.CornerRadius = 5;
            this.xuibtn_scaleConnect.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuibtn_scaleConnect.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_scaleConnect.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuibtn_scaleConnect.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scaleConnect.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuibtn_scaleConnect.Location = new System.Drawing.Point(3, 3);
            this.xuibtn_scaleConnect.Name = "xuibtn_scaleConnect";
            this.xuibtn_scaleConnect.Size = new System.Drawing.Size(400, 81);
            this.xuibtn_scaleConnect.TabIndex = 0;
            this.xuibtn_scaleConnect.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_scaleConnect.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_scaleConnect.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // tlp_mainWindow
            // 
            this.tlp_mainWindow.ColumnCount = 1;
            this.tlp_mainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_mainWindow.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlp_mainWindow.Controls.Add(this.xuiWidgetPanel1, 0, 1);
            this.tlp_mainWindow.Location = new System.Drawing.Point(12, 86);
            this.tlp_mainWindow.Name = "tlp_mainWindow";
            this.tlp_mainWindow.RowCount = 2;
            this.tlp_mainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_mainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_mainWindow.Size = new System.Drawing.Size(818, 465);
            this.tlp_mainWindow.TabIndex = 1;
            // 
            // xuiWidgetPanel1
            // 
            this.xuiWidgetPanel1.ControlsAsWidgets = false;
            this.xuiWidgetPanel1.Location = new System.Drawing.Point(3, 184);
            this.xuiWidgetPanel1.Name = "xuiWidgetPanel1";
            this.xuiWidgetPanel1.Size = new System.Drawing.Size(809, 278);
            this.xuiWidgetPanel1.TabIndex = 1;
            // 
            // ptb_logo
            // 
            this.ptb_logo.Image = global::ElectronicScale2MES.Properties.Resources.download;
            this.ptb_logo.Location = new System.Drawing.Point(0, 0);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(283, 80);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_logo.TabIndex = 0;
            this.ptb_logo.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 553);
            this.Controls.Add(this.tlp_mainWindow);
            this.Controls.Add(this.ptb_logo);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scale program";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlp_mainWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_logo;
        private XanderUI.XUIWifiPercentageAPI xuiWifiPercentageAPI1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuibtn_scaleConnect;
        private System.Windows.Forms.TableLayoutPanel tlp_mainWindow;
        private XanderUI.XUIWidgetPanel xuiWidgetPanel1;
    }
}

