using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.EducationDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Member")]
    public class EducationController : Controller
    {
        private IMapper _mapper;
        private IGenericService<Education> _educationService;
        public EducationController(IGenericService<Education> educationService, IMapper mapper)
        {
            _mapper = mapper;
            _educationService = educationService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "egitim";
            return View(_mapper.Map<List<EducationListDto>>(_educationService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var education = _educationService.GetById(id);
            _educationService.Delete(education);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            TempData["active"] = "egitim";
            return View(new EducationAddDto());
        }

        [HttpPost]
        public IActionResult Add(EducationAddDto model)
        {
            TempData["active"] = "egitim";
            if (ModelState.IsValid)
            {
                _educationService.Insert(_mapper.Map<Education>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "egitim";
            var education = _educationService.GetById(id);
            return View(_mapper.Map<EducationUpdateDto>(education));
        }

        [HttpPost]
        public IActionResult Update(EducationUpdateDto model)
        {
            TempData["active"] = "egitim";
            if (ModelState.IsValid)
            {
                _educationService.Update(_mapper.Map<Education>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
