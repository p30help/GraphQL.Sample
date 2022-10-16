using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Sample.Models
{
    public class CList<T>
    {
        public List<T> Items { get; set; }

        public int Count { get; set; }
    }
}
