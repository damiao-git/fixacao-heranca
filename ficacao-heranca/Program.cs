using System;
using System.Collections.Generic;
using fixacao_heranca.Entities;

namespace fixacao_heranca
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> prod = new List<Product>();

            for (int i = 1; i <= n; i++)
                {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported(c/i/u)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (ch)
                    {
                    case 'c':
                    case 'C':
                    prod.Add(new Product(name, price));
                    break;

                    case 'i':
                    case 'I':
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    prod.Add(new ImportedProduct(name, price, customsFee));
                    break;

                    case 'u':
                    case 'U':
                    Console.Write("Manufactured date: (DD/MM/YYYY) ");
                    DateTime manufacturedDate = DateTime.Parse(Console.ReadLine());
                    prod.Add(new UsedProduct(name, price, manufacturedDate));
                    break;
                    }
                }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in prod)
                {
                Console.WriteLine(p.PriceTag());
                }
            }
        }
    }
