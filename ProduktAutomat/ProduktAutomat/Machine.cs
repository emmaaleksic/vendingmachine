using System;
namespace ProductAutomat
{

    public class Machine
    {
        public int moneyInMachine { get; set; }

        public Machine(int moneyInMachine)
        {

            this.moneyInMachine = moneyInMachine;
        }
        public void buyProduct(int productPrice)
        {
            moneyInMachine = moneyInMachine - productPrice;
        }


    }

}