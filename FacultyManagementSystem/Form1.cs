using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FacultyManagementSystem
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string userid = ID.Text;
            string userpassword = Password.Text;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string studentQuery = "SELECT * FROM student WHERE stud_id = @id AND stud_pass = @pass";
                    SqlCommand studentCmd = new SqlCommand(studentQuery, con);
                    studentCmd.Parameters.AddWithValue("@id", userid);
                    studentCmd.Parameters.AddWithValue("@pass", userpassword);

                    string adminQuery = "SELECT * FROM admin WHERE admin_id = @id AND admin_pass = @pass";
                    SqlCommand adminCmd = new SqlCommand(adminQuery, con);
                    adminCmd.Parameters.AddWithValue("@id", userid);
                    adminCmd.Parameters.AddWithValue("@pass", userpassword);

                    string professorQuery = "SELECT * FROM professor WHERE prof_id = @id AND prof_pass = @pass";
                    SqlCommand professorCmd = new SqlCommand(professorQuery, con);
                    professorCmd.Parameters.AddWithValue("@id", userid);
                    professorCmd.Parameters.AddWithValue("@pass", userpassword);

                    string staffQuery = "SELECT * FROM staff WHERE staff_id = @id AND password = @pass";
                    SqlCommand staffCmd = new SqlCommand(staffQuery, con);
                    staffCmd.Parameters.AddWithValue("@id", userid);
                    staffCmd.Parameters.AddWithValue("@pass", userpassword);

                    DataTable dtable = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(studentCmd);
                    sda.Fill(dtable);

                    DataTable dtable2 = new DataTable();
                    SqlDataAdapter sda2 = new SqlDataAdapter(adminCmd);
                    sda2.Fill(dtable2);

                    DataTable dtable3 = new DataTable();
                    SqlDataAdapter sda3 = new SqlDataAdapter(professorCmd);
                    sda3.Fill(dtable3);

                    DataTable dtable4 = new DataTable();
                    SqlDataAdapter sda4 = new SqlDataAdapter(staffCmd);
                    sda4.Fill(dtable4);
                    if (dtable.Rows.Count > 0)
                    {
                        MessageBox.Show("Student Login Successful");
                        this.Hide();
                        Form6 frm6 = new Form6(userid);
                        frm6.Show();
                    }
                    else if (dtable2.Rows.Count > 0)
                    {
                        MessageBox.Show("Admin Login Successful");
                        this.Hide();
                        Form7 frm7 = new Form7(userid);
                        frm7.Show();
                    }
                    else if (dtable3.Rows.Count > 0)
                    {
                        MessageBox.Show("Professor Login Successful");
                        this.Hide();
                        Form8 frm8 = new Form8(userid);
                        frm8.Show();
                    }
                    else if (dtable4.Rows.Count > 0)
                    {
                        MessageBox.Show("staff Login Successful");
                        this.Hide();
                        Form13 frm8 = new Form13(userid);
                        frm8.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = show.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
