using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.InterestDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.ViewComponents
{
    public class InterestComponent: ViewComponent
    {
        private IMapper _mapper;
        private IGenericService<Interest> _interestService;
        public InterestComponent(IGenericService<Interest> interestService, IMapper mapper)
        {
            _mapper = mapper;
            _interestService = interestService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<InterestListDto>>(_interestService.GetAll()));
        }
    }
}
