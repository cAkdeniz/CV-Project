using Dapper.Contrib.Extensions;
using MyCV.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Entities.Concrete
{
    [Table("Educations")]
    public class Education : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Point { get; set; }
        public string MaxPoint { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
