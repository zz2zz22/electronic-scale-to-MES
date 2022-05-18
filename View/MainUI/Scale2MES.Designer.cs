
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
            this.lb_dataIn = new System.Windows.Forms.Label();
            this.lb_dataUnit = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grbx_dataInfos = new System.Windows.Forms.GroupBox();
            this.cbx_employeeInfo = new System.Windows.Forms.ComboBox();
            this.lb_employeeInfoLabel = new System.Windows.Forms.Label();
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
            this.dtgv_mesData.Location = new System.Drawing.Point(3, 83);
            this.dtgv_mesData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_mesData.MultiSelect = false;
            this.dtgv_mesData.Name = "dtgv_mesData";
            this.dtgv_mesData.ReadOnly = true;
            this.dtgv_mesData.RowHeadersVisible = false;
            this.dtgv_mesData.RowHeadersWidth = 51;
            this.dtgv_mesData.RowTemplate.Height = 24;
            this.dtgv_mesData.Size = new System.Drawing.Size(1026, 235);
            this.dtgv_mesData.TabIndex = 0;
            this.dtgv_mesData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_mesData_CellClick);
            // 
            // txb_searchErpCode
            // 
            this.txb_searchErpCode.Location = new System.Drawing.Point(120, 13);
            this.txb_searchErpCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_searchErpCode.Name = "txb_searchErpCode";
            this.txb_searchErpCode.Size = new System.Drawing.Size(155, 22);
            this.txb_searchErpCode.TabIndex = 2;
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
            this.panel_selectData.Location = new System.Drawing.Point(12, 11);
            this.panel_selectData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_selectData.Name = "panel_selectData";
            this.panel_selectData.Size = new System.Drawing.Size(1037, 320);
            this.panel_selectData.TabIndex = 3;
            // 
            // btn_resetSearch
            // 
            this.btn_resetSearch.BackColor = System.Drawing.Color.Silver;
            this.btn_resetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetSearch.Location = new System.Drawing.Point(860, 13);
            this.btn_resetSearch.Name = "btn_resetSearch";
            this.btn_resetSearch.Size = new System.Drawing.Size(139, 62);
            this.btn_resetSearch.TabIndex = 13;
            this.btn_resetSearch.Text = "RESET";
            this.btn_resetSearch.UseVisualStyleBackColor = false;
            this.btn_resetSearch.Click += new System.EventHandler(this.btn_resetSearch_Click);
            // 
            // txb_searchMatCode
            // 
            this.txb_searchMatCode.Location = new System.Drawing.Point(409, 13);
            this.txb_searchMatCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_searchMatCode.Name = "txb_searchMatCode";
            this.txb_searchMatCode.Size = new System.Drawing.Size(168, 22);
            this.txb_searchMatCode.TabIndex = 8;
            // 
            // btn_searchDatatable
            // 
            this.btn_searchDatatable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchDatatable.Location = new System.Drawing.Point(715, 13);
            this.btn_searchDatatable.Name = "btn_searchDatatable";
            this.btn_searchDatatable.Size = new System.Drawing.Size(139, 62);
            this.btn_searchDatatable.TabIndex = 7;
            this.btn_searchDatatable.Text = "SEARCH";
            this.btn_searchDatatable.UseVisualStyleBackColor = true;
            this.btn_searchDatatable.Click += new System.EventHandler(this.btn_searchDatatable_Click);
            // 
            // lb_materialCode
            // 
            this.lb_materialCode.AutoSize = true;
            this.lb_materialCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_materialCode.Location = new System.Drawing.Point(297, 16);
            this.lb_materialCode.Name = "lb_materialCode";
            this.lb_materialCode.Size = new System.Drawing.Size(106, 17);
            this.lb_materialCode.TabIndex = 6;
            this.lb_materialCode.Text = "Material code";
            // 
            // txb_searchProdCode
            // 
            this.txb_searchProdCode.Location = new System.Drawing.Point(120, 45);
            this.txb_searchProdCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_searchProdCode.Name = "txb_searchProdCode";
            this.txb_searchProdCode.Size = new System.Drawing.Size(155, 22);
            this.txb_searchProdCode.TabIndex = 5;
            // 
            // lb_productCode
            // 
            this.lb_productCode.AutoSize = true;
            this.lb_productCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productCode.Location = new System.Drawing.Point(8, 48);
            this.lb_productCode.Name = "lb_productCode";
            this.lb_productCode.Size = new System.Drawing.Size(104, 17);
            this.lb_productCode.TabIndex = 4;
            this.lb_productCode.Text = "Product code";
            // 
            // lb_erpCode
            // 
            this.lb_erpCode.AutoSize = true;
            this.lb_erpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_erpCode.Location = new System.Drawing.Point(8, 16);
            this.lb_erpCode.Name = "lb_erpCode";
            this.lb_erpCode.Size = new System.Drawing.Size(81, 17);
            this.lb_erpCode.TabIndex = 3;
            this.lb_erpCode.Text = "ERP Code";
            // 
            // btn_addNGQty
            // 
            this.btn_addNGQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNGQty.Location = new System.Drawing.Point(214, 126);
            this.btn_addNGQty.Name = "btn_addNGQty";
            this.btn_addNGQty.Size = new System.Drawing.Size(149, 68);
            this.btn_addNGQty.TabIndex = 25;
            this.btn_addNGQty.Text = "ADD NOT GOOD QUANTITY";
            this.btn_addNGQty.UseVisualStyleBackColor = true;
            this.btn_addNGQty.Click += new System.EventHandler(this.btn_addNGQty_Click);
            // 
            // lb_finishQtyInfo
            // 
            this.lb_finishQtyInfo.AutoSize = true;
            this.lb_finishQtyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_finishQtyInfo.Location = new System.Drawing.Point(125, 201);
            this.lb_finishQtyInfo.Name = "lb_finishQtyInfo";
            this.lb_finishQtyInfo.Size = new System.Drawing.Size(0, 17);
            this.lb_finishQtyInfo.TabIndex = 22;
            // 
            // lb_finishQtyInfoLabel
            // 
            this.lb_finishQtyInfoLabel.AutoSize = true;
            this.lb_finishQtyInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_finishQtyInfoLabel.Location = new System.Drawing.Point(16, 198);
            this.lb_finishQtyInfoLabel.Name = "lb_finishQtyInfoLabel";
            this.lb_finishQtyInfoLabel.Size = new System.Drawing.Size(71, 17);
            this.lb_finishQtyInfoLabel.TabIndex = 21;
            this.lb_finishQtyInfoLabel.Text = "Finish Qty";
            // 
            // lb_dispatchQtyInfo
            // 
            this.lb_dispatchQtyInfo.AutoSize = true;
            this.lb_dispatchQtyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dispatchQtyInfo.Location = new System.Drawing.Point(125, 162);
            this.lb_dispatchQtyInfo.Name = "lb_dispatchQtyInfo";
            this.lb_dispatchQtyInfo.Size = new System.Drawing.Size(0, 17);
            this.lb_dispatchQtyInfo.TabIndex = 20;
            // 
            // lb_dispatchQtyInfoLabel
            // 
            this.lb_dispatchQtyInfoLabel.AutoSize = true;
            this.lb_dispatchQtyInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dispatchQtyInfoLabel.Location = new System.Drawing.Point(16, 162);
            this.lb_dispatchQtyInfoLabel.Name = "lb_dispatchQtyInfoLabel";
            this.lb_dispatchQtyInfoLabel.Size = new System.Drawing.Size(89, 17);
            this.lb_dispatchQtyInfoLabel.TabIndex = 19;
            this.lb_dispatchQtyInfoLabel.Text = "Dispatch Qty";
            // 
            // lb_planQtyInfo
            // 
            this.lb_planQtyInfo.AutoSize = true;
            this.lb_planQtyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_planQtyInfo.Location = new System.Drawing.Point(125, 126);
            this.lb_planQtyInfo.Name = "lb_planQtyInfo";
            this.lb_planQtyInfo.Size = new System.Drawing.Size(0, 17);
            this.lb_planQtyInfo.TabIndex = 18;
            // 
            // lb_planQtyInfoLabel
            // 
            this.lb_planQtyInfoLabel.AutoSize = true;
            this.lb_planQtyInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_planQtyInfoLabel.Location = new System.Drawing.Point(16, 126);
            this.lb_planQtyInfoLabel.Name = "lb_planQtyInfoLabel";
            this.lb_planQtyInfoLabel.Size = new System.Drawing.Size(62, 17);
            this.lb_planQtyInfoLabel.TabIndex = 17;
            this.lb_planQtyInfoLabel.Text = "Plan Qty";
            // 
            // lb_matCodeInfo
            // 
            this.lb_matCodeInfo.AutoSize = true;
            this.lb_matCodeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matCodeInfo.Location = new System.Drawing.Point(125, 87);
            this.lb_matCodeInfo.Name = "lb_matCodeInfo";
            this.lb_matCodeInfo.Size = new System.Drawing.Size(0, 17);
            this.lb_matCodeInfo.TabIndex = 14;
            // 
            // lb_matCodeInfoLabel
            // 
            this.lb_matCodeInfoLabel.AutoSize = true;
            this.lb_matCodeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matCodeInfoLabel.Location = new System.Drawing.Point(16, 87);
            this.lb_matCodeInfoLabel.Name = "lb_matCodeInfoLabel";
            this.lb_matCodeInfoLabel.Size = new System.Drawing.Size(95, 17);
            this.lb_matCodeInfoLabel.TabIndex = 13;
            this.lb_matCodeInfoLabel.Text = "Material Code";
            // 
            // lb_prodCodeInfo
            // 
            this.lb_prodCodeInfo.AutoSize = true;
            this.lb_prodCodeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prodCodeInfo.Location = new System.Drawing.Point(125, 54);
            this.lb_prodCodeInfo.Name = "lb_prodCodeInfo";
            this.lb_prodCodeInfo.Size = new System.Drawing.Size(0, 17);
            this.lb_prodCodeInfo.TabIndex = 12;
            // 
            // lb_prodCodeInfoLabel
            // 
            this.lb_prodCodeInfoLabel.AutoSize = true;
            this.lb_prodCodeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prodCodeInfoLabel.Location = new System.Drawing.Point(16, 54);
            this.lb_prodCodeInfoLabel.Name = "lb_prodCodeInfoLabel";
            this.lb_prodCodeInfoLabel.Size = new System.Drawing.Size(94, 17);
            this.lb_prodCodeInfoLabel.TabIndex = 11;
            this.lb_prodCodeInfoLabel.Text = "Product Code";
            // 
            // lb_erpCodeInfo
            // 
            this.lb_erpCodeInfo.AutoSize = true;
            this.lb_erpCodeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_erpCodeInfo.Location = new System.Drawing.Point(125, 24);
            this.lb_erpCodeInfo.Name = "lb_erpCodeInfo";
            this.lb_erpCodeInfo.Size = new System.Drawing.Size(0, 17);
            this.lb_erpCodeInfo.TabIndex = 10;
            // 
            // lb_erpCodeInfoLabel
            // 
            this.lb_erpCodeInfoLabel.AutoSize = true;
            this.lb_erpCodeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_erpCodeInfoLabel.Location = new System.Drawing.Point(16, 24);
            this.lb_erpCodeInfoLabel.Name = "lb_erpCodeInfoLabel";
            this.lb_erpCodeInfoLabel.Size = new System.Drawing.Size(73, 17);
            this.lb_erpCodeInfoLabel.TabIndex = 8;
            this.lb_erpCodeInfoLabel.Text = "ERP Code";
            // 
            // cxb_updateTotalWeight
            // 
            this.cxb_updateTotalWeight.AutoSize = true;
            this.cxb_updateTotalWeight.Checked = true;
            this.cxb_updateTotalWeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cxb_updateTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxb_updateTotalWeight.Location = new System.Drawing.Point(660, 129);
            this.cxb_updateTotalWeight.Name = "cxb_updateTotalWeight";
            this.cxb_updateTotalWeight.Size = new System.Drawing.Size(155, 22);
            this.cxb_updateTotalWeight.TabIndex = 9;
            this.cxb_updateTotalWeight.Text = "Update total weight";
            this.cxb_updateTotalWeight.UseVisualStyleBackColor = true;
            this.cxb_updateTotalWeight.CheckedChanged += new System.EventHandler(this.cxb_updateTotalWeight_CheckedChanged);
            // 
            // cxb_stackWeight
            // 
            this.cxb_stackWeight.AutoSize = true;
            this.cxb_stackWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxb_stackWeight.Location = new System.Drawing.Point(660, 159);
            this.cxb_stackWeight.Name = "cxb_stackWeight";
            this.cxb_stackWeight.Size = new System.Drawing.Size(150, 22);
            this.cxb_stackWeight.TabIndex = 8;
            this.cxb_stackWeight.Text = "Add to total weight";
            this.cxb_stackWeight.UseVisualStyleBackColor = true;
            this.cxb_stackWeight.CheckedChanged += new System.EventHandler(this.cxb_stackWeight_CheckedChanged);
            // 
            // btn_resetTotalWeight
            // 
            this.btn_resetTotalWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_resetTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetTotalWeight.ForeColor = System.Drawing.Color.White;
            this.btn_resetTotalWeight.Location = new System.Drawing.Point(809, 634);
            this.btn_resetTotalWeight.Name = "btn_resetTotalWeight";
            this.btn_resetTotalWeight.Size = new System.Drawing.Size(97, 32);
            this.btn_resetTotalWeight.TabIndex = 7;
            this.btn_resetTotalWeight.Text = "RESET";
            this.btn_resetTotalWeight.UseVisualStyleBackColor = false;
            this.btn_resetTotalWeight.Click += new System.EventHandler(this.btn_resetTotalWeight_Click);
            // 
            // btn_save2MES
            // 
            this.btn_save2MES.BackColor = System.Drawing.Color.Yellow;
            this.btn_save2MES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save2MES.Location = new System.Drawing.Point(912, 583);
            this.btn_save2MES.Name = "btn_save2MES";
            this.btn_save2MES.Size = new System.Drawing.Size(137, 79);
            this.btn_save2MES.TabIndex = 6;
            this.btn_save2MES.Text = "SAVE TO MES";
            this.btn_save2MES.UseVisualStyleBackColor = false;
            this.btn_save2MES.Click += new System.EventHandler(this.btn_save2MES_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.lb_totalWeight);
            this.panel4.Controls.Add(this.lb_totalWeightUnit);
            this.panel4.Location = new System.Drawing.Point(467, 583);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 83);
            this.panel4.TabIndex = 5;
            // 
            // lb_totalWeight
            // 
            this.lb_totalWeight.AutoSize = true;
            this.lb_totalWeight.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalWeight.ForeColor = System.Drawing.Color.White;
            this.lb_totalWeight.Location = new System.Drawing.Point(3, 4);
            this.lb_totalWeight.Name = "lb_totalWeight";
            this.lb_totalWeight.Size = new System.Drawing.Size(204, 79);
            this.lb_totalWeight.TabIndex = 0;
            this.lb_totalWeight.Text = "00.00";
            // 
            // lb_totalWeightUnit
            // 
            this.lb_totalWeightUnit.AutoSize = true;
            this.lb_totalWeightUnit.BackColor = System.Drawing.Color.Black;
            this.lb_totalWeightUnit.Font = new System.Drawing.Font("DS-Digital", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalWeightUnit.ForeColor = System.Drawing.Color.White;
            this.lb_totalWeightUnit.Location = new System.Drawing.Point(278, 35);
            this.lb_totalWeightUnit.Name = "lb_totalWeightUnit";
            this.lb_totalWeightUnit.Size = new System.Drawing.Size(55, 37);
            this.lb_totalWeightUnit.TabIndex = 1;
            this.lb_totalWeightUnit.Text = "KG";
            // 
            // btn_undoWeightAdding
            // 
            this.btn_undoWeightAdding.BackColor = System.Drawing.Color.Gray;
            this.btn_undoWeightAdding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_undoWeightAdding.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_undoWeightAdding.Location = new System.Drawing.Point(809, 583);
            this.btn_undoWeightAdding.Name = "btn_undoWeightAdding";
            this.btn_undoWeightAdding.Size = new System.Drawing.Size(97, 46);
            this.btn_undoWeightAdding.TabIndex = 4;
            this.btn_undoWeightAdding.Text = "UNDO";
            this.btn_undoWeightAdding.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lb_dataIn);
            this.panel3.Controls.Add(this.lb_dataUnit);
            this.panel3.Location = new System.Drawing.Point(398, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 68);
            this.panel3.TabIndex = 2;
            // 
            // lb_dataIn
            // 
            this.lb_dataIn.AutoSize = true;
            this.lb_dataIn.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dataIn.ForeColor = System.Drawing.Color.White;
            this.lb_dataIn.Location = new System.Drawing.Point(3, 3);
            this.lb_dataIn.Name = "lb_dataIn";
            this.lb_dataIn.Size = new System.Drawing.Size(152, 59);
            this.lb_dataIn.TabIndex = 0;
            this.lb_dataIn.Text = "00.00";
            // 
            // lb_dataUnit
            // 
            this.lb_dataUnit.AutoSize = true;
            this.lb_dataUnit.BackColor = System.Drawing.Color.Black;
            this.lb_dataUnit.Font = new System.Drawing.Font("DS-Digital", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dataUnit.ForeColor = System.Drawing.Color.White;
            this.lb_dataUnit.Location = new System.Drawing.Point(219, 33);
            this.lb_dataUnit.Name = "lb_dataUnit";
            this.lb_dataUnit.Size = new System.Drawing.Size(34, 24);
            this.lb_dataUnit.TabIndex = 1;
            this.lb_dataUnit.Text = "KG";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // grbx_dataInfos
            // 
            this.grbx_dataInfos.Controls.Add(this.lb_employeeInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.cbx_employeeInfo);
            this.grbx_dataInfos.Controls.Add(this.btn_addNGQty);
            this.grbx_dataInfos.Controls.Add(this.lb_erpCodeInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.lb_finishQtyInfo);
            this.grbx_dataInfos.Controls.Add(this.panel3);
            this.grbx_dataInfos.Controls.Add(this.lb_finishQtyInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.cxb_stackWeight);
            this.grbx_dataInfos.Controls.Add(this.lb_dispatchQtyInfo);
            this.grbx_dataInfos.Controls.Add(this.cxb_updateTotalWeight);
            this.grbx_dataInfos.Controls.Add(this.lb_dispatchQtyInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.lb_erpCodeInfo);
            this.grbx_dataInfos.Controls.Add(this.lb_planQtyInfo);
            this.grbx_dataInfos.Controls.Add(this.lb_prodCodeInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.lb_planQtyInfoLabel);
            this.grbx_dataInfos.Controls.Add(this.lb_prodCodeInfo);
            this.grbx_dataInfos.Controls.Add(this.lb_matCodeInfo);
            this.grbx_dataInfos.Controls.Add(this.lb_matCodeInfoLabel);
            this.grbx_dataInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbx_dataInfos.Location = new System.Drawing.Point(23, 342);
            this.grbx_dataInfos.Name = "grbx_dataInfos";
            this.grbx_dataInfos.Size = new System.Drawing.Size(1018, 235);
            this.grbx_dataInfos.TabIndex = 26;
            this.grbx_dataInfos.TabStop = false;
            this.grbx_dataInfos.Text = "Data Information";
            // 
            // cbx_employeeInfo
            // 
            this.cbx_employeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_employeeInfo.FormattingEnabled = true;
            this.cbx_employeeInfo.Location = new System.Drawing.Point(391, 21);
            this.cbx_employeeInfo.Name = "cbx_employeeInfo";
            this.cbx_employeeInfo.Size = new System.Drawing.Size(327, 24);
            this.cbx_employeeInfo.TabIndex = 26;
            this.cbx_employeeInfo.Text = "Choose employee ";
            this.cbx_employeeInfo.SelectedValueChanged += new System.EventHandler(this.cbx_employeeInfo_SelectedValueChanged);
            // 
            // lb_employeeInfoLabel
            // 
            this.lb_employeeInfoLabel.AutoSize = true;
            this.lb_employeeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_employeeInfoLabel.Location = new System.Drawing.Point(315, 23);
            this.lb_employeeInfoLabel.Name = "lb_employeeInfoLabel";
            this.lb_employeeInfoLabel.Size = new System.Drawing.Size(70, 17);
            this.lb_employeeInfoLabel.TabIndex = 27;
            this.lb_employeeInfoLabel.Text = "Employee";
            // 
            // Scale2MES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 673);
            this.Controls.Add(this.btn_resetTotalWeight);
            this.Controls.Add(this.grbx_dataInfos);
            this.Controls.Add(this.btn_save2MES);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_undoWeightAdding);
            this.Controls.Add(this.panel_selectData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1079, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1079, 720);
            this.Name = "Scale2MES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scale2MES";
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_mesData;
        private System.Windows.Forms.TextBox txb_searchErpCode;
        private System.Windows.Forms.Panel panel_selectData;
        private System.Windows.Forms.Label lb_dataIn;
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
    }
}