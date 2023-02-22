using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCV.DataAccess.Interfaces;
using MyCV.DTOs.DTOs.InterestDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class InterestController : Controller
    {
        private IMapper _mapper;
        private IGenericDal<Interest> _interestService;
        public InterestController(IMapper mapper, IGenericDal<Interest> interestService)
        {
            _mapper = mapper;
            _interestService = interestService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "ilgi";
            return View(_mapper.Map<List<InterestListDto>>(_interestService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var interest = _interestService.GetById(id);
            _interestService.Delete(interest);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var interest = _interestService.GetById(id);
            return View(_mapper.Map<InterestUpdateDto>(interest));
        }

        [HttpPost]
        public IActionResult Update(InterestUpdateDto model)
        {
            if(ModelState.IsValid)
            {
                _interestService.Update(_mapper.Map<Interest>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Add()
        {
            return View(new InterestAddDto());
        }

        [HttpPost]
        public IActionResult Add(InterestAddDto model)
        {
            if(ModelState.IsValid)
            {
                _interestService.Insert(_mapper.Map<Interest>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
