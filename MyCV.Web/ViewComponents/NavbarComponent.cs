using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.AppUserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.ViewComponents
{
    public class NavbarComponent: ViewComponent
    {
        private IMapper _mapper;
        private IAppUserService _appUserService;
        public NavbarComponent(IMapper mapper, IAppUserService appUserService)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var appUser = _appUserService.GetById(1);
            return View(_mapper.Map<AppUserListDto>(appUser));
        }
    }
}
