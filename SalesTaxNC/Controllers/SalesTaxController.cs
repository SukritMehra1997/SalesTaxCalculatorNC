using SalesTaxNC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace SalesTaxNC.Controllers
{
    public class SalesTaxController : ApiController
    {
        [HttpGet]
        [Route("api/salestax/calculate/{county}/{cost:float}")]
        public HttpResponseMessage Calculate(string county, float cost)
        {
            try
            {
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(JObject.Parse(new TransactionReply(new Transaction(county, cost)).TransactionStatus).ToString(), Encoding.UTF8, "application/json")
                };
            }
            catch
            {
                var httpResponseFail = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Unable to perform function")
                };
                return httpResponseFail;
            }
        }
    }
}
