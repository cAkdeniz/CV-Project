using Dapper.Contrib.Extensions;
using MyCV.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Entities.Concrete
{
    [Table("Interests")]
    public class Interest: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
