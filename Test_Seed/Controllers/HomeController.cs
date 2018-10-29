using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_Seed.Data;
using System.Linq;

namespace Test_Seed.Controllers
{
    public class HomeController : Controller
    {
        private TestContext _testContext;
        private Test_2Context _test_2Context;

        public HomeController(TestContext testContext, Test_2Context test_2Context)
        {
            _testContext = testContext;
            _test_2Context = test_2Context;
        }
        public IActionResult Index()
        {
            var query = (from f in _testContext.Books join t in _test_2Context.Orders on f.BookID equals t.BookID select f.BookID);
            query.ToList();
            return View();
        }
    }
}