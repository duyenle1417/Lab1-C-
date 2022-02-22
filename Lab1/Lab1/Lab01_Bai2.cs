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
    public partial class Lab01_Bai2 : Form
    {
        public Lab01_Bai2()
        {
            InitializeComponent();
        }
        //kiem tra so nhap vao va in thanh chu tuong ung
        private void ChuyenDoi(int numInt)
        {
            if (numInt > 9 || numInt < 0)
                textBox2.Text = "Lỗi! Mời bạn nhập lại.";
            else
            {
                switch (numInt)
                {
                    case 0:
                        textBox2.Text = "Không";
                        break;
                    case 1:
                        textBox2.Text = "Một";
                        break;
                    case 2:
                        textBox2.Text = "Hai";
                        break;
                    case 3:
                        textBox2.Text = "Ba";
                        break;
                    case 4:
                        textBox2.Text = "Bốn";
                        break;
                    case 5:
                        textBox2.Text = "Năm";
                        break;
                    case 6:
                        textBox2.Text = "Sáu";
                        break;
                    case 7:
                        textBox2.Text = "Bảy";
                        break;
                    case 8:
                        textBox2.Text = "Tám";
                        break;
                    case 9:
                        textBox2.Text = "Chín";
                        break;
                }
            }
        }
        //nut Chuyen doi
        private void button1_Click(object sender, EventArgs e)
        {
            string s1Text = textBox1.Text;
            int numInt = int.Parse(s1Text);
            ChuyenDoi(numInt);
        }
        //nut Xoa
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        //nut Thoat
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
