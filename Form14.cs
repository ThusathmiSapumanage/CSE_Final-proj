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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand com;
        int Enum;
        string name;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Enum = Convert.ToInt32(comboBox2.Text);
            name = comboBox1.Text;
            com = new SqlCommand("Delete from employee where e_id=@enum", con);
            com.Parameters.AddWithValue("enum", Enum);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fprojectDataSet6.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.fprojectDataSet6.employee);
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
