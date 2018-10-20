using CategoryCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CategoryCalculator.Controllers
{
    public class UserController : Controller
    {

        UserDBContext objUserDBContext = new UserDBContext();
         
        public ActionResult Index()
        {
            return View();
        }

        public string SaveUserInfo(UserInput objinfo)
        {          
            objUserDBContext.userInputs.Add(objinfo);
            objUserDBContext.SaveChanges();            
            return "xyz category";
        }

        public ActionResult GetUserList()
        {
            List<UserInput> objList = new List<UserInput>();           
            return View(objUserDBContext.userInputs);
        }
    }
}