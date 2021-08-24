using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api_Tests.Interface;
using Web_Api_Tests.Models;

namespace Web_Api_Tests.Repository
{
    public class ShoppingRepository : IShoppingService
    {
       
            public ShoppingItem Add(ShoppingItem newItem)
            {
                throw new NotImplementedException();
            }
            public IEnumerable<ShoppingItem> GetAllItems()
            {
                throw new NotImplementedException();
            }
            public ShoppingItem GetById(Guid id)
            {
                throw new NotImplementedException();
            }
            public void Remove(Guid id)
            {
                throw new NotImplementedException();
            }
       


    }
}
