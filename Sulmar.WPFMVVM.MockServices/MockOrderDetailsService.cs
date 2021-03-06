﻿using System;
using System.Collections.Generic;
using System.Text;
using Sulmar.WPFMVVM.ShopPracz.Models;
using System.Linq;
using Sulmar.WPFMVVM.ShopPracz.Services;

namespace Sulmar.WPFMVVM.ShopPracz.MockServices
{
    public class MockOrderDetailsService : IOrderDetailsService
    {
        private ICollection<OrderDetail> orderDetails;

        public MockOrderDetailsService()
        {
            IList<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Produkt 1", Color = "Red", Price = 10m },
                new Product { Id = 2, Name = "Produkt 2", Color = "Blue", Price = 0.99m},
                new Product { Id = 3, Name = "Produkt 3", Color = "White", Price = 1.90m},
            };

            orderDetails = new List<OrderDetail>
            {
                // zam 1
                new OrderDetail { Id = 1, OrderId = 1, Product = products[0], Quantity = 1, UnitPrice = products[0].Price },
                new OrderDetail { Id = 2, OrderId = 1, Product = products[1], Quantity = 5, UnitPrice = products[1].Price },

                // zam 2
                new OrderDetail { Id = 3, OrderId = 2, Product = products[0], Quantity = 2, UnitPrice = products[0].Price },
                new OrderDetail { Id = 4, OrderId = 2, Product = products[1], Quantity = 1, UnitPrice = products[1].Price },
                new OrderDetail { Id = 5, OrderId = 2, Product = products[2], Quantity = 1, UnitPrice = products[2].Price },
            };
        }

        public ICollection<OrderDetail> Get(int orderId)
        {

            // return orderDetails.Where(od => od.OrderId == orderId).ToList();

            var expression = 
                    from od in orderDetails
                    where od.OrderId == orderId
                    select od;

            return expression.ToList();
        }
    }
}
