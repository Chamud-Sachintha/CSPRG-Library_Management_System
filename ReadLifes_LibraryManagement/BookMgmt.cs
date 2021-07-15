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
    public partial class BookMgmt : UserControl
    {
        public BookMgmt()
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

        ReadLifes_SystemDatabase db_obj = new ReadLifes_SystemDatabase();

        private void bookreg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string book_cat = category_dropdown.selectedValue;

                if (book_cat == "")
                {
                    MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int sup_id = Convert.ToInt32(supid_txt.Text);
                    string isbn_no = book_isbn_txt.Text;
                    string bookname = bookname_txt.Text;
                    string authour_name = author_txt.Text;

                    if (ChkEmpty(Convert.ToString(sup_id)) == true && ChkEmpty(isbn_no) == true && ChkEmpty(bookname) == true && ChkEmpty(authour_name) == true)
                    {
                        if (db_obj.BookRegister(sup_id, isbn_no, book_cat, bookname, authour_name) == true)
                        {
                            MessageBox.Show("Book Registration Succefully.." ,"Book Registration" ,MessageBoxButtons.OK ,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("There Is Some Error Occured While Registration..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            category_dropdown.Enabled = true;
            supid_txt.Enabled = true;
            book_isbn_txt.Enabled = true;
            bookname_txt.Enabled = true;
            author_txt.Enabled = true;

            bookreg_btn.Enabled = true;
            category_dropdown.selectedIndex = 0;

            supid_txt.Text = "";
            book_isbn_txt.Text = "";
            bookname_txt.Text = "";
            author_txt.Text = "";

            supid_txt.Text = "Supplier ID";
            searchbookNo_txt.Text = "Book ISBN Number";
        }

        private void chkbook_btn_Click(object sender, EventArgs e)
        {
            bookreg_btn.Enabled = false;

            category_dropdown.Enabled = false;
            supid_txt.Enabled = false;
            book_isbn_txt.Enabled = false;
            bookname_txt.Enabled = false;
            author_txt.Enabled = false;

            try
            {
                int isbn_no = Convert.ToInt32(searchbookNo_txt.Text);

                if (ChkEmpty(Convert.ToString(isbn_no)) == true)
                {
                    string[] book_details = db_obj.GetBookDetails(isbn_no);

                    for (int x = 0; x <= book_details.Length; x++)
                    {
                        if (book_details[0] == null)
                        {
                            MessageBox.Show("There Is No Book For That Book ISBn Number", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {

                            if (book_details[1] == "Programming")
                            {
                                category_dropdown.selectedIndex = 1;
                            }
                            if (book_details[1] == "Cyber Security")
                            {
                                category_dropdown.selectedIndex = 2;
                            }
                            if (book_details[1] == "Web Develeopment")
                            {
                                category_dropdown.selectedIndex = 3;
                            }
                            if (book_details[1] == "Red Teaming")
                            {
                                category_dropdown.selectedIndex = 4;
                            }
                            if (book_details[1] == "Forensics")
                            {
                                category_dropdown.selectedIndex = 5;
                            }

                            supid_txt.Text = book_details[2];
                            book_isbn_txt.Text = book_details[0];
                            bookname_txt.Text = book_details[3];
                            author_txt.Text = book_details[4];
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletebook_btn_Click(object sender, EventArgs e)
        {
            int isbn_no = Convert.ToInt32(searchbookNo_txt.Text);

            if(ChkEmpty(Convert.ToString(isbn_no)) == true)
            {
                DialogResult delete_query = MessageBox.Show("Are You Sure Want To Delete This Book ?" ,"Delete Book Details" ,MessageBoxButtons.YesNo ,MessageBoxIcon.Question);

                if(delete_query == DialogResult.Yes)
                {
                    if (db_obj.DeleteBookDetails(isbn_no) == true)
                    {
                        MessageBox.Show("Book Detail Removing Succefully..", "Book Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There Is Some Error Occured While Deletion Book Informations..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //nothing to execute
                }
            }
            else
            {
                MessageBox.Show("Please Check Your Feilds..", "Empty Fields..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supid_txt_Enter(object sender, EventArgs e)
        {
            if(supid_txt.Text == "Supplier ID")
            {
                supid_txt.Text = "";
            }
        }

        private void supid_txt_Leave(object sender, EventArgs e)
        {
            if (supid_txt.Text == "")
            {
                supid_txt.Text = "Supplier ID";
            }
        }

        private void searchbookNo_txt_Enter(object sender, EventArgs e)
        {
            if(searchbookNo_txt.Text == "Book ISBN Number")
            {
                searchbookNo_txt.Text = "";
            }
        }

        private void searchbookNo_txt_Leave(object sender, EventArgs e)
        {
            if (searchbookNo_txt.Text == "")
            {
                searchbookNo_txt.Text = "Book ISBN Number";
            }
        }
    }
}
