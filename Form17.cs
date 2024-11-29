using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HR
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;

        string a_name, password;
        int a_id;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            a_id = Convert.ToInt32(textBox1.Text);
            a_name = textBox2.Text;
            password = textBox3.Text;

            cmd = new SqlCommand("Insert into admin values(@ad_id, @ad_name, @pass)", con);

            cmd.Parameters.AddWithValue("ad_id", a_id);
            cmd.Parameters.AddWithValue("ad_name", a_name);
            cmd.Parameters.AddWithValue("pass", password);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted - Congratulations!!!", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
        }
    }
}
