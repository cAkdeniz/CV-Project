using FluentValidation;
using MyCV.DTOs.DTOs.SkillDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.FluentValidation
{
    public class SkillAddDtoValidator: AbstractValidator<SkillAddDto>
    {
        public SkillAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş Geçilemez");
        }
    }
}
