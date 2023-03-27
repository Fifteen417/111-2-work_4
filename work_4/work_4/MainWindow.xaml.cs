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
                txt_cal.Text = ""; //只有一行可以省略大括號
            txt_cal.Text += "3";
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = ""; //只有一行可以省略大括號
            txt_cal.Text += "4";
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = ""; //只有一行可以省略大括號
            txt_cal.Text += "5";
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = ""; //只有一行可以省略大括號
            txt_cal.Text += "6";
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = ""; //只有一行可以省略大括號
            txt_cal.Text += "7";
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = ""; //只有一行可以省略大括號
            txt_cal.Text += "8";
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (txt_cal.Text == "0")
                txt_cal.Text = ""; //只有一行可以省略大括號
            txt_cal.Text += "9";
        }
    }
}
