
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataIn = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.btClearData = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btClose = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataIn);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDataIn
            // 
            this.txtDataIn.Location = new System.Drawing.Point(558, 21);
            this.txtDataIn.Multiline = true;
            this.txtDataIn.Name = "txtDataIn";
            this.txtDataIn.ReadOnly = true;
            this.txtDataIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataIn.Size = new System.Drawing.Size(202, 185);
            this.txtDataIn.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chBoxAddToOldData);
            this.groupBox3.Controls.Add(this.chBoxAlwaysUpdate);
            this.groupBox3.Controls.Add(this.btClearData);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.btClose);
            this.groupBox3.Controls.Add(this.btOpen);
            this.groupBox3.Location = new System.Drawing.Point(282, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 185);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Com Port Status";
            // 
            // chBoxAddToOldData
            // 
            this.chBoxAddToOldData.AutoSize = true;
            this.chBoxAddToOldData.Location = new System.Drawing.Point(139, 93);
            this.chBoxAddToOldData.Name = "chBoxAddToOldData";
            this.chBoxAddToOldData.Size = new System.Drawing.Size(126, 21);
            this.chBoxAddToOldData.TabIndex = 4;
            this.chBoxAddToOldData.Text = "Add to old data";
            this.chBoxAddToOldData.UseVisualStyleBackColor = true;
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(139, 64);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(123, 21);
            this.chBoxAlwaysUpdate.TabIndex = 3;
            this.chBoxAlwaysUpdate.Text = "Always Update";
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            // 
            // btClearData
            // 
            this.btClearData.Location = new System.Drawing.Point(139, 35);
            this.btClearData.Name = "btClearData";
            this.btClearData.Size = new System.Drawing.Size(107, 23);
            this.btClearData.TabIndex = 2;
            this.btClearData.Text = "Clear Data";
            this.btClearData.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 75);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(118, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(75, 35);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(58, 23);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(15, 35);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(60, 23);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "Open";
            this.btOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOpen.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Com Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "PORT NAME";
            // 
            // cbParityBits
            // 
            this.cbParityBits.FormattingEnabled = true;
            this.cbParityBits.Items.AddRange(new object[] {
            "None",
            "Old",
            "Even"});
            this.cbParityBits.Location = new System.Drawing.Point(130, 141);
            this.cbParityBits.Name = "cbParityBits";
            this.cbParityBits.Size = new System.Drawing.Size(121, 24);
            this.cbParityBits.TabIndex = 4;
            this.cbParityBits.Text = "None";
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbStopBits.Location = new System.Drawing.Point(130, 111);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(121, 24);
            this.cbStopBits.TabIndex = 3;
            this.cbStopBits.Text = "One";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cbBaudRate.Location = new System.Drawing.Point(130, 51);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cbBaudRate.TabIndex = 2;
            this.cbBaudRate.Text = "9600";
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(130, 81);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 24);
            this.cbDataBits.TabIndex = 1;
            this.cbDataBits.Text = "8";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(130, 21);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 24);
            this.cbComPort.TabIndex = 0;
            // 
            // ScaleConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 231);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScaleConnect";
            this.Text = "ScaleConnect";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.CheckBox chBoxAddToOldData;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate;
        private System.Windows.Forms.Button btClearData;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btOpen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtDataIn;
    }
}