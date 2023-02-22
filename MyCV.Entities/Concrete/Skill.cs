using MyCV.Entities.Interfaces;
using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using System.Text;

namespace MyCV.Entities.Concrete
{
    [Table("Skills")]
    public class Skill: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
