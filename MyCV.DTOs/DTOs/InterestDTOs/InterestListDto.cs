using MyCV.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.DTOs.DTOs.InterestDTOs
{
    public class InterestListDto: IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
