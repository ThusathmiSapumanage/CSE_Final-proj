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

namespace HR
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        string user;
        string pwd;
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;

        private void Form7_Load(object sender, EventArgs e)
        {

            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from employee_signin where e_id=@UN and password=@PWD", con);
            user = textBox1.Text;
            pwd = textBox2.Text;
            cmd.Parameters.AddWithValue("UN", user);
            cmd.Parameters.AddWithValue("PWD", pwd);
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {

                    MessageBox.Show("Welcome!", "Login Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dr.Close();
                con.Close();

                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
