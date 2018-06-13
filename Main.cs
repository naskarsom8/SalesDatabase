using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Globalization;



namespace Sales_Commission
{
    public partial class Main : Form
    {
        StatusBar MainStatusBar = new StatusBar();
        StatusBarPanel sbpUserName = new StatusBarPanel();
        StatusBarPanel sbpDateTime = new StatusBarPanel();
        StatusBarPanel sbpTime = new StatusBarPanel();
        TimeZone localZone = TimeZone.CurrentTimeZone;
        DateTime currentDate = DateTime.Now;
        OrderManagement om;
        frm_Hierarchy hm;
        Flexible_Upload fu;
        Extracts ex;
        frm_Adjustments adj;

        public Main()
        {
            InitializeComponent();
            AddStatusBar();
        }


        private void AddStatusBar()
        {
            try
            {
                sbpUserName.BorderStyle = StatusBarPanelBorderStyle.Sunken;
                sbpUserName.Text = "User Name: " + Environment.UserName.ToUpper(); ;
                sbpUserName.ToolTipText = Environment.UserName.ToUpper();
                sbpUserName.AutoSize = StatusBarPanelAutoSize.Spring;
                MainStatusBar.Panels.Add(sbpUserName);

                sbpDateTime.BorderStyle = StatusBarPanelBorderStyle.Sunken;
                sbpDateTime.Text = " Day & Date: " + System.DateTime.Now.ToLongDateString() + "   Time: " + System.DateTime.Now.ToLongTimeString();
                sbpDateTime.ToolTipText = "DateTime: " + System.DateTime.Now;
                sbpDateTime.AutoSize = StatusBarPanelAutoSize.Contents;
                MainStatusBar.Panels.Add(sbpDateTime);

                MainStatusBar.ShowPanels = true;
                MainStatusBar.Font = new Font("Tahoma", 8, MainStatusBar.Font.Style);
                Controls.Add(MainStatusBar);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void PageLoad(string Pagename)
        {
            switch(Pagename)
            {
                case "adjustments":
                    if (ActiveMdiChild == null | ActiveMdiChild != adj)
                    {
                        adj = new frm_Adjustments();
                        adj.MdiParent = this;
                        adj.Show();
                        adj.WindowState = FormWindowState.Normal;
                        adj.StartPosition = FormStartPosition.CenterScreen;
                    }
                    else
                    {
                        adj.BringToFront();
                        adj.WindowState = FormWindowState.Normal;
                        adj.Activate();
                    }
                    break;
                case "extracts":
                    if (ActiveMdiChild == null | ActiveMdiChild != ex)
                    {
                        ex = new Extracts();
                        ex.MdiParent = this;
                        ex.Show();
                        ex.WindowState = FormWindowState.Normal;
                        ex.StartPosition = FormStartPosition.CenterScreen;
                    }
                    else
                    {
                        ex.BringToFront();
                        ex.WindowState = FormWindowState.Normal;
                        ex.Activate();
                    }
                    break;
                case "uploads":
                    if (ActiveMdiChild == null | ActiveMdiChild != fu)
                    {
                        fu = new Flexible_Upload();
                        fu.MdiParent = this;
                        fu.Show();
                        fu.WindowState = FormWindowState.Normal;
                        fu.StartPosition = FormStartPosition.CenterScreen;
                    }
                    else
                    {
                        fu.BringToFront();
                        fu.WindowState = FormWindowState.Normal;
                        fu.Activate();
                    }
                    break;
                case "hierarchy":
                    if (ActiveMdiChild == null | ActiveMdiChild != hm)
                    {
                        hm = new frm_Hierarchy();
                        hm.MdiParent = this;
                        hm.Show();
                        hm.WindowState = FormWindowState.Normal;
                        hm.StartPosition = FormStartPosition.CenterScreen;
                    }
                    else
                    {
                        hm.BringToFront();
                        hm.WindowState = FormWindowState.Normal;
                        hm.Activate();
                    }
                    break;
                case "orders":
                    if (ActiveMdiChild == null | ActiveMdiChild != om)
                    {
                        om = new OrderManagement();
                        om.MdiParent = this;
                        om.Show();
                        om.WindowState = FormWindowState.Normal;
                        om.StartPosition = FormStartPosition.CenterScreen;
                    }
                    else
                    {
                        om.BringToFront();
                        om.WindowState = FormWindowState.Normal;
                        om.Activate();
                    }
                    break;
                case "":
                    break;
                default:
                    MessageBox.Show("Please select a page before proceeding.");
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageLoad("uploads");
        }

        private void excelUploadsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PageLoad("uploads");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try { sbpDateTime.Text = " Day & Date: " + System.DateTime.Now.ToLongDateString() + "   Time: " + System.DateTime.Now.ToLongTimeString(); sbpDateTime.ToolTipText = "DateTime: " + System.DateTime.Now; }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void associatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in porgress. We'll notify you once the work is completed.");
        }

        private void salesExtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageLoad("extracts");
        }

        private void extractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageLoad("extracts");
        }

        private void flexibleUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageLoad("adjustments");
        }

        private void adjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageLoad("adjustments");
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageLoad("orders");
        }

        private void ordersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PageLoad("orders");
        }

        private void hierarchyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PageLoad("hierarchy");
        }

        private void hierarchyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PageLoad("hierarchy");
        }
    }
}
