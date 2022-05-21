
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scale2MES));
            this.dtgv_mesData = new System.Windows.Forms.DataGridView();
            this.txb_searchErpCode = new System.Windows.Forms.TextBox();
            this.panel_selectData = new System.Windows.Forms.Panel();
            this.btn_resetSearch = new System.Windows.Forms.Button();
            this.txb_searchMatCode = new System.Windows.Forms.TextBox();
            this.btn_searchDatatable = new System.Windows.Forms.Button();
            this.lb_materialCode = new System.Windows.Forms.Label();
            this.txb_searchProdCode = new System.Windows.Forms.TextBox();
            this.lb_productCode = new System.Windows.Forms.Label();
            this.lb_erpCode = new System.Windows.Forms.Label();
            this.btn_addNGQty = new System.Windows.Forms.Button();
            this.lb_finishQtyInfo = new System.Windows.Forms.Label();
            this.lb_finishQtyInfoLabel = new System.Windows.Forms.Label();
            this.lb_dispatchQtyInfo = new System.Windows.Forms.Label();
            this.lb_dispatchQtyInfoLabel = new System.Windows.Forms.Label();
            this.lb_planQtyInfo = new System.Windows.Forms.Label();
            this.lb_planQtyInfoLabel = new System.Windows.Forms.Label();
            this.lb_matCodeInfo = new System.Windows.Forms.Label();
            this.lb_matCodeInfoLabel = new System.Windows.Forms.Label();
            this.lb_prodCodeInfo = new System.Windows.Forms.Label();
            this.lb_prodCodeInfoLabel = new System.Windows.Forms.Label();
            this.lb_erpCodeInfo = new System.Windows.Forms.Label();
            this.lb_erpCodeInfoLabel = new System.Windows.Forms.Label();
            this.cxb_updateTotalWeight = new System.Windows.Forms.CheckBox();
            this.cxb_stackWeight = new System.Windows.Forms.CheckBox();
            this.btn_resetTotalWeight = new System.Windows.Forms.Button();
            this.btn_save2MES = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_totalWeight = new System.Windows.Forms.Label();
            this.lb_totalWeightUnit = new System.Windows.Forms.Label();
            this.btn_undoWeightAdding = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_dataNG = new System.Windows.Forms.Label();
            this.lb_dataUnit = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grbx_dataInfos = new System.Windows.Forms.GroupBox();
            this.btn_ngReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ngUndo = new System.Windows.Forms.Button();
            this.lb_employeeInfoLabel = new System.Windows.Forms.Label();
            this.cbx_employeeInfo = new System.Windows.Forms.ComboBox();
            this.lb_totalWeightInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_mesData)).BeginInit();
            this.panel_selectData.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbx_dataInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_mesData
            // 
            this.dtgv_mesData.AllowUserToAddRows = false;
            this.dtgv_mesData.AllowUserToDeleteRows = false;
            this.dtgv_mesData.AllowUserToResizeColumns = false;
            this.dtgv_mesData.AllowUserToResizeRows = false;
            this.dtgv_mesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_mesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgv_mesData, "dtgv_mesData");
            this.dtgv_mesData.MultiSelect = false;
            this.dtgv_mesData.Name = "dtgv_mesData";
            this.dtgv_mesData.ReadOnly = true;
            this.dtgv_mesData.RowHeadersVisible = false;
            this.dtgv_mesData.RowTemplate.Height = 24;
            this.dtgv_mesData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_mesData_CellClick);
            // 
            // txb_searchErpCode
            // 
            resources.ApplyResources(this.txb_searchErpCode, "txb_searchErpCode");
            this.txb_searchErpCode.Name = "txb_searchErpCode";
            // 
            // panel_selectData
            // 
            this.panel_selectData.Controls.Add(this.btn_resetSearch);
            this.panel_selectData.Controls.Add(this.txb_searchMatCode);
            this.panel_selectData.Controls.Add(this.btn_searchDatatable);
            this.panel_selectData.Controls.Add(this.lb_materialCode);
            this.panel_selectData.Controls.Add(this.txb_searchProdCode);
            this.panel_selectData.Controls.Add(this.lb_productCode);
            this.panel_selectData.Controls.Add(this.lb_erpCode);
            this.panel_selectData.Controls.Add(this.dtgv_mesData);
            this.panel_selectData.Controls.Add(this.txb_searchErpCode);
            resources.ApplyResources(this.panel_selectData, "panel_selectData");
            this.panel_selectData.Name = "panel_selectData";
            // 
            // btn_resetSearch
            // 
            this.btn_resetSearch.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btn_resetSearch, "btn_resetSearch");
            this.btn_resetSearch.Name = "btn_resetSearch";
            this.btn_resetSearch.UseVisualStyleBackColor = false;
            this.btn_resetSearch.Click += new System.EventHandler(this.btn_resetSearch_Click);
            // 
            // txb_searchMatCode
            // 
            resources.ApplyResources(this.txb_searchMatCode, "txb_searchMatCode");
            this.txb_searchMatCode.Name = "txb_searchMatCode";
            // 
            // btn_searchDatatable
            // 
            resources.ApplyResources(this.btn_searchDatatable, "btn_searchDatatable");
            this.btn_searchDatatable.Name = "btn_searchDatatable";
            this.btn_searchDatatable.UseVisualStyleBackColor = true;
            this.btn_searchDatatable.Click += new System.EventHandler(this.btn_searchDatatable_Click);
            // 
            // lb_materialCode
            // 
            resources.ApplyResources(this.lb_materialCode, "lb_materialCode");
            this.lb_materialCode.Name = "lb_materialCode";
            // 
            // txb_searchProdCode
            // 
            resources.ApplyResources(this.txb_searchProdCode, "txb_searchProdCode");
            this.txb_searchProdCode.Name = "txb_searchProdCode";
            // 
            // lb_productCode
            // 
            resources.ApplyResources(this.lb_productCode, "lb_productCode");
            this.lb_productCode.Name = "lb_productCode";
            // 
            // lb_erpCode
            // 
            resources.ApplyResources(this.lb_erpCode, "lb_erpCode");
            this.lb_erpCode.Name = "lb_erpCode";
            // 
            // btn_addNGQty
            // 
            resources.ApplyResources(this.btn_addNGQty, "btn_addNGQty");
            this.btn_addNGQty.Name = "btn_addNGQty";
            this.btn_addNGQty.UseVisualStyleBackColor = true;
            this.btn_addNGQty.Click += new System.EventHandler(this.btn_addNGQty_Click);
            // 
            // lb_finishQtyInfo
            // 
            resources.ApplyResources(this.lb_finishQtyInfo, "lb_finishQtyInfo");
            this.lb_finishQtyInfo.Name = "lb_finishQtyInfo";
            // 
            // lb_finishQtyInfoLabel
            // 
            resources.ApplyResources(this.lb_finishQtyInfoLabel, "lb_finishQtyInfoLabel");
            this.lb_finishQtyInfoLabel.Name = "lb_finishQtyInfoLabel";
            // 
            // lb_dispatchQtyInfo
            // 
            resources.ApplyResources(this.lb_dispatchQtyInfo, "lb_dispatchQtyInfo");
            this.lb_dispatchQtyInfo.Name = "lb_dispatchQtyInfo";
            // 
            // lb_dispatchQtyInfoLabel
            // 
            resources.ApplyResources(this.lb_dispatchQtyInfoLabel, "lb_dispatchQtyInfoLabel");
            this.lb_dispatchQtyInfoLabel.Name = "lb_dispatchQtyInfoLabel";
            // 
            // lb_planQtyInfo
            // 
            resources.ApplyResources(this.lb_planQtyInfo, "lb_planQtyInfo");
            this.lb_planQtyInfo.Name = "lb_planQtyInfo";
            // 
            // lb_planQtyInfoLabel
            // 
            resources.ApplyResources(this.lb_planQtyInfoLabel, "lb_planQtyInfoLabel");
            this.lb_planQtyInfoLabel.Name = "lb_planQtyInfoLabel";
            // 
            // lb_matCodeInfo
            // 
            resources.ApplyResources(this.lb_matCodeInfo, "lb_matCodeInfo");
            this.lb_matCodeInfo.Name = "lb_matCodeInfo";
            // 
            // lb_matCodeInfoLabel
            // 
            resources.ApplyResources(this.lb_matCodeInfoLabel, "lb_matCodeInfoLabel");
            this.lb_matCodeInfoLabel.Name = "lb_matCodeInfoLabel";
            // 
            // lb_prodCodeInfo
            // 
            resources.ApplyResources(this.lb_prodCodeInfo, "lb_prodCodeInfo");
            this.lb_prodCodeInfo.Name = "lb_prodCodeInfo";
            // 
            // lb_prodCodeInfoLabel
            // 
            resources.ApplyResources(this.lb_prodCodeInfoLabel, "lb_prodCodeInfoLabel");
            this.lb_prodCodeInfoLabel.Name = "lb_prodCodeInfoLabel";
            // 
            // lb_erpCodeInfo
            // 
            resources.ApplyResources(this.lb_erpCodeInfo, "lb_erpCodeInfo");
            this.lb_erpCodeInfo.Name = "lb_erpCodeInfo";
            // 
            // lb_erpCodeInfoLabel
            // 
            resources.ApplyResources(this.lb_erpCodeInfoLabel, "lb_erpCodeInfoLabel");
            this.lb_erpCodeInfoLabel.Name = "lb_erpCodeInfoLabel";
            // 
            // cxb_updateTotalWeight
            // 
            resources.ApplyResources(this.cxb_updateTotalWeight, "cxb_updateTotalWeight");
            this.cxb_updateTotalWeight.Name = "cxb_updateTotalWeight";
            this.cxb_updateTotalWeight.UseVisualStyleBackColor = true;
            this.cxb_updateTotalWeight.CheckedChanged += new System.EventHandler(this.cxb_updateTotalWeight_CheckedChanged);
            // 
            // cxb_stackWeight
            // 
            resources.ApplyResources(this.cxb_stackWeight, "cxb_stackWeight");
            this.cxb_stackWeight.Checked = true;
            this.cxb_stackWeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cxb_stackWeight.Name = "cxb_stackWeight";
            this.cxb_stackWeight.UseVisualStyleBackColor = true;
            this.cxb_stackWeight.CheckedChanged += new System.EventHandler(this.cxb_stackWeight_CheckedChanged);
            // 
            // btn_resetTotalWeight
            // 
            this.btn_resetTotalWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btn_resetTotalWeight, "btn_resetTotalWeight");
            this.btn_resetTotalWeight.ForeColor = System.Drawing.Color.White;
            this.btn_resetTotalWeight.Name = "btn_resetTotalWeight";
            this.btn_resetTotalWeight.UseVisualStyleBackColor = false;
            this.btn_resetTotalWeight.Click += new System.EventHandler(this.btn_resetTotalWeight_Click);
            // 
            // btn_save2MES
            // 
            this.btn_save2MES.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.btn_save2MES, "btn_save2MES");
            this.btn_save2MES.Name = "btn_save2MES";
            this.btn_save2MES.UseVisualStyleBackColor = false;
            this.btn_save2MES.Click += new System.EventHandler(this.btn_save2MES_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.lb_totalWeight);
            this.panel4.Controls.Add(this.lb_totalWeightUnit);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lb_totalWeight
            // 
            resources.ApplyResources(this.lb_totalWeight, "lb_totalWeight");
            this.lb_totalWeight.ForeColor = System.Drawing.Color.White;
            this.lb_totalWeight.Name = "lb_totalWeight";
            // 
            // lb_totalWeightUnit
            // 
            resources.ApplyResources(this.lb_totalWeightUnit, "lb_totalWeightUnit");
            this.lb_totalWeightUnit.BackColor = System.Drawing.Color.Black;
            this.lb_totalWeightUnit.ForeColor = System.Drawing.Color.White;
            this.lb_totalWeightUnit.Name = "lb_totalWeightUnit";
            // 
            // btn_undoWeightAdding
            // 
            this.btn_undoWeightAdding.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btn_undoWeightAdding, "btn_undoWeightAdding");
            this.btn_undoWeightAdding.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_undoWeightAdding.Name = "btn_undoWeightAdding";
            this.btn_undoWeightAdding.UseVisualStyleBackColor = false;
            this.btn_undoWeightAdding.Click += new System.EventHandler(this.btn_undoWeightAdding_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lb_dataNG);
            this.panel3.Controls.Add(this.lb_dataUnit);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lb_dataNG
            // 
            resources.ApplyResources(this.lb_dataNG, "lb_dataNG");
            this.lb_dataNG.ForeColor = System.Drawing.Color.White;
            this.lb_dataNG.Name = "lb_dataNG";
            // 
            // lb_dataUnit
            // 
            resources.ApplyResources(this.lb_dataUnit, "lb_dataUnit");
            this.lb_dataUnit.BackColor = System.Drawing.Color.Black;
            this.lb_dataUnit.ForeColor = System.Drawing.Color.White;
            this.lb_dataUnit.Name = "lb_dataUnit";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // grbx_dataInfos
            // 
            this.grbx_dataInfos.Controls.Add(this.btn_ngReset);
            this.grbx_dataInfos.Controls.Add(this.label1);
            this.grbx_dataInfos.Controls.Add(this.btn_ngUndo);
            this.grbx_dataInfos.Controls.Add(this.lb_employeeInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.cbx_employeeInfo);
            this.grbx_dataInfos.Controls.Add(this.btn_addNGQty);
            this.grbx_dataInfos.Controls.Add(this.lb_erpCodeInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.lb_finishQtyInfo);
            this.grbx_dataInfos.Controls.Add(this.panel3);
            this.grbx_dataInfos.Controls.Add(this.lb_finishQtyInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.lb_dispatchQtyInfo);
            this.grbx_dataInfos.Controls.Add(this.lb_dispatchQtyInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.lb_erpCodeInfo);
            this.grbx_dataInfos.Controls.Add(this.lb_planQtyInfo);
            this.grbx_dataInfos.Controls.Add(this.lb_prodCodeInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.lb_planQtyInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.lb_prodCodeInfo);
            this.grbx_dataInfos.Controls.Add(this.lb_matCodeInfo);
            this.grbx_dataInfos.Controls.Add(this.lb_matCodeInfoLabel);
            resources.ApplyResources(this.grbx_dataInfos, "grbx_dataInfos");
            this.grbx_dataInfos.Name = "grbx_dataInfos";
            this.grbx_dataInfos.TabStop = false;
            // 
            // btn_ngReset
            // 
            this.btn_ngReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btn_ngReset, "btn_ngReset");
            this.btn_ngReset.ForeColor = System.Drawing.Color.White;
            this.btn_ngReset.Name = "btn_ngReset";
            this.btn_ngReset.UseVisualStyleBackColor = false;
            this.btn_ngReset.Click += new System.EventHandler(this.btn_ngReset_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_ngUndo
            // 
            this.btn_ngUndo.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btn_ngUndo, "btn_ngUndo");
            this.btn_ngUndo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ngUndo.Name = "btn_ngUndo";
            this.btn_ngUndo.UseVisualStyleBackColor = false;
            this.btn_ngUndo.Click += new System.EventHandler(this.btn_ngUndo_Click);
            // 
            // lb_employeeInfoLabel
            // 
            resources.ApplyResources(this.lb_employeeInfoLabel, "lb_employeeInfoLabel");
            this.lb_employeeInfoLabel.Name = "lb_employeeInfoLabel";
            // 
            // cbx_employeeInfo
            // 
            resources.ApplyResources(this.cbx_employeeInfo, "cbx_employeeInfo");
            this.cbx_employeeInfo.FormattingEnabled = true;
            this.cbx_employeeInfo.Name = "cbx_employeeInfo";
            this.cbx_employeeInfo.SelectedValueChanged += new System.EventHandler(this.cbx_employeeInfo_SelectedValueChanged);
            // 
            // lb_totalWeightInfo
            // 
            resources.ApplyResources(this.lb_totalWeightInfo, "lb_totalWeightInfo");
            this.lb_totalWeightInfo.Name = "lb_totalWeightInfo";
            // 
            // Scale2MES
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_totalWeightInfo);
            this.Controls.Add(this.btn_resetTotalWeight);
            this.Controls.Add(this.grbx_dataInfos);
            this.Controls.Add(this.btn_save2MES);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_undoWeightAdding);
            this.Controls.Add(this.panel_selectData);
            this.Controls.Add(this.cxb_updateTotalWeight);
            this.Controls.Add(this.cxb_stackWeight);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Scale2MES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scale2MES_FormClosed);
            this.Load += new System.EventHandler(this.Scale2MES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_mesData)).EndInit();
            this.panel_selectData.ResumeLayout(false);
            this.panel_selectData.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grbx_dataInfos.ResumeLayout(false);
            this.grbx_dataInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_mesData;
        private System.Windows.Forms.TextBox txb_searchErpCode;
        private System.Windows.Forms.Panel panel_selectData;
        private System.Windows.Forms.Label lb_dataNG;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_dataUnit;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lb_erpCode;
        private System.Windows.Forms.TextBox txb_searchProdCode;
        private System.Windows.Forms.Label lb_productCode;
        private System.Windows.Forms.Button btn_searchDatatable;
        private System.Windows.Forms.Label lb_materialCode;
        private System.Windows.Forms.Button btn_undoWeightAdding;
        private System.Windows.Forms.Button btn_save2MES;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_totalWeight;
        private System.Windows.Forms.Label lb_totalWeightUnit;
        private System.Windows.Forms.CheckBox cxb_updateTotalWeight;
        private System.Windows.Forms.CheckBox cxb_stackWeight;
        private System.Windows.Forms.Button btn_resetTotalWeight;
        private System.Windows.Forms.Label lb_matCodeInfo;
        private System.Windows.Forms.Label lb_matCodeInfoLabel;
        private System.Windows.Forms.Label lb_prodCodeInfo;
        private System.Windows.Forms.Label lb_prodCodeInfoLabel;
        private System.Windows.Forms.Label lb_erpCodeInfo;
        private System.Windows.Forms.Label lb_erpCodeInfoLabel;
        private System.Windows.Forms.TextBox txb_searchMatCode;
        private System.Windows.Forms.Label lb_finishQtyInfo;
        private System.Windows.Forms.Label lb_finishQtyInfoLabel;
        private System.Windows.Forms.Label lb_dispatchQtyInfo;
        private System.Windows.Forms.Label lb_dispatchQtyInfoLabel;
        private System.Windows.Forms.Label lb_planQtyInfo;
        private System.Windows.Forms.Label lb_planQtyInfoLabel;
        private System.Windows.Forms.Button btn_resetSearch;
        private System.Windows.Forms.Button btn_addNGQty;
        private System.Windows.Forms.GroupBox grbx_dataInfos;
        private System.Windows.Forms.Label lb_employeeInfoLabel;
        private System.Windows.Forms.ComboBox cbx_employeeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_totalWeightInfo;
        private System.Windows.Forms.Button btn_ngReset;
        private System.Windows.Forms.Button btn_ngUndo;
    }
}