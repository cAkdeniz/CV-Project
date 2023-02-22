using FluentValidation;
using MyCV.DTOs.DTOs.EducationDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.FluentValidation
{
    public class EducationAddDtoValidator: AbstractValidator<EducationAddDto>
    {
        public EducationAddDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Boş Geçilemez.");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Boş Geçilemez.");
            RuleFor(x => x.EndDate).NotEmpty().WithMessage("Boş Geçilemez.");
            RuleFor(x => x.Point).NotEmpty().WithMessage("Boş Geçilemez.");
        }
    }
}
