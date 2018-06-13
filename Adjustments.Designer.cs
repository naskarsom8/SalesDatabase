namespace Sales_Commission
{
    partial class frm_Adjustments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Adjustments));
            this.btn_Gen_CTemplate = new System.Windows.Forms.Button();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.tb_Control_Adjustments = new System.Windows.Forms.TabControl();
            this.tbpg_BlankTemp_Adj = new System.Windows.Forms.TabPage();
            this.btn_SaveExcel_BT = new System.Windows.Forms.Button();
            this.btn_MoveAllCols_BT = new System.Windows.Forms.Button();
            this.lbl_SelectedCols_BT = new System.Windows.Forms.Label();
            this.btn_Move1ColBack_Bt = new System.Windows.Forms.Button();
            this.btn_MoveBackCols_BT = new System.Windows.Forms.Button();
            this.btn_Move1Col_BT = new System.Windows.Forms.Button();
            this.lstbx_SelectedCols_BT = new System.Windows.Forms.ListBox();
            this.lstbx_Cols_BT = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_BusinessUnit_BT = new System.Windows.Forms.Label();
            this.cb_Bunit_BT = new System.Windows.Forms.ComboBox();
            this.tbpg_CustomTemplate_Adj = new System.Windows.Forms.TabPage();
            this.dgv_DataView = new System.Windows.Forms.DataGridView();
            this.pnl_GridView_CTemplate = new System.Windows.Forms.Panel();
            this.lbl_Country_CT = new System.Windows.Forms.Label();
            this.cb_SelectCountry_CT = new System.Windows.Forms.ComboBox();
            this.btn_View_CTemplate = new System.Windows.Forms.Button();
            this.dtp_To_CTemplate = new System.Windows.Forms.DateTimePicker();
            this.dtp_From_CTemplate = new System.Windows.Forms.DateTimePicker();
            this.btn_Generate_CTemplate = new System.Windows.Forms.Button();
            this.pnl_SelectReset_CTemplate = new System.Windows.Forms.Panel();
            this.rdbtn_CheckAll_Adj = new System.Windows.Forms.RadioButton();
            this.rdbtn_Reset_Adj = new System.Windows.Forms.RadioButton();
            this.chklstbx_AdjustmentColumns = new System.Windows.Forms.CheckedListBox();
            this.lbl_To_CustomT = new System.Windows.Forms.Label();
            this.lbl_From_CustomT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_AdjustmentType_Adj = new System.Windows.Forms.ComboBox();
            this.cb_Year = new System.Windows.Forms.ComboBox();
            this.cb_Month = new System.Windows.Forms.ComboBox();
            this.pnl_Top.SuspendLayout();
            this.tb_Control_Adjustments.SuspendLayout();
            this.tbpg_BlankTemp_Adj.SuspendLayout();
            this.tbpg_CustomTemplate_Adj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataView)).BeginInit();
            this.pnl_GridView_CTemplate.SuspendLayout();
            this.pnl_SelectReset_CTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Gen_CTemplate
            // 
            this.btn_Gen_CTemplate.BackColor = System.Drawing.Color.Snow;
            this.btn_Gen_CTemplate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gen_CTemplate.ForeColor = System.Drawing.Color.Black;
            this.btn_Gen_CTemplate.Location = new System.Drawing.Point(319, 132);
            this.btn_Gen_CTemplate.Name = "btn_Gen_CTemplate";
            this.btn_Gen_CTemplate.Size = new System.Drawing.Size(121, 31);
            this.btn_Gen_CTemplate.TabIndex = 52;
            this.btn_Gen_CTemplate.Text = "GENERATE";
            this.btn_Gen_CTemplate.UseVisualStyleBackColor = false;
            this.btn_Gen_CTemplate.Click += new System.EventHandler(this.btn_Gen_CTemplate_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.tb_Control_Adjustments);
            this.pnl_Top.Controls.Add(this.cb_Year);
            this.pnl_Top.Controls.Add(this.cb_Month);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1007, 622);
            this.pnl_Top.TabIndex = 1;
            // 
            // tb_Control_Adjustments
            // 
            this.tb_Control_Adjustments.Controls.Add(this.tbpg_BlankTemp_Adj);
            this.tb_Control_Adjustments.Controls.Add(this.tbpg_CustomTemplate_Adj);
            this.tb_Control_Adjustments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Control_Adjustments.Location = new System.Drawing.Point(0, 0);
            this.tb_Control_Adjustments.Name = "tb_Control_Adjustments";
            this.tb_Control_Adjustments.SelectedIndex = 0;
            this.tb_Control_Adjustments.Size = new System.Drawing.Size(1007, 622);
            this.tb_Control_Adjustments.TabIndex = 62;
            // 
            // tbpg_BlankTemp_Adj
            // 
            this.tbpg_BlankTemp_Adj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpg_BlankTemp_Adj.Controls.Add(this.btn_SaveExcel_BT);
            this.tbpg_BlankTemp_Adj.Controls.Add(this.btn_MoveAllCols_BT);
            this.tbpg_BlankTemp_Adj.Controls.Add(this.lbl_SelectedCols_BT);
            this.tbpg_BlankTemp_Adj.Controls.Add(this.btn_Move1ColBack_Bt);
            this.tbpg_BlankTemp_Adj.Controls.Add(this.btn_MoveBackCols_BT);
            this.tbpg_BlankTemp_Adj.Controls.Add(this.btn_Move1Col_BT);
            this.tbpg_BlankTemp_Adj.Controls.Add(this.lstbx_SelectedCols_BT);
            this.tbpg_BlankTemp_Adj.Controls.Add(this.lstbx_Cols_BT);
            this.tbpg_BlankTemp_Adj.Controls.Add(this.label2);
            this.tbpg_BlankTemp_Adj.Controls.Add(this.lbl_BusinessUnit_BT);
            this.tbpg_BlankTemp_Adj.Controls.Add(this.cb_Bunit_BT);
            this.tbpg_BlankTemp_Adj.Location = new System.Drawing.Point(4, 22);
            this.tbpg_BlankTemp_Adj.Name = "tbpg_BlankTemp_Adj";
            this.tbpg_BlankTemp_Adj.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_BlankTemp_Adj.Size = new System.Drawing.Size(999, 596);
            this.tbpg_BlankTemp_Adj.TabIndex = 0;
            this.tbpg_BlankTemp_Adj.Text = "Blank Template";
            this.tbpg_BlankTemp_Adj.UseVisualStyleBackColor = true;
            // 
            // btn_SaveExcel_BT
            // 
            this.btn_SaveExcel_BT.Location = new System.Drawing.Point(451, 268);
            this.btn_SaveExcel_BT.Name = "btn_SaveExcel_BT";
            this.btn_SaveExcel_BT.Size = new System.Drawing.Size(75, 90);
            this.btn_SaveExcel_BT.TabIndex = 78;
            this.btn_SaveExcel_BT.Text = "Save Excel";
            this.btn_SaveExcel_BT.UseVisualStyleBackColor = true;
            this.btn_SaveExcel_BT.Click += new System.EventHandler(this.btn_SaveExcel_BT_Click);
            // 
            // btn_MoveAllCols_BT
            // 
            this.btn_MoveAllCols_BT.Location = new System.Drawing.Point(194, 272);
            this.btn_MoveAllCols_BT.Name = "btn_MoveAllCols_BT";
            this.btn_MoveAllCols_BT.Size = new System.Drawing.Size(75, 23);
            this.btn_MoveAllCols_BT.TabIndex = 85;
            this.btn_MoveAllCols_BT.Text = ">>";
            this.btn_MoveAllCols_BT.UseVisualStyleBackColor = true;
            this.btn_MoveAllCols_BT.Click += new System.EventHandler(this.btn_MoveAllCols_BT_Click);
            // 
            // lbl_SelectedCols_BT
            // 
            this.lbl_SelectedCols_BT.AutoSize = true;
            this.lbl_SelectedCols_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectedCols_BT.Location = new System.Drawing.Point(246, 93);
            this.lbl_SelectedCols_BT.Name = "lbl_SelectedCols_BT";
            this.lbl_SelectedCols_BT.Size = new System.Drawing.Size(123, 15);
            this.lbl_SelectedCols_BT.TabIndex = 84;
            this.lbl_SelectedCols_BT.Text = "Selected Columns";
            // 
            // btn_Move1ColBack_Bt
            // 
            this.btn_Move1ColBack_Bt.Location = new System.Drawing.Point(194, 368);
            this.btn_Move1ColBack_Bt.Name = "btn_Move1ColBack_Bt";
            this.btn_Move1ColBack_Bt.Size = new System.Drawing.Size(75, 23);
            this.btn_Move1ColBack_Bt.TabIndex = 83;
            this.btn_Move1ColBack_Bt.Text = "<";
            this.btn_Move1ColBack_Bt.UseVisualStyleBackColor = true;
            this.btn_Move1ColBack_Bt.Click += new System.EventHandler(this.btn_Move1ColBack_Bt_Click);
            // 
            // btn_MoveBackCols_BT
            // 
            this.btn_MoveBackCols_BT.Location = new System.Drawing.Point(194, 339);
            this.btn_MoveBackCols_BT.Name = "btn_MoveBackCols_BT";
            this.btn_MoveBackCols_BT.Size = new System.Drawing.Size(75, 23);
            this.btn_MoveBackCols_BT.TabIndex = 82;
            this.btn_MoveBackCols_BT.Text = "<<";
            this.btn_MoveBackCols_BT.UseVisualStyleBackColor = true;
            this.btn_MoveBackCols_BT.Click += new System.EventHandler(this.btn_MoveBackCols_BT_Click);
            // 
            // btn_Move1Col_BT
            // 
            this.btn_Move1Col_BT.Location = new System.Drawing.Point(194, 243);
            this.btn_Move1Col_BT.Name = "btn_Move1Col_BT";
            this.btn_Move1Col_BT.Size = new System.Drawing.Size(75, 23);
            this.btn_Move1Col_BT.TabIndex = 80;
            this.btn_Move1Col_BT.Text = ">";
            this.btn_Move1Col_BT.UseVisualStyleBackColor = true;
            this.btn_Move1Col_BT.Click += new System.EventHandler(this.btn_Move1Col_BT_Click);
            // 
            // lstbx_SelectedCols_BT
            // 
            this.lstbx_SelectedCols_BT.FormattingEnabled = true;
            this.lstbx_SelectedCols_BT.Location = new System.Drawing.Point(275, 111);
            this.lstbx_SelectedCols_BT.Name = "lstbx_SelectedCols_BT";
            this.lstbx_SelectedCols_BT.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbx_SelectedCols_BT.Size = new System.Drawing.Size(151, 472);
            this.lstbx_SelectedCols_BT.TabIndex = 79;
            this.lstbx_SelectedCols_BT.SelectedIndexChanged += new System.EventHandler(this.lstbx_SelectedCols_BT_SelectedIndexChanged);
            // 
            // lstbx_Cols_BT
            // 
            this.lstbx_Cols_BT.FormattingEnabled = true;
            this.lstbx_Cols_BT.Location = new System.Drawing.Point(37, 111);
            this.lstbx_Cols_BT.Name = "lstbx_Cols_BT";
            this.lstbx_Cols_BT.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbx_Cols_BT.Size = new System.Drawing.Size(151, 472);
            this.lstbx_Cols_BT.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Select Columns";
            // 
            // lbl_BusinessUnit_BT
            // 
            this.lbl_BusinessUnit_BT.AutoSize = true;
            this.lbl_BusinessUnit_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BusinessUnit_BT.Location = new System.Drawing.Point(34, 28);
            this.lbl_BusinessUnit_BT.Name = "lbl_BusinessUnit_BT";
            this.lbl_BusinessUnit_BT.Size = new System.Drawing.Size(95, 15);
            this.lbl_BusinessUnit_BT.TabIndex = 1;
            this.lbl_BusinessUnit_BT.Text = "Business Unit";
            // 
            // cb_Bunit_BT
            // 
            this.cb_Bunit_BT.FormattingEnabled = true;
            this.cb_Bunit_BT.Items.AddRange(new object[] {
            "Best Of Breed",
            "MNC"});
            this.cb_Bunit_BT.Location = new System.Drawing.Point(34, 47);
            this.cb_Bunit_BT.Name = "cb_Bunit_BT";
            this.cb_Bunit_BT.Size = new System.Drawing.Size(161, 21);
            this.cb_Bunit_BT.TabIndex = 0;
            this.cb_Bunit_BT.SelectedIndexChanged += new System.EventHandler(this.cb_Bunit_BT_SelectedIndexChanged);
            // 
            // tbpg_CustomTemplate_Adj
            // 
            this.tbpg_CustomTemplate_Adj.Controls.Add(this.dgv_DataView);
            this.tbpg_CustomTemplate_Adj.Controls.Add(this.pnl_GridView_CTemplate);
            this.tbpg_CustomTemplate_Adj.Location = new System.Drawing.Point(4, 22);
            this.tbpg_CustomTemplate_Adj.Name = "tbpg_CustomTemplate_Adj";
            this.tbpg_CustomTemplate_Adj.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_CustomTemplate_Adj.Size = new System.Drawing.Size(999, 596);
            this.tbpg_CustomTemplate_Adj.TabIndex = 1;
            this.tbpg_CustomTemplate_Adj.Text = "Adjustments";
            this.tbpg_CustomTemplate_Adj.UseVisualStyleBackColor = true;
            // 
            // dgv_DataView
            // 
            this.dgv_DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DataView.Location = new System.Drawing.Point(3, 315);
            this.dgv_DataView.Name = "dgv_DataView";
            this.dgv_DataView.Size = new System.Drawing.Size(993, 278);
            this.dgv_DataView.TabIndex = 54;
            // 
            // pnl_GridView_CTemplate
            // 
            this.pnl_GridView_CTemplate.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_GridView_CTemplate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_GridView_CTemplate.Controls.Add(this.lbl_Country_CT);
            this.pnl_GridView_CTemplate.Controls.Add(this.cb_SelectCountry_CT);
            this.pnl_GridView_CTemplate.Controls.Add(this.btn_View_CTemplate);
            this.pnl_GridView_CTemplate.Controls.Add(this.dtp_To_CTemplate);
            this.pnl_GridView_CTemplate.Controls.Add(this.dtp_From_CTemplate);
            this.pnl_GridView_CTemplate.Controls.Add(this.btn_Generate_CTemplate);
            this.pnl_GridView_CTemplate.Controls.Add(this.pnl_SelectReset_CTemplate);
            this.pnl_GridView_CTemplate.Controls.Add(this.chklstbx_AdjustmentColumns);
            this.pnl_GridView_CTemplate.Controls.Add(this.lbl_To_CustomT);
            this.pnl_GridView_CTemplate.Controls.Add(this.lbl_From_CustomT);
            this.pnl_GridView_CTemplate.Controls.Add(this.label1);
            this.pnl_GridView_CTemplate.Controls.Add(this.cb_AdjustmentType_Adj);
            this.pnl_GridView_CTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_GridView_CTemplate.Location = new System.Drawing.Point(3, 3);
            this.pnl_GridView_CTemplate.Name = "pnl_GridView_CTemplate";
            this.pnl_GridView_CTemplate.Size = new System.Drawing.Size(993, 312);
            this.pnl_GridView_CTemplate.TabIndex = 55;
            // 
            // lbl_Country_CT
            // 
            this.lbl_Country_CT.AutoSize = true;
            this.lbl_Country_CT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country_CT.Location = new System.Drawing.Point(24, 23);
            this.lbl_Country_CT.Name = "lbl_Country_CT";
            this.lbl_Country_CT.Size = new System.Drawing.Size(99, 15);
            this.lbl_Country_CT.TabIndex = 82;
            this.lbl_Country_CT.Text = "Select Country";
            // 
            // cb_SelectCountry_CT
            // 
            this.cb_SelectCountry_CT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_SelectCountry_CT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_SelectCountry_CT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SelectCountry_CT.FormattingEnabled = true;
            this.cb_SelectCountry_CT.Items.AddRange(new object[] {
            "----Select----",
            "Audit",
            "No Start",
            "Restarts",
            "Others"});
            this.cb_SelectCountry_CT.Location = new System.Drawing.Point(27, 41);
            this.cb_SelectCountry_CT.MaxDropDownItems = 10;
            this.cb_SelectCountry_CT.Name = "cb_SelectCountry_CT";
            this.cb_SelectCountry_CT.Size = new System.Drawing.Size(149, 21);
            this.cb_SelectCountry_CT.TabIndex = 1;
            // 
            // btn_View_CTemplate
            // 
            this.btn_View_CTemplate.BackColor = System.Drawing.Color.Snow;
            this.btn_View_CTemplate.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_CTemplate.Location = new System.Drawing.Point(275, 149);
            this.btn_View_CTemplate.Name = "btn_View_CTemplate";
            this.btn_View_CTemplate.Size = new System.Drawing.Size(121, 31);
            this.btn_View_CTemplate.TabIndex = 80;
            this.btn_View_CTemplate.Text = "View Data";
            this.btn_View_CTemplate.UseVisualStyleBackColor = false;
            this.btn_View_CTemplate.Click += new System.EventHandler(this.btn_View_CTemplate_Click_1);
            // 
            // dtp_To_CTemplate
            // 
            this.dtp_To_CTemplate.Location = new System.Drawing.Point(250, 84);
            this.dtp_To_CTemplate.Name = "dtp_To_CTemplate";
            this.dtp_To_CTemplate.Size = new System.Drawing.Size(200, 20);
            this.dtp_To_CTemplate.TabIndex = 79;
            // 
            // dtp_From_CTemplate
            // 
            this.dtp_From_CTemplate.Location = new System.Drawing.Point(250, 38);
            this.dtp_From_CTemplate.Name = "dtp_From_CTemplate";
            this.dtp_From_CTemplate.Size = new System.Drawing.Size(200, 20);
            this.dtp_From_CTemplate.TabIndex = 78;
            // 
            // btn_Generate_CTemplate
            // 
            this.btn_Generate_CTemplate.BackColor = System.Drawing.Color.Snow;
            this.btn_Generate_CTemplate.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate_CTemplate.ForeColor = System.Drawing.Color.Black;
            this.btn_Generate_CTemplate.Location = new System.Drawing.Point(275, 220);
            this.btn_Generate_CTemplate.Name = "btn_Generate_CTemplate";
            this.btn_Generate_CTemplate.Size = new System.Drawing.Size(121, 31);
            this.btn_Generate_CTemplate.TabIndex = 76;
            this.btn_Generate_CTemplate.Text = "Save Excel";
            this.btn_Generate_CTemplate.UseVisualStyleBackColor = false;
            this.btn_Generate_CTemplate.Click += new System.EventHandler(this.btn_Generate_CTemplate_Click);
            // 
            // pnl_SelectReset_CTemplate
            // 
            this.pnl_SelectReset_CTemplate.Controls.Add(this.rdbtn_CheckAll_Adj);
            this.pnl_SelectReset_CTemplate.Controls.Add(this.rdbtn_Reset_Adj);
            this.pnl_SelectReset_CTemplate.Location = new System.Drawing.Point(27, 108);
            this.pnl_SelectReset_CTemplate.Name = "pnl_SelectReset_CTemplate";
            this.pnl_SelectReset_CTemplate.Size = new System.Drawing.Size(135, 23);
            this.pnl_SelectReset_CTemplate.TabIndex = 75;
            // 
            // rdbtn_CheckAll_Adj
            // 
            this.rdbtn_CheckAll_Adj.AutoSize = true;
            this.rdbtn_CheckAll_Adj.Location = new System.Drawing.Point(3, 3);
            this.rdbtn_CheckAll_Adj.Name = "rdbtn_CheckAll_Adj";
            this.rdbtn_CheckAll_Adj.Size = new System.Drawing.Size(69, 17);
            this.rdbtn_CheckAll_Adj.TabIndex = 48;
            this.rdbtn_CheckAll_Adj.TabStop = true;
            this.rdbtn_CheckAll_Adj.Text = "Select All";
            this.rdbtn_CheckAll_Adj.UseVisualStyleBackColor = true;
            this.rdbtn_CheckAll_Adj.CheckedChanged += new System.EventHandler(this.rdbtn_CheckAll_Adj_CheckedChanged);
            // 
            // rdbtn_Reset_Adj
            // 
            this.rdbtn_Reset_Adj.AutoSize = true;
            this.rdbtn_Reset_Adj.Location = new System.Drawing.Point(78, 3);
            this.rdbtn_Reset_Adj.Name = "rdbtn_Reset_Adj";
            this.rdbtn_Reset_Adj.Size = new System.Drawing.Size(53, 17);
            this.rdbtn_Reset_Adj.TabIndex = 49;
            this.rdbtn_Reset_Adj.TabStop = true;
            this.rdbtn_Reset_Adj.Text = "Reset";
            this.rdbtn_Reset_Adj.UseVisualStyleBackColor = true;
            this.rdbtn_Reset_Adj.CheckedChanged += new System.EventHandler(this.rdbtn_Reset_Adj_CheckedChanged);
            // 
            // chklstbx_AdjustmentColumns
            // 
            this.chklstbx_AdjustmentColumns.FormattingEnabled = true;
            this.chklstbx_AdjustmentColumns.Location = new System.Drawing.Point(27, 137);
            this.chklstbx_AdjustmentColumns.Name = "chklstbx_AdjustmentColumns";
            this.chklstbx_AdjustmentColumns.Size = new System.Drawing.Size(161, 169);
            this.chklstbx_AdjustmentColumns.TabIndex = 74;
            // 
            // lbl_To_CustomT
            // 
            this.lbl_To_CustomT.AutoSize = true;
            this.lbl_To_CustomT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To_CustomT.Location = new System.Drawing.Point(221, 89);
            this.lbl_To_CustomT.Name = "lbl_To_CustomT";
            this.lbl_To_CustomT.Size = new System.Drawing.Size(27, 15);
            this.lbl_To_CustomT.TabIndex = 73;
            this.lbl_To_CustomT.Text = "To:";
            // 
            // lbl_From_CustomT
            // 
            this.lbl_From_CustomT.AutoSize = true;
            this.lbl_From_CustomT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From_CustomT.Location = new System.Drawing.Point(204, 38);
            this.lbl_From_CustomT.Name = "lbl_From_CustomT";
            this.lbl_From_CustomT.Size = new System.Drawing.Size(44, 15);
            this.lbl_From_CustomT.TabIndex = 72;
            this.lbl_From_CustomT.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Select Adjustment type";
            // 
            // cb_AdjustmentType_Adj
            // 
            this.cb_AdjustmentType_Adj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_AdjustmentType_Adj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_AdjustmentType_Adj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AdjustmentType_Adj.FormattingEnabled = true;
            this.cb_AdjustmentType_Adj.Items.AddRange(new object[] {
            "----Select----",
            "Audit",
            "No Start",
            "Restarts",
            "Others"});
            this.cb_AdjustmentType_Adj.Location = new System.Drawing.Point(27, 87);
            this.cb_AdjustmentType_Adj.Name = "cb_AdjustmentType_Adj";
            this.cb_AdjustmentType_Adj.Size = new System.Drawing.Size(149, 21);
            this.cb_AdjustmentType_Adj.TabIndex = 2;
            this.cb_AdjustmentType_Adj.SelectedIndexChanged += new System.EventHandler(this.cb_AdjustmentType_Adj_SelectedIndexChanged);
            // 
            // cb_Year
            // 
            this.cb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Year.FormattingEnabled = true;
            this.cb_Year.Items.AddRange(new object[] {
            "---Select---",
            "2017",
            "2016",
            "2015"});
            this.cb_Year.Location = new System.Drawing.Point(513, 77);
            this.cb_Year.Name = "cb_Year";
            this.cb_Year.Size = new System.Drawing.Size(121, 21);
            this.cb_Year.TabIndex = 61;
            // 
            // cb_Month
            // 
            this.cb_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Month.FormattingEnabled = true;
            this.cb_Month.Items.AddRange(new object[] {
            "---Select---",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cb_Month.Location = new System.Drawing.Point(513, 27);
            this.cb_Month.Name = "cb_Month";
            this.cb_Month.Size = new System.Drawing.Size(121, 21);
            this.cb_Month.TabIndex = 59;
            // 
            // frm_Adjustments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1007, 622);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.btn_Gen_CTemplate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Adjustments";
            this.Text = "Adjustments";
            this.Load += new System.EventHandler(this.Custom_Template_Load);
            this.pnl_Top.ResumeLayout(false);
            this.tb_Control_Adjustments.ResumeLayout(false);
            this.tbpg_BlankTemp_Adj.ResumeLayout(false);
            this.tbpg_BlankTemp_Adj.PerformLayout();
            this.tbpg_CustomTemplate_Adj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataView)).EndInit();
            this.pnl_GridView_CTemplate.ResumeLayout(false);
            this.pnl_GridView_CTemplate.PerformLayout();
            this.pnl_SelectReset_CTemplate.ResumeLayout(false);
            this.pnl_SelectReset_CTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Gen_CTemplate;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.ComboBox cb_Year;
        private System.Windows.Forms.ComboBox cb_Month;
        private System.Windows.Forms.TabControl tb_Control_Adjustments;
        private System.Windows.Forms.TabPage tbpg_BlankTemp_Adj;
        private System.Windows.Forms.TabPage tbpg_CustomTemplate_Adj;
        private System.Windows.Forms.DataGridView dgv_DataView;
        private System.Windows.Forms.Panel pnl_GridView_CTemplate;
        private System.Windows.Forms.Label lbl_Country_CT;
        internal System.Windows.Forms.ComboBox cb_SelectCountry_CT;
        private System.Windows.Forms.Button btn_View_CTemplate;
        private System.Windows.Forms.DateTimePicker dtp_To_CTemplate;
        private System.Windows.Forms.DateTimePicker dtp_From_CTemplate;
        private System.Windows.Forms.Button btn_Generate_CTemplate;
        private System.Windows.Forms.Panel pnl_SelectReset_CTemplate;
        private System.Windows.Forms.RadioButton rdbtn_CheckAll_Adj;
        private System.Windows.Forms.RadioButton rdbtn_Reset_Adj;
        private System.Windows.Forms.CheckedListBox chklstbx_AdjustmentColumns;
        private System.Windows.Forms.Label lbl_To_CustomT;
        private System.Windows.Forms.Label lbl_From_CustomT;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cb_AdjustmentType_Adj;
        private System.Windows.Forms.Label lbl_BusinessUnit_BT;
        private System.Windows.Forms.ComboBox cb_Bunit_BT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SaveExcel_BT;
        private System.Windows.Forms.ListBox lstbx_Cols_BT;
        private System.Windows.Forms.Button btn_Move1Col_BT;
        private System.Windows.Forms.ListBox lstbx_SelectedCols_BT;
        private System.Windows.Forms.Button btn_Move1ColBack_Bt;
        private System.Windows.Forms.Button btn_MoveBackCols_BT;
        private System.Windows.Forms.Label lbl_SelectedCols_BT;
        private System.Windows.Forms.Button btn_MoveAllCols_BT;
    }
}