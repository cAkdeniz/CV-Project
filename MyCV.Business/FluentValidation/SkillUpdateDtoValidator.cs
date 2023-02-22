using FluentValidation;
using MyCV.DTOs.DTOs.SkillDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.FluentValidation
{
    public class SkillUpdateDtoValidator: AbstractValidator<SkillUpdateDto>
    {
        public SkillUpdateDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş Geçilemez");
        }
    }
}
