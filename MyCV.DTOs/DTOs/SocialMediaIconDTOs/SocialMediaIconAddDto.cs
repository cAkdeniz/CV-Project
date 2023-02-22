using MyCV.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.DTOs.DTOs.SocialMediaIconDTOs
{
    public class SocialMediaIconAddDto: IDto
    {
        public string Link { get; set; }
        public string Icon { get; set; }

        public int AppUserId { get; set; }
    }
}
