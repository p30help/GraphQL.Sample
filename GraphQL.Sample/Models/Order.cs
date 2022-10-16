using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Sample.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public decimal TotalPrice { get; set; }

        public CList<Product> Products { get; set; }

        public Address Address { get; set; }
    }
}
