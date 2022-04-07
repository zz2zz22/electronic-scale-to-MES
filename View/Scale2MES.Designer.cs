
namespace ElectronicScale2MES
{
    partial class Scale2MES
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
            this.dtgv_mesData = new System.Windows.Forms.DataGridView();
            this.lb_instruction = new System.Windows.Forms.Label();
            this.txb_searchData = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_mesData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_mesData
            // 
            this.dtgv_mesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_mesData.Location = new System.Drawing.Point(8, 88);
            this.dtgv_mesData.Name = "dtgv_mesData";
            this.dtgv_mesData.RowHeadersWidth = 51;
            this.dtgv_mesData.RowTemplate.Height = 24;
            this.dtgv_mesData.Size = new System.Drawing.Size(611, 375);
            this.dtgv_mesData.TabIndex = 0;
            // 
            // lb_instruction
            // 
            this.lb_instruction.AutoSize = true;
            this.lb_instruction.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_instruction.ForeColor = System.Drawing.Color.Red;
            this.lb_instruction.Location = new System.Drawing.Point(17, 12);
            this.lb_instruction.Name = "lb_instruction";
            this.lb_instruction.Size = new System.Drawing.Size(593, 30);
            this.lb_instruction.TabIndex = 1;
            this.lb_instruction.Text = "SCAN THE MATERIAL QR TO SHOW DATA";
            // 
            // txb_searchData
            // 
            this.txb_searchData.Location = new System.Drawing.Point(8, 45);
            this.txb_searchData.Multiline = true;
            this.txb_searchData.Name = "txb_searchData";
            this.txb_searchData.Size = new System.Drawing.Size(611, 37);
            this.txb_searchData.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_instruction);
            this.panel1.Controls.Add(this.dtgv_mesData);
            this.panel1.Controls.Add(this.txb_searchData);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 466);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(652, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 466);
            this.panel2.TabIndex = 4;
            // 
            // Scale2MES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Scale2MES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scale2MES";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_mesData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_mesData;
        private System.Windows.Forms.Label lb_instruction;
        private System.Windows.Forms.TextBox txb_searchData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}