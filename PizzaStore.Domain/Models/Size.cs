using System;

namespace PizzaStore.Domain.Models
{
  public class Size
  {
    public string Name {get; set; }

    public Size(string name)
    {
      Name = name;
    }

        public Size()
        {
        }

        public override string ToString()
        {
          return Name;
        }
        // internal void AddRange(Size size)
        // {
        //     throw new NotImplementedException();
        // }

        // internal void Add(Size size)
        // {
        //     throw new NotImplementedException();
        // }
    }
}