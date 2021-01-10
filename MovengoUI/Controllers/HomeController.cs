using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovengoUI.Models;

namespace MovengoUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public async Task<ActionResult<Customer>> CheckCustomerLogin(IFormCollection collection)
        //{
        //    Customer cutomer = new Customer();
        //    var client = new HttpClient();
        //    client.DefaultRequestHeaders.Clear();
        //    UriBuilder builder = new UriBuilder("https://localhost:44356/api/Customers/ValidateCustomer?");
        //    builder.Query = "email=" + collection["exampleInputEmail1"] + "&UserPassword=" + collection["exampleInputPassword1"];
        //    HttpResponseMessage Res = await client.GetAsync(builder.Uri);
        //    var Customer = Res.Content.ReadAsStringAsync().Result;
        //    var a = JsonConvert.DeserializeObject<Customer>(Customer);
        //    //Store in cookies
        //    if (Request.Cookies["userid"] == null)
        //    {
        //        CookieOptions option = new CookieOptions();
        //        option.Expires = DateTime.Now.AddDays(50);
        //        option.IsEssential = true;
        //        Response.Cookies.Append("userid", a.Id.ToString(), option);

        //    }
        //    Load load = new Load();
        //    //Featured--field name MarkAsNew
        //    var clientF = new HttpClient();
        //    var urlF = "https://localhost:44356/api/Products/GetFeatuedProducts";
        //    var responseF = await clientF.GetAsync(urlF);
        //    var FeaturedProduct = responseF.Content.ReadAsStringAsync().Result;
        //    load.FeaturedProduct = JsonConvert.DeserializeObject<Product[]>(FeaturedProduct);
        //    //New Arrivals--field name Recent
        //    var clientN = new HttpClient();
        //    var urlN = "https://localhost:44356/api/Products/GetNewProducts";
        //    var responseN = await clientN.GetAsync(urlN);
        //    var NewProduct = responseN.Content.ReadAsStringAsync().Result;
        //    load.NewProduct = JsonConvert.DeserializeObject<Product[]>(NewProduct);
        //    //Customers
        //    if (Request.Cookies["userid"] != null)
        //    {
        //        var clientC = new HttpClient();
        //        UriBuilder builderC = new UriBuilder("https://localhost:44356/api/Customers/LoginID?");
        //        builderC.Query = "UserId=" + Request.Cookies["userid"];
        //        HttpResponseMessage responseC = await clientC.GetAsync(builderC.Uri);
        //        if (responseC.IsSuccessStatusCode)
        //        {
        //            var Users = responseC.Content.ReadAsStringAsync().Result;
        //            load.Customer = JsonConvert.DeserializeObject<Customer>(Users);
        //            ViewBag.UserName = load.Customer.Username;
        //        }
        //    }
        //    return View("Index", load);
        //}
        //public async Task<ActionResult<Customer>> CheckCustomerCookie()
        //{
        //    Customer cutomer = new Customer();
        //    var client = new HttpClient();

        //    //Customers
        //    if (Request.Cookies["userid"] != null)
        //    {
        //        var clientC = new HttpClient();
        //        UriBuilder builderC = new UriBuilder("https://localhost:44356/api/Customers/LoginID?");
        //        builderC.Query = "UserId=" + Request.Cookies["userid"];
        //        HttpResponseMessage responseC = await clientC.GetAsync(builderC.Uri);
        //        if (responseC.IsSuccessStatusCode)
        //        {
        //            var Users = responseC.Content.ReadAsStringAsync().Result;
        //            return JsonConvert.DeserializeObject<Customer>(Users);
        //        }
        //    }
        //    return null;

        //}
        ////By SM on Nov 12, 2020, remove Index1 action controller
        //public async Task<ActionResult> Index()
        //{
        //    try
        //    {
        //        Load load = new Load();
        //        //Featured--field name MarkAsNew
        //        var clientF = new HttpClient();
        //        var urlF = "https://localhost:44356/api/Products/GetFeatuedProducts";
        //        var responseF = await clientF.GetAsync(urlF);
        //        var FeaturedProduct = responseF.Content.ReadAsStringAsync().Result;
        //        load.FeaturedProduct = JsonConvert.DeserializeObject<Product[]>(FeaturedProduct);
        //        //New Arrivals--field name Recent
        //        var clientN = new HttpClient();
        //        var urlN = "https://localhost:44356/api/Products/GetNewProducts";
        //        var responseN = await clientN.GetAsync(urlN);
        //        var NewProduct = responseN.Content.ReadAsStringAsync().Result;
        //        load.NewProduct = JsonConvert.DeserializeObject<Product[]>(NewProduct);
        //        //Parent Categories
        //        var ClientPC = new HttpClient();
        //        var UrlPC = "https://localhost:44356/api/Products/GetParentCategories";
        //        var responsePC = await ClientPC.GetAsync(UrlPC);
        //        var ParentC = responsePC.Content.ReadAsStringAsync().Result;
        //        load.Category = JsonConvert.DeserializeObject<Category[]>(ParentC);
        //        //Sub-Categories
        //        var ClientSubCatMen = new HttpClient();
        //        var urlSubCatMen = "https://localhost:44356/api/Products/GetSubCategories";
        //        var responseSubCatMen = await ClientSubCatMen.GetAsync(urlSubCatMen);
        //        var SubCatMen = responseSubCatMen.Content.ReadAsStringAsync().Result;
        //        load.SubCatMen = JsonConvert.DeserializeObject<Category[]>(SubCatMen);
        //        //Customers
        //        if (Request.Cookies["userid"] != null)
        //        {
        //            var clientC = new HttpClient();
        //            UriBuilder builderC = new UriBuilder("https://localhost:44356/api/Customers/LoginID?");
        //            builderC.Query = "UserId=" + Request.Cookies["userid"];
        //            HttpResponseMessage responseC = await clientC.GetAsync(builderC.Uri);
        //            if (responseC.IsSuccessStatusCode)
        //            {
        //                var Users = responseC.Content.ReadAsStringAsync().Result;
        //                load.Customer = JsonConvert.DeserializeObject<Customer>(Users);
        //                ViewBag.UserName = load.Customer.Username;

        //            }
        //        }
        //        ViewBag.Vendormessage = TempData["Vendormessage"];
        //        return View("Index", load);
        //    }
        //    catch (Exception e)
        //    {
        //        Error err = new Error();
        //        err.ErrorMessage = "Sorry couldn't autoload";
        //        ViewBag.Error = err;
        //        return View("Error", err);
        //    }
        //}


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
