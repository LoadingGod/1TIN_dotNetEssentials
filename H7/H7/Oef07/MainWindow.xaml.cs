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
using System.Windows.Threading;

namespace Oef07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int memory;
        String huidigeOperator = "";
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            calcTextBox.Text = "";
            timer.Stop();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button temp = (Button) sender;
            switch (temp.Name)
            {
                case "oneButton":
                    calcTextBox.Text += 1;
                    break;
                case "twoButton":
                    calcTextBox.Text += 2;
                    break;
                case "threeButton":
                    calcTextBox.Text += 3;
                    break;
                case "fourButton":
                    calcTextBox.Text += 4;
                    break;
                case "fiveButton":
                    calcTextBox.Text += 5;
                    break;
                case "sixButton":
                    calcTextBox.Text += 6;
                    break;
                case "sevenButton":
                    calcTextBox.Text += 7;
                    break;
                case "eightButton":
                    calcTextBox.Text += 8;
                    break;
                case "nineButton":
                    calcTextBox.Text += 9;
                    break;
                case "zeroButton":
                    calcTextBox.Text += 0;
                    break;
                case "addButton":
                    huidigeOperator = "+";
                    memory = Convert.ToInt32(calcTextBox.Text);
                    calcTextBox.Clear();
                    break;
                case "subtractButton":
                    huidigeOperator = "-";
                    memory = Convert.ToInt32(calcTextBox.Text);
                    calcTextBox.Clear();
                    break;
                case "equalsButton":
                    if (huidigeOperator == "+")
                    {
                        calcTextBox.Text = Convert.ToString(memory + Convert.ToInt32(calcTextBox.Text));
                    }
                    else
                    {
                        calcTextBox.Text = Convert.ToString(memory - Convert.ToInt32(calcTextBox.Text));
                    }
                    break;
                case "clearButton":
                    calcTextBox.Text = "CLEAR";
                    memory = 0;
                    timer.Start();
                    break;
            };
        }

    }
}
