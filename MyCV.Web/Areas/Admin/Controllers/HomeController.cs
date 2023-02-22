using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.AppUserDTOs;
using MyCV.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private IMapper _mapper;
        private IAppUserService _appUserService;
        public HomeController(IAppUserService appUserService, IMapper mapper)
        {
            _mapper = mapper;
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "bilgilerim";
            var user = _appUserService.FindByUserName(User.Identity.Name);

            var appUserListDto = new AppUserUpdateModel
            {
                Email = user.Email,
                Adress = user.Adress,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth,
                ShortDescription = user.ShortDescription,
                ImageUrl = user.ImageUrl
            };

            return View(appUserListDto);
        }

        [HttpPost]
        public IActionResult Index(AppUserUpdateModel model)
        {
            TempData["active"] = "bilgilerim";
            if (ModelState.IsValid)
            {
                var updatedUser = _appUserService.GetById(model.Id);
                if (model.Picture != null)
                {
                    var imgName = Guid.NewGuid() + Path.GetExtension(model.Picture.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/img/" + imgName);
                    var stream = new FileStream(path, FileMode.Create);
                    model.Picture.CopyTo(stream);
                    updatedUser.ImageUrl = imgName;
                }
                updatedUser.FirstName = model.FirstName;
                updatedUser.LastName = model.LastName;
                updatedUser.Email = model.Email;
                updatedUser.PhoneNumber = model.PhoneNumber;
                updatedUser.Adress = model.Adress;
                updatedUser.ShortDescription = model.ShortDescription;

                _appUserService.Update(updatedUser);

                TempData["message"] = "Güncelleme İşlemi Başarıyla Gerçekleşti.";

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult ChangePassword()
        {
            TempData["active"] = "sifre";
            var user = _appUserService.FindByUserName(User.Identity.Name);
            var appUserPasswordDto = new AppUserPasswordDto
            {
                Id = user.Id,
                OldPassword = user.Password
            };
            return View(appUserPasswordDto);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(AppUserPasswordDto appUserPasswordDto)
        {
            TempData["active"] = "sifre";
            if(ModelState.IsValid)
            {
                var user = _appUserService.FindByUserName(User.Identity.Name);
                if(user.Password != appUserPasswordDto.OldPassword)
                {
                    ModelState.AddModelError("", "Eski Şifre Yanlış");
                    return View(appUserPasswordDto);
                }
                user.Password = appUserPasswordDto.Password;
                _appUserService.Update(user);

                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                return RedirectToAction("Index");
            }
            return View(appUserPasswordDto);
        }
    }
}
