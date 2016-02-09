using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson10ASP.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index(int param=0)
        {
            if (param == 0)
            {
                return View("~/Views/First/Index1.cshtml");
            }

            else if (param > 0)
            {
                return View("~/Views/First/Index2.cshtml");
            }
            else if (param < 0)
            {
                return View("~/Views/First/Index3.cshtml");
            }
            else return View();
        }


        public ActionResult MinMax(int min = 0, int max = 0)
        {
            int[] nums = new int[(max - min) + 1];
            List<int> list = new List<int>();
            for (int i = min; i <= max; i++)
            {
                list.Add(i);
              
            }

            ViewBag.Res = list;

            return View(list);
        }

    }
}