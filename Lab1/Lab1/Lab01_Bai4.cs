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
    public partial class Lab01_Bai4 : Form
    {
        public Lab01_Bai4()
        {
            InitializeComponent();
        }

        //nut Tinh toan
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();//xoa man hinh ket qua
            //khai bao du lieu
            string s1Text = textBox1.Text;
            string s2Text = textBox2.Text;
            int numA, numB, resultS1=0, resultS2=0;
            long resultS3 = 0, resultA = 1, resultB = 1;
            //chuyen kieu du lieu string sang int
            numA = int.Parse(s1Text);
            numB = int.Parse(s2Text);
            //kiem tra du lieu
            if(numA>=0 && numB>=0)
            {
                //tinh A!
                for (int i = 1; i <= numA; i++)
                {
                    resultA *= i;
                }
                //tinh B!
                for (int i = 1; i <= numB; i++)
                {
                    resultB *= i;
                }
                //tinh  S1 = 1+2+3+4+…+A
                for (int i = 1; i <= numA; i++)
                {
                    resultS1 += i;
                }
                //tinh  S2 = 1+2+3+4+…+B
                for (int i = 1; i <= numB; i++)
                {
                    resultS2 += i;
                }
                //tinh  S3 = A^1+A^2+A^3+A^4+…+A^B
                for (int i = 1; i <= numB; i++)
                {
                    int tempInt = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        tempInt *= numA;
                    }
                    resultS3 += tempInt;
                }
                //Xuat ket qua tinh toan
                textBox3.Text = textBox3.Text + "A!= " + resultA.ToString() + "\r\nB!= " + resultB.ToString();
                textBox3.Text = textBox3.Text + Environment.NewLine + "S1 = 1+2+3+4+…+A = " + resultS1.ToString();
                textBox3.Text = textBox3.Text + Environment.NewLine + "S2 = 1+2+3+4+…+B = " + resultS2.ToString();
                textBox3.Text = textBox3.Text + Environment.NewLine + "S3 = A^1+A^2+…+A^B = " + resultS3.ToString();
            }
            else
            {
                textBox3.Text = "Lỗi! Mời bạn nhập lại.";
            }
        }
        //nut Thoat
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //nut Xoa
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
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
