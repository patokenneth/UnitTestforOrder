using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api_Tests.Models;

namespace Web_Api_Tests.Interface
{
    public interface IShoppingService
    {
     
            IEnumerable<ShoppingItem> GetAllItems();
            ShoppingItem Add(ShoppingItem newItem);
            ShoppingItem GetById(Guid id);
            void Remove(Guid id);
        
    }
}
