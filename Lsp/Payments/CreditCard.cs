using System;

namespace Lsp.Payments
{
    class CreditCard : BankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando limite....");
            Console.WriteLine("Limite OK!");
        }
    }
}
