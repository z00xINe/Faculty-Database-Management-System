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

namespace FacultyManagementSystem
{
    public partial class Form10 : Form
    {
        static String sql = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        string _id;
        string _Fname;
        string _Lname;
        string _email;
        string _password;
        public Form10(string userFname, string userLname, string userid, string useremail, string userpassword)
        {
            _id = userid;
            _Fname = userFname;
            _Lname = userLname;
            _email = useremail;
            _password = userpassword;
            InitializeComponent();
        }


        private void Save_Click(object sender, EventArgs e)
        {

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
            string query = "SELECT COUNT(*) FROM professor WHERE prof_id = @ID AND prof_id <> @ID2";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@ID2", _id);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count > 0;
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            ID.Text = _id;
            FName.Text = _Fname;
            LName.Text = _Lname;
            Email.Text = _email;
            Password.Text = _password;
        }
       
        private void Save_Click_1(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                con.Open();
                string qeury = "UPDATE professor SET first_name = @fname, second_name = @lname, prof_email = @email, prof_pass = @pass WHERE prof_id = @id";
                SqlCommand cmd = new SqlCommand(qeury, con);
                cmd.Parameters.AddWithValue("@id", ID.Text);
                cmd.Parameters.AddWithValue("@fname", FName.Text);
                cmd.Parameters.AddWithValue("@lname", LName.Text);
                cmd.Parameters.AddWithValue("@email", Email.Text);
                cmd.Parameters.AddWithValue("@pass", Password.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your profile updated successfuly , please sign up again");
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure?", "confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                con.Open();
                string query = "DELETE FROM prof_courses WHERE prof_id = @ID;" +
                    "DELETE FROM prof_departement WHERE prof_id = @ID;" +
                    "DELETE FROM professor WHERE prof_id = @ID;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", _id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("user deleted successfully");
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();

            }
        }

        private void show_CheckedChanged_1(object sender, EventArgs e)
        {
            Password.PasswordChar = show.Checked ? '\0' : '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm8 = new Form8(_id);
            frm8.Show();
        }
    }
}
