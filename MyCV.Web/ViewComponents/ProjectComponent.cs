using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCV.Business.Interfaces;
using MyCV.DTOs.DTOs.ProjectDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.ViewComponents
{
    public class ProjectComponent: ViewComponent
    {
        private IMapper _mapper;
        private IGenericService<Project> _projectService;
        public ProjectComponent(IGenericService<Project> projectService, IMapper mapper)
        {
            _mapper = mapper;
            _projectService = projectService;
        }

        public IViewComponentResult Invoke()
        {
            var project = _projectService.GetById(1);
            return View(_mapper.Map<ProjectListDto>(project));
        }
    }
}
