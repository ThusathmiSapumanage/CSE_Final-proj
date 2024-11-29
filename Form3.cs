using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HR
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand com;

        int e_id, dt;

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fprojectDataSet7.leave' table. You can move, or remove it, as needed.
            this.leaveTableAdapter.Fill(this.fprojectDataSet7.leave);
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            e_id = Convert.ToInt32(comboBox1.Text);
            dt = Convert.ToInt32(textBox2.Text);
            com = new SqlCommand("update leave set d_taken = @dt where e_id = @eid", con);
            com.Parameters.AddWithValue("eid", e_id);
            com.Parameters.AddWithValue("dt", dt);
            com.ExecuteNonQuery();
            MessageBox.Show("Record updated !", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}
