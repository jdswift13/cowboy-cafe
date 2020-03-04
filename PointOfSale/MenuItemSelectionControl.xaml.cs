using System;
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
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            //buttonname.click += eventhandler;
            AngryChickenButton.Click += Button_Click;
            CowpokeChiliButton.Click += CowpokeChiliButton_Click;
            RustlersRibsButton.Click += RustlersRibsButton_Click;
            PecosPulledPorkButton.Click += PecosPulledPorkButton_Click;
            TrailBurgerButton.Click += TrailBurgerButton_Click;
            DakotaDoubleBurgerButton.Click += DakotaDoubleBurgerButton_Click;
            TexasTripleBurgerButton.Click += TexasTripleBurgerButton_Click;

            ChiliCheeseFriesButton.Click += ChiliCheeseFriesButton_Click;
            CornDodgersButton.Click += CornDodgersButton_Click;
            PanDeCampoButton.Click += PanDeCampoButton_Click;
            BakedBeansButton.Click += BakedBeansButton_Click;
            JerkedSodaButton.Click += JerkedSodaButton_Click;
            TexasTeaButton.Click += TexasTeaButton_Click;
            CowboyCoffeeButton.Click += CowboyCoffeeButton_Click;
            WaterButton.Click += WaterButton_Click;
        }

        /// <summary>
        /// Angry Chicken Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order o)
            {
                o.Add(new AngryChicken());
                
            }
        }

        private void CowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order o ) 
            {
                
                o.Add(new CowpokeChili());
            }
        }

        private void RustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new RustlersRibs());
            }
        }

        private void PecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new PecosPulledPork());
            }
        }

        private void TrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new TrailBurger());
            }
        }

        private void DakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new DakotaDoubleBurger());
            }
        }

        private void TexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new TexasTripleBurger());
            }
        }

        private void ChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new ChiliCheeseFries());
            }
        }

        private void CornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new CornDodgers());
            }
        }

        private void PanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new PanDeCampo());
            }
        }

        private void BakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new BakedBeans());
            }
        }

        private void JerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new JerkedSoda());
            }
        }

        private void TexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new TexasTea());
            }
        }

        private void CowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new CowboyCoffee());
            }
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                o.Add(new Water());
            }
        }

        //private void OrderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}
    }
}
