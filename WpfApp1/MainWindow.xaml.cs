﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Button btn = new Button();
            //btn.FontWeight = FontWeights.Bold;

            //WrapPanel pnl = new WrapPanel();

            //TextBlock txt = new TextBlock();
            //txt.Text = "Multi";
            //txt.Foreground = Brushes.Blue;
            //pnl.Children.Add(txt);

            //txt = new TextBlock();
            //txt.Text = "Color";
            //txt.Foreground = Brushes.Red;
            //pnl.Children.Add(txt);

            //txt = new TextBlock();
            //txt.Text = "Button";
            //pnl.Children.Add(txt);

            //btn.Content = pnl;
            //pnlMainGrid.Children.Add(btn);


            pnlMainGrid.MouseUp += pnlMainGrid_MouseUp;

        }
        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at abcd " + e.GetPosition(this).ToString());
        }
    }
}
