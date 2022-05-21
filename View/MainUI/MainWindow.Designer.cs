
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
            this.tlp_mainWindow = new System.Windows.Forms.TableLayoutPanel();
            this.xuiWidgetPanel1 = new XanderUI.XUIWidgetPanel();
            this.xuibtn_mainTask = new XanderUI.XUIButton();
            this.xuibtn_setting = new XanderUI.XUIButton();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.lb_dbInfo = new System.Windows.Forms.Label();
            this.lb_dbInfoShow = new System.Windows.Forms.Label();
            this.lb_dbUserShow = new System.Windows.Forms.Label();
            this.lb_dbUserInfo = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel2.Controls.Add(this.xuibtn_mainTask, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.xuibtn_setting, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(812, 88);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.tlp_mainWindow.Size = new System.Drawing.Size(818, 287);
            this.tlp_mainWindow.TabIndex = 1;
            // 
            // xuiWidgetPanel1
            // 
            this.xuiWidgetPanel1.ControlsAsWidgets = false;
            this.xuiWidgetPanel1.Location = new System.Drawing.Point(3, 97);
            this.xuiWidgetPanel1.Name = "xuiWidgetPanel1";
            this.xuiWidgetPanel1.Size = new System.Drawing.Size(809, 187);
            this.xuiWidgetPanel1.TabIndex = 1;
            // 
            // xuibtn_mainTask
            // 
            this.xuibtn_mainTask.BackgroundColor = System.Drawing.Color.White;
            this.xuibtn_mainTask.ButtonImage = global::ElectronicScale2MES.Properties.Resources.list;
            this.xuibtn_mainTask.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuibtn_mainTask.ButtonText = "MAIN TASKS";
            this.xuibtn_mainTask.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuibtn_mainTask.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_mainTask.CornerRadius = 5;
            this.xuibtn_mainTask.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuibtn_mainTask.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_mainTask.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuibtn_mainTask.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_mainTask.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuibtn_mainTask.Location = new System.Drawing.Point(3, 3);
            this.xuibtn_mainTask.Name = "xuibtn_mainTask";
            this.xuibtn_mainTask.Size = new System.Drawing.Size(400, 81);
            this.xuibtn_mainTask.TabIndex = 1;
            this.xuibtn_mainTask.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_mainTask.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_mainTask.Click += new System.EventHandler(this.xuibtn_mainTask_Click);
            // 
            // xuibtn_setting
            // 
            this.xuibtn_setting.BackgroundColor = System.Drawing.Color.White;
            this.xuibtn_setting.ButtonImage = global::ElectronicScale2MES.Properties.Resources.key_person;
            this.xuibtn_setting.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuibtn_setting.ButtonText = "SETTINGS";
            this.xuibtn_setting.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuibtn_setting.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_setting.CornerRadius = 5;
            this.xuibtn_setting.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuibtn_setting.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_setting.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuibtn_setting.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_setting.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuibtn_setting.Location = new System.Drawing.Point(409, 3);
            this.xuibtn_setting.Name = "xuibtn_setting";
            this.xuibtn_setting.Size = new System.Drawing.Size(400, 82);
            this.xuibtn_setting.TabIndex = 2;
            this.xuibtn_setting.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtn_setting.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtn_setting.Click += new System.EventHandler(this.xuibtn_setting_Click);
            // 
            // ptb_logo
            // 
            this.ptb_logo.Image = global::ElectronicScale2MES.Properties.Resources.download;
            this.ptb_logo.Location = new System.Drawing.Point(12, 0);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(283, 80);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_logo.TabIndex = 0;
            this.ptb_logo.TabStop = false;
            // 
            // lb_dbInfo
            // 
            this.lb_dbInfo.AutoSize = true;
            this.lb_dbInfo.Location = new System.Drawing.Point(366, 9);
            this.lb_dbInfo.Name = "lb_dbInfo";
            this.lb_dbInfo.Size = new System.Drawing.Size(69, 17);
            this.lb_dbInfo.TabIndex = 2;
            this.lb_dbInfo.Text = "Database";
            // 
            // lb_dbInfoShow
            // 
            this.lb_dbInfoShow.AutoSize = true;
            this.lb_dbInfoShow.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ElectronicScale2MES.Properties.Settings.Default, "conHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_dbInfoShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dbInfoShow.Location = new System.Drawing.Point(449, 9);
            this.lb_dbInfoShow.Name = "lb_dbInfoShow";
            this.lb_dbInfoShow.Size = new System.Drawing.Size(0, 17);
            this.lb_dbInfoShow.TabIndex = 3;
            this.lb_dbInfoShow.Text = global::ElectronicScale2MES.Properties.Settings.Default.conHost;
            // 
            // lb_dbUserShow
            // 
            this.lb_dbUserShow.AutoSize = true;
            this.lb_dbUserShow.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ElectronicScale2MES.Properties.Settings.Default, "conUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_dbUserShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dbUserShow.Location = new System.Drawing.Point(449, 38);
            this.lb_dbUserShow.Name = "lb_dbUserShow";
            this.lb_dbUserShow.Size = new System.Drawing.Size(0, 17);
            this.lb_dbUserShow.TabIndex = 5;
            this.lb_dbUserShow.Text = global::ElectronicScale2MES.Properties.Settings.Default.conUser;
            // 
            // lb_dbUserInfo
            // 
            this.lb_dbUserInfo.AutoSize = true;
            this.lb_dbUserInfo.Location = new System.Drawing.Point(366, 38);
            this.lb_dbUserInfo.Name = "lb_dbUserInfo";
            this.lb_dbUserInfo.Size = new System.Drawing.Size(73, 17);
            this.lb_dbUserInfo.TabIndex = 4;
            this.lb_dbUserInfo.Text = "Username";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 380);
            this.Controls.Add(this.lb_dbUserShow);
            this.Controls.Add(this.lb_dbUserInfo);
            this.Controls.Add(this.lb_dbInfoShow);
            this.Controls.Add(this.lb_dbInfo);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_logo;
        private XanderUI.XUIWifiPercentageAPI xuiWifiPercentageAPI1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private XanderUI.XUIButton xuibtn_setting;
        private XanderUI.XUIButton xuibtn_mainTask;
        private System.Windows.Forms.TableLayoutPanel tlp_mainWindow;
        private XanderUI.XUIWidgetPanel xuiWidgetPanel1;
        private System.Windows.Forms.Label lb_dbInfo;
        private System.Windows.Forms.Label lb_dbInfoShow;
        private System.Windows.Forms.Label lb_dbUserShow;
        private System.Windows.Forms.Label lb_dbUserInfo;
    }
}

