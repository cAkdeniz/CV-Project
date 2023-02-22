using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.CertificationDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class CertificationController : Controller
    {
        private IMapper _mapper;
        private IGenericService<Certification> _certificationService;
        public CertificationController(IGenericService<Certification> certificationService, IMapper mapper)
        {
            _mapper = mapper;
            _certificationService = certificationService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "sertifika";
            return View(_mapper.Map<List<CertificationListDto>>(_certificationService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "sertifika";
            var certifica = _certificationService.GetById(id);
            _certificationService.Delete(certifica);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View(new CertificationAddDto());
        }

        [HttpPost]
        public IActionResult Add(CertificationAddDto model)
        {
            TempData["active"] = "sertifika";
            if (ModelState.IsValid)
            {
                _certificationService.Insert(_mapper.Map<Certification>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "sertifika";
            var certificate = _certificationService.GetById(id);
            return View(_mapper.Map<CertificationUpdateDto>(certificate));
        }

        [HttpPost]
        public IActionResult Update(CertificationUpdateDto model)
        {
            TempData["active"] = "sertifika";
            if(ModelState.IsValid)
            {
                _certificationService.Update(_mapper.Map<Certification>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
