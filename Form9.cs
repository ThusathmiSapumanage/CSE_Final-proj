using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HR
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        string user;
        string pwd;
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data source = DESKTOP-NRUK56G\\SQLEXPRESS; initial catalog = Fproject; integrated security = true";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from admin where ad_id=@UN and pass=@PWD", con);
            user = textBox1.Text;
            pwd = textBox2.Text;
            cmd.Parameters.AddWithValue("UN", user);
            cmd.Parameters.AddWithValue("PWD", pwd);
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {

                    MessageBox.Show(" Welcome, Admin", "Login Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dr.Close();
                con.Close();
                Form15 form15 = new Form15();
                form15.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Close();


        }
    }
}
