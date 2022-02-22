using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Lab01_Bai1 form = new Lab01_Bai1();
            form.ShowDialog();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Lab01_Bai2 form = new Lab01_Bai2();
            form.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Lab01_Bai3 form = new Lab01_Bai3();
            form.ShowDialog();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Lab01_Bai4 form = new Lab01_Bai4();
            form.ShowDialog();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Lab01_Bai5 form = new Lab01_Bai5();
            form.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
