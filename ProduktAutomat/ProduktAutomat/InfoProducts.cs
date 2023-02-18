using System;
namespace ProductAutomat
{
    public abstract class InfoProducts : iDescription
    {

        public string Name { get; set; }
        public string ProductInfo { get; set; }
        public int Price { get; set; }


        public InfoProducts(string name, string productInfo, int price)
        {
            this.Name = name;
            this.ProductInfo = productInfo;
            this.Price = price;

        }

        public abstract void description();

        public abstract void buy();

        public abstract void use();
    }
}

