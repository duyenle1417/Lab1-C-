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
    public partial class Lab01_Bai5 : Form
    {
        public Lab01_Bai5()
        {
            InitializeComponent();
        }

        //bien toan cuc
        double num1Double = 0, num2Double = 0;//giu gia tri de tinh toan
        string dauString = " ";//kiem tra phep toan +-*/
        bool resultBool = false;//neu là true se xoa ket qua cu va lam phep tinh moi
        double resultDouble;//nut ans
        bool NangCao = false;//neu phep toan chi can co 1 gia tri là true
        //vi  mu va giai thua chi can mot gia tri tinh
        bool SoAmBool = false;//nhap so am

        private double Cong(double num1, double num2)
        {
            return num1 + num2;
        }

        private double Tru(double num1, double num2)
        {
            return num1 - num2;
        }
        private double Nhan(double num1, double num2)
        {
            return num1 * num2;
        }
        private double Chia(double num1, double num2)
        {
            return num1 / num2;
        }
        
        private double BinhPhuong(double num)
        {
            return System.Math.Pow(num, 2);
        }
        private double LapPhuong(double num)
        {
            return System.Math.Pow(num, 3);
        }
        private double GiaiThua(double num)
        {
            double result = 1;
            for (int i = 2; i <= num; i++)
                result *= i;
            return result;
        }

        private void so0_Click(object sender, EventArgs e)
        {
            //neu muon tinh toan bai moi, xoa man hinh
            if(dauString==" " && resultBool==true)
            {
                ManHinh.Clear();
                ManHinhNho.Clear();
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text;
                resultBool = false;
            }
            //nhap
            ManHinh.Text = ManHinh.Text + "0";
        }

        private void so1_Click(object sender, EventArgs e)
        {
            //neu muon tinh toan bai moi
            if (dauString == " " && resultBool == true)
            {
                ManHinh.Clear();
                ManHinhNho.Clear();
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text;
                resultBool = false;
            }
            //nhap
            ManHinh.Text = ManHinh.Text + "1";
        }

        private void so2_Click(object sender, EventArgs e)
        {
            //neu muon tinh toan bai moi
            if (dauString == " " && resultBool == true)
            {
                ManHinh.Clear();
                ManHinhNho.Clear();
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text;
                resultBool = false;
            }
            //nhap
            ManHinh.Text = ManHinh.Text + "2";
        }

        private void so3_Click(object sender, EventArgs e)
        {
            //neu muon tinh toan bai moi
            if (dauString == " " && resultBool == true)
            {
                ManHinh.Clear();
                ManHinhNho.Clear();
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text;
                resultBool = false;
            }
            //nhap
            ManHinh.Text = ManHinh.Text + "3";
        }

        private void so4_Click(object sender, EventArgs e)
        {
            //neu muon tinh toan bai moi
            if (dauString == " " && resultBool == true)
            {
                ManHinh.Clear();
                ManHinhNho.Clear();
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text;
                resultBool = false;
            }
            //nhap
            ManHinh.Text = ManHinh.Text + "4";
        }

        private void so5_Click(object sender, EventArgs e)
        {
            //neu muon tinh toan bai moi
            if (dauString == " " && resultBool == true)
            {
                ManHinh.Clear();
                ManHinhNho.Clear();
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text;
                resultBool = false;
            }
            //nhap
            ManHinh.Text = ManHinh.Text + "5";
        }

        private void so6_Click(object sender, EventArgs e)
        {
            //neu muon tinh toan bai moi
            if (dauString == " " && resultBool == true)
            {
                ManHinh.Clear();
                ManHinhNho.Clear();
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text;
                resultBool = false;
            }
            //nhap
            ManHinh.Text = ManHinh.Text + "6";
        }

        private void so7_Click(object sender, EventArgs e)
        {
            //neu muon tinh toan bai moi
            if (dauString == " " && resultBool == true)
            {
                ManHinh.Clear();
                ManHinhNho.Clear();
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text;
                resultBool = false;
            }
            //nhap
            ManHinh.Text = ManHinh.Text + "7";
        }

        private void so8_Click(object sender, EventArgs e)
        {
            //neu muon tinh toan bai moi
            if (dauString == " " && resultBool == true)
            {
                ManHinh.Clear();
                ManHinhNho.Clear();
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text;
                resultBool = false;
            }
            //nhap
            ManHinh.Text = ManHinh.Text + "8";
        }

        private void so9_Click(object sender, EventArgs e)
        {
            //neu muon tinh toan bai moi
            if (dauString == " " && resultBool == true)
            {
                ManHinh.Clear();
                ManHinhNho.Clear();
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text;
                resultBool = false;
            }
            //nhap
            ManHinh.Text = ManHinh.Text + "9";
        }

        private void cong_Click(object sender, EventArgs e)
        {
            //xoa ket qua tu phep tinh truoc
            if(resultBool==true)
            {
                ManHinhNho.Clear();
            }
            if(ManHinh.Text.Length>0)
            {
                num1Double = double.Parse(ManHinh.Text);
                dauString = cong.Text;
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + " " + dauString + " ";
                ManHinh.Clear();
                NangCao = false;//phep tinh co hai bien
                SoAmBool = false;
            }
        }

        private void tru_Click(object sender, EventArgs e)
        {
            //xoa ket qua tu phep tinh truoc
            if (resultBool == true)
            {
                ManHinhNho.Clear();
            }
            if (ManHinh.Text.Length > 0)
            {
                //luu gia tri va dau, hien thi tren man hinh nho
                dauString = tru.Text;
                num1Double = double.Parse(ManHinh.Text);
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + " " + dauString + " ";
                ManHinh.Clear();
                NangCao = false;//phep tinh co hai bien
                SoAmBool = false;
            }
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            //xoa ket qua tu phep tinh truoc
            if (resultBool == true)
            {
                ManHinhNho.Clear();
            }
            if (ManHinh.Text.Length > 0)
            {
                //luu gia tri va dau, hien thi tren man hinh nho
                dauString = nhan.Text;
                num1Double = double.Parse(ManHinh.Text);
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + " " + dauString + " ";
                ManHinh.Clear();
                NangCao = false;//phep tinh co hai bien
                SoAmBool = false;
            }
        }

        private void chia_Click(object sender, EventArgs e)
        {
            //xoa ket qua tu phep tinh truoc
            if (resultBool == true)
            {
                ManHinhNho.Clear();
            }
            if (ManHinh.Text.Length > 0)
            {
                //luu gia tri va dau, hien thi tren man hinh nho
                dauString = chia.Text;
                num1Double = double.Parse(ManHinh.Text);
                ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + " " + dauString + " ";
                ManHinh.Clear();
                NangCao = false;//phep tinh co hai bien
                SoAmBool = false;
            }
        }

        private void dau_bang_Click(object sender, EventArgs e)
        {      
            if(dauString!=" ")
            {
                if (NangCao == false)
                {
                    //luu gia tri va tinh toan
                    num2Double = double.Parse(ManHinh.Text);
                    ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + " " + dau_bang.Text + " ";
                    

                    //in ket qua
                    switch (dauString)
                    {
                        case "+":
                            ManHinh.Text = Cong(num1Double, num2Double).ToString();
                            break;
                        case "-":
                            ManHinh.Text = Tru(num1Double, num2Double).ToString();
                            break;
                        case "x":
                            ManHinh.Text = Nhan(num1Double, num2Double).ToString();
                            break;
                        case "/":
                            if (num2Double == 0)//chia cho 0 -> Loi
                                ManHinh.Text = "Error!";
                            else
                                ManHinh.Text = Chia(num1Double, num2Double).ToString();
                            break;
                    }
                }
                else
                {
                    switch (dauString)
                    {
                        case "!":
                            ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + " " + dau_bang.Text + " ";
                            int numTemp = Convert.ToInt16(num1Double);
                            //kiem tra co la so nguyen duong hay khong?
                            if (num1Double < 0 || (numTemp != num1Double))
                            {
                                ManHinh.Text = "Error!";
                                num1Double = 0;
                            }
                            else
                                ManHinh.Text = GiaiThua(num1Double).ToString();
                            break;
                        case "^2":
                            ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + " " + dau_bang.Text + " ";
                            ManHinh.Text = BinhPhuong(num1Double).ToString();
                            break;
                        case "^3":
                            ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + " " + dau_bang.Text + " ";
                            ManHinh.Text = LapPhuong(num1Double).ToString();
                            break;
                        case "sin":
                            ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + ") " + dau_bang.Text + " ";
                            num1Double = double.Parse(ManHinh.Text.Substring(4));
                            num1Double = num1Double * Math.PI / 180;
                            ManHinh.Text = Math.Sin(num1Double).ToString();
                            break;
                        case "cos":
                            ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + ") " + dau_bang.Text + " ";
                            num1Double = double.Parse(ManHinh.Text.Substring(4));
                            num1Double = num1Double * Math.PI / 180;
                            ManHinh.Text = Math.Cos(num1Double).ToString();
                            break;
                        case "tan":
                            ManHinhNho.Text = ManHinhNho.Text + ManHinh.Text + ") " + dau_bang.Text + " ";
                            num1Double = double.Parse(ManHinh.Text.Substring(4));
                            num1Double = num1Double * Math.PI / 180;
                            ManHinh.Text = Math.Tan(num1Double).ToString();
                            break;
                    }
                }
                dauString = " ";
                resultBool = true;
                SoAmBool = false;
            }
            if(ManHinh.Text!="Error!")
            {
                string sTemp = ManHinh.Text;
                resultDouble = double.Parse(sTemp);
            }
        }
        //nhap so thap phan
        private void thapphan_Click(object sender, EventArgs e)
        {
            ManHinh.Text = ManHinh.Text + ".";
        }
        //xoa man hinh
        private void xoa1_Click(object sender, EventArgs e)
        {
            ManHinhNho.Clear();
            ManHinh.Clear();
        }
        //tat may tinh
        private void off_Calculator_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //in ket qua tinh cu
        private void ans_Click(object sender, EventArgs e)
        {
            ManHinh.Text = resultDouble.ToString();
        }
        //tinh giai thua x!
        private void giai_thua_Click(object sender, EventArgs e)
        {
            if (resultBool == true)
            {
                ManHinhNho.Clear();
            }
            if (ManHinh.Text.Length > 0)
            {
                num1Double = double.Parse(ManHinh.Text);
                dauString = "!";
                ManHinh.Text = ManHinh.Text + dauString;
                NangCao = true;
                SoAmBool = false;
            }
        }
        

        private void Mu_2_Click(object sender, EventArgs e)
        {
            if (resultBool == true)
            {
                ManHinhNho.Clear();
            }
            if (ManHinh.Text.Length > 0)
            {
                dauString = "^2";
                num1Double = double.Parse(ManHinh.Text);
                ManHinh.Text = ManHinh.Text + dauString;
                NangCao = true;
                SoAmBool = false;
            }
        }

        private void Mu_3_Click(object sender, EventArgs e)
        {
            if (resultBool == true)
            {
                ManHinhNho.Clear();
            }
            if (ManHinh.Text.Length > 0)
            {
                dauString = "^3";
                num1Double = double.Parse(ManHinh.Text);
                ManHinh.Text = ManHinh.Text + dauString;
                NangCao = true;
                SoAmBool = false;
            }
        }

        //xoa ky tu cuoi cung vua nhap
        private void delete_Click(object sender, EventArgs e)
        {
            if(ManHinh.Text.Length>0)
                ManHinh.Text = ManHinh.Text.Substring(0, ManHinh.Text.Length - 1);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void SoAm_Click(object sender, EventArgs e)
        {
            //so am
            if(!SoAmBool)
            {
                if (resultBool == true)
                {
                    ManHinhNho.Clear();
                    ManHinh.Clear();
                    resultBool = false;
                }
                if (dauString == "sin" || dauString == "cos" || dauString == "tan")
                    ManHinh.Text = ManHinh.Text + "-";
                else
                    ManHinh.Text = "-" + ManHinh.Text;
                SoAmBool = true;
            }
            //so duong
            else
            {
                if(ManHinh.Text.Length>0)
                {
                    ManHinh.Text = ManHinh.Text.Substring(1);
                    SoAmBool=false;
                }
            }
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            if (resultBool == true)
            {
                ManHinhNho.Clear();
                ManHinh.Clear();
            }
            dauString = "sin";
            ManHinh.Text = ManHinh.Text + dauString + "(";
            NangCao = true;
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            if (resultBool == true)
            {
                ManHinhNho.Clear();
                ManHinh.Clear();
            }
            dauString = "cos";
            ManHinh.Text = ManHinh.Text + dauString + "(";
            NangCao = true;
            resultBool = false;
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            if (resultBool == true)
            {
                ManHinhNho.Clear();
                ManHinh.Clear();
            }
            dauString = "tan";
            ManHinh.Text = ManHinh.Text + dauString + "(";
            NangCao = true;
            resultBool = false;
        }

        //reset lai may tinh
        private void xoa_het_Click(object sender, EventArgs e)
        {
            ManHinh.Clear();
            ManHinhNho.Clear();
            num1Double = 0;
            num2Double = 0;
            resultDouble = 0;
            resultBool = false;
        }
    }
}
