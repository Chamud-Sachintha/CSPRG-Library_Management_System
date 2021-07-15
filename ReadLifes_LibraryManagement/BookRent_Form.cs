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
    public partial class BookRent_Form : UserControl
    {
        public BookRent_Form()
        {
            InitializeComponent();
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

        public int get_value;

        public bool ChkInt(string value)
        {
            try
            {
                get_value = Convert.ToInt32(value);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        ReadLifes_SystemDatabase db_obj = new ReadLifes_SystemDatabase();
        public int [] book_id = new int[4];

        private void rentconfirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int member_id = Convert.ToInt32(memid_txt.Text);

                if (ChkEmpty(Convert.ToString(member_id)) == false && memid_txt.Text == "Member ID" || no_of_books_txt.Text == "No.Of Books" || no_of_books_txt.Text == "")
                {
                    MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Convert.ToInt32(no_of_books_txt.Text) == 1)
                    {
                        if (ChkInt(bookid1_txt.Text) == true)
                        {
                            book_id[0] = Convert.ToInt32(bookid1_txt.Text);
                        }
                    }
                    if (Convert.ToInt32(no_of_books_txt.Text) == 2)
                    {
                        if (ChkInt(bookid1_txt.Text) == true && ChkInt(bookid2_txt.Text) == true)
                        {
                            book_id[0] = Convert.ToInt32(bookid1_txt.Text);
                            book_id[1] = Convert.ToInt32(bookid2_txt.Text);
                        }
                    }
                    if (Convert.ToInt32(no_of_books_txt.Text) == 3)
                    {
                        if (ChkInt(bookid1_txt.Text) == true && ChkInt(bookid2_txt.Text) == true && ChkInt(bookid3_txt.Text) == true)
                        {
                            book_id[0] = Convert.ToInt32(bookid1_txt.Text);
                            book_id[1] = Convert.ToInt32(bookid2_txt.Text);
                            book_id[2] = Convert.ToInt32(bookid3_txt.Text);
                        }
                    }

                    if (book_id[0] == 0 && book_id[1] == 0 && book_id[2] == 0)
                    {
                        MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (db_obj.MakeRent(member_id, Convert.ToInt32(no_of_books_txt.Text), book_id) == true)
                        {
                            MessageBox.Show("Member Registration Succeffuly...", "Member Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("There Is Some Error Occured While Inserting Details", "Connection Or Database Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookRent_Form_Load(object sender, EventArgs e)
        {
            bookid1_txt.Enabled = false;
            bookid2_txt.Enabled = false;
            bookid3_txt.Enabled = false;
        }

        private void no_of_books_txt_OnValueChanged(object sender, EventArgs e)
        {
            if (no_of_books_txt.Text.Equals("1"))
            {
                bookid1_txt.Enabled = true;
                bookid2_txt.Enabled = false;
                bookid3_txt.Enabled = false;              
            }
            else if (no_of_books_txt.Text.Equals("2"))
            {
                bookid1_txt.Enabled = true;
                bookid2_txt.Enabled = true;
                bookid3_txt.Enabled = false;
            }
            else if (no_of_books_txt.Text.Equals("3"))
            {
                bookid1_txt.Enabled = true;
                bookid2_txt.Enabled = true;
                bookid3_txt.Enabled = true;
            }
        }

        private void chkrent_btn_Click(object sender, EventArgs e)
        {
            rentconfirm_btn.Enabled = false;

            memid_txt.Enabled = false;
            no_of_books_txt.Enabled = false;
            bookid1_txt.Enabled = false;
            bookid2_txt.Enabled = false;
            bookid3_txt.Enabled = false;

            try
            {
                int member_id = Convert.ToInt32(searchrent_txt.Text);

                int[] rent_details = db_obj.GetRent_Details(member_id);

                for (int x = 0; x <= rent_details.Length; x++)
                {
                    if (rent_details[0] == 0)
                    {
                        MessageBox.Show("There Is No Rent For That Member ID", "Check Rent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        memid_txt.Text = Convert.ToString(rent_details[0]);
                        no_of_books_txt.Text = Convert.ToString(rent_details[1]);
                        bookid1_txt.Text = Convert.ToString(rent_details[2]);
                        bookid2_txt.Text = Convert.ToString(rent_details[3]);
                        bookid3_txt.Text = Convert.ToString(rent_details[4]);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            rentconfirm_btn.Enabled = true;

            searchrent_txt.Text = "";

            memid_txt.Enabled = true;
            no_of_books_txt.Enabled = true;
            bookid1_txt.Enabled = true;
            bookid2_txt.Enabled = true;
            bookid3_txt.Enabled = true;

            memid_txt.Text = "";
            no_of_books_txt.Text = "";
            bookid1_txt.Text = "";
            bookid2_txt.Text = "";
            bookid3_txt.Text = "";
        }

        private void deleterent_btn_Click(object sender, EventArgs e)
        {
            int mem_id = Convert.ToInt32(searchrent_txt.Text);

            if(ChkEmpty(Convert.ToString(mem_id)) == true)
            {
                DialogResult delete_confirm = MessageBox.Show("Are You Sure Want To Delete This User ? " , "Delete User.." ,MessageBoxButtons.YesNo ,MessageBoxIcon.Question);

                if(delete_confirm == DialogResult.Yes)
                {
                    db_obj.DeleteRent(mem_id);
                }
                else
                {
                    //nothing execute
                }
            }
            else
            {
                MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchrent_txt_Enter(object sender, EventArgs e)
        {
            if(searchrent_txt.Text == "Search ID")
            {
                searchrent_txt.Text = "";
            }
        }

        private void searchrent_txt_Leave(object sender, EventArgs e)
        {
            if (searchrent_txt.Text == "")
            {
                searchrent_txt.Text = "Search ID";
            }
        }
    }
}
