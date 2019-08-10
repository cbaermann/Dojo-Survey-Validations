using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidtion.Models;

namespace DojoSurveyValidtion.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        

        [HttpPost("Create")]

        public IActionResult Create(Survey newSurvey)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", newSurvey);
            }

            else
            {
                return View("Index");
            }
        }

        [HttpGet("Success")]
        public IActionResult Success (Survey newSurvey)
        {
            return View ("Success", newSurvey);
        }

  
    }
}
