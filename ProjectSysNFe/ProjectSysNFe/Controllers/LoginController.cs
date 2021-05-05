using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSysNFe.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Conta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logar()
        {
            return Redirect("~/Home/Index");
        }

    }
}