using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;
using PizzaStore.Storing.Repositories;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main()
        {
            Welcome();
        }

        //  static void Main(string[] args)
        //  {
        //      Welcome();
        //  }

        static void Welcome()
        {
            Console.WriteLine("Welcome to PizzaWorld");
            Console.WriteLine("Best Pizza in the World");
            Console.WriteLine("What is your name?");
            
            var name = Console.ReadLine();
            // name = new Store().Name;
            var startup = new PizzaStore.Client.Startup();
            var user = new User(name);
            var store = new Store();
            var order = startup.CreateOrder(user, store);

            try
            {
                Menu3(startup.CreateOrder(user, store));
            }
             catch (Exception ex)
             {
                  Console.WriteLine(ex.Message);
             }
        }
        
        
        
         static void SizeMenu(Pizza Pizza)
                {
                    var flag = true;
                    do{
                        int select2;
                        Console.WriteLine("Select 1 for Large");
                        Console.WriteLine("Select 2 for Medium");
                        Console.WriteLine("Select 3 for small");
                        int.TryParse(Console.ReadLine(), out select2);
                        switch (select2)
                        {
                            case 1:
                                Pizza.Size = new Size("Large");
                                flag = false;
                                break;
                            case 2:
                                Pizza.Size = new Size("Medium");
                                flag = false;
                                break;
                            case 3:
                                Pizza.Size = new Size("Large");
                                flag = false;
                                break;
                        }
                    }while (flag);
                }
            static void CrustMenu(Pizza Pizza)
                {
                    var flag = true;
                    do {
                        int select3;
                        Console.WriteLine("Select 1 for Handtossed");
                        Console.WriteLine("Select 2 for Flatbread");
                        Console.WriteLine("Press 3 for Stuffed Crust");
                        int.TryParse(Console.ReadLine(), out select3);
                        switch (select3)
                        {
                            case 1:
                                Pizza.Crust = new Crust("Handtossed");
                                flag = false;
                                break;
                            case 2:
                                Pizza.Crust = new Crust("Flatbread");
                                flag = false;
                                break;
                            case 3:
                                Pizza.Crust = new Crust("Stuffed Crust");
                                flag = false;
                                break;
                        }
                    } while (flag);
                }
                static void CustomMenu(Pizza Pizza)
                {
                    var flag = true;
                    do{
                    int select4;
                    Console.WriteLine("Select 1 for Pepperoni");
                    Console.WriteLine("Select 2 for Pineapple");
                    Console.WriteLine("Select 3 for Canadian Bacon");
                    Console.WriteLine("Select 4 for Anchovies");
                    Console.WriteLine("Select 5 for Olives");
                    Console.WriteLine("Select 6 for Extra Cheese");
                    Console.WriteLine("Select 7 to continue");
                    int.TryParse(Console.ReadLine(), out select4);
                    switch (select4)
                        {
                            case 1:
                                Pizza.Toppings.Add(new Toppings("Pepperoni"));
                                break;
                            case 2:
                                Pizza.Toppings.Add(new Toppings("Pineapple"));
                               break;
                            case 3:
                                Pizza.Toppings.Add(new Toppings("Canadian Bacon"));
                                break;
                            case 4:
                                Pizza.Toppings.Add(new Toppings("Anchovies"));
                                break;
                            case 5:
                                Pizza.Toppings.Add(new Toppings("Olives"));
                                break;
                            case 6:
                                Pizza.Toppings.Add(new Toppings("Extra Cheese"));
                                break;
                            case 7:
                                flag = false;
                                break;
                        }
                    }while (flag); 
                } 

        static void Menu3(Order cart) //Order datatype called cart
        {
            var exit = false;

            do
            {
                Console.WriteLine("Select 1 for Cheese Pizza");
                Console.WriteLine("Select 2 for Pepperoni Pizza");
                Console.WriteLine("Select 3 for Hawaiian Pizza");
                Console.WriteLine("Select 4 for Custom Pizza");
                Console.WriteLine("Select 5 to view cart");
                Console.WriteLine("Select 6 to exit");

                int select;
                int.TryParse(Console.ReadLine(), out select);
                //reads the input put in by user

                switch (select)
                {
                    case 1:
                        var Pizza = new Pizza(new Size {}, new Crust{}, new List<Toppings> { new Toppings("Cheese") }, 5);
                        SizeMenu(Pizza);
                        CrustMenu(Pizza);
                        Console.WriteLine("added Cheese Pizza");
                        cart.CreatePizza(Pizza);
                        
                        break;
                    case 2:
                        Pizza = new Pizza(new Size{}, new Crust{}, new List<Toppings> { new Toppings("Pepperoni") }, 5);
                        SizeMenu(Pizza);
                        CrustMenu(Pizza);
                        Console.WriteLine("added Pepperoni Pizza");
                        cart.CreatePizza(Pizza);
                        break;
                    case 3:
                        Pizza = new Pizza(new Size {}, new Crust { }, new List<Toppings> { new Toppings("Hawaiian") }, 5);
                        SizeMenu(Pizza);
                        CrustMenu(Pizza);
                        Console.WriteLine("added Hawaiian Pizza");
                        cart.CreatePizza(Pizza);
                        break;
                    case 4:
                        Pizza = new Pizza(new Size {}, new Crust { }, new List<Toppings> { new Toppings("Cheese") }, 5);
                        SizeMenu(Pizza);
                        CrustMenu(Pizza);
                        CustomMenu(Pizza);
                        cart.CreatePizza(Pizza);
                        break;
                    case 5:
                        DisplayCart(cart);
                        break;
                    case 6:
                        // var fm = new FileManager();
                        // fm.Write(cart);
                        PizzaRepository pr = new PizzaRepository();
                        foreach(var pizza in cart.Pizzas) 
                        {
                            pr.Create(pizza);
                        }
                        Console.WriteLine("Thank you, goodbye!");
                        exit = true;
                        break;
                    case 7:
                        var fmr = new FileManager();
                        DisplayCart(fmr.Read());
                        break;
                }
                
               
                
                
            } while (!exit);
        }
        static void DisplayCart(Order cart)
        {
            foreach (var Pizza in cart.Pizzas)
            {
                Console.WriteLine(Pizza);
            }
        }
        static void DisplayUser(User user)
        {
            foreach (var Name in user.Name)
            {
                Console.WriteLine(user);
            }
        }


    }
}
