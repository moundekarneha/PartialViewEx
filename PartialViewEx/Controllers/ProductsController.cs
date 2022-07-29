using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewEx.Models;

namespace PartialViewEx.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> list = new List<Product>()
        {
            new Product(){Pid=1,Name="Nature image 1",Price=120.9,Photo="~/Images/img1.jpg"},
            new Product(){Pid=2,Name="Nature image 2",Price=190.9,Photo="~/Images/img2.jpg"},
            new Product(){Pid=3,Name="Nature image 3",Price=100.9,Photo="~/Images/img3.jpg"},
            new Product(){Pid=4,Name="Nature image 4",Price=160.9,Photo="~/Images/img4.jpg"},
            new Product(){Pid=5,Name="Nature image 5",Price=170.9,Photo="~/Images/img5.jpg"}
        };

        //partial view
        public PartialViewResult Prototype()
        {
            return PartialView();
        }

        // GET: Products
        public ActionResult Index()
        {
            return View(list);
        }
    }
}