using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.EducationDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.ViewComponents
{
    public class EducationComponent: ViewComponent
    {
        private IMapper _mapper;
        private IGenericService<Education> _educationService;
        public EducationComponent(IMapper mapper, IGenericService<Education> educationService)
        {
            _mapper = mapper;
            _educationService = educationService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<EducationListDto>>(_educationService.GetAll()));
        }
    }
}
