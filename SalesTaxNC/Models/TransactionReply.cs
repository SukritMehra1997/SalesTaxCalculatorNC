using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesTaxNC.Models
{
    public class TransactionReply
    {
        public string TransactionStatus { get; set; }
        public Transaction Trans { get; set; }
        public float Tax { get; set; }

        public TransactionReply(Transaction trans)
        {
            Trans = trans;
            GetSalesTax();
        }

        private void GetSalesTax()
        {
            TransactionTotal a = new TransactionTotal();
            float tax = a.calculate(Trans);
            if (tax > 0)
            {
                
                TransactionStatus = "{\"status\":\"SUCCESS\",\"data\":[\""+tax.ToString("c2") + "\"]}"; 
                Tax =  tax;
            }
            else
            {
                TransactionStatus = "{\"status\":\"FAIL\",\"data\":[\"\"]}";
                Tax = 0;
            }
        }
}
}