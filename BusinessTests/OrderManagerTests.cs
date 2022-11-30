using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CateringApp;
using DTO;

namespace Business.Tests
{
    [TestClass()]
    public class OrderManagerTests
    {
        [TestMethod()]
        public void CalculateTotalPriceTest()
        {
            /*IngredientManager ingManager = new IngredientManager();
            Item firstDish = new Item("firstDish", 10.20, "Food", "Testing", ingManager.ListOfIngredients());
            Item secondDish = new Item("secondDish", 5.20, "Food", "Testing", ingManager.ListOfIngredients());
            Item thirdDish = new Item("thirdDish", 1.60, "Drinks", "Testing", ingManager.ListOfIngredients());
            
            List<Item> listOfItems = new List<Item>();

            listOfItems.Add(firstDish);
            listOfItems.Add(secondDish);
            listOfItems.Add(thirdDish);

            Order order = new Order(1, listOfItems);
            List<Order> listOfOrders = new List<Order>();
            listOfOrders.Add(order);

            OrderManager orderManager = new OrderManager(listOfOrders);

            
            Assert.AreEqual(17, orderManager.CalculateTotalPrice(1));
            */
        }
    }
}