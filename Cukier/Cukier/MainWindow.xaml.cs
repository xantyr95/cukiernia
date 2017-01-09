﻿using System;
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

namespace Cukier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            czas1.Visibility = Visibility.Hidden;
            przep1.Visibility = Visibility.Hidden;
            czas2.Visibility = Visibility.Hidden;
            przep2.Visibility = Visibility.Hidden;
            ok.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            czas1.Visibility = Visibility.Visible;
            przep1.Visibility = Visibility.Visible;
            czas2.Visibility = Visibility.Visible;
            przep2.Visibility = Visibility.Visible;
            ok.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
