﻿using System;

namespace Lsp.Payments
{
    class BankRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
            Console.WriteLine("Pontuação creditada!");
        }

        public void Validate()
        {
            Console.WriteLine("Limite OK, Rewards OK!");
        }
    }
}
