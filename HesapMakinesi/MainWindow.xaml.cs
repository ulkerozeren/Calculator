using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HesapMakinesi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double Sayi;
        private string Islem;
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }


        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }


        private void Btn6Bolme_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtNumber.Text, out Sayi);
            Islem = ((Button)sender).Content.ToString();

            txtNumber.Text = "0";
            txtNumber.Focus();
        }

        private void BtnCarpma_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtNumber.Text, out Sayi);
            Islem = ((Button)sender).Content.ToString();

            txtNumber.Text = "0";
            txtNumber.Focus();
        }

        private void BtnArti_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtNumber.Text, out Sayi);
            Islem= ((Button)sender).Content.ToString();

            txtNumber.Text = "0";
            txtNumber.Focus();
        }

        private void BtnCikarma_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtNumber.Text, out Sayi);
            Islem = ((Button)sender).Content.ToString();

            txtNumber.Text = "0";
            txtNumber.Focus();
        }


        private void BtnKareKok_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtNumber.Text, out Sayi);
            Islem = ((Button)sender).Content.ToString();

            txtNumber.Focus();
        }
        private void BtnEsittir_Click(object sender, RoutedEventArgs e)
        {
            switch (Islem)
            {
                case "*":
                    Sayi *= double.Parse(txtNumber.Text);
                    break;
                case "/":
                    Sayi /= double.Parse(txtNumber.Text);
                    break;
                case "-":
                    Sayi -= double.Parse(txtNumber.Text);
                    break;
                case "+":
                    Sayi += double.Parse(txtNumber.Text);
                    break;
                case "√":
                    Sayi = Math.Sqrt(double.Parse(txtNumber.Text));
                    break;
                case "%":
                    Sayi = Sayi * double.Parse(txtNumber.Text) / 100;
                    break;
            }


            txtNumber.Text = Sayi.ToString();
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            Sayi = 0;       
            txtNumber.Text = "0";
            txtNumber.Focus();
        }

        private void BtnSil_Click(object sender, RoutedEventArgs e)
        {
            string veri = txtNumber.Text;
            txtNumber.Text = "";
            
            for (int i = 0; i < veri.Length - 1; i++)
            {
                txtNumber.Text += veri[i].ToString();
            }
            if (txtNumber.Text.Length == 0)
            {
                txtNumber.Text = "0";
            }
        }

        private void BtnYuzde_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtNumber.Text, out Sayi);
            Islem = ((Button)sender).Content.ToString();

            txtNumber.Text = "0";
            txtNumber.Focus();
        }

        private void BtnVirgul_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ((Button)sender).Content.ToString();
            }
            else
            {
                txtNumber.Text += ((Button)sender).Content.ToString();
            }
        }
    }
}
