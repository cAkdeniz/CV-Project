using FluentValidation;
using MyCV.DTOs.DTOs.AppUserDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.FluentValidation
{
    public class AppUserPasswordDtoValidator: AbstractValidator<AppUserPasswordDto>
    {
        public AppUserPasswordDtoValidator()
        {
            RuleFor(x => x.OldPassword).NotEmpty().WithMessage("Eski Parola boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Parola(Tekrar) boş geçilemez");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Parolalar eşleşmiyor.");
        }
    }
}
