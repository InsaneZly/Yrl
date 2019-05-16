using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cl201831980103.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            ViewBag.aaa = "这是我自定义控制器My中的Index动作的数据";
            return View();
        }
    }
}