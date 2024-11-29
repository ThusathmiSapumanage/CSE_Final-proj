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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        int Enum;
        float BasicSalary;
        int leaves;
        int OTH;
        float Bonus;
        float MonthlySalary;

        private void Form10_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-1B0VOOB\\TEW_SQLEXPRESS;Initial Catalog=HR;integrated security=true";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Enum = Convert.ToInt32(textBox1.Text);
            cmd = new SqlCommand("select Ename from Employee where Enumb=@num", con);
            cmd.Parameters.AddWithValue("num", Enum);
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    textBox2.Text = dr.GetString(1);


                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Invalid Employee Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
                con.Close();
            }

            leaves = Convert.ToInt32(textBox4.Text);
            if (radioButton1.Checked == true)
            {
                BasicSalary = 2000 * (30 - leaves);
                label7.Text = BasicSalary + "RS";
            }
            else
            {
                BasicSalary = 1500 * (30 - leaves);
                label7.Text = BasicSalary + "rs";
            }

            OTH = Convert.ToInt32(textBox3.Text);
            if (radioButton1.Checked == true)
            {
                Bonus = OTH * 1000;
                label8.Text = Bonus + "  Rs";
            }
            else
            {
                Bonus = 500 * OTH;
                label8.Text = Bonus + "  Rs";
            }

            MonthlySalary = Bonus + BasicSalary;
            label10.Text = MonthlySalary + "  Rs";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("Insert into payroll values (@Enum,@OvertimeHours, @Bsalary, @Bns,@NetSalary)", con);

            cmd.Parameters.AddWithValue("Enum", Enum);
            cmd.Parameters.AddWithValue("OvertimeHours", OTH);
            cmd.Parameters.AddWithValue("Bsalary", BasicSalary);
            cmd.Parameters.AddWithValue("Bns", Bonus);
            cmd.Parameters.AddWithValue("NetSalary", MonthlySalary);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted-Congrtaulations!!!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
