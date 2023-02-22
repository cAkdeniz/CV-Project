using FluentValidation;
using MyCV.DTOs.DTOs.EducationDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.FluentValidation
{
    public class EducationUpdateDtoValidator: AbstractValidator<EducationUpdateDto>
    {
        public EducationUpdateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Boş Geçilemez.");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Boş Geçilemez.");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Boş Geçilemez.");
            RuleFor(x => x.EndDate).NotEmpty().WithMessage("Boş Geçilemez.");
            RuleFor(x => x.Point).NotEmpty().WithMessage("Boş Geçilemez.");
        }
    }
}
