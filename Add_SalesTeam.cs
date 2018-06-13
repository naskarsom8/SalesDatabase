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
    public partial class Add_SalesTeam : Form
    {
        DataAccess dac;
        
        public Add_SalesTeam()
        {

            InitializeComponent();
            dac = new DataAccess();
       
            cb_Country_Addsalesteam.DataSource = dac.GetBUNames();
        }

        internal bool AddsalesteamMandatoryfields()
        {
            if (textBox_SalesTeamid.Text == string.Empty | textBox_addsalesteamname.Text == string.Empty |
               string.IsNullOrWhiteSpace(textBox_SalesTeamid.Text) | string.IsNullOrWhiteSpace(textBox_addsalesteamname.Text) | cb_Country_Addsalesteam.SelectedIndex < 1
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Btn_AddSalesteam_Click(object sender, EventArgs e)
        {
            if(AddsalesteamMandatoryfields() == false)
            {
                MessageBox.Show("Mandatory fields are marked as '*' which cannot be blank. \n Please select/Enter the values for the mandatory fields.");
            }

            else
            {
                MessageBox.Show("Done");
            }
        
        }
    }
}
