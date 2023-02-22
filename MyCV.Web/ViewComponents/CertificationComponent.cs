using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.CertificationDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.ViewComponents
{
    public class CertificationComponent: ViewComponent
    {
        private IMapper _mapper;
        private IGenericService<Certification> _certificationService;
        public CertificationComponent(IGenericService<Certification> certificationService,IMapper mapper)
        {
            _mapper = mapper;
            _certificationService = certificationService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<CertificationListDto>>(_certificationService.GetAll()));
        }
    }
}
