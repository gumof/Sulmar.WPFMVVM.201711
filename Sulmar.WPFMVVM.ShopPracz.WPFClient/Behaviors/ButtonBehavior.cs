﻿using Sulmar.WPFMVVM.ShopPracz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace Sulmar.WPFMVVM.ShopPracz.WPFClient.Behaviors
{
    public class ButtonBehavior : Behavior<Button>
    {
        public Order Order
        {
            get { return (Order)GetValue(orderProperty); }
            set { SetValue(orderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for order.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty orderProperty =
            DependencyProperty.Register("Order", typeof(Order), typeof(ButtonBehavior), new PropertyMetadata());



        protected override void OnAttached()
        {
            this.AssociatedObject.MouseEnter += AssociatedObject_MouseEnter;
        }

        private void AssociatedObject_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.AssociatedObject.Background = new SolidColorBrush(Colors.Blue);
        }
    }
}
