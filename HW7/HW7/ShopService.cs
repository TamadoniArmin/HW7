using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class ShopService : IShopService
    {
        public void GetListOfItems(int category)
        {
            int counter = 1;
            foreach (var item in Storage.Items)
            {
                if (category==1)
                {
                    if (item.Category==CategoryEnum.House)
                    {
                        Console.WriteLine(counter + ")");
                        Console.WriteLine(item.Name + "item ID: " + "(" + item.Id + ")");
                        Console.WriteLine($"Price: {item.Price}");
                        counter++;
                    }
                }
                else
                    if (category==2)
                {
                    if (item.Category==CategoryEnum.Fantasi)
                    {
                        Console.WriteLine(counter + ")");
                        Console.WriteLine(item.Name + "item ID: " + "(" + item.Id + ")");
                        Console.WriteLine($"Price: {item.Price}");
                        counter++;
                    }
                }
                else
                    if (category==3)
                {
                    if (item.Category==CategoryEnum.Cooking)
                    {
                        Console.WriteLine(counter + ")");
                        Console.WriteLine(item.Name+"item ID: " +"("+item.Id+")");
                        Console.WriteLine($"Price: {item.Price}");
                        counter++;
                    }
                }
                
            }
        }
        public bool Checkamount(int ItemId, int amount)
        {
            foreach (var item in Storage.Items)
            {
                if (item.Id==ItemId)
                {
                    if (item.ExstingAmount>=amount)
                    {
                        item.ExstingAmount -= amount;
                        item.askedamount = amount;
                        return true;
                    }
                    else if (item.ExstingAmount<amount)
                    {
                        Console.WriteLine("You can not buy this amount of item!");
                        return false;
                    }
                }
            }
            return false;
        }
        public bool AddToShoppingCart(int IdItem, int IdUser)
        {
            var item = Storage.Items.FirstOrDefault(I => I.Id == IdItem);
            var user = Storage.Users.FirstOrDefault(U => U.Id == IdUser);
            if (item == null || user == null)
            {
                Console.WriteLine("You can not add this item to your shopping cart!");
                return false;
            }
            user.ShoppingCart.Items.Add(item);
            return true;
            
        }
        public bool RemoveItemFromShoppingCsrt(int IdItem, int IdUser)
        {
            var item = Storage.Items.FirstOrDefault(I => I.Id == IdItem);
            var user = Storage.Users.FirstOrDefault(U => U.Id == IdUser);
            var existing = Storage.Users.FirstOrDefault(e => e.Name == item.Name);
            if (item == null || user == null || existing==null)
            {
                Console.WriteLine("You can not add this item to your shopping cart!");
                return false;
            }
            user.ShoppingCart.Items.Remove(item);
            return true;
        }
        public void ShoppingCart(int IdUser)
        {
            foreach (var user in Storage.Users)
            {
                if (user.Id==IdUser)
                {
                    int counter = 1;
                    foreach (var item in user.ShoppingCart.Items)
                    {
                        Console.WriteLine(counter+")"+" "+item);
                        counter++;
                    }
                }
            }
        }
        public int Settlement(int Userid)
        {
            int sum = 0;
            foreach (var user in Storage.Users)
            {
                if (user.Id==Userid)
                {
                    foreach (var item in user.ShoppingCart.Items)
                    {
                        sum += (item.Price * item.askedamount);
                        return sum;
                    }
                }
            }
            return 0;
        }
    }
}
