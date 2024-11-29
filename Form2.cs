using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fprojectDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter2.Fill(this.fprojectDataSet2.employee);
            // TODO: This line of code loads data into the 'fprojectDataSet1.leave' table. You can move, or remove it, as needed.
            this.leaveTableAdapter1.Fill(this.fprojectDataSet1.leave);
            // TODO: This line of code loads data into the 'fprojectDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.fprojectDataSet.employee);
            // TODO: This line of code loads data into the 'fPDataSet3.Promotion' table. You can move, or remove it, as needed.
            this.promotionTableAdapter.Fill(this.fPDataSet3.Promotion);
            // TODO: This line of code loads data into the 'fPDataSet2.leave' table. You can move, or remove it, as needed.
            this.leaveTableAdapter.Fill(this.fPDataSet2.leave);
            // TODO: This line of code loads data into the 'fPDataSet1.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.fPDataSet1.employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
