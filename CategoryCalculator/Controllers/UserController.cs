﻿using CategoryCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CategoryCalculator.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
         
        public ActionResult SaveUserInfo(UserInput objinfo)
        {
            var _output =(objinfo.Age/objinfo.Height)*objinfo.Height;
            return new EmptyResult();
        }
    }
}