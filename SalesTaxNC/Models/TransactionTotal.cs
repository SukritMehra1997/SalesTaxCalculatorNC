using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace SalesTaxNC.Models
{

    //class used for calculating sales tax
    public class TransactionTotal
    {
        private County LoadJson(string county)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\ncTax.json";
            using (StreamReader r = new StreamReader(dir))
            {
                County retCounty = null;
                string json = r.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                County[] array = js.Deserialize<County[]>(json);
                foreach (var x in array)
                {
                    if (string.Equals(x.name, county, StringComparison.OrdinalIgnoreCase))
                    {
                        retCounty = x;
                    }
                }
                return retCounty;
            }
        }

        public float calculate(Transaction trans)
        {
            County curr = LoadJson(trans.county);
            if (curr != null)
                return trans.cost * curr.tax / 100;
            else 
                return -1;
        }
        
    }
}