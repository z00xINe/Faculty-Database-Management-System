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
    public partial class Form9 : Form
    {
        static String sql = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        string _id;
        string _Fname;
        string _Lname;
        string _email;
        string _password;
        public Form9(string userFname, string userLname, string userid, string useremail, string userpassword)
        {
            _id = userid;
            _Fname = userFname;
            _Lname = userLname;
            _email = useremail;
            _password = userpassword;
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            ID.Text = _id;
            FName.Text = _Fname;
            LName.Text = _Lname;
            Email.Text = _email;
            Password.Text = _password;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                con.Open();
                string qeury = "UPDATE student SET first_name = @fname, second_name = @lname, stud_email = @email, stud_pass = @pass WHERE stud_id = @id";
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
            string query = "SELECT COUNT(*) FROM student WHERE stud_id = @ID AND stud_id <> @ID2";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@ID2", _id);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count > 0;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure?", "confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                con.Open();
                string query = "DELETE FROM stud_courses WHERE stud_id = @ID;" +
                    "DELETE FROM student WHERE stud_id = @ID;";
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

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = show.Checked ? '\0' : '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6(_id);
            frm6.Show();
        }
    }
}
