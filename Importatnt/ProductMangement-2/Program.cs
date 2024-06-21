namespace Assignment_18_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            JoMart shop = new JoMart();

            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nPlease Select from the options below:\n");
                Console.WriteLine("1.Add the products \n2.Display the Products \n3.Search mobiles whose price is less than the max price of mobiles.\n4.Search all mobiles by Manufacturer.\n5.View all mobiles whose price is greater than minimum mobile price and less than maximum mobile price.\n6.Remove mobiles whose price is greater than minimum mobile price and less than maximum mobile price.\n7.To remove all the products\n8.To exit the application\n");
                Console.WriteLine("Enter the Choice:");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("That was not a valid number. Please enter a number from 1 to 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Enter the product name:");
                        String name = Console.ReadLine();
                        Console.WriteLine("Enter manufacturedBy:");
                        String manufacture = Console.ReadLine();
                        Console.WriteLine("Enter description about the product:");
                        String description = Console.ReadLine();
                        Console.WriteLine("Enter the price of product:");


                        double price;
                        while (true)
                        {
                            if (double.TryParse(Console.ReadLine(), out  price))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("That was not a valid price. Please enter a valid number:");
                            }
                        }

                        


                        Mobile mobile = new Mobile()
                        {

                            Name = name.ToLower(),
                            ManufacturedBy = manufacture.ToLower(),
                            Description = description.ToLower(),
                            Price = price,

                        };

                        shop.AddMobile(mobile);
                        break;
                    case 2:
                        shop.DisplayProducts();
                        break;
                    case 3:
                        shop.SearchLessMax();
                        break;
                    case 4:
                        Console.WriteLine("Enter the manufacture name");
                        string brand = Console.ReadLine();
                        brand = brand.ToLower();
                        shop.SearchByManufacture(brand);
                        break;
                    case 5:
                        shop.BetweenMaxMin();
                        break;
                    case 6:
                       shop.RemoveMinMax();
                        break;
                    case 7:
                        shop.RemoveMobile();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nEnter a valid Input");
                        break;

                }




            }
        }
    }
}
