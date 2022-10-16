using GraphQL.Sample.MockSource;
using GraphQL.Sample.Models;

namespace GraphQL.Sample
{
    public class QueryLibrary
    {
        public CurrentUser? GetCurrentUser()
        {
            // get user data from token
            //...

            var addresses = new List<Address>() {
                    new Address(){ Id = 1, AddressLine = "Rue de la Saint 75", PostCode = "1000", City = "Tehran" }
                };

            return new CurrentUser()
            {
                Id = 1,
                FirstName = "Mahdi",
                LastName = "Radi",
                Username = "mahdiradi",
                Addresses = new CList<Address>()
                {
                    Count = addresses.Count,
                    Items = addresses
                }
            };
        }

        public User? GetUser(int id)
        {
            return UsersMock.Users.FirstOrDefault(x => x.Id == id);
        }

        public List<User> GetUsers()
        {
            return UsersMock.Users;
        }

        public int GetTotalUsers()
        {
            return UsersMock.Users.Count;
        }

        public CList<Order> GetUserOrders()
        {
            return new CList<Order>()
            {
                Count = OrdersMock.Orders.Count,
                Items = OrdersMock.Orders
            };
        }
    }
}
