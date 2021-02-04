
using ApiTestLibrary;
using System;
using System.Linq;


namespace ApiTest
{   
    class Program
    {

        static void Main(string[] args)
        {
            Api api = new Api();
            while (true)
            {
                Console.WriteLine("1 join api \t2 exit");
                int value;

                if(!Int32.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("incorrect");
                    continue;
                }

                switch (value)
                {
                    case 1:
                        api.GetValue();
                        var list = api.root.Products.Join(api.root.Categories,
                            p => p.CategoryId,
                            c => c.Id,
                            (p, c) => new { Name = p.Name, CategoryName = c.Name });

                        Console.WriteLine("{0,20} {1,20}", "Product: ", "Category: ");

                        foreach (var item in list)
                        {
                            Console.WriteLine("{0,20} |{1,20}", item.Name, item.CategoryName);
                        }
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }                  
            }
        }
    }
}
