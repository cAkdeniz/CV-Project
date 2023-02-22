using Dapper.Contrib.Extensions;
using MyCV.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Entities.Concrete
{
    [Table("SocialMediaIcons")]
    public class SocialMediaIcon: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }

        public int AppUserId { get; set; }
    }
}
