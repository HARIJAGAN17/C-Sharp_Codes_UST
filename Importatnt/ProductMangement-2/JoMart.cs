using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18_6_2024
{
    internal class JoMart
    {
        private List<Mobile> mobiles;

        public JoMart()
        {
            mobiles = new List<Mobile>();

        }


        public void AddMobile(Mobile mobile)
        {
            if (mobiles.Find(individualMobile => individualMobile.Name == mobile.Name) == null)
            {
                mobile.Id = mobiles.Count == 0 ? 3000 : mobiles.Max(m => m.Id) + 1;
                mobiles.Add(mobile);
                Console.WriteLine($"{mobile.Name} is added to the list");
            }
            else
            {
                Console.WriteLine("Mobile Already Exists!");
            }
        }

        public void RemoveMobile()
        {
            if (mobiles.Count > 0)
            {
                mobiles.Clear();
                Console.WriteLine("All products are removed");
            }
            else
            {
                Console.WriteLine("There is no product Exist please add some product!");
            }
        }

        public void DisplayProducts()
        {

            if (mobiles.Count > 0)
            {
                Console.WriteLine("Here the product list:");
                mobiles.ForEach(mobile =>
                {
                    Console.WriteLine($"Id-{mobile.Id} Name-{mobile.Name} ManufactureBy-{mobile.ManufacturedBy} Price-{mobile.Price}");
                });
            }
            else
            {
                Console.WriteLine("There is no product Exist please add some product!");
            }
        }

        public void SearchLessMax()
        {


            if (mobiles.Count > 0)
            {
                
                mobiles.ForEach(mobile =>
                {
                    if (mobile.Price < mobiles.Max((p) => p.Price))
                    {
                        Console.WriteLine($"Id-{mobile.Id} Name-{mobile.Name} ManufactureBy-{mobile.ManufacturedBy} Price-{mobile.Price}");
                    }
                });
            }
            else
            {
                Console.WriteLine("There is no product Exist please add some product!");
            }
        }

        public void SearchByManufacture(String s)
        {
            if (mobiles.Count > 0)
            {
                mobiles.FindAll((m) => m.ManufacturedBy == s).ForEach(mobile =>
                {
                    Console.WriteLine($"Id-{mobile.Id} Name-{mobile.Name} ManufactureBy-{mobile.ManufacturedBy} Price-{mobile.Price}");
                });
            }
            else
            {
                Console.WriteLine($"There is no manufacture Exist in the Name of {s}!");
            }
        }

        public void BetweenMaxMin()
        {



            if (mobiles.Count > 0)
            {

                if (mobiles.Count <= 2)
                {
                    Console.WriteLine($"Only {mobiles.Count} element exist here");
                    mobiles.ForEach(mobile =>
                    {

                        Console.WriteLine($"Id-{mobile.Id} Name-{mobile.Name} ManufactureBy-{mobile.ManufacturedBy} Price-{mobile.Price}");
                        return;

                    });
                }
                else
                {


                    mobiles.ForEach(mobile =>
                    {
                        if (mobile.Price > mobiles.Min((p) => p.Price) && mobile.Price < mobiles.Max((p) => p.Price))
                        {
                            Console.WriteLine($"Id-{mobile.Id} Name-{mobile.Name} ManufactureBy-{mobile.ManufacturedBy} Price-{mobile.Price}");
                        }
                    });
                }

            }
            else
            {
                Console.WriteLine("There is no product Exist please add some product!");
            }

        }

        public void RemoveMinMax()
        {
            if (mobiles.Count > 0)
            {
                if (mobiles.Count <= 2)
                {
                    Console.WriteLine($"Only {mobiles.Count} element(s) exist here");
                }
                else
                {
                    // Create a list to hold mobiles to remove
                    List<Mobile> mobilesToRemove = new List<Mobile>();

                    
                    double minPrice = mobiles.Min(p => p.Price);
                    double maxPrice = mobiles.Max(p => p.Price);

                    
                    foreach (Mobile mobile in mobiles)
                    {
                        if (mobile.Price > minPrice && mobile.Price < maxPrice)
                        {
                            mobilesToRemove.Add(mobile);
                        }
                    }

                    // Remove the collected items from the mobiles list
                    foreach (Mobile mobile in mobilesToRemove)
                    {
                        mobiles.Remove(mobile);
                    }
                    Console.WriteLine("Products removed from the list");
                }
            }
            else
            {
                Console.WriteLine("There is no product Exist please add some product!");
            }
        }






    }
}
