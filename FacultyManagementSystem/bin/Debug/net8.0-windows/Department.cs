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
    public partial class Department : UserControl
    {
        static String sql = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        public Department()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = loadusertable();
            dataGridView2.DataSource = loadusertable1();
        }
        private DataTable loadusertable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM departement";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        private DataTable loadusertable1()
        {
            DataTable dt = new DataTable();
            string query = "select departement.depart_name ,  COUNT(student.stud_id)As student_number from departement,student where departement.depart_code = student.depart_code group by departement.depart_name";
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
            string q = "insert into departement values(@code,@name,@id)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", ID.Text.Trim());
            cmd.Parameters.AddWithValue("@name", Name.Text.Trim());
            cmd.Parameters.AddWithValue("@code", Code.Text.Trim());
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = loadusertable();
            dataGridView2.DataSource = loadusertable1();
        }
    }
}
