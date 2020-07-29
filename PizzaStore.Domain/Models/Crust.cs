using System;

namespace PizzaStore.Domain.Models
{
  public class Crust
  {
    public string Name {get; set;}

    public Crust(string name)
    {
      Name = name;
    }

        public Crust()
        {
        }
        public override string ToString()
        {
          return Name;
        }

        // internal void AddRange(Crust crust)
        // {
        //     throw new NotImplementedException();
        // }

        // internal void Add(Crust crust)
        // {
        //     throw new NotImplementedException();
        // }
    }
}