using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SalesTaxNC.Controllers;

namespace SalesTaxNC.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SalesTaxExpectedResult_intParameter()
        {
            var controller = new SalesTaxController();
            var response = controller.Calculate("Yancey", 123);
            var s = getData(response);

            Assert.IsTrue(response.IsSuccessStatusCode,"Function was not Executed successfully");

            Assert.AreEqual("$8.30", s,  "Expected result not equal to actual result");

        }
        [TestMethod]
        public void SalesTaxExpectedResult_floatParameter()
        {
            var controller = new SalesTaxController();
            var response = controller.Calculate("Yancey", (float)124.53);
            var s = getData(response);

            Assert.IsTrue(response.IsSuccessStatusCode, "Function was not Executed successfully");

            Assert.AreEqual("$8.41", s, "Expected result not equal to actual result");

        }
        [TestMethod]
        public void IsStatusFail()
        {
            var controller = new SalesTaxController();
            var response = controller.Calculate("Yance", 120);
            var s = getStatus(response);

            Assert.IsTrue(response.IsSuccessStatusCode, "Function was not Executed successfully");

            Assert.AreEqual("FAIL", s, "Transaction should Fail since county does not exist");

        }
        [TestMethod]
        public void IsStatusSuccess()
        {
            var controller = new SalesTaxController();
            var response = controller.Calculate("Yancey", 120);
            var s = getStatus(response);

            Assert.IsTrue(response.IsSuccessStatusCode, "Function was not Executed successfully");

            Assert.AreEqual("SUCCESS", s, "Transaction should be successful since county exists");

        }

        private string getData(System.Net.Http.HttpResponseMessage response)
        {
            var res = response.Content.ReadAsStringAsync().Result;
            var content = JsonConvert.DeserializeObject<Resp>(res);
            //Console.WriteLine(content.data);
            return content.data[0];
        }

        private string getStatus(System.Net.Http.HttpResponseMessage response)
        {
            var res = response.Content.ReadAsStringAsync().Result;
            var content = JsonConvert.DeserializeObject<Resp>(res);
            //Console.WriteLine(content.data);
            return content.status;
        }
    }


}
