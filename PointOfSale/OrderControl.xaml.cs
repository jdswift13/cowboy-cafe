﻿using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            //buttonname.click += eventhandler;
            var order = new Order();
            this.DataContext = order;

        }
        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }

        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewOrderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
