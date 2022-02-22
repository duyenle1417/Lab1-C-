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
    public partial class Lab01_Bai3 : Form
    {
        public Lab01_Bai3()
        {
            InitializeComponent();
        }

        
        //nut Chuyen doi
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            //khai bao bien
            string s1Text = textBox1.Text;
            double money1 = double.Parse(s1Text);
            if (money1 >= 0)
            {
                double money2 = 0;
                //lay menh gia tien ban dau muon chuyen
                string selectedItem1 = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                string selectedItem2 = comboBox1.Items[comboBox2.SelectedIndex].ToString();
                //chuyen menh gia tien sang VND
                if(selectedItem2=="VND (Việt Nam Đồng)")
                {
                    switch (selectedItem1)
                    {
                        case "USD (Đô-la Mỹ)":
                            money2 = money1 * 22.772;
                            break;
                        case "EUR (Euro)":
                            money2 = money1 * 28.132;
                            break;
                        case "GBP (Bảng Anh)":
                            money2 = money1 * 31.538;
                            break;
                        case "SGD (Đô-la Singapore)":
                            money2 = money1 * 17.286;
                            break;
                        case "JPY (Yên Nhật)":
                            money2 = money1 * 214;
                            break;
                        default:
                            money2 = money1;
                            break;
                    }
                }
                else if (selectedItem2 == "USD (Đô-la Mỹ)")
                {
                    switch (selectedItem1)
                    {
                        case "VND (Việt Nam Đồng)":
                            money2 = money1 / 22.772;
                            break;
                        case "EUR (Euro)":
                            money2 = money1 * 28.132 / 22.772;
                            break;
                        case "GBP (Bảng Anh)":
                            money2 = money1 * 31.538 / 22.772;
                            break;
                        case "SGD (Đô-la Singapore)":
                            money2 = money1 * 17.286 / 22.772;
                            break;
                        case "JPY (Yên Nhật)":
                            money2 = money1 * 214 / 22.772;
                            break;
                        default:
                            money2 = money1;
                            break;
                    }
                }
                else if (selectedItem2 == "EUR (Euro)")
                {
                    switch (selectedItem1)
                    {
                        case "VND (Việt Nam Đồng)":
                            money2 = money1 / 28.132;
                            break;
                        case "USD (Đô-la Mỹ)":
                            money2 = money1 * 22.772 / 28.132;
                            break;
                        case "GBP (Bảng Anh)":
                            money2 = money1 * 31.538 / 28.132;
                            break;
                        case "SGD (Đô-la Singapore)":
                            money2 = money1 * 17.286 / 28.132;
                            break;
                        case "JPY (Yên Nhật)":
                            money2 = money1 * 214 / 28.132;
                            break;
                        default:
                            money2 = money1;
                            break;
                    }
                }
                else if (selectedItem2 == "GBP (Bảng Anh)")
                {
                    switch (selectedItem1)
                    {
                        case "VND (Việt Nam Đồng)":
                            money2 = money1 / 31.538;
                            break;
                        case "EUR (Euro)":
                            money2 = money1 * 28.132 / 31.538;
                            break;
                        case "USD (Đô-la Mỹ)":
                            money2 = money1 * 22.772 / 31.538;
                            break;
                        case "SGD (Đô-la Singapore)":
                            money2 = money1 * 17.286 / 31.538;
                            break;
                        case "JPY (Yên Nhật)":
                            money2 = money1 * 214 / 31.538;
                            break;
                        default:
                            money2 = money1;
                            break;
                    }
                }
                else if (selectedItem2 == "SGD (Đô-la Singapore)")
                {
                    switch (selectedItem1)
                    {
                        case "VND (Việt Nam Đồng)":
                            money2 = money1 / 17.286;
                            break;
                        case "EUR (Euro)":
                            money2 = money1 * 28.132 / 17.286;
                            break;
                        case "GBP (Bảng Anh)":
                            money2 = money1 * 31.538 / 17.286;
                            break;
                        case "USD (Đô-la Mỹ)":
                            money2 = money1 * 22.772 / 17.286;
                            break;
                        case "JPY (Yên Nhật)":
                            money2 = money1 * 214 / 17.286;
                            break;
                        default:
                            money2 = money1;
                            break;
                    }
                }
                else
                {
                    switch (selectedItem1)
                    {
                        case "VND (Việt Nam Đồng)":
                            money2 = money1 / 214;
                            break;
                        case "EUR (Euro)":
                            money2 = money1 * 28.132 / 214;
                            break;
                        case "GBP (Bảng Anh)":
                            money2 = money1 * 31.538 / 214;
                            break;
                        case "USD (Đô-la Mỹ)":
                            money2 = money1 * 22.772 / 214;
                            break;
                        case "SGD (Đô-la Singapore)":
                            money2 = money1 * 17.286 / 214;
                            break;
                        default:
                            money2 = money1;
                            break;
                    }
                }

                //xuat ket qua
                textBox2.Text = money2.ToString();
            }
            else
                textBox2.Text = "Lỗi!";
        }
        //nut Thoat
        private void button2_Click(object sender, EventArgs e)
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
