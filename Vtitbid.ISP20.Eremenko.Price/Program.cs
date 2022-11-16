using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Eremenko.Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Price[] price = new Price[3];
            for (int i=0; i< price.Length;i++)
            {
                Console.WriteLine("Название товара: ");
                string name = Console.ReadLine();
                Console.WriteLine("Название магазина: ");
                string shop = Console.ReadLine();
                Console.WriteLine("Стоимость товара (в рублях): ");
                string cost = Console.ReadLine();
                price[i] = new Price(name, shop, cost);
            }
            price = price.OrderBy(obj => obj.Shop).ToArray();
            for (int i=0; i< price.Length;i++)
            {
                Console.WriteLine(price[i]);
            }
            Console.WriteLine("Поиск по магазину: ");
            string ser = Console.ReadLine();
            for (int i=0; i< price.Length; i++)
            {
                if (ser.ToLower() == price[i].Shop.ToLower())
                {
                    Console.WriteLine(price[i]);
                }
                else if (ser.ToLower() != price[i].Shop.ToLower() && i == price.Length -1)
                {
                    Console.WriteLine("Такого магазина нет!!!");
                }
            }
            Console.ReadKey();
        }
    }
}
