using MyCV.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.DTOs.DTOs.AppUserDTOs
{
    public class AppUserPasswordDto: IDto
    {
        public int Id { get; set; }
        public string OldPassword { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
