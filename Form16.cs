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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd; 
        
        string name, batch, position, contact;
        int e_id;
        float salary;

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fprojectDataSet11.positoins_av' table. You can move, or remove it, as needed.
            this.positoins_avTableAdapter.Fill(this.fprojectDataSet11.positoins_av);
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            e_id = Convert.ToInt32(textBox2.Text);
            batch = comboBox1.Text;
            contact = textBox5.Text;
            name = textBox1.Text;
            position = comboBox2.Text;
            salary = Convert.ToSingle(textBox7.Text);

            cmd = new SqlCommand("Insert into employee values(@e_id, @name, @pos, @salary, @contact, @batch)", con);

            cmd.Parameters.AddWithValue("e_id", e_id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("batch", batch);
            cmd.Parameters.AddWithValue("contact", contact);
            cmd.Parameters.AddWithValue("pos", position);
            cmd.Parameters.AddWithValue("salary", salary);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted - Congratulations!!!", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
