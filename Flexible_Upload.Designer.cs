namespace Sales_Commission
{
    partial class Flexible_Upload
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flexible_Upload));
            this.pnl_Browse_SU = new System.Windows.Forms.Panel();
            this.lbl_AdjType_FU = new System.Windows.Forms.Label();
            this.cb_AdjTypeUpload_FU = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Country_FxUpload = new System.Windows.Forms.ComboBox();
            this.lbl_UType_FxUpload = new System.Windows.Forms.Label();
            this.cb_UploadType_FxUpload = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Upload_Summary = new System.Windows.Forms.TextBox();
            this.btn_Upload_FU = new System.Windows.Forms.Button();
            this.txt_Browse_FU = new System.Windows.Forms.TextBox();
            this.btn_Browse_FU = new System.Windows.Forms.Button();
            this.dgv_DataView_FU = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Browse_SU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataView_FU)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Browse_SU
            // 
            this.pnl_Browse_SU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Browse_SU.Controls.Add(this.lbl_AdjType_FU);
            this.pnl_Browse_SU.Controls.Add(this.cb_AdjTypeUpload_FU);
            this.pnl_Browse_SU.Controls.Add(this.label2);
            this.pnl_Browse_SU.Controls.Add(this.cb_Country_FxUpload);
            this.pnl_Browse_SU.Controls.Add(this.lbl_UType_FxUpload);
            this.pnl_Browse_SU.Controls.Add(this.cb_UploadType_FxUpload);
            this.pnl_Browse_SU.Controls.Add(this.label1);
            this.pnl_Browse_SU.Controls.Add(this.txt_Upload_Summary);
            this.pnl_Browse_SU.Controls.Add(this.btn_Upload_FU);
            this.pnl_Browse_SU.Controls.Add(this.txt_Browse_FU);
            this.pnl_Browse_SU.Controls.Add(this.btn_Browse_FU);
            this.pnl_Browse_SU.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Browse_SU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Browse_SU.Location = new System.Drawing.Point(0, 0);
            this.pnl_Browse_SU.Name = "pnl_Browse_SU";
            this.pnl_Browse_SU.Size = new System.Drawing.Size(1083, 139);
            this.pnl_Browse_SU.TabIndex = 2;
            // 
            // lbl_AdjType_FU
            // 
            this.lbl_AdjType_FU.AutoSize = true;
            this.lbl_AdjType_FU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdjType_FU.Location = new System.Drawing.Point(439, 14);
            this.lbl_AdjType_FU.Name = "lbl_AdjType_FU";
            this.lbl_AdjType_FU.Size = new System.Drawing.Size(112, 15);
            this.lbl_AdjType_FU.TabIndex = 13;
            this.lbl_AdjType_FU.Text = "Adjustment Type";
            // 
            // cb_AdjTypeUpload_FU
            // 
            this.cb_AdjTypeUpload_FU.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_AdjTypeUpload_FU.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_AdjTypeUpload_FU.Items.AddRange(new object[] {
            "-----Select-----",
            "Audits",
            "No Starts",
            "Restarts",
            "Others",
            ""});
            this.cb_AdjTypeUpload_FU.Location = new System.Drawing.Point(442, 36);
            this.cb_AdjTypeUpload_FU.Name = "cb_AdjTypeUpload_FU";
            this.cb_AdjTypeUpload_FU.Size = new System.Drawing.Size(194, 23);
            this.cb_AdjTypeUpload_FU.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Country";
            // 
            // cb_Country_FxUpload
            // 
            this.cb_Country_FxUpload.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Country_FxUpload.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Country_FxUpload.FormattingEnabled = true;
            this.cb_Country_FxUpload.Location = new System.Drawing.Point(220, 36);
            this.cb_Country_FxUpload.Name = "cb_Country_FxUpload";
            this.cb_Country_FxUpload.Size = new System.Drawing.Size(204, 23);
            this.cb_Country_FxUpload.TabIndex = 10;
            this.cb_Country_FxUpload.SelectedIndexChanged += new System.EventHandler(this.cb_Country_FxUpload_SelectedIndexChanged);
            // 
            // lbl_UType_FxUpload
            // 
            this.lbl_UType_FxUpload.AutoSize = true;
            this.lbl_UType_FxUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UType_FxUpload.Location = new System.Drawing.Point(16, 13);
            this.lbl_UType_FxUpload.Name = "lbl_UType_FxUpload";
            this.lbl_UType_FxUpload.Size = new System.Drawing.Size(131, 15);
            this.lbl_UType_FxUpload.TabIndex = 9;
            this.lbl_UType_FxUpload.Text = "Select Upload Type";
            // 
            // cb_UploadType_FxUpload
            // 
            this.cb_UploadType_FxUpload.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_UploadType_FxUpload.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_UploadType_FxUpload.FormattingEnabled = true;
            this.cb_UploadType_FxUpload.Items.AddRange(new object[] {
            "-----Select-----",
            "Sales Upload",
            "Flexible Upload"});
            this.cb_UploadType_FxUpload.Location = new System.Drawing.Point(16, 35);
            this.cb_UploadType_FxUpload.Name = "cb_UploadType_FxUpload";
            this.cb_UploadType_FxUpload.Size = new System.Drawing.Size(187, 23);
            this.cb_UploadType_FxUpload.TabIndex = 8;
            this.cb_UploadType_FxUpload.SelectedIndexChanged += new System.EventHandler(this.cb_UploadType_FxUpload_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sales Upload Path:";
            // 
            // txt_Upload_Summary
            // 
            this.txt_Upload_Summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Upload_Summary.Location = new System.Drawing.Point(677, 13);
            this.txt_Upload_Summary.Multiline = true;
            this.txt_Upload_Summary.Name = "txt_Upload_Summary";
            this.txt_Upload_Summary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Upload_Summary.Size = new System.Drawing.Size(259, 110);
            this.txt_Upload_Summary.TabIndex = 6;
            // 
            // btn_Upload_FU
            // 
            this.btn_Upload_FU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload_FU.Location = new System.Drawing.Point(561, 87);
            this.btn_Upload_FU.Name = "btn_Upload_FU";
            this.btn_Upload_FU.Size = new System.Drawing.Size(75, 23);
            this.btn_Upload_FU.TabIndex = 5;
            this.btn_Upload_FU.Text = "Upload";
            this.btn_Upload_FU.UseVisualStyleBackColor = true;
            this.btn_Upload_FU.Click += new System.EventHandler(this.btn_Upload_FU_Click);
            // 
            // txt_Browse_FU
            // 
            this.txt_Browse_FU.Location = new System.Drawing.Point(16, 89);
            this.txt_Browse_FU.Name = "txt_Browse_FU";
            this.txt_Browse_FU.Size = new System.Drawing.Size(435, 21);
            this.txt_Browse_FU.TabIndex = 3;
            // 
            // btn_Browse_FU
            // 
            this.btn_Browse_FU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse_FU.Location = new System.Drawing.Point(471, 87);
            this.btn_Browse_FU.Name = "btn_Browse_FU";
            this.btn_Browse_FU.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse_FU.TabIndex = 2;
            this.btn_Browse_FU.Text = "Browse";
            this.btn_Browse_FU.UseVisualStyleBackColor = true;
            this.btn_Browse_FU.Click += new System.EventHandler(this.btn_Browse_FU_Click);
            // 
            // dgv_DataView_FU
            // 
            this.dgv_DataView_FU.AllowUserToAddRows = false;
            this.dgv_DataView_FU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DataView_FU.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DataView_FU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DataView_FU.Location = new System.Drawing.Point(0, 139);
            this.dgv_DataView_FU.Name = "dgv_DataView_FU";
            this.dgv_DataView_FU.Size = new System.Drawing.Size(1083, 259);
            this.dgv_DataView_FU.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 44);
            this.panel1.TabIndex = 4;
            // 
            // Flexible_Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 442);
            this.Controls.Add(this.dgv_DataView_FU);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Browse_SU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Flexible_Upload";
            this.Text = "Sales Upload";
            this.Load += new System.EventHandler(this.Flexible_Upload_Load);
            this.pnl_Browse_SU.ResumeLayout(false);
            this.pnl_Browse_SU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataView_FU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Browse_SU;
        private System.Windows.Forms.TextBox txt_Browse_FU;
        private System.Windows.Forms.Button btn_Browse_FU;
        private System.Windows.Forms.DataGridView dgv_DataView_FU;
        private System.Windows.Forms.Button btn_Upload_FU;
        private System.Windows.Forms.TextBox txt_Upload_Summary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_UType_FxUpload;
        private System.Windows.Forms.ComboBox cb_UploadType_FxUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Country_FxUpload;
        private System.Windows.Forms.Label lbl_AdjType_FU;
        private System.Windows.Forms.ComboBox cb_AdjTypeUpload_FU;
    }
}