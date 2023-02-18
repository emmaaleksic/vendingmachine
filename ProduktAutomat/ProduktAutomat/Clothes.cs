using System;
namespace ProductAutomat
{
    public class Clothes : InfoProducts
    {


        public Clothes(string name, string productInfo, int price) : base(name, productInfo, price)
        {
        }

        public override void buy()
        {
            Console.WriteLine($"Ditt köpt på totalt {this.Price}:- är godkänt");
        }

        public override void description()
        {
            Console.WriteLine($"Din {this.Name} anländer snart....");
        }

        public override void use()
        {
            Console.WriteLine($"Varsågod! Din {this.ProductInfo} {this.Name} är redo att använda direkt :)");

        }



    }

}








