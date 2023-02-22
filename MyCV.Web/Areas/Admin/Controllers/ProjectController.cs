using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.ProjectDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProjectController : Controller
    {
        private IMapper _mapper;
        private IGenericService<Project> _projectService;
        public ProjectController(IGenericService<Project> projectService, IMapper mapper)
        {
            _mapper = mapper;
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "proje";
            var proje = _projectService.GetById(1);
            return View(_mapper.Map<ProjectUpdateDto>(proje));
        }

        [HttpPost]
        public IActionResult Index(ProjectUpdateDto model)
        {
            TempData["active"] = "proje";
            if (ModelState.IsValid)
            {
                _projectService.Update(_mapper.Map<Project>(model));
                TempData["message"] = "Güncelleme İşlemi Başarıyla Gerçekleşti.";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
