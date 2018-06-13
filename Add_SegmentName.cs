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
    public partial class Add_SegmentName : Form
    {
        DataAccess dac;
        public Add_SegmentName()
        {
            InitializeComponent();
            dac = new DataAccess();

            
        }
        internal bool AddSegmentMandatoryfields()
        {
            if (textBox_SegmentID.Text == string.Empty | textBox_Segmentname.Text == string.Empty |
               string.IsNullOrWhiteSpace(textBox_SegmentID.Text) | string.IsNullOrWhiteSpace(textBox_Segmentname.Text)
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Btn_AddSegment_Click(object sender, EventArgs e)
        {
            if (AddSegmentMandatoryfields() == false)
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
