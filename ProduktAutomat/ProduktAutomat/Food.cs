using System;
namespace ProductAutomat
{
    public class Food : InfoProducts
    {
        public Food(string name, string productInfo, int price) : base(name, productInfo, price)
        { }

        public override void buy()
        {

            Console.WriteLine($"Ditt köpt på totalt {this.Price}:- är godkänt");
        }

        public override void description()
        {
            Console.WriteLine($"Din {this.Name} med {this.ProductInfo} anländer snart....");
        }

        public override void use()
        {
            Console.WriteLine("Smaklig måltid!");
        }
    }

}

