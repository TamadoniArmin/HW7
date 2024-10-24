using HW7;

Console.WriteLine("***** Wellcome *****");
while (true)
{
    Console.Write("Do you have account in this site(+/-) ?");
    char answer = Convert.ToChar(Console.ReadLine()!);
    Authentication authentication = new Authentication();
    if (answer=='+')
    {
        Storage storage12 = new();
        Console.Clear();
        Console.WriteLine("****************************");
        Console.WriteLine("           Login            ");
        Console.WriteLine("****************************");
        Console.Write("Please enter your Username: ");
        string enteredUsername = Console.ReadLine()!;
        Console.Write("Please enter your password: ");
        string entredPassword = Console.ReadLine()!;
        bool result1= authentication.Login(enteredUsername, entredPassword);
        if (result1)
        {
            Console.WriteLine($"***** Wellcome {enteredUsername} *****");
            Console.WriteLine("Press (1) if you want to shop.");
            Console.WriteLine("Press (2) if you want to logout.");
            int task = int.Parse(Console.ReadLine()!);
            if (task==1)
            {
                UserMeniue();
            }
            else if (task==2)
            {
                Console.WriteLine("***** goodbye *****");
            }
        }
        else if (!result1)
        {
            Console.WriteLine("There is no person with this information ib database!");
        }
    }
    else if (answer=='-')
    {
        Console.Clear();
        Console.WriteLine("****************************");
        Console.WriteLine("          Register          ");
        Console.WriteLine("****************************");
        Console.Write("Please enter your email: ");
        string email = Console.ReadLine()!;
        Console.Write("Please enter your wanted password: ");
        string passsword = Console.ReadLine()!;
        Console.Write("Please enter your wanted username: ");
        string Username = Console.ReadLine()!;
        bool result2= authentication.Register(email, passsword, Username);
        if (result2)
        {
            Console.WriteLine("You have been registed succesfully. Now Please login.");
        }
        else if (!result2)
        {
            Console.WriteLine("PLease try againe");
        }
    }
}








void UserMeniue()
{
    Console.Clear();
    ShopService shopService = new ShopService();
    int currentUserID = Storage.CurrentUsersId();
    Console.WriteLine("Please choose one of the category below: ");
    Console.WriteLine("1.Huose");
    Console.WriteLine("2.Fantasi");
    Console.WriteLine("3.Cooking");
    int answer3 = int.Parse(Console.ReadLine()!);
    //check trypars
    if (answer3==1)
    {
        shopService.GetListOfItems(1);
    }
    else if (answer3==2)
    {
        shopService.GetListOfItems(2);
    }
    else if (answer3==3)
    {
        shopService.GetListOfItems(3);
    }
    Console.Write("Please choose one of the items above by ID: ");
    int Idofitem = int.Parse(Console.ReadLine()!);
    Console.Write("PLease enter the amount of this item: ");
    int Itemamount = int.Parse(Console.ReadLine()!);
    bool result3= shopService.Checkamount(Idofitem, Itemamount);
    if (!result3)
    {
        Console.WriteLine("Try again!");
        UserMeniue();
    }
    bool result4= shopService.AddToShoppingCart(Idofitem, currentUserID);
    if (result4)
    {
        Console.WriteLine("This item added to your shopping cart.");
    }
    else if (!result4)
    {
        Console.WriteLine("Try again!");
    }
    Console.WriteLine("------------------------");
    Console.WriteLine("Press (1) if you want to add some other iteams.");
    Console.WriteLine("Press (2) if you want to see your receipt.");
    Console.WriteLine("Prees (3) if you want to settlement.");
    int answer5 = int.Parse(Console.ReadLine()!);
    if (answer5==1)
    {
        UserMeniue();
    }
    else if (answer5==2)
    {
        shopService.ShoppingCart(currentUserID);
    }
    else if (answer5==3)
    {
        shopService.ShoppingCart(currentUserID);
        Console.WriteLine("------------------------");
        int lastprice= shopService.Settlement(currentUserID);
        Console.WriteLine($"The last avaluable price that you can pay is: {lastprice}");
        Console.WriteLine("Press (+) if you want to settlement.");
        Console.WriteLine("Press (-) if you want to add other items.");
        Console.WriteLine("Press (*) clear your shopping cart.");
        char answer6 = Convert.ToChar(Console.ReadLine()!);
        if (answer6=='+')
        {
            Console.WriteLine("Done.");
            Storage.CurrentUser = null;
        }
        else if (answer6=='-')
        {
            UserMeniue();
        }
        else if (answer6=='*')
        {
            Storage.CurrentUser.ShoppingCart = null;
        }
    }
}