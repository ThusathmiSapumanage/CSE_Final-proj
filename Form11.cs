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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        int Enum;
        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            Enum = Convert.ToInt32(textBox1.Text);
            cmd = new SqlCommand("Select pnumn,mpay,bonus from payroll where enumb=@num", con);
            cmd.Parameters.AddWithValue("num", Enum);
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    textBox2.Text = dr.GetInt32(0).ToString();
                    textBox3.Text = dr.GetInt32(1).ToString();
                    textBox4.Text = dr.GetInt32(2).ToString();
                }
                dr.Close();
            }
            else
            { MessageBox.Show("Invalid Employee Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            dr.Close();
            con.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-1B0VOOB\\TEW_SQLEXPRESS;Initial Catalog=HR;integrated security=true";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
