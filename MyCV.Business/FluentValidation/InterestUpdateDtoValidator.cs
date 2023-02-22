using FluentValidation;
using MyCV.DTOs.DTOs.InterestDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.FluentValidation
{
    public class InterestUpdateDtoValidator : AbstractValidator<InterestUpdateDto>
    {
        public InterestUpdateDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş Geçilemez");
        }
    }
}
