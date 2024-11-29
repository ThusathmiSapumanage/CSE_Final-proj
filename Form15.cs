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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.ShowDialog();
        }

        private void salaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.ShowDialog();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.ShowDialog();
        }

        private void employeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void vacationDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void promotionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void promotionsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form13= new Form13();
            form13.ShowDialog();
        }

        private void salaryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.ShowDialog();
        }

        private void vacationDaysToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vactionDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void promotionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.ShowDialog();
        }

        private void makeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void employeeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void newOpenPositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.ShowDialog();
        }

        private void positionsTakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.ShowDialog();
        }
    }
}
