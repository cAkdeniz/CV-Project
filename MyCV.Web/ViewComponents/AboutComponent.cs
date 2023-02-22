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
    public class AboutComponent: ViewComponent
    {
        private IMapper _mapper;
        private IAppUserService _appUserService;
        public AboutComponent(IAppUserService appUserService, IMapper mapper)
        {
            _mapper = mapper;
            _appUserService = appUserService;
        }

        public IViewComponentResult Invoke()
        {
            var appUser = _appUserService.GetById(1);
            return View(_mapper.Map<AppUserListDto>(appUser));
        }
    }
}
