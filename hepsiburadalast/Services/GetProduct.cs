using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hepsiburadalast.Models;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using hepsiburadalast.Controllers;

namespace hepsiburadalast.Services
{



    public class GetProduct
    {
        private List<ProductModelTest2> _productModel;


        public ProductList.Result GetProductApi()
        {
            var client = new RestClient("https://listing-external.hepsiburada.com/listings/merchantid/885ea783-6b3e-41ef-a344-6cd1d289a1ea");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Basic ZW15ZF9kZXY6RW15ZDEyMzQ1IQ==");
            request.AlwaysMultipartFormData = true;
            IRestResponse response = client.Execute(request);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response.Content);

            string _xml = doc.InnerXml;

            return XmlHelper.DeserializeXmlToObject<ProductList.Result>(_xml, "Result");

        }

        public List<hbimagename.hbimagenames> GetHbimagename()
        {
            List<hbimagename.hbimagenames> Data = new List<hbimagename.hbimagenames>();

            try
            {
                IWebDriver driver = new ChromeDriver();
                //var sku1 = _productModel.hepsiburadaSku;
                _productModel = new HomeController().GetApiData();
                var productsku = _productModel.Select(a => a.hepsiburadaSku);
                List<hbimagename.hbimagenames> ImageData = new List<hbimagename.hbimagenames>();
                

                List<hbimagename.hbimagenames> denemes = new();

                foreach (var item in productsku.Take(5))
                {
                    denemes.Add(new hbimagename.hbimagenames
                    {
                        hepsiburadaSku = item,
                        //Url = "https://www.hepsiburada.com/--p-" + item
                    });
                    //var hepsiburadasku = item;
                    //driver.Url = "https://www.hepsiburada.com/--p-" + hepsiburadasku;
                    //Thread.Sleep(2000);
                }

                foreach (var item in denemes)
                {
                    driver.Url = "https://www.hepsiburada.com/--p-" + item.hepsiburadaSku;
                    Thread.Sleep(2000);
                }

                string Name = driver.FindElement(By.CssSelector("h1#product-name")).Text;
                string gorselyolu = "";

                foreach (var item in driver.FindElements(By.CssSelector("div#productThumbnailsCarousel .owl-item img")))
                {
                    gorselyolu = item.GetAttribute("src").Replace("48-64", "960-1280");

                    Data.Add(new hbimagename.hbimagenames
                    {
                        image = gorselyolu,
                        name = Name,
                        hepsiburadaSku = denemes.Where(w => w.Url == driver.Url).Select(s => s.hepsiburadaSku).FirstOrDefault()
                    });
                }

                driver.Close();
            }
            catch
            {
                
            }

            return Data;

        }
    }

    //public class Deneme1
    //{
    //    public string productsku { get; set; }
    //    public string Url { get; set; }
    //}
}
