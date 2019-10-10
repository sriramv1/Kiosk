﻿using Kiosk.View;
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

namespace Kiosk
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

        private void SearchForBooks_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Hide();
                BookView bookView = new BookView();
                bookView.Show();
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }

        }
    }
}