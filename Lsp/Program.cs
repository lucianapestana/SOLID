using System;
using Lsp.Payments;

namespace Lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreditCard card = new CreditCard();
            //DebitCard card = new DebitCard();
            BankRewards card = new BankRewards();

            card.Validate();
            card.CollectPayment();

            Console.ReadLine();
        }
    }
}
