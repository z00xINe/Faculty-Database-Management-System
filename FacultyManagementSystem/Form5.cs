using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace FacultyManagementSystem
{
    public partial class Form5 : Form
    {
        static String sql = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                con.Open();
                string query = "INSERT INTO professor(prof_id,first_name,second_name,prof_email,prof_pass) VALUES (@ID,@FName,@LName,@Email,@Password)";
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
            string query = "SELECT COUNT(*) FROM professor WHERE prof_id = @ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count > 0;
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
