using GraphQL.Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Sample.MockSource
{
    public class UsersMock
    {
        public static CurrentUser CurrentUser = new CurrentUser()
        {
            Id = 1,
            FirstName = "Mahdi",
            LastName = "Radi",
            Username = "mahdiradi",
            Addresses = new CList<Address>()
            {
                Count = 1,
                Items = new List<Address>() { new Address() { Id = 1, AddressLine = "Rue de la Saint 75", PostCode = "1000", City = "Tehran" } }
            }
        };


        public static List<User> Users = new List<User>()
        {
            new User(){
                Id = 1,
                FirstName = "Mahdi",
                LastName = "Radi",
                Username = "mahdiradi",
                //Addresses = new List<Address>() {
                //    new Address(){ Id = 1, AddressLine = "Rue de la Saint 75", PostCode = "1000", City = "Tehran" }
                //}
            },
            new User(){
                Id = 2,
                //BirthDate = null ,
                FirstName = "Farid",
                LastName = null,
                Username = "farid007",
                //Addresses = null
            },
            new User(){
                Id = 3,
                //BirthDate = new DateOnly(1990,01,01) ,
                FirstName = null,
                LastName = null,
                Username = "james",
                //Addresses = new List<Address>() {}
            },
            new User(){
                Id = 8,
                //BirthDate = new DateOnly(1990,01,01) ,
                FirstName = null,
                LastName = "messi",
                Username = "leomessi",
                //Addresses = new List<Address>() {
                //    new Address(){ Id = 6, AddressLine = "Si ta re morata 10", PostCode = "10532", City = "Barcelon" },
                //    new Address(){ Id = 80, AddressLine = "Rue de la Psg 41", PostCode = "97321", City = "Paris" }
                //}
            }
        };
    }
}
