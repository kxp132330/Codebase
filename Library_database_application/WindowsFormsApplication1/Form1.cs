using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["LIB"].ToString()))
                {
                    string bookid = string.Empty;
                    string title = string.Empty;
                    string authorname = string.Empty;

                    string sqlQuery = string.Empty;

                    bookid = bookiduser.Text;
                    title = titleuser.Text;
                    authorname = authornameuser.Text;

                    if (!(bookid.Equals(string.Empty)) || !(title.Equals(string.Empty)) || !(authorname.Equals(string.Empty)))
                        sqlQuery = "SELECT B.book_id,B.title,BA.author_name, LB.branch_name,LB.branch_id, BC.no_of_copies AS total_avail, (BC.no_of_copies-COUNT(BL.book_id)) AS current_avail FROM book B INNER JOIN book_copies BC ON B.book_id=BC.book_id INNER JOIN book_authors BA ON B.book_id = BA.book_id INNER JOIN library_branch LB ON LB.branch_id=BC.branch_id LEFT OUTER JOIN book_loans BL ON BL.book_id=B.book_id AND BL.branch_id=LB.branch_id where B.book_id Like'%" + bookid + "%' and B.title like '%" + title + "%'  AND BA.author_name like '%" + authorname + "%' GROUP BY B.title,LB.branch_name;";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = new MySqlCommand(sqlQuery, con);
                    DataSet dsGroupDetails = new DataSet();
                    DataTable dtGrpDetails = new DataTable();
                    adapter.Fill(dsGroupDetails);
                    dtGrpDetails = dsGroupDetails.Tables[0];
                    displaysearch.DataSource = dtGrpDetails;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["LIB"].ToString()))
                {
                    DataSet dsGroupDetails = new DataSet();
                    DataTable dtGrpDetails = new DataTable();
                    string outbookid = string.Empty;
                    string outbranchid = string.Empty;
                    string outcardno = string.Empty;

                    string test = string.Empty;
                    int checkbookid = 0;
                    Int32 checkcardno = 0;
                    Int32 checkloansno = 0;

                    string query1 = string.Empty;
                    string query2 = string.Empty;
                    string query3 = string.Empty;

                    outbookid = bookiduserbox.Text;
                    outbranchid = branchiduserbox.Text;
                    outcardno = cardnouserbox.Text;

                    query2 = "select count(*) from book_loans where card_no='" + outcardno + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query2, con);
                    con.Open();
                    checkcardno = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

                    if (checkcardno >= 3)
                    {
                        checkoutlabel.Text = "Maximum Book_loans limit reached for the given Borrower";
                    }
                    else
                    {
                        using (MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["LIB"].ToString()))
                        {
                            query3 = "select (bc.No_of_Copies- (select count(*) from book_loans as bl  where bl.book_id='" + outbookid + "' and bl.branch_id='" + outbranchid + "')) as avaialble from book_copies as bc where bc.book_id='" + outbookid + "' and bc.branch_id='" + outbranchid + "';";


                            MySqlCommand cmd2 = new MySqlCommand(query3, con1);
                            con1.Open();
                            checkloansno = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                            if (checkloansno <= 0)
                            {
                                checkoutlabel.Text = "No more book copies available";
                            }

                            else
                            {
                                using (MySqlConnection con2 = new MySqlConnection(ConfigurationManager.ConnectionStrings["LIB"].ToString()))
                                {
                                    query1 = "Insert into book_loans values ('" + outbookid + "','" + outbranchid + "', '" + outcardno + "',CURDATE(),CURDATE()+14);";
                                    MySqlCommand cmd = new MySqlCommand(query1, con2);
                                    con2.Open();
                                    checkbookid = cmd.ExecuteNonQuery();
                                    if (checkbookid > 0)
                                    {
                                        checkoutlabel.Text = "Added Book_loan Successfully";
                                    }



                                    else
                                    {
                                        checkoutlabel.Text = "Not Added Book_loan Successfully";
                                    }
                                }//con2 terminated
                            }
                        }//con1 terminated
                    }
                }//end of con
            }
            catch (Exception ex)
            {
                checkoutlabel.Text = ex.Message.ToString();
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displaysearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void inbutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["LIB"].ToString()))
                {
                    DataSet dsGroupDetails = new DataSet();
                    DataTable dtGrpDetails = new DataTable();
                    string checkinbookid = string.Empty;
                    string checkincardno = string.Empty;
                    string checkinborrower = string.Empty;
                    string command1 = string.Empty;
                    string command2 = string.Empty;
                    string command3 = string.Empty;
                    checkinbookid = inbookidtext.Text;
                    checkincardno = incardnotext.Text;
                    checkinborrower = inborrowertext.Text;
                    if (!(checkinbookid.Equals(string.Empty)))
                    {
                        command2 = "select * from book_loans where book_id='" + checkinbookid + "'";
                    }
                    else if (!(checkincardno.Equals(string.Empty)))
                    {
                        command2 = "select * from book_loans where card_no='" + checkincardno + "'";
                    }
                    else if (!(checkinborrower.Equals(string.Empty)))
                    {
                        command2 = "select * from book_loans where  exists (select * from borrower  where fname like  '%" + checkinborrower + "%');";
                    }
                    MySqlCommand cmd = new MySqlCommand(command2, con);
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = new MySqlCommand(command2, con);
                    adapter.Fill(dsGroupDetails);
                    dtGrpDetails = dsGroupDetails.Tables[0];
                    ingriddisplay.Text = "Displaying tuples from book_loans";
                    ingriddisplay.DataSource = dtGrpDetails;
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                ingriddisplay.Text = ex.Message.ToString();
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGroupDetails = new DataSet();
                DataTable dtGrpDetails = new DataTable();
                int cardNo = 0;
                string firstname = string.Empty;
                string lastname = string.Empty;
                string address = string.Empty;
                string phone = string.Empty;
                firstname = borrowerfirstname.Text;
                lastname = borrowerlastname.Text;
                address = borroweraddress.Text;
                phone = borrowerphone.Text;
                string command1 = string.Empty;
                string command2 = string.Empty;
                string command3 = string.Empty;
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["LIB"].ToString()))
                {
                    if (!(firstname.Equals(String.Empty) || !(address.Equals(String.Empty) || !(lastname.Equals(String.Empty)))))
                    {
                        command1 = "select count(*) from borrower where fname='" + firstname + "' and lname='" + lastname + "' and address='" + address + "';";
                    }
                    else
                    {
                        borrowerlabel.ForeColor = Color.Red;
                        borrowerlabel.Text = "Please fill all the details";
                    }

                    MySqlCommand cmd1 = new MySqlCommand(command1, con);
                    con.Open();
                    int BorrowerCount = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                    if (BorrowerCount != 0)
                    {
                        borrowerlabel.ForeColor = Color.Red;
                        borrowerlabel.Text = "Another person with same details already exists";
                    }
                    else
                    {
                        using (MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["LIB"].ToString()))
                        {
                            using (MySqlConnection con3 = new MySqlConnection(ConfigurationManager.ConnectionStrings["LIB"].ToString()))
                            {
                                command3 = "select max(card_no) from borrower";
                                MySqlCommand cmd2 = new MySqlCommand(command3, con3);
                                con3.Open();
                                cardNo = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                                cardNo = cardNo + 1;
                            }

                            if (!(firstname.Equals(String.Empty) || !(address.Equals(String.Empty) || !(lastname.Equals(String.Empty)))))
                            {
                                command1 = "Insert into borrower(card_no,fname,lname,address,phone) values ('" + cardNo + "','" + firstname + "','" + lastname + "','" + address + "','" + phone + "') ;";
                            }
                            else
                            {
                                borrowerlabel.ForeColor = Color.Red;
                                borrowerlabel.Text = "Please fill all the details";
                            }
                            MySqlCommand cmd = new MySqlCommand(command1, con1);
                            con1.Open();
                            Int32 Barrowercreated = cmd.ExecuteNonQuery();
                            if (Barrowercreated > 0)
                            {
                                borrowerlabel.ForeColor = Color.Green;
                                borrowerlabel.Text = "New account created for the borrower and his card no. is :-" + cardNo;

                            }
                            else
                            {
                                borrowerlabel.ForeColor = Color.Red;
                                borrowerlabel.Text = "Unable to add this borrower to the system. Please try again";

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                borrowerlabel.Text = ex.Message.ToString();
            }
        }
        private void borrowerlabel_Click(object sender, EventArgs e)
        {
        }

        private void borrowerphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void indelbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsGroupDetails = new DataSet();
                DataTable dtGrpDetails = new DataTable();
                string bookId = string.Empty;
                int branchId = 0; 
                string cardNo = string.Empty;
                string DateOut = string.Empty;
                string DueDate = string.Empty;
                int result = 0;
                 cardNo = ingriddisplay.SelectedRows[0].Cells[2].Value.ToString();
                bookId = ingriddisplay.SelectedRows[0].Cells[0].Value.ToString();
                branchId = Convert.ToInt32(ingriddisplay.SelectedRows[0].Cells[1].Value.ToString());
                DateOut = (Convert.ToDateTime(ingriddisplay.SelectedRows[0].Cells[3].Value.ToString())).Date.ToShortDateString();
                DueDate = (Convert.ToDateTime(ingriddisplay.SelectedRows[0].Cells[4].Value.ToString())).Date.ToShortDateString();
                if (!(cardNo.Equals(String.Empty) || !(bookId.Equals(String.Empty) || !(branchId.Equals(String.Empty)))))
                {
                    checkinlabel.ForeColor = Color.Red;
                    checkinlabel.Text = "Nothing to check in here";
                }

                 using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["LIB"].ToString()))
                {
                    string sqlQuery = string.Empty;
                    sqlQuery = "Delete from book_loans where book_id = '" + bookId + "' and branch_id= '" + branchId + "'and card_no='" + cardNo + "';";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    con.Open();
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        checkinlabel.ForeColor = Color.Green;
                        checkinlabel.Text = "Bookloan got checked in successfully";

                    }
                    else
                    {
                        checkinlabel.ForeColor = Color.Red;
                        checkinlabel.Text = "checking in of your borrowed book failed  ";

                    }
                }
            }
            catch (Exception ex)
            {

                checkinlabel.Text = ex.Message.ToString();
            }
        }

        private void bookiduserbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrowerfirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

