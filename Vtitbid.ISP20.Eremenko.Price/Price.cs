using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Eremenko.Price
{
    internal class Price
    {
        public string Name;
        public string Shop;
        public string Cost;

        public Price(string name, string shop, string cost)
        {
            Name = name;
            Shop = shop;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Название товара: {Name}, название магазина: {Shop}, Стоимость товара (в рублях): {Cost}";
        }
    }
}
