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

namespace Prishchepova_PR5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int text1 = 0;
        int text2 = 0;
        int text3 = 0;


        public MainWindow()
        {
            InitializeComponent();
            Box1.Text = "0";
            Box2.Text = "0";
            Box3.Text = "0";

        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            text1 += 3;
            Box1.Text = text1.ToString();
        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            text1 += 2;
            Box1.Text = text1.ToString();
        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            text1 += 1;
            Box1.Text = text1.ToString();
        }

        private void But4_Click(object sender, RoutedEventArgs e)
        {
            text1 -= 3;
            Box1.Text = text1.ToString();
        }

        private void But5_Click(object sender, RoutedEventArgs e)
        {
            text1 -= 2;
            Box1.Text = text1.ToString();
        }

        private void But6_Click(object sender, RoutedEventArgs e)
        {
            text1 -= 1;
            Box1.Text = text1.ToString();
        }

        private void But7_Click(object sender, RoutedEventArgs e)
        {
            text2 += 3;
            Box2.Text = text2.ToString();
        }

        private void But8_Click(object sender, RoutedEventArgs e)
        {
            text2 += 2;
            Box2.Text = text2.ToString();
        }

        private void But9_Click(object sender, RoutedEventArgs e)
        {
            text2 += 1;
            Box2.Text = text2.ToString();
        }

        private void But10_Click(object sender, RoutedEventArgs e)
        {
            text2 -= 3;
            Box2.Text = text2.ToString();
        }

        private void But11_Click(object sender, RoutedEventArgs e)
        {
            text2 -= 2;
            Box2.Text = text2.ToString();
        }

        private void But12_Click(object sender, RoutedEventArgs e)
        {
            text2 -= 1;
            Box2.Text = text2.ToString(); 
        }

        private void But13_Click(object sender, RoutedEventArgs e)
        {
            text3 += 3;
            Box3.Text = text3.ToString();
        }

        private void But14_Click(object sender, RoutedEventArgs e)
        {
            text3 += 2;
            Box3.Text = text3.ToString();
        }

        private void But15_Click(object sender, RoutedEventArgs e)
        {
            text3 += 1;
            Box3.Text = text3.ToString();
        }

        private void But16_Click(object sender, RoutedEventArgs e)
        {
            text3 -= 3;
            Box3.Text = text3.ToString();
        }

        private void But17_Click(object sender, RoutedEventArgs e)
        {
            text3 -= 2;
            Box3.Text = text3.ToString();
        }

        private void But18_Click(object sender, RoutedEventArgs e)
        {
            text3 -= 1;
            Box3.Text = text3.ToString();
        }

        private void Sbros_Click(object sender, RoutedEventArgs e)
        {
            text1 = 0;
            text2 = 0;
            text3 = 0;
            Box1.Text = "0";
            Box2.Text = "0";
            Box3.Text = "0";
        }
    }
}
