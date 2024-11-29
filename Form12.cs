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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand com;
        int anum;
        string aname;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            anum = Convert.ToInt32(comboBox1.Text);
            aname = comboBox2.Text;
            com = new SqlCommand("Delete from admin where ad_id=@anum", con);
            com.Parameters.AddWithValue("anum", anum);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox1.Text = "";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fprojectDataSet5.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.fprojectDataSet5.admin);
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
