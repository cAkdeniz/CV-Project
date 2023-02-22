using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.SkillDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.ViewComponents
{
    public class SkillComponent:ViewComponent
    {
        private IMapper _mapper;
        private IGenericService<Skill> _skillService;
        public SkillComponent(IGenericService<Skill> skillService, IMapper mapper)
        {
            _mapper = mapper;
            _skillService = skillService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<SkillListDto>>(_skillService.GetAll()));
        }
    }
}
