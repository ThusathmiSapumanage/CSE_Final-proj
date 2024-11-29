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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand com;

        int e_id, l_id, d_g, d_t;
        string type;

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            int l_id = Convert.ToInt32(textBox1.Text);
            com = new SqlCommand("DELETE FROM [leave] WHERE l_id = @l_id", con);
            com.Parameters.AddWithValue("@l_id", l_id);
            com.ExecuteNonQuery();

            MessageBox.Show("Record Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            l_id = Convert.ToInt32(textBox1.Text);
            type = comboBox2.Text;
            d_g = Convert.ToInt32(textBox4.Text);
            d_t = Convert.ToInt32(textBox3.Text);
            e_id = Convert.ToInt32(comboBox1.Text);
            if (d_t > d_g)
            {
                MessageBox.Show("Record invalid, please check days taken again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                com = new SqlCommand("INSERT INTO [leave] (l_id, type, d_given, d_taken, e_id) VALUES (@l_id, @type, @d_given, @d_taken, @e_id)", con);

                com.Parameters.AddWithValue("l_id", l_id);
                com.Parameters.AddWithValue("e_id", e_id);
                com.Parameters.AddWithValue("type", type);
                com.Parameters.AddWithValue("d_given", d_g);
                com.Parameters.AddWithValue("d_taken", d_t);

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted-Congratulations!!!", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fprojectDataSet9.leave' table. You can move, or remove it, as needed.
            this.leaveTableAdapter.Fill(this.fprojectDataSet9.leave);
            // TODO: This line of code loads data into the 'fprojectDataSet8.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.fprojectDataSet8.employee);
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}
