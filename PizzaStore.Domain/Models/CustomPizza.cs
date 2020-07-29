using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class CustomPizza
    {
        public List<Toppings> Toppings {get{ return _toppings;}}
        List<Toppings> _toppings = new List<Toppings>();

        public List<string> Crust { get; set; }
        public List<string> Size { get; set; }
        public int Price { get; }
        

        public void AddTopping(Toppings topping)
        {
            _toppings.Add(topping);
        }
        public void AddCrust(string crust)
        {
            Crust.Add(crust);
        }
        public void AddSize(string size)
        {
            Size.Add(size);
        }

        public CustomPizza(List<string> size, List<string> crust, List<Toppings> toppings, int price)
        {
             Size.AddRange(size);
             Crust.AddRange(crust);
             Toppings.AddRange(toppings);
             Price = price;
        }

        // public CustomPizza()
        // {

        // }

        // void AddToppings(string topping)
        // {
        //     Toppings.Add(topping);
        // }


        // void AddSize(string size)
        // {
        //     Size.Add(size);
        // }

        // void AddCrust(string crust)
        // {
        //     Crust.Add(crust);
        // }


        //         void AddCustomToppings(string customtopping)
        // {
        //     CustomToppings.Add(customtopping);
        // }
    }
}