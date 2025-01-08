using System;

namespace Lsp.Payments
{
    abstract class BankCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado!");
        }

        public virtual void Validate()
        {
            //Validação básica
        }
    }
}
