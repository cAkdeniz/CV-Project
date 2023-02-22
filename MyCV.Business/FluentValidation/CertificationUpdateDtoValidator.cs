using FluentValidation;
using MyCV.DTOs.DTOs.CertificationDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.FluentValidation
{
    public class CertificationUpdateDtoValidator: AbstractValidator<CertificationUpdateDto>
    {
        public CertificationUpdateDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş Geçilemez.");
        }
    }
}
