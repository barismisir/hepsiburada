using hepsiburadalast.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using hepsiburadalast.Services;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace hepsiburadalast.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductModel _productModel;
        private readonly ProductList _productList;

        public IActionResult Index()
        {
            #region tuple
            //// string sku = _productModel.hepsiburadaSku;
            // var data2 = new GetProduct().GetHbimagename("HBCV000004SAMJ");

            // var listproduct1 = data2.Select(s => new ProductModel
            // {
            //     name = s.name,
            //     image = s.image

            // }).ToList();


            // var data = new GetProduct().GetProductApi();

            // var listproduct2 = data.Listings.Listing.ToList().Select(s => new ProductModel
            // {
            //     hepsiburadaSku = s.HepsiburadaSku,
            //     cargoCompany1 = s.CargoCompany1,
            //     price = s.Price,
            //     availableStock = s.AvailableStock,
            //     //image=listproduct1.Select(a=>a.image).ToString(),
            //     //name=listproduct1.Select(a=>a.name).FirstOrDefault().ToString()

            // }).ToList();



            //var tuple = (listproduct1, listproduct2);
            #endregion tuple

            HomeViewModel homeViewModel = new()
            {
                Test1 = GetImageNamee(),
                Test2 = GetApiData()
            }


            ;
            //GetImageNamee();

            return View(homeViewModel);

        }
        //public IActionResult Privacy()
        //{
        //    return View(GetImageNamee());
        //}

        public List<ProductModelTest1> GetImageNamee()
        {


            var data2 = new GetProduct().GetHbimagename();

            var listproduct2 = data2.Select(s => new ProductModelTest1
            {
                name = s.name,
                image = s.image

            }).ToList();


            return listproduct2;
        }

        public List<ProductModelTest2> GetApiData()
        {
            var data = new GetProduct().GetProductApi();

            var listproduct2 = data.Listings.Listing.ToList().Select(s => new ProductModelTest2
            {
                hepsiburadaSku = s.HepsiburadaSku,
                cargoCompany1 = s.CargoCompany1,
                price = s.Price,
                availableStock = s.AvailableStock

                //image=listproduct1.Select(a=>a.image).ToString(),
                //name=listproduct1.Select(a=>a.name).FirstOrDefault().ToString()

            }).ToList();





            return listproduct2;


        }



    }

    public class HomeViewModel
    {
        public List<ProductModelTest1> Test1 { get; set; }
        public List<ProductModelTest2> Test2 { get; set; }

    }
}
