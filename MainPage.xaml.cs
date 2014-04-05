using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace FitKidz
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            


            childProgressBar1.Minimum = 0;
            childProgressBar1.MaxHeight = 100;
            childProgressBar1.Value = 40;

            childProgressBar2.Minimum = 0;
            childProgressBar2.MaxHeight = 100;
            childProgressBar2.Value = 100;

            childProgressBar3.Minimum = 0;
            childProgressBar3.MaxHeight = 100;
            childProgressBar3.Value = 50;

            childProgressBar4.Minimum = 0;
            childProgressBar4.MaxHeight = 100;
            childProgressBar4.Value = 70;

           
        }

        private void addChildButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}