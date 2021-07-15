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
    public partial class MemberMgmt_Form : UserControl
    {
        public MemberMgmt_Form()
        {
            InitializeComponent();
        }

        private void searchmemberid_txt_Enter(object sender, EventArgs e)
        {
            if(searchmemberid_txt.Text == "Member ID No")
            {
                searchmemberid_txt.Text = "";
            }
        }

        private void searchmemberid_txt_Leave(object sender, EventArgs e)
        {
            if (searchmemberid_txt.Text == "")
            {
                searchmemberid_txt.Text = "Member ID No";
            }
        }

        public bool ChkEmpty(string value)
        {
            if(value.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ResetFeilds()
        {
            memid_txt.Text = "";
            fname_txt.Text = "";
            lastname_txt.Text = "";
            address_txt.Text = "";
            email_txt.Text = "";
            mobile_txt.Text = "";
            nic_txt.Text = "";

            searchmemberid_txt.Text = "";

            Male_chkbox.Checked = false;
            female_chkbox.Checked = false;

            active_feilds();
        }

        ReadLifes_SystemDatabase db_obj = new ReadLifes_SystemDatabase();

        public string gen_sts;

        private void reg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int memid = Convert.ToInt32(memid_txt.Text);
                string fname = fname_txt.Text;
                string sname = lastname_txt.Text;
                string com_addr = address_txt.Text;
                string email = email_txt.Text;
                string mobile = mobile_txt.Text;
                string nic_no = nic_txt.Text;

                if (Male_chkbox.Checked == true && female_chkbox.Checked == true || Male_chkbox.Checked == false && female_chkbox.Checked == false)
                {
                    MessageBox.Show("Please Check Your Gender Status", "Invalid Argument", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Male_chkbox.Checked == true)
                    {
                        gen_sts = "Male";
                    }
                    else
                    {
                        gen_sts = "Female";
                    }

                    if(Convert.ToString(mobile).Length != 10)
                    {
                        MessageBox.Show("Please Check Your Mobile Number.." ,"Invalid Mobile Number" ,MessageBoxButtons.OK ,MessageBoxIcon.Error );
                    }
                    else
                    {
                        ResetFeilds();

                        if (db_obj.RegisterMember(memid, fname, sname, com_addr, email, mobile, nic_no, gen_sts) == true)
                        {
                            MessageBox.Show("Member Registration Succeffuly..." ,"Member Registration" ,MessageBoxButtons.OK ,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Already In Database.", "Data Duplication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Feilds.", "Invalid Argument", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MemberMgmt_Form_Load(object sender, EventArgs e)
        {
            memIndex_txt.Text = Convert.ToString(db_obj.GetIndex());

            memIndex_txt.Enabled = false;
            Male_chkbox.Checked = false;
            female_chkbox.Checked = false;

            save_btn.Visible = false;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        public void active_feilds()
        {
            memid_txt.Enabled = true;
            fname_txt.Enabled = true;
            lastname_txt.Enabled = true;
            address_txt.Enabled = true;
            email_txt.Enabled = true;
            mobile_txt.Enabled = true;
            nic_txt.Enabled = true;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            ResetFeilds();

            save_btn.Visible = false;
            update_btn.Visible = true;
            update_btn.Enabled = false;
            reg_btn.Enabled = true;
            delete_btn.Enabled = false;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            memid_txt.Enabled = false;
            fname_txt.Enabled = false;
            lastname_txt.Enabled = false;
            address_txt.Enabled = false;
            email_txt.Enabled = false;
            mobile_txt.Enabled = false;
            nic_txt.Enabled = false;

            if (searchmemberid_txt.Text == "")
            {
                MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string[] mem_details = db_obj.SearchMemberDetails(Convert.ToInt32(searchmemberid_txt.Text));

                    for (int x = 0; x <= mem_details.Length; x++)
                    {
                        if (mem_details[0] == null)
                        {
                            MessageBox.Show("There Is No Member For That ID", "Search Member");
                            break;
                        }
                        else
                        {
                            update_btn.Enabled = true;
                            reg_btn.Enabled = false;
                            delete_btn.Enabled = true;

                            memid_txt.Text = mem_details[0];
                            fname_txt.Text = mem_details[1];
                            lastname_txt.Text = mem_details[2];
                            address_txt.Text = mem_details[3];
                            email_txt.Text = mem_details[4];
                            mobile_txt.Text = mem_details[5];
                            nic_txt.Text = mem_details[6];

                            if (mem_details[7] == "Male")
                            {
                                Male_chkbox.Checked = true;
                            }
                            else
                            {
                                female_chkbox.Checked = true;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    active_feilds();
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            update_btn.Visible = false;
            delete_btn.Enabled = false;
            save_btn.Visible = true;

            fname_txt.Enabled = true;
            lastname_txt.Enabled = true;
            address_txt.Enabled = true;
            email_txt.Enabled = true;
            mobile_txt.Enabled = true;
            nic_txt.Enabled = true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            int memid = Convert.ToInt32(memid_txt.Text);
            string fname = fname_txt.Text;
            string sname = lastname_txt.Text;
            string com_addr = address_txt.Text;
            string email = email_txt.Text;
            string mobile = mobile_txt.Text;
            string nic_no = nic_txt.Text;

            if (db_obj.UpdateMemberDetails(memid, fname, sname, com_addr, email, mobile, nic_no) == true)
            {
                MessageBox.Show("Member Details Update Sucessfully!" ,"Update Member Details" ,MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There Is Some Error OccuredIn Updateing Details" ,"Update Error" ,MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int memid = Convert.ToInt32(memid_txt.Text);

            if(memid.Equals(""))
            {
                MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult delete_user = MessageBox.Show("Are You Sure Want To Delete This User ?" ,"User Deletion" ,MessageBoxButtons.YesNo ,MessageBoxIcon.Question);

                if(delete_user == DialogResult.Yes)
                {
                    if (db_obj.DeleteUser(memid) == true)
                    {
                        MessageBox.Show("Member Deletion Sucessfully!", "Update Member Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There Is Some Error Occured In Delete Details", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //nothing execute
                }
            }
        }
    }
}
