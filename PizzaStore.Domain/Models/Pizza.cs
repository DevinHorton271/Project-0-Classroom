using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        //STATE
        //fields
        //string imageUrl = "";
        public Size Size {get; set; }

        public List<Toppings> Toppings {get; set;}
        public Crust Crust {get; set;}
        public int Price {get; }
        public string Name { get; set; }

        //properties '
        //BEHAVIOR
        //methods


        // public void AddSize(Size size)
        // {
        //     _size.Add(size);
        // }

        public override string ToString()
        {
            var top = "";

            foreach(Toppings x in Toppings)
            {
                top += $"{x.Name}, ";
            }

            return $"{Crust} Crust \n{Size} \n{top} \n${Price}.00"; 
        }
        //constructors

        public Pizza(Size size, Crust crust, List<Toppings> toppings, int price)
        {

            Size = size;
            Crust = crust;
            Toppings = toppings;
            Price = price;
        }

        public Pizza()
        {
            //intentionally empty
        }


        //finalizers (AKA Destructors)
    }
}