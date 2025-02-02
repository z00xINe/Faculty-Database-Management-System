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
using System.Xml.Linq;

namespace FacultyManagementSystem
{
    public partial class Form13 : Form
    {
        static String sql = "Data Source=DESKTOP-MNOPKLE\\SQLEXPRESS;Initial Catalog=FormDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection(sql);
        string _id;
        string _Fname;
        string _Lname;
        string _password;
        string code;
        public Form13(string userid)
        {
            _id = userid;
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            GetInfo();
            Title.Text = "Welecome " + _Fname + " " + _Lname;
            label3.Text = code;
        }
        public void GetInfo()
        {
            con.Open();
            string query = "SELECT first_name, second_name, password,depart_code FROM staff WHERE staff_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                _Fname = reader["first_name"].ToString();
                _Lname = reader["second_name"].ToString();
                _password = reader["password"].ToString();
                code = reader["depart_code"].ToString();
            }

            reader.Close();
            con.Close();
        }


        private void Edit_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 frm = new Form14(_Fname, _Lname, _id, _password);
            frm.Show();
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
