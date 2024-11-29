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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HR
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        float BasicSalary;
        int leaves;
        int OTH;
        float Bonus;
        float MonthlySalary;
        int e_id;


        private void button1_Click(object sender, EventArgs e)
        {
            leaves = Convert.ToInt32(textBox4.Text);
            OTH = Convert.ToInt32(textBox3.Text);
            if (radioButton1.Checked)
            {
                BasicSalary = 2000 * (30 - leaves);
                Bonus = OTH * 1000;
                MonthlySalary = Bonus + BasicSalary;
                label7.Text = BasicSalary + " LKR";
                label8.Text = Bonus + "LKR";
                label10.Text = MonthlySalary + " LKR";

            }
            else
            {
                BasicSalary = 1000 * (30 - leaves);
                Bonus = OTH * 500;
                MonthlySalary = Bonus + BasicSalary;
                label7.Text = BasicSalary + " LKR";
                label8.Text = Bonus + "LKR";
                label10.Text = MonthlySalary + " LKR";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label7.Text = "";
            label8.Text = "";
            label10.Text = "";
            radioButton1.Checked = false; 
            radioButton2.Checked = false;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";

        }

        private void button6_Click(object sender, EventArgs e)
        {

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            e_id = Convert.ToInt32(textBox5.Text);
            cmd = new SqlCommand("UPDATE employee SET salary = @salary WHERE e_id = @e_id", con);
            cmd.Parameters.AddWithValue("@salary", MonthlySalary);
            cmd.Parameters.AddWithValue("@e_id", e_id);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated - Congratulations!!!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
