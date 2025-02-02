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
    public partial class Student : UserControl
    {
        static String query = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(query);
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadUserTable();
            dataGridView2.DataSource = LoadUserTable1();
        }
        private DataTable LoadUserTable1()
        {

            DataTable dt = new DataTable();
            string query = "SELECT * FROM student";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        private DataTable LoadUserTable()
        {

            DataTable dt = new DataTable();
            string query = "select student.stud_id,stud_courses.course_code, stud_courses.grade from student,stud_courses where student.stud_id = stud_courses.stud_id";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "insert into stud_courses (stud_id,course_code) values (@id,@code)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", Id.Text.Trim());
            cmd.Parameters.AddWithValue("@code", Code.Text.Trim());
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = LoadUserTable();
            dataGridView2.DataSource = LoadUserTable1();
            MessageBox.Show("Done");
        }
    }
}
