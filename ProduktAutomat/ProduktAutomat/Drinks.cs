using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace ProductAutomat
{
    public class Drinks : InfoProducts
    {
        public Drinks(string name, string productInfo, int price) : base(name, productInfo, price)
        {
        }
        public override void buy()
        {
            Console.WriteLine($"Ditt köpt på totalt {this.Price}:- är godkänt");
        }

        public override void description()
        {
            Console.WriteLine($"Din {this.ProductInfo} anländer snart....");
        }

        public override void use()
        {
            Console.WriteLine($"Save water, drick {this.Name}!");
        }

    }
}

