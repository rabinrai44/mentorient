﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mentorient.Controllers
{
    public class TenantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}