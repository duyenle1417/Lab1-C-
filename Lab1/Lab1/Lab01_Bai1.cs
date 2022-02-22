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
    public partial class Lab01_Bai1 : Form
    {
        public Lab01_Bai1()
        {
            InitializeComponent();
        }
        //nut Tim
        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, maxNum, minNum;
            string s1Text = textBox1.Text;
            string s2Text = textBox2.Text;
            string s3Text = textBox3.Text;
            //chuyen kieu du lieu
            num1 = double.Parse(s1Text);
            num2 = double.Parse(s2Text);
            num3 = double.Parse(s3Text);
            //kiem tra du lieu
            if(num1==num2 && num2==num3)
            {
                //thong bao loi
                textBox6.Text = textBox6.Text + "\r\nBa số đều bằng nhau.";
                textBox6.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
                //tim so lon nhat max
                maxNum = num1;
                if (num2 > maxNum)
                {
                    maxNum = num2;
                }
                
                if (num3 > maxNum)
                {
                    maxNum = num3;
                }
                
                //tim so nho nhat min
                minNum = num1;
                if (num2 < minNum)
                {
                    minNum = num2;
                }
                
                if (num3 < minNum)
                {
                    minNum = num3;
                }
                
                //xuat ket qua
                textBox4.Text = maxNum.ToString();
                textBox5.Text = minNum.ToString();
            }
            
        }
        //nut Xoa
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Visible = false;
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
