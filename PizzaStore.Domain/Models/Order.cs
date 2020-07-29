using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizzas {get; set;}

        public void CreatePizza(Size size, Crust crust, List<Toppings> toppings, int price)
        {
            Pizzas.Add(new Pizza(size, crust, toppings, price));
        }
        // public void CreateCustomPizza(List<string> size, List<string> crust, List<Toppings> toppings, int price)
        // {
        //     Pizzas.Add(new Pizza(size, crust, toppings, price));
        // }
        public void CreatePizza(Pizza p)
        {
            Pizzas.Add(p);
        }
        public Order()
        {
            Pizzas = new List<Pizza>();
        }
        
        public override string ToString()
        {
            var pi = "";
            foreach(Pizza x in Pizzas)
            {
                pi +=x;
            }
            return $"{pi}";
        }
    }
}