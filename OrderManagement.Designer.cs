namespace Sales_Commission
{
    partial class OrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagement));
            this.cb_BU_OM = new System.Windows.Forms.ComboBox();
            this.lbl_BUnit_OM = new System.Windows.Forms.Label();
            this.pnl_Dates_OM = new System.Windows.Forms.Panel();
            this.lbl_StDate_OM = new System.Windows.Forms.Label();
            this.dtpckr_StartDt_OM = new System.Windows.Forms.DateTimePicker();
            this.dtpckr_EndDt_OM = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndDate_OM = new System.Windows.Forms.Label();
            this.lbl_SelectionType_OM = new System.Windows.Forms.Label();
            this.cb_SelectionType_OM = new System.Windows.Forms.ComboBox();
            this.lbl_Values_OM = new System.Windows.Forms.Label();
            this.btn_delete_OM = new System.Windows.Forms.Button();
            this.btn_View_OM = new System.Windows.Forms.Button();
            this.txt_DeleteValues_OM = new System.Windows.Forms.TextBox();
            this.dgv_View_OM = new System.Windows.Forms.DataGridView();
            this.tbctrl_Delete = new System.Windows.Forms.TabControl();
            this.tbpg_OrderDelete_OM = new System.Windows.Forms.TabPage();
            this.pnl_bottom_OM = new System.Windows.Forms.Panel();
            this.pnl_Top_OM = new System.Windows.Forms.Panel();
            this.cb_CorrectionType_OM = new System.Windows.Forms.ComboBox();
            this.lbl_CorrectionType_OM = new System.Windows.Forms.Label();
            this.lbl_Comments_OM = new System.Windows.Forms.Label();
            this.txt_DeleteComments_OM = new System.Windows.Forms.TextBox();
            this.tbpg_OrderUpdates_OM = new System.Windows.Forms.TabPage();
            this.pnl_Dates_OM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_OM)).BeginInit();
            this.tbctrl_Delete.SuspendLayout();
            this.tbpg_OrderDelete_OM.SuspendLayout();
            this.pnl_bottom_OM.SuspendLayout();
            this.pnl_Top_OM.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_BU_OM
            // 
            this.cb_BU_OM.FormattingEnabled = true;
            this.cb_BU_OM.Location = new System.Drawing.Point(14, 33);
            this.cb_BU_OM.Name = "cb_BU_OM";
            this.cb_BU_OM.Size = new System.Drawing.Size(179, 21);
            this.cb_BU_OM.TabIndex = 1;
            this.cb_BU_OM.SelectedIndexChanged += new System.EventHandler(this.cb_BU_OM_SelectedIndexChanged);
            // 
            // lbl_BUnit_OM
            // 
            this.lbl_BUnit_OM.AutoSize = true;
            this.lbl_BUnit_OM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BUnit_OM.Location = new System.Drawing.Point(14, 17);
            this.lbl_BUnit_OM.Name = "lbl_BUnit_OM";
            this.lbl_BUnit_OM.Size = new System.Drawing.Size(95, 15);
            this.lbl_BUnit_OM.TabIndex = 1;
            this.lbl_BUnit_OM.Text = "Business Unit";
            // 
            // pnl_Dates_OM
            // 
            this.pnl_Dates_OM.Controls.Add(this.lbl_StDate_OM);
            this.pnl_Dates_OM.Controls.Add(this.dtpckr_StartDt_OM);
            this.pnl_Dates_OM.Controls.Add(this.dtpckr_EndDt_OM);
            this.pnl_Dates_OM.Controls.Add(this.lbl_EndDate_OM);
            this.pnl_Dates_OM.Location = new System.Drawing.Point(440, 10);
            this.pnl_Dates_OM.Name = "pnl_Dates_OM";
            this.pnl_Dates_OM.Size = new System.Drawing.Size(154, 152);
            this.pnl_Dates_OM.TabIndex = 4;
            // 
            // lbl_StDate_OM
            // 
            this.lbl_StDate_OM.AutoSize = true;
            this.lbl_StDate_OM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StDate_OM.Location = new System.Drawing.Point(13, 10);
            this.lbl_StDate_OM.Name = "lbl_StDate_OM";
            this.lbl_StDate_OM.Size = new System.Drawing.Size(71, 15);
            this.lbl_StDate_OM.TabIndex = 4;
            this.lbl_StDate_OM.Text = "Start Date";
            // 
            // dtpckr_StartDt_OM
            // 
            this.dtpckr_StartDt_OM.Location = new System.Drawing.Point(16, 28);
            this.dtpckr_StartDt_OM.Name = "dtpckr_StartDt_OM";
            this.dtpckr_StartDt_OM.Size = new System.Drawing.Size(131, 20);
            this.dtpckr_StartDt_OM.TabIndex = 4;
            // 
            // dtpckr_EndDt_OM
            // 
            this.dtpckr_EndDt_OM.Location = new System.Drawing.Point(16, 115);
            this.dtpckr_EndDt_OM.Name = "dtpckr_EndDt_OM";
            this.dtpckr_EndDt_OM.Size = new System.Drawing.Size(131, 20);
            this.dtpckr_EndDt_OM.TabIndex = 5;
            // 
            // lbl_EndDate_OM
            // 
            this.lbl_EndDate_OM.AutoSize = true;
            this.lbl_EndDate_OM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndDate_OM.Location = new System.Drawing.Point(13, 97);
            this.lbl_EndDate_OM.Name = "lbl_EndDate_OM";
            this.lbl_EndDate_OM.Size = new System.Drawing.Size(66, 15);
            this.lbl_EndDate_OM.TabIndex = 5;
            this.lbl_EndDate_OM.Text = "End Date";
            // 
            // lbl_SelectionType_OM
            // 
            this.lbl_SelectionType_OM.AutoSize = true;
            this.lbl_SelectionType_OM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectionType_OM.Location = new System.Drawing.Point(14, 68);
            this.lbl_SelectionType_OM.Name = "lbl_SelectionType_OM";
            this.lbl_SelectionType_OM.Size = new System.Drawing.Size(101, 15);
            this.lbl_SelectionType_OM.TabIndex = 11;
            this.lbl_SelectionType_OM.Text = "Selection Type";
            // 
            // cb_SelectionType_OM
            // 
            this.cb_SelectionType_OM.FormattingEnabled = true;
            this.cb_SelectionType_OM.Items.AddRange(new object[] {
            "SO_Number",
            "RollCall_Date",
            "Processed_Date"});
            this.cb_SelectionType_OM.Location = new System.Drawing.Point(14, 84);
            this.cb_SelectionType_OM.Name = "cb_SelectionType_OM";
            this.cb_SelectionType_OM.Size = new System.Drawing.Size(179, 21);
            this.cb_SelectionType_OM.TabIndex = 2;
            this.cb_SelectionType_OM.SelectedIndexChanged += new System.EventHandler(this.cb_SelectionType_OM_SelectedIndexChanged);
            // 
            // lbl_Values_OM
            // 
            this.lbl_Values_OM.AutoSize = true;
            this.lbl_Values_OM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Values_OM.Location = new System.Drawing.Point(218, 17);
            this.lbl_Values_OM.Name = "lbl_Values_OM";
            this.lbl_Values_OM.Size = new System.Drawing.Size(96, 15);
            this.lbl_Values_OM.TabIndex = 9;
            this.lbl_Values_OM.Text = "Delete Values";
            // 
            // btn_delete_OM
            // 
            this.btn_delete_OM.Location = new System.Drawing.Point(977, 122);
            this.btn_delete_OM.Name = "btn_delete_OM";
            this.btn_delete_OM.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_OM.TabIndex = 7;
            this.btn_delete_OM.Text = "Delete";
            this.btn_delete_OM.UseVisualStyleBackColor = true;
            this.btn_delete_OM.Click += new System.EventHandler(this.btn_Delete_OM_Click);
            // 
            // btn_View_OM
            // 
            this.btn_View_OM.Location = new System.Drawing.Point(977, 50);
            this.btn_View_OM.Name = "btn_View_OM";
            this.btn_View_OM.Size = new System.Drawing.Size(75, 23);
            this.btn_View_OM.TabIndex = 6;
            this.btn_View_OM.Text = "View";
            this.btn_View_OM.UseVisualStyleBackColor = true;
            this.btn_View_OM.Click += new System.EventHandler(this.btn_View_OM_Click);
            // 
            // txt_DeleteValues_OM
            // 
            this.txt_DeleteValues_OM.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_DeleteValues_OM.Location = new System.Drawing.Point(221, 35);
            this.txt_DeleteValues_OM.Multiline = true;
            this.txt_DeleteValues_OM.Name = "txt_DeleteValues_OM";
            this.txt_DeleteValues_OM.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_DeleteValues_OM.Size = new System.Drawing.Size(199, 127);
            this.txt_DeleteValues_OM.TabIndex = 3;
            this.txt_DeleteValues_OM.Text = "Enter SO_Numbers to be deleted";
            this.txt_DeleteValues_OM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DeleteValues_OM.Enter += new System.EventHandler(this.txt_DeleteValues_OM_Enter);
            this.txt_DeleteValues_OM.Leave += new System.EventHandler(this.txt_DeleteValues_OM_Leave);
            // 
            // dgv_View_OM
            // 
            this.dgv_View_OM.AllowUserToAddRows = false;
            this.dgv_View_OM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_OM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_View_OM.Location = new System.Drawing.Point(0, 0);
            this.dgv_View_OM.Name = "dgv_View_OM";
            this.dgv_View_OM.Size = new System.Drawing.Size(1285, 436);
            this.dgv_View_OM.TabIndex = 0;
            // 
            // tbctrl_Delete
            // 
            this.tbctrl_Delete.Controls.Add(this.tbpg_OrderDelete_OM);
            this.tbctrl_Delete.Controls.Add(this.tbpg_OrderUpdates_OM);
            this.tbctrl_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrl_Delete.Location = new System.Drawing.Point(0, 0);
            this.tbctrl_Delete.Name = "tbctrl_Delete";
            this.tbctrl_Delete.SelectedIndex = 0;
            this.tbctrl_Delete.Size = new System.Drawing.Size(1299, 647);
            this.tbctrl_Delete.TabIndex = 4;
            // 
            // tbpg_OrderDelete_OM
            // 
            this.tbpg_OrderDelete_OM.Controls.Add(this.pnl_bottom_OM);
            this.tbpg_OrderDelete_OM.Controls.Add(this.pnl_Top_OM);
            this.tbpg_OrderDelete_OM.Location = new System.Drawing.Point(4, 22);
            this.tbpg_OrderDelete_OM.Name = "tbpg_OrderDelete_OM";
            this.tbpg_OrderDelete_OM.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_OrderDelete_OM.Size = new System.Drawing.Size(1291, 621);
            this.tbpg_OrderDelete_OM.TabIndex = 0;
            this.tbpg_OrderDelete_OM.Text = "Order Deletion";
            this.tbpg_OrderDelete_OM.UseVisualStyleBackColor = true;
            // 
            // pnl_bottom_OM
            // 
            this.pnl_bottom_OM.Controls.Add(this.dgv_View_OM);
            this.pnl_bottom_OM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bottom_OM.Location = new System.Drawing.Point(3, 182);
            this.pnl_bottom_OM.Name = "pnl_bottom_OM";
            this.pnl_bottom_OM.Size = new System.Drawing.Size(1285, 436);
            this.pnl_bottom_OM.TabIndex = 13;
            // 
            // pnl_Top_OM
            // 
            this.pnl_Top_OM.Controls.Add(this.cb_CorrectionType_OM);
            this.pnl_Top_OM.Controls.Add(this.lbl_CorrectionType_OM);
            this.pnl_Top_OM.Controls.Add(this.lbl_Comments_OM);
            this.pnl_Top_OM.Controls.Add(this.txt_DeleteComments_OM);
            this.pnl_Top_OM.Controls.Add(this.lbl_BUnit_OM);
            this.pnl_Top_OM.Controls.Add(this.btn_View_OM);
            this.pnl_Top_OM.Controls.Add(this.pnl_Dates_OM);
            this.pnl_Top_OM.Controls.Add(this.txt_DeleteValues_OM);
            this.pnl_Top_OM.Controls.Add(this.lbl_SelectionType_OM);
            this.pnl_Top_OM.Controls.Add(this.btn_delete_OM);
            this.pnl_Top_OM.Controls.Add(this.cb_SelectionType_OM);
            this.pnl_Top_OM.Controls.Add(this.cb_BU_OM);
            this.pnl_Top_OM.Controls.Add(this.lbl_Values_OM);
            this.pnl_Top_OM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top_OM.Location = new System.Drawing.Point(3, 3);
            this.pnl_Top_OM.Name = "pnl_Top_OM";
            this.pnl_Top_OM.Size = new System.Drawing.Size(1285, 179);
            this.pnl_Top_OM.TabIndex = 12;
            // 
            // cb_CorrectionType_OM
            // 
            this.cb_CorrectionType_OM.FormattingEnabled = true;
            this.cb_CorrectionType_OM.Items.AddRange(new object[] {
            "",
            "Incorrect",
            "Duplicates",
            "Not Applicable"});
            this.cb_CorrectionType_OM.Location = new System.Drawing.Point(14, 141);
            this.cb_CorrectionType_OM.Name = "cb_CorrectionType_OM";
            this.cb_CorrectionType_OM.Size = new System.Drawing.Size(179, 21);
            this.cb_CorrectionType_OM.TabIndex = 16;
            this.cb_CorrectionType_OM.SelectedIndexChanged += new System.EventHandler(this.cb_CorrectionType_OM_SelectedIndexChanged);
            // 
            // lbl_CorrectionType_OM
            // 
            this.lbl_CorrectionType_OM.AutoSize = true;
            this.lbl_CorrectionType_OM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CorrectionType_OM.Location = new System.Drawing.Point(14, 123);
            this.lbl_CorrectionType_OM.Name = "lbl_CorrectionType_OM";
            this.lbl_CorrectionType_OM.Size = new System.Drawing.Size(107, 15);
            this.lbl_CorrectionType_OM.TabIndex = 15;
            this.lbl_CorrectionType_OM.Text = "Correction Type";
            // 
            // lbl_Comments_OM
            // 
            this.lbl_Comments_OM.AutoSize = true;
            this.lbl_Comments_OM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comments_OM.Location = new System.Drawing.Point(617, 17);
            this.lbl_Comments_OM.Name = "lbl_Comments_OM";
            this.lbl_Comments_OM.Size = new System.Drawing.Size(75, 15);
            this.lbl_Comments_OM.TabIndex = 13;
            this.lbl_Comments_OM.Text = "Comments";
            // 
            // txt_DeleteComments_OM
            // 
            this.txt_DeleteComments_OM.Location = new System.Drawing.Point(620, 35);
            this.txt_DeleteComments_OM.Multiline = true;
            this.txt_DeleteComments_OM.Name = "txt_DeleteComments_OM";
            this.txt_DeleteComments_OM.Size = new System.Drawing.Size(273, 127);
            this.txt_DeleteComments_OM.TabIndex = 12;
            // 
            // tbpg_OrderUpdates_OM
            // 
            this.tbpg_OrderUpdates_OM.Location = new System.Drawing.Point(4, 22);
            this.tbpg_OrderUpdates_OM.Name = "tbpg_OrderUpdates_OM";
            this.tbpg_OrderUpdates_OM.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_OrderUpdates_OM.Size = new System.Drawing.Size(1291, 621);
            this.tbpg_OrderUpdates_OM.TabIndex = 1;
            this.tbpg_OrderUpdates_OM.Text = "Order Updates";
            this.tbpg_OrderUpdates_OM.UseVisualStyleBackColor = true;
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 647);
            this.Controls.Add(this.tbctrl_Delete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderManagement";
            this.Text = "OrderManagement";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            this.pnl_Dates_OM.ResumeLayout(false);
            this.pnl_Dates_OM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_OM)).EndInit();
            this.tbctrl_Delete.ResumeLayout(false);
            this.tbpg_OrderDelete_OM.ResumeLayout(false);
            this.pnl_bottom_OM.ResumeLayout(false);
            this.pnl_Top_OM.ResumeLayout(false);
            this.pnl_Top_OM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_BU_OM;
        private System.Windows.Forms.Label lbl_BUnit_OM;
        private System.Windows.Forms.DataGridView dgv_View_OM;
        private System.Windows.Forms.Label lbl_EndDate_OM;
        private System.Windows.Forms.Label lbl_StDate_OM;
        private System.Windows.Forms.DateTimePicker dtpckr_EndDt_OM;
        private System.Windows.Forms.DateTimePicker dtpckr_StartDt_OM;
        private System.Windows.Forms.TextBox txt_DeleteValues_OM;
        private System.Windows.Forms.Button btn_delete_OM;
        private System.Windows.Forms.Button btn_View_OM;
        private System.Windows.Forms.Label lbl_Values_OM;
        private System.Windows.Forms.Label lbl_SelectionType_OM;
        private System.Windows.Forms.ComboBox cb_SelectionType_OM;
        private System.Windows.Forms.Panel pnl_Dates_OM;
        private System.Windows.Forms.TabControl tbctrl_Delete;
        private System.Windows.Forms.TabPage tbpg_OrderDelete_OM;
        private System.Windows.Forms.TabPage tbpg_OrderUpdates_OM;
        private System.Windows.Forms.Panel pnl_bottom_OM;
        private System.Windows.Forms.Panel pnl_Top_OM;
        private System.Windows.Forms.Label lbl_Comments_OM;
        private System.Windows.Forms.TextBox txt_DeleteComments_OM;
        private System.Windows.Forms.ComboBox cb_CorrectionType_OM;
        private System.Windows.Forms.Label lbl_CorrectionType_OM;
    }
}