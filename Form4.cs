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

namespace HR
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;
        string password;
        int e_id;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            e_id = Convert.ToInt32(textBox2.Text);
            password = textBox3.Text;

            cmd = new SqlCommand("INSERT INTO [employee_signin] (password, e_id) VALUES (@password, @e_id)", con);

            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("e_id", e_id);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted - Congratulations!!!", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            int e_id = Convert.ToInt32(textBox2.Text);
            cmd = new SqlCommand("DELETE FROM employee_signin WHERE e_id = @e_id", con);
            cmd.Parameters.AddWithValue("e_id", e_id);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
