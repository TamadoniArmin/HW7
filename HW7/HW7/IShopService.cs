using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public interface IShopService
    {
        public void GetListOfItems(int category);
        public bool Checkamount(int ItemId,int amount);
        public bool AddToShoppingCart(int IdItem, int IdUser);
        public bool RemoveItemFromShoppingCsrt(int IdItem, int IdUser);
        public void ShoppingCart(int IdUser);
        public int Settlement(int Userid);
    }
}
