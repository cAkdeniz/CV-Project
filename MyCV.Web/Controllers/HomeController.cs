using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.Controllers
{
    public class HomeController : Controller
    {
        private IGenericService<Skill> _genericService;
        public HomeController(IGenericService<Skill> genericService)
        {
            _genericService = genericService;
        }

        public IActionResult Index()
        {
            var skills = _genericService.GetAll();
            return View(skills);
        }
    }
}
