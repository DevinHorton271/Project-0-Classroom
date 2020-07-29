using PizzaStore.Domain.Models;
using System.Collections.Generic;
using Xunit;

namespace PizzaStore.Testing.Tests
{
    public class OrderTest
    {
        [Fact]
        public void Test_CreatePizza()
        {
            //arrange
            var sut = new Order();
            Size size = new Size ( "S" );
            Crust crust = new Crust ("C");
            List<Toppings> toppings = new List<Toppings> { new Toppings("T")};
            int price = 5;

            //act
            sut.CreatePizza(size, crust, toppings, price);

            //assert
            Assert.True(sut.Pizzas.Count == 1);
        }
    }
}