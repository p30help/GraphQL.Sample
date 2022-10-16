using GraphQL.Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Sample.MockSource
{
    public class OrdersMock
    {
        public static List<Product> Prducts = new List<Product>()
        {
            new Product()
            {
                ProductId = 1,
                Price = 2,
                ProductName = "A4 Paper Pack",
            },
            new Product()
            {
                ProductId = 2,
                Price = 6,
                ProductName = "A2 Paper Pack",
            },
            new Product()
            {
                ProductId = 3,
                Price = 15,
                ProductName = "Coffe Maker",
            },
            new Product()
            {
                ProductId = 4,
                Price = 3.5m,
                ProductName = "Led Lamp",
            }
        };


        public static List<Order> Orders = new List<Order>()
        {


            new Order(){
                Id = 1,
                CreatedDate = DateTime.Now.AddDays(-200),
                Products = new CList<Product>()
                {
                    Count = 2,
                    Items = new List<Product>()
                    {
                        Prducts.First(x => x.ProductId == 1),
                        Prducts.First(x => x.ProductId == 3),
                    }
                },
                TotalPrice = 17,
                Address = UsersMock.CurrentUser.Addresses.Items.First()
            }
        };
    }
}
