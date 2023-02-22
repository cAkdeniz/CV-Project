using FluentValidation;
using MyCV.DTOs.DTOs.ProjectDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.FluentValidation
{
    public class ProjectUpdateDtoValidator: AbstractValidator<ProjectUpdateDto>
    {
        public ProjectUpdateDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş Geçilemez.");
        }
    }
}
