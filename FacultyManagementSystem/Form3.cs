using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FacultyManagementSystem
{
    public partial class Form3 : Form
    {
        static string sql = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);

        public Form3()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                con.Open();
                string query = "INSERT INTO student(stud_id, first_name, second_name, stud_email, stud_pass) VALUES (@ID, @FName, @LName, @Email, @Password)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", ID.Text);
                cmd.Parameters.AddWithValue("@FName", FName.Text);
                cmd.Parameters.AddWithValue("@LName", LName.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Saved");
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(ID.Text) || string.IsNullOrWhiteSpace(FName.Text) ||
                string.IsNullOrWhiteSpace(LName.Text) || string.IsNullOrWhiteSpace(Email.Text) ||
                string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return false;
            }

            if (!IsValidEmail(Email.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            if (IsExistingID(ID.Text))
            {
                MessageBox.Show("This ID already exists.");
                return false;
            }

            if (Password.Text.Length < 8)
            {
                MessageBox.Show("Please enter a password with at least 8 characters.");
                return false;
            }


            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsExistingID(string id)
        {
            con.Open();
            string query = "SELECT COUNT(*) FROM student WHERE stud_id = @ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count > 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
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
