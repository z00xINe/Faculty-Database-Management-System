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
    public partial class Courses : UserControl
    {
        private readonly string connectionString = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        public Courses()
        {
            InitializeComponent();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            dg.DataSource = LoadUserTable();
            dataGridView1.DataSource = LoadUserTable1();
        }
        private DataTable LoadUserTable()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM course ";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                return dt;
            }
        }

        private DataTable LoadUserTable1()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                string query = "SELECT course.course_name, COUNT(stud_courses.stud_id) AS student_number " +
                               "FROM course " +
                               "LEFT JOIN stud_courses ON course.course_code = stud_courses.course_code " +
                               "GROUP BY course.course_name " +
                               "ORDER BY student_number";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "insert into course values (@code,@name,null,@id)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", ID.Text.Trim());
                cmd.Parameters.AddWithValue("@code", Code.Text.Trim());
                cmd.Parameters.AddWithValue("@name", Name.Text.Trim());
                cmd.ExecuteNonQuery();
                if (REQ.Text != "")
                {
                    string q = "Update course set course_req = @req where course_code = @code";
                    SqlCommand cmd2 = new SqlCommand(q, con);
                    cmd2.Parameters.AddWithValue("@req", REQ.Text.Trim());
                    cmd2.Parameters.AddWithValue("@code", Code.Text.Trim());
                    cmd2.ExecuteNonQuery();
                }
                con.Close();
                dg.DataSource = LoadUserTable();
                dataGridView1.DataSource = LoadUserTable1();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
