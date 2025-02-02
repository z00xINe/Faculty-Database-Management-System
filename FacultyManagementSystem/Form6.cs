using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FacultyManagementSystem
{
    public partial class Form6 : Form
    {
        static String sql = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        string _id;
        string _Fname;
        string _Lname;
        string _email;
        string _password;
        string department_code;
        public Form6(string userid)
        {
            _id = userid;
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            GetInfo();
            Title.Text = "Welecome " + _Fname + " " + _Lname;
            getdepartment();
            dataGridView1.DataSource = loaduser();
        }
        public void GetInfo()
        {
            con.Open();
            string query = "SELECT first_name, second_name, stud_email, stud_pass FROM student WHERE stud_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                _Fname = reader["first_name"].ToString();
                _Lname = reader["second_name"].ToString();
                _email = reader["stud_email"].ToString();
                _password = reader["stud_pass"].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 frm9 = new Form9(_Fname, _Lname, _id, _email, _password);
            frm9.Show();

        }
        private void getdepartment()
        {
            string q = "Select * from departement";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);

            Dep.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {

                string departmentData = row["depart_code"].ToString();
                Dep.Items.Add(departmentData);
            }
            con.Close();

        }
        private void Dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            department_code = Dep.Text.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "update student set major = @code, depart_code = @code where stud_id = @id";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.Parameters.AddWithValue("@code", department_code);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = loaduser();
            MessageBox.Show("Done");
        }

        private void New_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public DataTable loaduser()
        {
            DataTable dt = new DataTable();
            con.Open();
            string q = "select stud_courses.stud_id,stud_courses.course_code,stud_courses.grade,student.major,student.depart_code from stud_courses join student on stud_courses.stud_id = student.stud_id where student.stud_id = @id";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.ExecuteNonQuery();
            con.Close();
            sda.Fill(dt);
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
