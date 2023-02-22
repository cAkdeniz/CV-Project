using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.SkillDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SkillController : Controller
    {
        private IMapper _mapper;
        private IGenericService<Skill> _skillService;
        public SkillController(IMapper mapper, IGenericService<Skill> skillService)
        {
            _mapper = mapper;
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "yetenek";
            return View(_mapper.Map<List<SkillListDto>>(_skillService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "yetenek";
            var skill = _skillService.GetById(id);
            _skillService.Delete(skill);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            TempData["active"] = "yetenek";
            return View(new SkillAddDto());
        }

        [HttpPost]
        public IActionResult Add(SkillAddDto model)
        {
            TempData["active"] = "yetenek";
            if (ModelState.IsValid)
            {
                _skillService.Insert(_mapper.Map<Skill>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "yetenek";
            var skill = _skillService.GetById(id);
            return View(_mapper.Map<SkillUpdateDto>(skill));
        }

        [HttpPost]
        public IActionResult Update(SkillUpdateDto model)
        {
            TempData["active"] = "yetenek";
            if (ModelState.IsValid)
            {
                _skillService.Update(_mapper.Map<Skill>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
