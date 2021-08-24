using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Web_Api_Tests.Controllers;
using Web_Api_Tests.Interface;
using Web_Api_Tests.Models;
using Xunit;

namespace xUnitWebApi
{
    public class MockTest
    {
        private readonly IShoppingService _shopservice;
        private readonly ShoppingCartController foreCastController;

        public MockTest()
        {
            _shopservice = new ShoppingCartServiceFake();
            foreCastController = new ShoppingCartController(_shopservice);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOK()
        {
            var result = foreCastController.Get();

            Assert.IsType<OkObjectResult>(result.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            var result = foreCastController.Get().Result as OkObjectResult;
            var items = Assert.IsType<List<ShoppingItem>>(result.Value);
            
            Assert.Equal(3, items.Count);
        }
    }
}
