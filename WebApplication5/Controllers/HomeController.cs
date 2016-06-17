using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            TestModel TM = new TestModel();
            string str = TM.Test("Testing");
            return str;
        }
    }
}
