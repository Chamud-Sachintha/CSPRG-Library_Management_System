using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadLifes_LibraryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            side_panel.Height = dashboard_btn.Height;
            side_panel.Top = dashboard_btn.Top;

            dashboardForm1.Show();
            dashboardForm1.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dashboardForm1.Show();
            memberMgmt_Form1.Hide();
            bookRent_Form1.Hide();
            bookMgmt1.Hide();
            suppliermgmt_form1.Hide();
        }

        private void memreg_btn_Click(object sender, EventArgs e)
        {
            side_panel.Height = memreg_btn.Height;
            side_panel.Top = memreg_btn.Top;

            dashboardForm1.Hide();
            memberMgmt_Form1.Show();
            memberMgmt_Form1.BringToFront();
        }

        private void bookrent_btn_Click(object sender, EventArgs e)
        {
            side_panel.Height = bookrent_btn.Height;
            side_panel.Top = bookrent_btn.Top;

            dashboardForm1.Hide();
            memberMgmt_Form1.Hide();

            bookRent_Form1.Show();
            bookRent_Form1.BringToFront();
        }

        private void bookmgmt_btn_Click(object sender, EventArgs e)
        {
            side_panel.Height = bookmgmt_btn.Height;
            side_panel.Top = bookmgmt_btn.Top;

            dashboardForm1.Hide();
            bookRent_Form1.Hide();
            memberMgmt_Form1.Hide();

            bookMgmt1.Show();
            bookMgmt1.BringToFront();
        }

        private void suplierreg_btn_Click(object sender, EventArgs e)
        {
            side_panel.Height = suplierreg_btn.Height;
            side_panel.Top = suplierreg_btn.Top;

            dashboardForm1.Hide();
            bookRent_Form1.Hide();
            memberMgmt_Form1.Hide();
            bookMgmt1.Hide();

            suppliermgmt_form1.Show();
            suppliermgmt_form1.BringToFront();
        }
        
    }
}
