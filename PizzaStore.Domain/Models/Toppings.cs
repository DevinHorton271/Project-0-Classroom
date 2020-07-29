namespace PizzaStore.Domain.Models
{
  public class Toppings
  {
      public string Name { get; set; }
      public Toppings(string name)
      {
          Name = name;
      }
  }
}