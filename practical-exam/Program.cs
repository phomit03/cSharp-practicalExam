using System;
using System.Collections.Generic;

namespace practical_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManage manageProduct = new ProductManage();

            while (true)
            {
                Console.WriteLine("\n\t PRODUCT MANAGEMENT PROGRAM C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Add product records.                          **");
                Console.WriteLine("**  2. Display product records.                      **");
                Console.WriteLine("**  3. Delete product records.                       **");
                Console.WriteLine("**  4. Exit.                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Please enter options: ");
                int key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Add products.");
                        manageProduct.AddProduct();
                        Console.WriteLine("\nMore successful products!");
                        break;
                    case 2:
                        if (manageProduct.ProductNumber() > 0)
                        {
                            Console.WriteLine("\n2. Show product list.");
                            manageProduct.ShowProduct(manageProduct.getListProduct());
                        }
                        else
                        {
                            Console.WriteLine("\nProduct list is empty!");
                        }
                        break;
                    case 3:
                        if (manageProduct.ProductNumber() > 0)
                        {
                            string ID;
                            Console.WriteLine("\n3. Delete product by ID.");
                            Console.Write("\nInput ID to delete: ");
                            ID = Console.ReadLine();
                            if (manageProduct.DeleteById(ID))
                            {
                                Console.WriteLine("\nProduct ID with = {0} has been removed!", ID);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nThere are no products in the list.");
                        }
                        break;
                    
                    case 4:
                        Console.WriteLine("\nYou have exited the program!");
                        return;
                    default:
                        Console.WriteLine("\nThis function is not available in the menu.");
                        Console.WriteLine("\nPlease choose again!");
                        break;
                }
            }
        }
    }
}