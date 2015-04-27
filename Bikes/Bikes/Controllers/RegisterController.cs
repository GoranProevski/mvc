using Register.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Register.BusinessLayer.Contracts;

namespace Bikes.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            BikeDisplayCommand bikeComm = new BikeDisplayCommand("getall");
            BikeDisplayResult result = CommandInvoker.InvokeCommand<BikeDisplayCommand, BikeDisplayResult>(bikeComm);
            return View(result.bikes);
        }
    }
}