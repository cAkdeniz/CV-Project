using MyCV.Entities.Interfaces;
using System;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Entities.Concrete
{
    [Table("AppUsers")]
    public class AppUser: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public DateTime DateOfBirth { 
            get
            {
                return new DateTime(2000, 04, 12);
            }
            private set
            {

            }
        }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ShortDescription { get; set; }
    }
}
