using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.Models
{
    public class AppUserUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad alanı boş geçilemez.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Adres alanı boş geçilemez.")]
        public string Adress { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "E-mail alanı boş geçilemez.")]
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Telefon Numarası alanı boş geçilemez.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Ön Yazı alanı boş geçilemez.")]
        public string ShortDescription { get; set; }
        public string UserName { get; set; }
        public IFormFile Picture { get; set; }
    }
}
