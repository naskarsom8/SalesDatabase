using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Commission
{
    public partial class frm_Hierarchy : Form
    {
        DataAccess dac;
        string success = "Insert Success.";
        string failure = "Insert Failure.";
        int BUID = 0;
        public frm_Hierarchy()
        {
            dac = new DataAccess();
            InitializeComponent();
        }

        public void Accessiblity()
        {
            cb_BusinessUnit_H.DataSource = dac.GetBUNames(this.Name);
            cb_Segment_H.DataSource = dac.GetHierarchyDetails("segments", 0);
            cb_Role_H.DataSource = dac.GetHierarchyDetails("designations", 0);
            cb_RelatedSegmentNew_H.DataSource = dac.GetHierarchyDetails("segments", 0);
            cb_ReportingName_H.DataSource = dac.GetHierarchyDetails("reportingto", 0);
            cb_BusinessUnit_H.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_BusinessUnit_H.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_ReportingName_H.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_ReportingName_H.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Role_H.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_Role_H.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_SalesTeam_H.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_SalesTeam_H.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Segment_H.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_Segment_H.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_BUOther_H.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_BUOther_H.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_BUOther_H.DataSource = dac.GetBUNames(this.Name);
            txt_NewTeam_H.Enabled = false;
            btn_SaveTeam_H.Enabled = false;
            btn_SaveSegment_H.Enabled = false;
            btn_SaveRole_H.Enabled = false;
            ValueObjects.Message = "No record was inserted.";

        }

        private void frm_Hierarchy_Load(object sender, EventArgs e)
        {
            Accessiblity();
        }

        private void lnklbl_RoleHere_H_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbcntrl_Hierarchy.SelectedTab = tbpg_AddOtherDetails_H;
            txt_NewRole_H.Focus();
            
        }

        private void lnklbl_NewTeam_H_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbcntrl_Hierarchy.SelectedTab = tbpg_AddOtherDetails_H;
            cb_BUOther_H.Focus();
        }

        private void lnklbl_NewSegment_H_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbcntrl_Hierarchy.SelectedTab = tbpg_AddOtherDetails_H;
            txt_NewSegment_H.Focus();
        }

        private void cb_BusinessUnit_H_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_BusinessUnit_H.SelectedItem.ToString().ToLower())
            {
                case "global view":
                case "streamline":
                    BUID = 2;
                    break;
                case "italy":
                    BUID = 5;
                    break;
                case "spain":
                    BUID = 6;
                    break;
                case "poland":
                    BUID = 7;
                    break;
                case "switzerland":
                    BUID = 10;
                    break;
                default:
                    BUID = 1;
                    break;
            }
            cb_SalesTeam_H.DataSource = dac.GetHierarchyDetails("teams", BUID);
            cb_ReportingName_H.DataSource = dac.GetHierarchyDetails("reportingto",BUID);

            btn_SaveNew_H.Enabled = cb_BusinessUnit_H.SelectedIndex >= 1 ? true : false;
        }

        private void cb_BUOther_H_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_BUOther_H.SelectedIndex >= 1)
            {
                txt_NewTeam_H.Enabled = true;
            }
            else
            {
                txt_NewTeam_H.Enabled = false;
                txt_NewTeam_H.Text = string.Empty;
            }
        }

        private void txt_NewTeam_H_TextChanged(object sender, EventArgs e)
        {
            btn_SaveTeam_H.Enabled = string.IsNullOrWhiteSpace(txt_NewTeam_H.Text) | string.IsNullOrEmpty(txt_NewTeam_H.Text) ? false : true;
        }

        private void txt_NewSegment_H_TextChanged(object sender, EventArgs e)
        {
            btn_SaveSegment_H.Enabled = string.IsNullOrEmpty(txt_NewSegment_H.Text) | string.IsNullOrWhiteSpace(txt_NewSegment_H.Text) ? false : true;
        }
        private void txt_NewRole_H_TextChanged(object sender, EventArgs e)
        {
            btn_SaveRole_H.Enabled = string.IsNullOrWhiteSpace(txt_NewRole_H.Text) | string.IsNullOrEmpty(txt_NewRole_H.Text) ? false : true;
        }

        private void btn_SaveTeam_H_Click(object sender, EventArgs e)
        {
            ValueObjects.SalesTeamId = Convert.ToInt32(dac.GetHierarchyDetails("teams", 0)[1].ToString()) + 1;

            if(dac.InsertHierarchyDetails("teams", ValueObjects.SalesTeamId, txt_NewTeam_H.Text,"1",cb_BUOther_H.SelectedIndex)== true)
            {
                MessageBox.Show("Team inserted successfully", success);
            }
            else
            {
                MessageBox.Show(ValueObjects.Message, failure);
            }
        }

        private void btn_SaveRole_H_Click(object sender, EventArgs e)
        {
            ValueObjects.DesignationId = Convert.ToInt32(dac.GetHierarchyDetails("designationid", 0)[1].ToString()) + 1;
            string RoleAbbreviation = null;

            foreach(string s in ValueObjects.Abbreviator(txt_NewRole_H.Text))
            {
                RoleAbbreviation += s.ElementAt<char>(0).ToString();
            }

            if(dac.InsertHierarchyDetails("designations", ValueObjects.DesignationId, RoleAbbreviation, txt_NewRole_H.Text,1)==true)
            {
                MessageBox.Show("Role inserted successfully.", success);
            }
            else
            {
                MessageBox.Show(ValueObjects.Message, failure);
            }
        }

        private void btn_SaveSegment_H_Click(object sender, EventArgs e)
        {
            ValueObjects.SegmentId = Convert.ToInt32(dac.GetHierarchyDetails("segmentid", 0)[1].ToString()) + 1;

            string RsegmentId = cb_RelatedSegmentNew_H.SelectedItem.ToString();

            RsegmentId = string.IsNullOrWhiteSpace(RsegmentId) | string.IsNullOrEmpty(RsegmentId) ? "0" : RsegmentId.Substring(0, RsegmentId.IndexOf("-")).Trim();
            if(dac.InsertHierarchyDetails("segments", ValueObjects.SegmentId, txt_NewSegment_H.Text, "1", Convert.ToInt32(RsegmentId))== true)
            {
                MessageBox.Show("Segment inserted successfully.", success);
            }
            else
            {
                MessageBox.Show(ValueObjects.Message, failure);
            }

        }

        private void btn_SaveNew_H_Click(object sender, EventArgs e)
        {
            int stid, segid;

            segid = cb_Segment_H.SelectedIndex <= 0 ? 0 : Convert.ToInt32(cb_Segment_H.SelectedItem.ToString().Substring(0, cb_Segment_H.SelectedItem.ToString().IndexOf("-")).Trim());
            if (cb_SalesTeam_H.SelectedIndex <= 0 || cb_BusinessUnit_H.SelectedIndex <= 0 || string.IsNullOrEmpty(txt_AID_H.Text) || string.IsNullOrWhiteSpace(txt_AID_H.Text)
                || string.IsNullOrEmpty(txt_Name_H.Text) || string.IsNullOrWhiteSpace(txt_Name_H.Text) || cb_Role_H.SelectedIndex <= 0 || cb_Segment_H.SelectedIndex <= 0)
            {
                MessageBox.Show("Fields marked ** cannot be blank.","Missing mandatory fields.",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ValueObjects.TeamName = cb_SalesTeam_H.SelectedItem.ToString();               
                stid = Convert.ToInt32(dac.GetHierarchyDetails("teamid", 0)[1].ToString());

                if (dac.InsertSalesPersonDetails(Convert.ToInt32(txt_AID_H.Text), txt_Name_H.Text, Convert.ToInt32(cb_Role_H.SelectedItem.ToString().Substring(0,cb_Role_H.SelectedItem.ToString().IndexOf("-")).Trim()),
                    Convert.ToInt32(txt_AID_H.Text), stid, segid, BUID, dtpkr_StartDate_H.Value.ToString("yyyy-MM-dd")
                    , chkbx_UseLatest_H.Checked == true ? true : false) == true)
                {
                    MessageBox.Show("Person information inserted sucessfully.", success);
                }
                else
                {
                    MessageBox.Show(ValueObjects.Message, failure);
                }
            }
        }

        private void cb_ReportingName_H_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueObjects.ReportingTo = cb_ReportingName_H.SelectedItem.ToString();
            txt_ReportingAID_H.Text = cb_ReportingName_H.SelectedIndex <= 0 ? "" : dac.GetHierarchyDetails("reportingtoid", 0)[1].ToString();
            ValueObjects.PersonId = string.IsNullOrEmpty(txt_ReportingAID_H.Text) || string.IsNullOrWhiteSpace(txt_ReportingAID_H.Text) ? 0 : Convert.ToInt32(txt_ReportingAID_H.Text);
            string team, segment, value;

            value = ValueObjects.PersonId == 0 ? "" : dac.GetHierarchyDetails("segmentteam", 0)[1].ToString();

            team = value == "" ? "" : value.Substring(0,value.IndexOf("~"));
            segment = value == "" ? "" : value.Substring(value.IndexOf("~")+1);

            cb_SalesTeam_H.SelectedIndex = cb_SalesTeam_H.Items.Contains(team) ? cb_SalesTeam_H.Items.IndexOf(team) : 0;

            cb_Segment_H.SelectedIndex = cb_Segment_H.Items.Contains(segment) ? cb_Segment_H.Items.IndexOf(segment) : cb_Segment_H.Items.IndexOf("");

        }
    }
}
