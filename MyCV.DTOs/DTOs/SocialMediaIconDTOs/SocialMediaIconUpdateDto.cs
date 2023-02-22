using MyCV.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.DTOs.DTOs.SocialMediaIconDTOs
{
    public class SocialMediaIconUpdateDto: IDto
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }

        public int AppUserId { get; set; }
    }
}
