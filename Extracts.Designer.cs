namespace Sales_Commission
{
    partial class Extracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extracts));
            this.dgv_DataView_Extracts = new System.Windows.Forms.DataGridView();
            this.pnl_Browse_SU = new System.Windows.Forms.Panel();
            this.chkbx_MNC_Ex = new System.Windows.Forms.CheckBox();
            this.grpbx_DateCriteria = new System.Windows.Forms.GroupBox();
            this.rdbtn_RollCallDate_Ex = new System.Windows.Forms.RadioButton();
            this.rdbtn_DateProcessed_Ex = new System.Windows.Forms.RadioButton();
            this.cb_BuName_Ex = new System.Windows.Forms.ComboBox();
            this.lbl_BUName_Ex = new System.Windows.Forms.Label();
            this.ToolStrp_Extracts = new System.Windows.Forms.ToolStrip();
            this.toolStrp_lbl_Search_Cri_Ex = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrpCb_Business_Ex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrp_SearchValue_Ex = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstrp_txt_SearchValue_Ex = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lbl_To_Ex = new System.Windows.Forms.Label();
            this.lbl_From_Ex = new System.Windows.Forms.Label();
            this.dtpckr_To_Ex = new System.Windows.Forms.DateTimePicker();
            this.dtpckr_From_Ex = new System.Windows.Forms.DateTimePicker();
            this.cb_ExtractType_Ex = new System.Windows.Forms.ComboBox();
            this.lbl_Extract_Type_Ex = new System.Windows.Forms.Label();
            this.btn_GenerateExtract = new System.Windows.Forms.Button();
            this.btn_ViewExtract_Adj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataView_Extracts)).BeginInit();
            this.pnl_Browse_SU.SuspendLayout();
            this.grpbx_DateCriteria.SuspendLayout();
            this.ToolStrp_Extracts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DataView_Extracts
            // 
            this.dgv_DataView_Extracts.AllowUserToAddRows = false;
            this.dgv_DataView_Extracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataView_Extracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DataView_Extracts.Location = new System.Drawing.Point(0, 177);
            this.dgv_DataView_Extracts.Name = "dgv_DataView_Extracts";
            this.dgv_DataView_Extracts.Size = new System.Drawing.Size(1003, 327);
            this.dgv_DataView_Extracts.TabIndex = 5;
            // 
            // pnl_Browse_SU
            // 
            this.pnl_Browse_SU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Browse_SU.Controls.Add(this.chkbx_MNC_Ex);
            this.pnl_Browse_SU.Controls.Add(this.grpbx_DateCriteria);
            this.pnl_Browse_SU.Controls.Add(this.cb_BuName_Ex);
            this.pnl_Browse_SU.Controls.Add(this.lbl_BUName_Ex);
            this.pnl_Browse_SU.Controls.Add(this.ToolStrp_Extracts);
            this.pnl_Browse_SU.Controls.Add(this.lbl_To_Ex);
            this.pnl_Browse_SU.Controls.Add(this.lbl_From_Ex);
            this.pnl_Browse_SU.Controls.Add(this.dtpckr_To_Ex);
            this.pnl_Browse_SU.Controls.Add(this.dtpckr_From_Ex);
            this.pnl_Browse_SU.Controls.Add(this.cb_ExtractType_Ex);
            this.pnl_Browse_SU.Controls.Add(this.lbl_Extract_Type_Ex);
            this.pnl_Browse_SU.Controls.Add(this.btn_GenerateExtract);
            this.pnl_Browse_SU.Controls.Add(this.btn_ViewExtract_Adj);
            this.pnl_Browse_SU.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Browse_SU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Browse_SU.Location = new System.Drawing.Point(0, 0);
            this.pnl_Browse_SU.Name = "pnl_Browse_SU";
            this.pnl_Browse_SU.Size = new System.Drawing.Size(1003, 177);
            this.pnl_Browse_SU.TabIndex = 6;
            // 
            // chkbx_MNC_Ex
            // 
            this.chkbx_MNC_Ex.AutoSize = true;
            this.chkbx_MNC_Ex.Location = new System.Drawing.Point(12, 137);
            this.chkbx_MNC_Ex.Name = "chkbx_MNC_Ex";
            this.chkbx_MNC_Ex.Size = new System.Drawing.Size(108, 19);
            this.chkbx_MNC_Ex.TabIndex = 23;
            this.chkbx_MNC_Ex.Text = "Include MNC";
            this.chkbx_MNC_Ex.UseVisualStyleBackColor = true;
            // 
            // grpbx_DateCriteria
            // 
            this.grpbx_DateCriteria.Controls.Add(this.rdbtn_RollCallDate_Ex);
            this.grpbx_DateCriteria.Controls.Add(this.rdbtn_DateProcessed_Ex);
            this.grpbx_DateCriteria.Location = new System.Drawing.Point(498, 39);
            this.grpbx_DateCriteria.Name = "grpbx_DateCriteria";
            this.grpbx_DateCriteria.Size = new System.Drawing.Size(134, 91);
            this.grpbx_DateCriteria.TabIndex = 22;
            this.grpbx_DateCriteria.TabStop = false;
            this.grpbx_DateCriteria.Text = "Date Basis";
            // 
            // rdbtn_RollCallDate_Ex
            // 
            this.rdbtn_RollCallDate_Ex.AutoSize = true;
            this.rdbtn_RollCallDate_Ex.Location = new System.Drawing.Point(6, 60);
            this.rdbtn_RollCallDate_Ex.Name = "rdbtn_RollCallDate_Ex";
            this.rdbtn_RollCallDate_Ex.Size = new System.Drawing.Size(108, 19);
            this.rdbtn_RollCallDate_Ex.TabIndex = 6;
            this.rdbtn_RollCallDate_Ex.TabStop = true;
            this.rdbtn_RollCallDate_Ex.Text = "Rollcall Date";
            this.rdbtn_RollCallDate_Ex.UseVisualStyleBackColor = true;
            this.rdbtn_RollCallDate_Ex.CheckedChanged += new System.EventHandler(this.rdbtn_RollCallDate_Ex_CheckedChanged);
            // 
            // rdbtn_DateProcessed_Ex
            // 
            this.rdbtn_DateProcessed_Ex.AutoSize = true;
            this.rdbtn_DateProcessed_Ex.Location = new System.Drawing.Point(6, 22);
            this.rdbtn_DateProcessed_Ex.Name = "rdbtn_DateProcessed_Ex";
            this.rdbtn_DateProcessed_Ex.Size = new System.Drawing.Size(126, 19);
            this.rdbtn_DateProcessed_Ex.TabIndex = 5;
            this.rdbtn_DateProcessed_Ex.TabStop = true;
            this.rdbtn_DateProcessed_Ex.Text = "Date Processed";
            this.rdbtn_DateProcessed_Ex.UseVisualStyleBackColor = true;
            this.rdbtn_DateProcessed_Ex.CheckedChanged += new System.EventHandler(this.rdbtn_DateProcessed_Ex_CheckedChanged);
            // 
            // cb_BuName_Ex
            // 
            this.cb_BuName_Ex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_BuName_Ex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_BuName_Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BuName_Ex.FormattingEnabled = true;
            this.cb_BuName_Ex.Location = new System.Drawing.Point(12, 108);
            this.cb_BuName_Ex.Name = "cb_BuName_Ex";
            this.cb_BuName_Ex.Size = new System.Drawing.Size(226, 23);
            this.cb_BuName_Ex.TabIndex = 2;
            this.cb_BuName_Ex.SelectedIndexChanged += new System.EventHandler(this.cb_ExtractType_Ex_SelectedIndexChanged);
            // 
            // lbl_BUName_Ex
            // 
            this.lbl_BUName_Ex.AutoSize = true;
            this.lbl_BUName_Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BUName_Ex.Location = new System.Drawing.Point(12, 91);
            this.lbl_BUName_Ex.Name = "lbl_BUName_Ex";
            this.lbl_BUName_Ex.Size = new System.Drawing.Size(95, 15);
            this.lbl_BUName_Ex.TabIndex = 19;
            this.lbl_BUName_Ex.Text = "Business Unit";
            // 
            // ToolStrp_Extracts
            // 
            this.ToolStrp_Extracts.BackColor = System.Drawing.Color.DimGray;
            this.ToolStrp_Extracts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrp_lbl_Search_Cri_Ex,
            this.toolStripSeparator1,
            this.toolStrpCb_Business_Ex,
            this.toolStripSeparator2,
            this.toolStrp_SearchValue_Ex,
            this.toolStripSeparator5,
            this.toolstrp_txt_SearchValue_Ex,
            this.toolStripButton1});
            this.ToolStrp_Extracts.Location = new System.Drawing.Point(0, 0);
            this.ToolStrp_Extracts.Name = "ToolStrp_Extracts";
            this.ToolStrp_Extracts.Size = new System.Drawing.Size(999, 25);
            this.ToolStrp_Extracts.TabIndex = 18;
            this.ToolStrp_Extracts.Text = "ToolStrip";
            // 
            // toolStrp_lbl_Search_Cri_Ex
            // 
            this.toolStrp_lbl_Search_Cri_Ex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrp_lbl_Search_Cri_Ex.Name = "toolStrp_lbl_Search_Cri_Ex";
            this.toolStrp_lbl_Search_Cri_Ex.Size = new System.Drawing.Size(78, 22);
            this.toolStrp_lbl_Search_Cri_Ex.Text = "Search Criteria";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrpCb_Business_Ex
            // 
            this.toolStrpCb_Business_Ex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toolStrpCb_Business_Ex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStrpCb_Business_Ex.Name = "toolStrpCb_Business_Ex";
            this.toolStrpCb_Business_Ex.Size = new System.Drawing.Size(175, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrp_SearchValue_Ex
            // 
            this.toolStrp_SearchValue_Ex.Name = "toolStrp_SearchValue_Ex";
            this.toolStrp_SearchValue_Ex.Size = new System.Drawing.Size(69, 22);
            this.toolStrp_SearchValue_Ex.Text = "Search Value";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolstrp_txt_SearchValue_Ex
            // 
            this.toolstrp_txt_SearchValue_Ex.AcceptsTab = true;
            this.toolstrp_txt_SearchValue_Ex.Name = "toolstrp_txt_SearchValue_Ex";
            this.toolstrp_txt_SearchValue_Ex.Size = new System.Drawing.Size(175, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // lbl_To_Ex
            // 
            this.lbl_To_Ex.AutoSize = true;
            this.lbl_To_Ex.Location = new System.Drawing.Point(280, 91);
            this.lbl_To_Ex.Name = "lbl_To_Ex";
            this.lbl_To_Ex.Size = new System.Drawing.Size(70, 15);
            this.lbl_To_Ex.TabIndex = 12;
            this.lbl_To_Ex.Text = "End Date:";
            // 
            // lbl_From_Ex
            // 
            this.lbl_From_Ex.AutoSize = true;
            this.lbl_From_Ex.Location = new System.Drawing.Point(280, 31);
            this.lbl_From_Ex.Name = "lbl_From_Ex";
            this.lbl_From_Ex.Size = new System.Drawing.Size(75, 15);
            this.lbl_From_Ex.TabIndex = 11;
            this.lbl_From_Ex.Text = "Start Date:";
            // 
            // dtpckr_To_Ex
            // 
            this.dtpckr_To_Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpckr_To_Ex.Location = new System.Drawing.Point(283, 109);
            this.dtpckr_To_Ex.Name = "dtpckr_To_Ex";
            this.dtpckr_To_Ex.Size = new System.Drawing.Size(200, 21);
            this.dtpckr_To_Ex.TabIndex = 4;
            // 
            // dtpckr_From_Ex
            // 
            this.dtpckr_From_Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpckr_From_Ex.Location = new System.Drawing.Point(283, 49);
            this.dtpckr_From_Ex.Name = "dtpckr_From_Ex";
            this.dtpckr_From_Ex.Size = new System.Drawing.Size(200, 21);
            this.dtpckr_From_Ex.TabIndex = 3;
            // 
            // cb_ExtractType_Ex
            // 
            this.cb_ExtractType_Ex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_ExtractType_Ex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_ExtractType_Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ExtractType_Ex.FormattingEnabled = true;
            this.cb_ExtractType_Ex.Items.AddRange(new object[] {
            "----Select----",
            "Sales Report",
            "Commission Report",
            "Correction Report",
            "UK Implementation Report"});
            this.cb_ExtractType_Ex.Location = new System.Drawing.Point(12, 48);
            this.cb_ExtractType_Ex.Name = "cb_ExtractType_Ex";
            this.cb_ExtractType_Ex.Size = new System.Drawing.Size(226, 23);
            this.cb_ExtractType_Ex.TabIndex = 1;
            this.cb_ExtractType_Ex.SelectedIndexChanged += new System.EventHandler(this.cb_Extracts_SelectedIndexChanged);
            // 
            // lbl_Extract_Type_Ex
            // 
            this.lbl_Extract_Type_Ex.AutoSize = true;
            this.lbl_Extract_Type_Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Extract_Type_Ex.Location = new System.Drawing.Point(12, 31);
            this.lbl_Extract_Type_Ex.Name = "lbl_Extract_Type_Ex";
            this.lbl_Extract_Type_Ex.Size = new System.Drawing.Size(129, 15);
            this.lbl_Extract_Type_Ex.TabIndex = 7;
            this.lbl_Extract_Type_Ex.Text = "Select Extract Type";
            // 
            // btn_GenerateExtract
            // 
            this.btn_GenerateExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateExtract.Location = new System.Drawing.Point(657, 92);
            this.btn_GenerateExtract.Name = "btn_GenerateExtract";
            this.btn_GenerateExtract.Size = new System.Drawing.Size(75, 23);
            this.btn_GenerateExtract.TabIndex = 8;
            this.btn_GenerateExtract.Text = "Save Excel";
            this.btn_GenerateExtract.UseVisualStyleBackColor = true;
            this.btn_GenerateExtract.Click += new System.EventHandler(this.btn_GenerateExtract_Click);
            // 
            // btn_ViewExtract_Adj
            // 
            this.btn_ViewExtract_Adj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewExtract_Adj.Location = new System.Drawing.Point(657, 51);
            this.btn_ViewExtract_Adj.Name = "btn_ViewExtract_Adj";
            this.btn_ViewExtract_Adj.Size = new System.Drawing.Size(75, 23);
            this.btn_ViewExtract_Adj.TabIndex = 7;
            this.btn_ViewExtract_Adj.Text = "View Data";
            this.btn_ViewExtract_Adj.UseVisualStyleBackColor = true;
            this.btn_ViewExtract_Adj.Click += new System.EventHandler(this.btn_ViewExtract_Click);
            // 
            // Extracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 504);
            this.Controls.Add(this.dgv_DataView_Extracts);
            this.Controls.Add(this.pnl_Browse_SU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Extracts";
            this.Text = "Extracts";
            this.Load += new System.EventHandler(this.Extracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataView_Extracts)).EndInit();
            this.pnl_Browse_SU.ResumeLayout(false);
            this.pnl_Browse_SU.PerformLayout();
            this.grpbx_DateCriteria.ResumeLayout(false);
            this.grpbx_DateCriteria.PerformLayout();
            this.ToolStrp_Extracts.ResumeLayout(false);
            this.ToolStrp_Extracts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DataView_Extracts;
        private System.Windows.Forms.Panel pnl_Browse_SU;
        private System.Windows.Forms.ComboBox cb_ExtractType_Ex;
        private System.Windows.Forms.Label lbl_Extract_Type_Ex;
        private System.Windows.Forms.Button btn_GenerateExtract;
        private System.Windows.Forms.Button btn_ViewExtract_Adj;
        private System.Windows.Forms.Label lbl_From_Ex;
        private System.Windows.Forms.DateTimePicker dtpckr_To_Ex;
        private System.Windows.Forms.DateTimePicker dtpckr_From_Ex;
        private System.Windows.Forms.ToolStrip ToolStrp_Extracts;
        private System.Windows.Forms.ToolStripLabel toolStrp_lbl_Search_Cri_Ex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStrpCb_Business_Ex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox cb_BuName_Ex;
        private System.Windows.Forms.Label lbl_BUName_Ex;
        private System.Windows.Forms.GroupBox grpbx_DateCriteria;
        private System.Windows.Forms.RadioButton rdbtn_RollCallDate_Ex;
        private System.Windows.Forms.RadioButton rdbtn_DateProcessed_Ex;
        private System.Windows.Forms.ToolStripLabel toolStrp_SearchValue_Ex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox toolstrp_txt_SearchValue_Ex;
        private System.Windows.Forms.Label lbl_To_Ex;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.CheckBox chkbx_MNC_Ex;
    }
}