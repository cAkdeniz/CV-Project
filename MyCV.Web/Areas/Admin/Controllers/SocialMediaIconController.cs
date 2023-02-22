using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.SocialMediaIconDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SocialMediaIconController : Controller
    {
        private IMapper _mapper;
        private IAppUserService _appUserService;
        private ISocialMediaService _socialMediaService;

        public SocialMediaIconController(IMapper mapper, IAppUserService appUserService, 
            ISocialMediaService socialMediaService)
        {
            _mapper = mapper;
            _socialMediaService = socialMediaService;
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "sosyal";
            var user = _appUserService.FindByUserName(User.Identity.Name);
            var socialMediaIcon = _socialMediaService.GetByUserId(user.Id);
            return View(_mapper.Map<List<SocialMediaIconListDto>>(socialMediaIcon));
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "sosyal";
            var socialMedia = _socialMediaService.GetById(id);
            _socialMediaService.Delete(socialMedia);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            TempData["active"] = "sosyal";
            return View(new SocialMediaIconAddDto());
        }

        [HttpPost]
        public IActionResult Add(SocialMediaIconAddDto model)
        {
            TempData["active"] = "sosyal";
            if (ModelState.IsValid)
            {
                var user = _appUserService.FindByUserName(User.Identity.Name);
                model.AppUserId = user.Id;
                _socialMediaService.Insert(_mapper.Map<SocialMediaIcon>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "sosyal";
            var socialMedia = _socialMediaService.GetById(id);
            return View(_mapper.Map<SocialMediaIconUpdateDto>(socialMedia));
        }

        [HttpPost]
        public IActionResult Update(SocialMediaIconUpdateDto model)
        {
            TempData["active"] = "sosyal";
            if (ModelState.IsValid)
            {
                var user = _appUserService.FindByUserName(User.Identity.Name);
                model.AppUserId = user.Id;
                _socialMediaService.Update(_mapper.Map<SocialMediaIcon>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
