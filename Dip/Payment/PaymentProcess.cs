using System;
using Dip.Factory;
using Dip.Model;

namespace Dip.Payment
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            IDBProduct product = DBProductFactory.Create();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }
    }
}
