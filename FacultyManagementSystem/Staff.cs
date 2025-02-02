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
    public partial class Staff : UserControl
    {
        static String query = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(query);
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadUserTable();
        }
        private DataTable LoadUserTable()
        {

            DataTable dt = new DataTable();
            string query = "select * from staff";
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
            string q = "Update staff set depart_code = @code Where staff_id = @id";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", Id.Text.Trim());
            cmd.Parameters.AddWithValue("@code", Code.Text.Trim());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done");
            dataGridView1.DataSource = LoadUserTable();
        }
    }
}
