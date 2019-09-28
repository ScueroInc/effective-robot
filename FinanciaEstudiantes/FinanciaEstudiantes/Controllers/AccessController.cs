using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinanciaEstudiantes.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {
                return Content("1");
            }
            catch(Exception e)
            {
                return Content("ocurrio un error :(" + e.Message);
            }
        }
    }
}