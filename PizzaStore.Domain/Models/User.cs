using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class User
    {
        public List<Order> Orders {get; set;}
        public string Name {get; set;}

        public User(string name)
        {
            Orders = new List<Order>();
            Name = name;
        }
        public User()
        {

        }
    }
}