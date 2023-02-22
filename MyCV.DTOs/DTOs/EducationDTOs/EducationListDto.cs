using MyCV.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.DTOs.DTOs.EducationDTOs
{
    public class EducationListDto: IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Point { get; set; }
        public string MaxPoint { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
