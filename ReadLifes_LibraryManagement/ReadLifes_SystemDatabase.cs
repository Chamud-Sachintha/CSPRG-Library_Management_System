using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlServerCe;

namespace ReadLifes_LibraryManagement
{
    class ReadLifes_SystemDatabase
    {
        public static string db_path = Path.GetFullPath(Environment.CurrentDirectory);
        public static string db_name = "ReadLifes_SystemDB.sdf";
        SqlCeConnection conn = new SqlCeConnection(@"Data Source='D:\hacking books beginners\C# prac\Projects\ReadLifes_LibraryManagement\ReadLifes_LibraryManagement\ReadLifes_SystemDB.sdf';Password='root123'");

        public bool RegisterMember(int memid, string fname, string sname, string com_addr, string email, string mobile, string nic_no, string gen_sts)
        {
            //conn.Open();
            try
            {
                SqlCeCommand insert_cmd = new SqlCeCommand("insert into Member_Details values ('" + memid + "','" + fname + "','" + sname + "', '" + com_addr + "','" + email + "' ,'" + mobile + "','" + nic_no + "' ,'" + gen_sts + "')", conn);
                insert_cmd.ExecuteNonQuery();

                insert_cmd.Dispose();
            }
            catch (Exception)
            {
                return false;
            }

            return true;

            conn.Close();
        }

        public string [] SearchMemberDetails(int mem_id)
        {
            conn.Close();
            conn.Open();
            string[] member_details = new string[8];

            SqlCeCommand search_cmd = new SqlCeCommand("select *from Member_Details where member_id = '" + mem_id + "'" ,conn);
            SqlCeDataReader sdr = search_cmd.ExecuteReader();

            while(sdr.Read())
            {
                member_details[0] = Convert.ToString(sdr[0].ToString());
                member_details[1] = Convert.ToString(sdr[1].ToString());
                member_details[2] = Convert.ToString(sdr[2].ToString());
                member_details[3] = Convert.ToString(sdr[3].ToString());
                member_details[4] = Convert.ToString(sdr[4].ToString());
                member_details[5] = Convert.ToString(sdr[5].ToString());
                member_details[6] = Convert.ToString(sdr[6].ToString());
                member_details[7] = Convert.ToString(sdr[7].ToString());
            }

            return member_details;
            search_cmd.Dispose();
            conn.Close();
        }

        public bool UpdateMemberDetails(int memid, string fname, string sname, string com_addr, string email, string mobile, string nic_no)
        {
            //conn.Open();
            try
            {
                SqlCeCommand update_cmd = new SqlCeCommand("update Member_Details set fname = '" + fname + "',lname = '" + sname + "',address = '" + com_addr + "',email = '" + email + "',mobile = '" + mobile + "',nic_no = '" + nic_no + "' where member_id = '" + memid + "'", conn);

                update_cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;

            conn.Close();
        }

        public bool DeleteUser(int memid)
        {
            //conn.Open();
            try
            {
                SqlCeCommand delete_cmd = new SqlCeCommand("delete from Member_Details where member_id = '" + memid + "'", conn);

                delete_cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public int GetIndex()
        {
            int index;
            int index_no = 0;

            try
            {
                conn.Open();

                SqlCeCommand get_index = new SqlCeCommand("select max(member_id) from Member_Details", conn);
                SqlCeDataReader sdr = get_index.ExecuteReader();

                while (sdr.Read())
                {
                    index = Convert.ToInt32(sdr[0]); ;
                    index_no = 0 + index;
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return index_no + 1;
        }

        public bool MakeRent(int member_id, int quen_books, int[] book_id)
        {
            try
            {
                conn.Open();
                SqlCeCommand rent_details_cmd = new SqlCeCommand("insert into Rent_Details (member_id,no_of_books,book_1,book_2,book_3) values (@member_id,@quen_books,@book_1,@book_2,@book_3)", conn);

                rent_details_cmd.Parameters.Add("@member_id", member_id);
                rent_details_cmd.Parameters.Add("@quen_books", quen_books);
                rent_details_cmd.Parameters.Add("@book_1", book_id[0]);
                rent_details_cmd.Parameters.Add("@book_2", book_id[1]);
                rent_details_cmd.Parameters.Add("@book_3", book_id[3]);

                rent_details_cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public int[] GetRent_Details(int member_id)
        {
            conn.Close();
            conn.Open();
            int[] rent_details = new int[5];
            SqlCeCommand getrent_details = new SqlCeCommand("select * from Rent_Details where member_id = '" + member_id + "'" ,conn);

            SqlCeDataReader sdr = getrent_details.ExecuteReader();

            while(sdr.Read())
            {
                rent_details[0] = Convert.ToInt32(sdr[0]);
                rent_details[1] = Convert.ToInt32(sdr[1]);
                rent_details[2] = Convert.ToInt32(sdr[2]);
                rent_details[3] = Convert.ToInt32(sdr[3]);
                rent_details[4] = Convert.ToInt32(sdr[4]);
            }

            return rent_details;
        }

        public void DeleteRent(int mem_id)
        {
            SqlCeCommand delete_cmd = new SqlCeCommand("delete from Rent_Details where member_id = '" + mem_id + "'" ,conn);

            delete_cmd.ExecuteNonQuery();
        }

        public bool BookRegister(int sup_id, string isbn_no, string book_cat, string bookname, string authour_name)
        {
            try
            {
                conn.Open();
                SqlCeCommand insert_cmd = new SqlCeCommand("insert into Book_Details (isbn_no,book_category,sup_id,book_name,authur_name) values (@isbn_no,@book_category,@sup_id,@book_name,@auth_name)", conn);

                insert_cmd.Parameters.Add("@isbn_no", isbn_no);
                insert_cmd.Parameters.Add("@book_category", book_cat);
                insert_cmd.Parameters.Add("@sup_id", sup_id);
                insert_cmd.Parameters.Add("@book_name", bookname);
                insert_cmd.Parameters.Add("@auth_name", authour_name);

                insert_cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public string[] GetBookDetails(int isbn_no)
        {
            conn.Close();
            conn.Open();
            string[] book_details = new string[5];

            SqlCeCommand get_bookdetails = new SqlCeCommand("select * from Book_Details where isbn_no = '" + isbn_no + "'" ,conn);

            SqlCeDataReader sdr = get_bookdetails.ExecuteReader();

            while(sdr.Read())
            {
                book_details[0] = Convert.ToString(sdr[0]);
                book_details[1] = Convert.ToString(sdr[1]);
                book_details[2] = Convert.ToString(sdr[2]);
                book_details[3] = Convert.ToString(sdr[3]);
                book_details[4] = Convert.ToString(sdr[4]);
            }

            return book_details;
        }

        public bool DeleteBookDetails(int isbn_no)
        {
            try
            {
                //conn.Open();
                SqlCeCommand deletebook_details = new SqlCeCommand("delete from Book_Details where isbn_no = '" + isbn_no + "'", conn);

                deletebook_details.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool RegisterSupplier(int supid, string sname,string fname, string address, string mobile, string email)
        {
            try
            {
                conn.Open();
                SqlCeCommand insert_cmd = new SqlCeCommand("insert into Supplier_Details (sup_id,fname,sname,address,mobile,email) values (@sup_id,@fname,@sname,@address,@mobile,@email)", conn);

                insert_cmd.Parameters.Add("@sup_id", supid);
                insert_cmd.Parameters.Add("@fname", fname);
                insert_cmd.Parameters.Add("@sname", sname);
                insert_cmd.Parameters.Add("@address", address);
                insert_cmd.Parameters.Add("@mobile", mobile);
                insert_cmd.Parameters.Add("@email", email);

                insert_cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public string [] GetSupplierDetails(int sup_id)
        {
            conn.Close();
            conn.Open();
            string[] sup_details = new string[6];

            SqlCeCommand getsup_details = new SqlCeCommand("select * from Supplier_Details where sup_id = '" + sup_id + "'" ,conn);
            SqlCeDataReader sdr = getsup_details.ExecuteReader();

            while(sdr.Read())
            {
                sup_details[0] = Convert.ToString(sdr[0].ToString());
                sup_details[1] = Convert.ToString(sdr[1].ToString());
                sup_details[2] = Convert.ToString(sdr[2].ToString());
                sup_details[3] = Convert.ToString(sdr[3].ToString());
                sup_details[4] = Convert.ToString(sdr[4].ToString());
                sup_details[5] = Convert.ToString(sdr[5].ToString());
            }

            return sup_details;
        }

        public bool UpdateSupplieDetails(int supid, string fname, string sname, string address, string mobile, string email)
        {
            try
            {
                //conn.Open();
                SqlCeCommand update_cmd = new SqlCeCommand("update Supplier_Details set fname = '" + fname + "',sname = '" + sname + "',address='" + address + "',mobile='" + mobile + "',email = '" + email + "' where sup_id = '" + supid + "'", conn);

                update_cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        int indexNo;

        public int GetSupplierIndex()
        {
            conn.Open();
            SqlCeCommand getmax = new SqlCeCommand("select max(sup_id) from Supplier_Details" ,conn);
            SqlCeDataReader sdr = getmax.ExecuteReader();

            while(sdr.Read())
            {
                indexNo = Convert.ToInt32(sdr[0]);
            }

            return indexNo + 1;
        }

        public bool DeleteSupplierDetails(int supid)
        {
            try
            {
                //conn.Open();
                SqlCeCommand delete_cmd = new SqlCeCommand("delete from Supplier_Details where sup_id = '" + supid + "'", conn);

                delete_cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
