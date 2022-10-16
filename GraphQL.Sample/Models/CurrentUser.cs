using GraphQL.Sample.MockSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Sample.Models
{
    public class CurrentUser
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Username { get; set; }
        public DateOnly? BirthDate { get; set; }

        public CList<Address>? Addresses { get; set; }

        public int GetUnreadMessagesCount()
        {
            return 10;
        }
    }
}
