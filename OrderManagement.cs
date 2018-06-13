using System;
using System.Linq;
using System.Windows.Forms;

namespace Sales_Commission
{
    public partial class OrderManagement : Form
    {

        private DataAccess dac;
        StatusBar OrderDeletion = new StatusBar();
        StatusBarPanel sbpRecordCount = new StatusBarPanel();
        StatusBarPanel sbpEmptypnl = new StatusBarPanel();
        public OrderManagement()
        {
            InitializeComponent();
            dac = new DataAccess();
        }
        private void OrderManagement_Load(object sender, EventArgs e)
        {
            Accessiblity();
        }

        private void Accessiblity()
        {
            btn_delete_OM.Enabled = false;
            cb_BU_OM.DataSource = dac.GetBUNames(this.Name);
            cb_SelectionType_OM.SelectedIndex = 0;
            pnl_Dates_OM.Enabled = false;
            btn_View_OM.Enabled = false;
        }


        //Function to add status bar at the bottom of the form.
        private void AddStatusBar()
        {
            OrderDeletion.Panels.Remove(sbpEmptypnl);
            OrderDeletion.Panels.Remove(sbpRecordCount);
            try
            {
                int recordcnt = dgv_View_OM.Rows.Count;
                sbpEmptypnl.BorderStyle = StatusBarPanelBorderStyle.Sunken;
                sbpEmptypnl.Text = " ";
                sbpEmptypnl.ToolTipText = " ";
                sbpEmptypnl.AutoSize = StatusBarPanelAutoSize.Spring;
                OrderDeletion.Panels.Add(sbpEmptypnl);

                sbpRecordCount.BorderStyle = StatusBarPanelBorderStyle.Sunken;
                sbpRecordCount.Text = "Total Records: " + recordcnt.ToString();
                sbpRecordCount.ToolTipText = recordcnt.ToString();
                sbpRecordCount.AutoSize = StatusBarPanelAutoSize.Contents;
                OrderDeletion.Panels.Add(sbpRecordCount);

                OrderDeletion.ShowPanels = true;
                OrderDeletion.Font = new System.Drawing.Font("Tahoma", 8, OrderDeletion.Font.Style);
                Controls.Add(OrderDeletion);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btn_View_OM_Click(object sender, EventArgs e)
        {

            string frm, to, cType, So_Number = txt_DeleteValues_OM.Text;

            switch(cb_CorrectionType_OM.SelectedItem.ToString())
            {
                case "Incorrect":
                    cType = "I";
                    break;
                case "Duplicates":
                    cType = "D";
                    break;
                case "Not Applicable":
                    cType = "NA";
                    break;
                default:
                    cType = "";
                    break;
            }

            So_Number = So_Number.Contains("Enter") ? string.Empty : So_Number;

            frm = to = "";

            if (pnl_Dates_OM.Enabled == true)
            {
                frm = dtpckr_StartDt_OM.Value.ToString("yyyy-MM-dd");
                to = dtpckr_EndDt_OM.Value.ToString("yyyy-MM-dd");
            }

            if((string.IsNullOrEmpty(txt_DeleteValues_OM.Text) || string.IsNullOrWhiteSpace(txt_DeleteValues_OM.Text) 
                || txt_DeleteComments_OM.Text.Contains("Enter") == true) && cb_SelectionType_OM.SelectedIndex == 0)
            {
                MessageBox.Show("Values cannot be blank. Please enter valid SO_Numbers to proceed.");
            }
            else
            {
                dac.InsertOrderDeletion("Deal_delete", So_Number.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList()
                    , cb_SelectionType_OM.SelectedItem.ToString(),cb_BU_OM.SelectedItem.ToString(),frm,to, txt_DeleteComments_OM.Text, cType, Environment.UserName);
            }

            dgv_View_OM.DataSource = dac.GetDeleteDetails(cb_BU_OM.SelectedItem.ToString(), frm, to, SQLDynamicTypeCreator.TextSeparator(txt_DeleteValues_OM.Text), cb_SelectionType_OM.SelectedItem.ToString());
            AddStatusBar();

            btn_delete_OM.Enabled = true;
        }

        private void cb_SelectionType_OM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_SelectionType_OM.SelectedIndex > 0)
            {
                pnl_Dates_OM.Enabled = true;
                txt_DeleteValues_OM.Enabled = false;
            }
            else
            {
                pnl_Dates_OM.Enabled = false;
                txt_DeleteValues_OM.Enabled = true;
            }
        }

        private void btn_Delete_OM_Click(object sender, EventArgs e)
        {
            if (cb_CorrectionType_OM.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a correction type before proceeding.", "No correction type selected.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (dac.ExecuteProcedure(4) == true)
                {
                    MessageBox.Show("Data was successfully deleted", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record was deleted from db.", "Delete Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void txt_DeleteValues_OM_Leave(object sender, EventArgs e)
        {
            if(txt_DeleteValues_OM.Text == string.Empty || txt_DeleteValues_OM.Text == "Enter SO_Numbers to be deleted.")
            {
                txt_DeleteValues_OM.Text = "Enter SO_Numbers to be deleted.";
                txt_DeleteValues_OM.ForeColor = System.Drawing.Color.Gray;
                txt_DeleteValues_OM.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void txt_DeleteValues_OM_Enter(object sender, EventArgs e)
        {
            txt_DeleteValues_OM.Text = string.Empty;
            txt_DeleteValues_OM.TextAlign = HorizontalAlignment.Left;
        }

        private void cb_BU_OM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_SelectionType_OM.Enabled = cb_BU_OM.SelectedIndex > 0 ? true : false;
        }

        private void cb_CorrectionType_OM_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_View_OM.Enabled = cb_BU_OM.SelectedIndex > 0 ? true : false;
        }
    }
}
