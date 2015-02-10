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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ellipse gezicht = new Ellipse();
        Ellipse linkerOog = new Ellipse();
        
        

        public MainWindow()
        {
            InitializeComponent();

            gezicht.Width = 100;
            gezicht.Height = 120;
            gezicht.Margin = new Thickness(tekenCanvas.Width / 3, 20, 0, 0);
            gezicht.Stroke = new SolidColorBrush(Colors.Pink);
            gezicht.Fill  = new SolidColorBrush(Colors.Pink);
            
            linkerOog.Width = 15;
            linkerOog.Height = 15;
            linkerOog.Margin = new Thickness(130, 50, 0, 0);
            linkerOog.Stroke = new SolidColorBrush(Colors.Blue);
            linkerOog.Fill = new SolidColorBrush(Colors.DarkBlue);
            
        }

        private void ClickHandler(object sender, RoutedEventArgs e)
        {
            tekenCanvas.Children.Add(gezicht);
            tekenCanvas.Children.Add(linkerOog);
        }
    }
}