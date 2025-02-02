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
    public partial class Form8 : Form
    {
        static String sql = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        string _id;
        string _Fname;
        string _Lname;
        string _email;
        string _password;
        string department_code;
        public Form8(string userid)
        {
            _id = userid;
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            GetInfo();
            Title.Text = "Welecome " + _Fname + " " + _Lname;
            getdepartment();
            dataGridView1.DataSource = LoadUserTable();

        }
        private DataTable LoadUserTable()
        {
            using (SqlConnection con = new SqlConnection(sql))
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM stud_courses";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                return dt;
            }
        }
        public void GetInfo()
        {
            con.Open();
            string query = "SELECT first_name, second_name, prof_email, prof_pass FROM professor WHERE prof_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                _Fname = reader["first_name"].ToString();
                _Lname = reader["second_name"].ToString();
                _email = reader["prof_email"].ToString();
                _password = reader["prof_pass"].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }
        private void getdepartment()
        {
            string q = "Select * from departement";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);

            dep.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {

                string departmentData = row["depart_code"].ToString();
                dep.Items.Add(departmentData);
            }
            con.Close();

        }

        private void dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            department_code = dep.Text.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "insert into prof_departement values(@id,@code)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.Parameters.AddWithValue("@code", department_code);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "update stud_courses set grade = @grade where stud_id = @id AND course_code = @code";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", ID.Text.Trim());
            cmd.Parameters.AddWithValue("@code", Code.Text.Trim());
            cmd.Parameters.AddWithValue("@grade", Grade.Text.Trim());
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = LoadUserTable();
            MessageBox.Show("Done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm10 = new Form10(_Fname, _Lname, _id, _email, _password);
            frm10.Show();
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
    }
}
