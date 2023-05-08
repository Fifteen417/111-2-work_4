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

namespace work_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float firstNumber, secondNumber;
        int operators = -1; //0:加, 1:減, 2:乘, 3:除, -1:重新設定
        float finalResults = 0f;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
            {
                txt_cal.Text = "";
            }
            txt_cal.Text = txt_cal.Text + "0";
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0") 
                txt_cal.Text = ""; //只有一行可以省略大括號
            txt_cal.Text += "1"; //簡化版本
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = "";
            txt_cal.Text += "2";
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = "";
            txt_cal.Text += "3";
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = "";
            txt_cal.Text += "4";
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = "";
            txt_cal.Text += "5";
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = "";
            txt_cal.Text += "6";
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = "";
            txt_cal.Text += "7";
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = "";
            txt_cal.Text += "8";
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = "";
            txt_cal.Text += "9";
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle (txt_cal.Text); // 把文字框轉換成浮點數，存入第一個數字的全域變數
            txt_cal.Text = "0"; // 重置文字框
            operators = 0; // 選擇加號 "0 = 「+」"
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txt_cal.Text);
            txt_cal.Text = "0";
            operators = 1; // 選擇減號 "1 = 「-」"
        }

        private void btn_times_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txt_cal.Text);
            txt_cal.Text = "0";
            operators = 2; // 選擇乘號 "2 = 「*」"
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txt_cal.Text);
            txt_cal.Text = "0";
            operators = 3; // 選擇除號 "3 = 「/」"
        }

        private void btn_PC_Click(object sender, RoutedEventArgs e)
        {
            finalResults = finalResults / 100;
            txt_cal.Text = string.Format("{0:P2}", finalResults);
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            secondNumber = Convert.ToSingle(txt_cal.Text); // 把文字框轉換成浮點數，存入第二個數字的全域變數

            // 依照選擇進行運算 "加減乘除"
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            txt_cal.Text = string.Format("{0:0.#########}", finalResults); // 在文字框中顯示最後的結果

            //重置所有全域變數
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text.IndexOf(".") == -1) // 確認文字框中沒有小數點
                txt_cal.Text = txt_cal.Text + "."; // 添加小數點
        }

        private void btn_BS_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text.Length > 0) 
            {
                txt_cal.Text = txt_cal.Text.Substring(0, txt_cal.Text.Length - 1);
            }

        }


        private void btn_AC_Click(object sender, RoutedEventArgs e)
        {
            txt_cal.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
    }
}
