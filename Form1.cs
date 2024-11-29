using Microsoft.Win32.SafeHandles;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand com;
        public SqlDataReader datar;

        string batch, p_n;
        int e_id;

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            e_id = Convert.ToInt32(comboBox3.Text);
            batch = comboBox2.Text;
            p_n = comboBox1.Text;
            com = new SqlCommand("update employee set batch = @batch, pro_now = @pn where e_id = @eid", con);
            com.Parameters.AddWithValue("batch", batch);
            com.Parameters.AddWithValue("pn", p_n);
            com.Parameters.AddWithValue("eid", e_id);
            com.ExecuteNonQuery();
            MessageBox.Show("Record updated !", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            e_id = Convert.ToInt32(comboBox3.Text);
            com = new SqlCommand("Select batch, pro_now from employee where e_id = @e_id", con);
            com.Parameters.AddWithValue("e_id", e_id);
            datar = com.ExecuteReader();
            if (datar.HasRows == true)
            {
                while(datar.Read())
                {
                    comboBox2.Text = datar.GetString(0);
                    comboBox1.Text = datar.GetString(1);
                }
                datar.Close();
            }
            else
            {
                MessageBox.Show("Invalid request ! Check request and try again !", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            datar.Close();
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fprojectDataSet4.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.fprojectDataSet4.employee);
            // TODO: This line of code loads data into the 'fprojectDataSet3.positoins_av' table. You can move, or remove it, as needed.
            this.positoins_avTableAdapter.Fill(this.fprojectDataSet3.positoins_av);
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }
    }
}
