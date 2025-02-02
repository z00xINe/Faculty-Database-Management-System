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
    public partial class Form7 : Form
    {
        static String sql = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        string _id;
        string _Fname;
        string _Lname;
        string _email;
        string _password;
        public Form7(string userid)
        {
            _id = userid;
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Student.Visible = false;
            Department.Visible = false;
            Course.Visible = false;
            Staff.Visible = false;
            GetInfo();
            Title.Text = "Welecome " + _Fname + " " + _Lname;
        }
        public void GetInfo()
        {
            con.Open();
            string query = "SELECT first_name, second_name, admin_email, admin_pass FROM admin WHERE admin_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                _Fname = reader["first_name"].ToString();
                _Lname = reader["second_name"].ToString();
                _email = reader["admin_email"].ToString();
                _password = reader["admin_pass"].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student.Visible = false;
            Department.Visible = false;
            Course.Visible = true;
            Staff.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student.Visible = false;
            Department.Visible = true;
            Course.Visible = false;
            Staff.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student.Visible = true;
            Department.Visible = false;
            Course.Visible = false;
            Staff.Visible = false;

        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form11 frm11 = new Form11(_Fname, _Lname, _id, _email, _password);
            frm11.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void New_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student.Visible = false;
            Department.Visible = false;
            Course.Visible = false;
            Staff.Visible = true;
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
