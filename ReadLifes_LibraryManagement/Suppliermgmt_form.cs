using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadLifes_LibraryManagement
{
    public partial class Suppliermgmt_form : UserControl
    {
        public Suppliermgmt_form()
        {
            InitializeComponent();
        }

        public bool ChkEmpty(string value)
        {
            if (value.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        ReadLifes_SystemDatabase db_obj = new ReadLifes_SystemDatabase();

        private void supreg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int supid = Convert.ToInt32(supid_txt.Text);
                string fname = fname_txt.Text;
                string sname = sname_txt.Text;
                string address = address_txt.Text;
                string mobile = mobile_txt.Text;
                string email = email_txt.Text;

                if (ChkEmpty(fname) == true && ChkEmpty(sname) == true && ChkEmpty(address) == true && ChkEmpty(mobile) == true && ChkEmpty(email) == true)
                {
                    if (db_obj.RegisterSupplier(supid, fname, sname, address, mobile, email) == true)
                    {
                        MessageBox.Show("Supplier Registration Succefully..", "Supplier Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There Is Some Error Occured While Registration..", "Improper Values...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Feilds..", "Improper Values...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActiveFeilds()
        {
            supid_txt.Enabled = true;
            fname_txt.Enabled = true;
            sname_txt.Enabled = true;
            address_txt.Enabled = true;
            mobile_txt.Enabled = true;
            email_txt.Enabled = true;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            supid_txt.Text = "";
            fname_txt.Text = "";
            sname_txt.Text = "";
            address_txt.Text = "";
            mobile_txt.Text = "";
            email_txt.Text = "";

            ActiveFeilds();

            updatesup_btn.Visible = true;
            updatesup_btn.Enabled = false;
            savedetails_btn.Visible = false;
        }

        private void searchsup_btn_Click(object sender, EventArgs e)
        {
            string supid = searchsup_txt.Text;

            supid_txt.Enabled = false;
            fname_txt.Enabled = false;
            sname_txt.Enabled = false;
            address_txt.Enabled = false;
            mobile_txt.Enabled = false;
            email_txt.Enabled = false;

            if(ChkEmpty(supid) == true)
            {
                string [] sup_details = db_obj.GetSupplierDetails(Convert.ToInt32(supid));

                for (int x = 0; x <= sup_details.Length; x++)
                {
                    if(sup_details[0] == null)
                    {
                        MessageBox.Show("There Is No Suuplie Details For That Supplier ID.", "Check Supplier ID...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        supid_txt.Text = sup_details[0];
                        fname_txt.Text = sup_details[1];
                        sname_txt.Text = sup_details[2];
                        address_txt.Text = sup_details[3];
                        mobile_txt.Text = sup_details[4];
                        email_txt.Text = sup_details[5];

                        updatesup_btn.Visible = true;
                        updatesup_btn.Enabled = true;
                        deletesup_btn.Enabled = true;
                        savedetails_btn.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Check Your Feilds..", "Improper Values...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchsup_txt_Enter(object sender, EventArgs e)
        {
            if(searchsup_txt.Text == "Search Supplier")
            {
                searchsup_txt.Text = "";
            }
        }

        private void searchsup_txt_Leave(object sender, EventArgs e)
        {
            if (searchsup_txt.Text == "")
            {
                searchsup_txt.Text = "Search Supplier";
            }
        }

        private void Suppliermgmt_form_Load(object sender, EventArgs e)
        {
            supplierIndex_txt.Text = Convert.ToString(db_obj.GetSupplierIndex());

            updatesup_btn.Enabled = false;
            deletesup_btn.Enabled = false;
            savedetails_btn.Visible = false;
        }

        private void updatesup_btn_Click(object sender, EventArgs e)
        {
            ActiveFeilds();
            updatesup_btn.Visible = false;
            deletesup_btn.Enabled = false;

            savedetails_btn.Visible = true;
        }

        private void savedetails_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int supid = Convert.ToInt32(supid_txt.Text);
                string fname = fname_txt.Text;
                string sname = sname_txt.Text;
                string address = address_txt.Text;
                string mobile = mobile_txt.Text;
                string email = email_txt.Text;

                if (ChkEmpty(fname) == true && ChkEmpty(sname) == true && ChkEmpty(address) == true && ChkEmpty(mobile) == true && ChkEmpty(email) == true)
                {
                    if (db_obj.UpdateSupplieDetails(supid, fname, sname, address, mobile, email) == true)
                    {
                        MessageBox.Show("Supplier Registration Succefully..", "Supplier Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There Is Some Error Occured While Registration..", "Improper Values...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Feilds..", "Improper Values...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletesup_btn_Click(object sender, EventArgs e)
        {
            string supid = supid_txt.Text;

            if (ChkEmpty(supid) == true)
            {
                DialogResult delet_confirm = MessageBox.Show("Are You Sure Want To Delete This Supplier Informations", "Delete Supplier Details...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delet_confirm == DialogResult.Yes)
                {
                    if(db_obj.DeleteSupplierDetails(Convert.ToInt32(supid)) == true)
                    {
                        MessageBox.Show("Supplier Deletion Succesfully..." ,"Supplier Deletion" ,MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There Is Some Error Occured While Deletion..", "Improper Values...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //nothing to execute
                }
            }
            else
            {
                MessageBox.Show("Please Check Your Feilds..", "Improper Values...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
