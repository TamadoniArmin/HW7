//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW7
//{
//    public static class Storage
//    {

//        public static List<Items> Items { get; set; }
//        public static List<User> Users { get; set; }
//        public static User? CurrentUser { get; set; }
//        //public List<Items> MyProperty { get; set; }
//        public static int CurrentUsersId()
//        {
//            if (Users == null) return 0;
//            return CurrentUser.Id;
//        }
//        static Storage()
//        {
//            Users = new List<User>();
//            Items = new List<Items>();
//            Items.Add(new Items { Id = 1, Category = CategoryEnum.Cooking, Name = "Pot", Price = 200, ExstingAmount = 10 });
//            Items.Add(new Items { Id = 2, Category = CategoryEnum.Cooking, Name = "skimmer", Price = 120, ExstingAmount = 20 });
//            Items.Add(new Items { Id = 3, Category = CategoryEnum.Fantasi, Name = "Study Light", Price = 300, ExstingAmount = 15 });
//            Items.Add(new Items { Id = 3, Category = CategoryEnum.Fantasi, Name = "Study Light", Price = 300, ExstingAmount = 15 });
//            Items.Add(new Items { Id = 4, Category = CategoryEnum.Fantasi, Name = "Slippers", Price = 100, ExstingAmount = 100 });
//            Items.Add(new Items { Id = 5, Category = CategoryEnum.House, Name = "Sofa", Price = 100000, ExstingAmount = 4 });
//            Items.Add(new Items { Id = 6, Category = CategoryEnum.House, Name = "Desk", Price = 6000, ExstingAmount = 12 });
//            Users.Add(new User { Id = 1, Name = "Amir", Family = "mohagheghiyan", Email = "Amir@gmail.com", Password = "123456", Role = RoleEnum.NormalUser, Username = "AmirMo" });

//        }

//    }
//}
using HW7;

public class Storage
{
    public static List<Items> Items { get; set; }
    public static List<User> Users { get; set; }
    public static User? CurrentUser { get; set; }
    //public List<Items> MyProperty { get; set; }
    public static int CurrentUsersId()
    {
        if (Users == null) return 0;
        return CurrentUser.Id;
    }



    static Storage()
    {
        Users = new List<User>(); // Initialize the Users list
        Items = new List<Items>(); // Initialize the Items list

        Items.Add(new Items { Id = 1, Category = CategoryEnum.Cooking, Name = "Pot", Price = 200, ExstingAmount = 10 });
        Items.Add(new Items { Id = 2, Category = CategoryEnum.Cooking, Name = "skimmer", Price = 120, ExstingAmount = 20 });
        Items.Add(new Items { Id = 3, Category = CategoryEnum.Fantasi, Name = "Study Light", Price = 300, ExstingAmount = 15 });
        Items.Add(new Items { Id = 3, Category = CategoryEnum.Fantasi, Name = "Study Light", Price = 300, ExstingAmount = 15 });
        Items.Add(new Items { Id = 4, Category = CategoryEnum.Fantasi, Name = "Slippers", Price = 100, ExstingAmount = 100 });
        Items.Add(new Items { Id = 5, Category = CategoryEnum.House, Name = "Sofa", Price = 100000, ExstingAmount = 4 });
        Items.Add(new Items { Id = 6, Category = CategoryEnum.House, Name = "Desk", Price = 6000, ExstingAmount = 12 });
        Users.Add(new User { Id = 2, Name = "Amir", Family = "mohagheghiyan", Email = "Amir@gmail.com", Password = "123456", Role = RoleEnum.NormalUser, Username = "AmirMo" });

        Users.Add(new User
        {
            Id = 1,
            Name = "Amir",
            Family = "mohagheghiyan",
            Email = "Amir@gmail.com",
            Password = "123456",
            Role = RoleEnum.NormalUser,
            Username = "AmirMo"
        });
    }


}
