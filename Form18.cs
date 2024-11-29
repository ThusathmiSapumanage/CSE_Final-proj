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
using System.Xml.Linq;

namespace HR
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand com;
        string pos;

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fprojectDataSet10.positoins_av' table. You can move, or remove it, as needed.
            this.positoins_avTableAdapter.Fill(this.fprojectDataSet10.positoins_av);
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            pos = comboBox1.Text;

            com = new SqlCommand("Insert into positoins_av values (@pos)", con);

            com.Parameters.AddWithValue("pos", pos);

            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted - Congratulations!!!", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            pos =   comboBox1.Text;
            com = new SqlCommand("DELETE FROM positoins_av WHERE positons = @pos", con);
            com.Parameters.AddWithValue("pos", pos);
            com.ExecuteNonQuery();

            MessageBox.Show("Record Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
