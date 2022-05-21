
namespace ElectronicScale2MES
{
    partial class ScaleConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleConnect));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbParityBits = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_portRefresh = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btClose = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rtb_testConnection = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbParityBits);
            this.groupBox2.Controls.Add(this.cbStopBits);
            this.groupBox2.Controls.Add(this.cbBaudRate);
            this.groupBox2.Controls.Add(this.cbDataBits);
            this.groupBox2.Controls.Add(this.cbComPort);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbParityBits
            // 
            this.cbParityBits.FormattingEnabled = true;
            this.cbParityBits.Items.AddRange(new object[] {
            resources.GetString("cbParityBits.Items"),
            resources.GetString("cbParityBits.Items1"),
            resources.GetString("cbParityBits.Items2")});
            resources.ApplyResources(this.cbParityBits, "cbParityBits");
            this.cbParityBits.Name = "cbParityBits";
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            resources.GetString("cbStopBits.Items"),
            resources.GetString("cbStopBits.Items1")});
            resources.ApplyResources(this.cbStopBits, "cbStopBits");
            this.cbStopBits.Name = "cbStopBits";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            resources.GetString("cbBaudRate.Items"),
            resources.GetString("cbBaudRate.Items1"),
            resources.GetString("cbBaudRate.Items2")});
            resources.ApplyResources(this.cbBaudRate, "cbBaudRate");
            this.cbBaudRate.Name = "cbBaudRate";
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            resources.GetString("cbDataBits.Items"),
            resources.GetString("cbDataBits.Items1"),
            resources.GetString("cbDataBits.Items2")});
            resources.ApplyResources(this.cbDataBits, "cbDataBits");
            this.cbDataBits.Name = "cbDataBits";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            resources.ApplyResources(this.cbComPort, "cbComPort");
            this.cbComPort.Name = "cbComPort";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_portRefresh);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.btClose);
            this.groupBox3.Controls.Add(this.btOpen);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btn_portRefresh
            // 
            resources.ApplyResources(this.btn_portRefresh, "btn_portRefresh");
            this.btn_portRefresh.Name = "btn_portRefresh";
            this.btn_portRefresh.UseVisualStyleBackColor = true;
            this.btn_portRefresh.Click += new System.EventHandler(this.btn_portRefresh_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // btClose
            // 
            resources.ApplyResources(this.btClose, "btClose");
            this.btClose.Name = "btClose";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btOpen
            // 
            resources.ApplyResources(this.btOpen, "btOpen");
            this.btOpen.Name = "btOpen";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // rtb_testConnection
            // 
            resources.ApplyResources(this.rtb_testConnection, "rtb_testConnection");
            this.rtb_testConnection.Name = "rtb_testConnection";
            // 
            // ScaleConnect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtb_testConnection);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScaleConnect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScaleConnect_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbParityBits;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_portRefresh;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btOpen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox rtb_testConnection;
    }
}