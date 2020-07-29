using System.Collections.Generic;
using System.Linq;
using PizzaStore.Domain.Models;
using domain = PizzaStore.Domain.Models;

namespace PizzaStore.Storing.Repositories
{
    public class PizzaRepository
    //all objects should go through here, so maybe don't use just Pizza

    {
        private PizzaStoreDbContext _db = new PizzaStoreDbContext();


        public void Create(domain.Pizza pizza)
        {
            //       var newPizza =  new Pizza();
            //       //var newTopping = new Topping();

            //       _db.Crust.Add(newPizza.Crust);
            //       newPizza.Crust.Name = pizza.Crust.Name;
            //       _db.Size.Add(newPizza.Size);
            //       newPizza.Size.Name = pizza.Size.Name;
            //       newPizza.Name = pizza.Name;
            //       newPizza.

            //       //var orderDate = DateTime.UtcNow;

            //       //_db.Pizza.Add(newPizza);
            //       //_db.Topping.Add(newTopping);
            //       _db.SaveChanges();
            var newPizza = new Pizza();

            newPizza.Crust = new Crust() { Name = pizza.Crust.Name };
            newPizza.Size = new Size() { Name = pizza.Size.Name };
            newPizza.Name = pizza.Name;


            _db.Pizza.Add(newPizza);
            _db.SaveChanges();
        }
        public void Create(domain.Crust crust)
        {
            var newCrust = new Crust();
            _db.Crust.Add(newCrust);
            newCrust.Name = crust.Name;
            _db.SaveChanges();

        }

        public void Create(domain.User user)
        {
            var newUser = new User();
            _db.User.Add(newUser);
            newUser.Name = user.Name;
            _db.SaveChanges();
        }

        public List<domain.Pizza> ReadAll()
        {
            var domainPizzaList = new List<domain.Pizza>();
            //   var query = from p in _db.Pizza;
            //   var pizzasWithCrust = _db.Pizza.Include(t -> t.Pizza).Include(t -> t.Size);
            //   var pizzasWithTopping = _db.Pizza.Include(t -> t.Pizza).Include(t -> t.Topping);


            foreach (var item in _db.Pizza.ToList())
            {
                domainPizzaList.Add(new domain.Pizza()
                {
                    Crust = new domain.Crust() { Name = item.Crust.Name },
                    Size = new domain.Size() { Name = item.Size.Name },
                    Toppings = new List<domain.Toppings>()
                });
            };

            return domainPizzaList;
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}