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

namespace Oef06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SolidColorBrush brush = new SolidColorBrush(Colors.Black);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DrawStreet(10, 50);
        }

        private void DrawStreet(double plaats, double grootte)
        {
            DrawHouse(paperCanvas, brush, plaats, 90, grootte, grootte);
            DrawHouse(paperCanvas, brush, (plaats + 70), 90, grootte, grootte);
            DrawHouse(paperCanvas, brush, (plaats + 140), 90, grootte, grootte);
            DrawHouse(paperCanvas, brush, (plaats + 210), 90, grootte, grootte);
        }
        private void DrawHouse(Canvas drawingArea,
                               SolidColorBrush brushToUse,
                               double topRoofX,
                               double topRoofY,
                               double width,
                               double height)
        {
            DrawTriangle(drawingArea, brushToUse, topRoofX,
                         topRoofY, width, height);
            DrawRectangle(drawingArea, brushToUse, topRoofX,
                          topRoofY + height, width, height);
        }

        private void DrawTriangle(Canvas drawingArea,
                                  SolidColorBrush brushToUse,
                                  double xPlace,
                                  double yPlace,
                                  double width,
                                  double height)
        {
            DrawLine(drawingArea, brushToUse, xPlace, yPlace,
                     xPlace, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace,
                     yPlace + height,
                     xPlace + width, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace,
                     xPlace + width, yPlace + height);
        }

        private void DrawLine(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double startX, double startY,
                              double endX, double endY)
        {
            Line l = new Line();
            l.X1 = startX; l.X2 = endX;
            l.Y1 = startY; l.Y2 = endY;
            l.Stroke = brushToUse;
            l.StrokeThickness = 1;
            drawingArea.Children.Add(l);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPos,
                                   double yPos,
                                   double width,
                                   double height)
        {
            Rectangle rect = new Rectangle();
            rect.Width = width;
            rect.Height = height;
            rect.Margin = new Thickness(xPos, yPos, 0, 0);
            rect.Stroke = brushToUse;
            drawingArea.Children.Add(rect);
        }
    }
}
