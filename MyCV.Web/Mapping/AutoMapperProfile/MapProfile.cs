using AutoMapper;
using MyCV.DTOs.DTOs.AppUserDTOs;
using MyCV.DTOs.DTOs.CertificationDTOs;
using MyCV.DTOs.DTOs.EducationDTOs;
using MyCV.DTOs.DTOs.InterestDTOs;
using MyCV.DTOs.DTOs.ProjectDTOs;
using MyCV.DTOs.DTOs.SkillDTOs;
using MyCV.DTOs.DTOs.SocialMediaIconDTOs;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.Mapping.AutoMapperProfile
{
    public class MapProfile: Profile
    {
        public MapProfile()
        {
            CreateMap<AppUserListDto, AppUser>();
            CreateMap<AppUser, AppUserListDto>();
            CreateMap<AppUserUpdateDto, AppUser>();
            CreateMap<AppUser, AppUserUpdateDto>();

            CreateMap<Certification, CertificationListDto>();
            CreateMap<CertificationListDto, Certification>();
            CreateMap<CertificationAddDto, Certification>();
            CreateMap<Certification, CertificationAddDto>();
            CreateMap<CertificationUpdateDto, Certification>();
            CreateMap<Certification, CertificationUpdateDto>();

            CreateMap<Education, EducationListDto>();
            CreateMap<EducationListDto, Education>();
            CreateMap<Education, EducationAddDto>();
            CreateMap<EducationAddDto, Education>();
            CreateMap<Education, EducationUpdateDto>();
            CreateMap<EducationUpdateDto, Education>();

            CreateMap<Project, ProjectListDto>();
            CreateMap<ProjectListDto, Project>();
            CreateMap<Project, ProjectAddDto>();
            CreateMap<ProjectAddDto, Project>();
            CreateMap<Project, ProjectUpdateDto>();
            CreateMap<ProjectUpdateDto, Project>();

            CreateMap<Interest, InterestListDto>();
            CreateMap<InterestListDto, Interest>();
            CreateMap<Interest, InterestAddDto>();
            CreateMap<InterestAddDto, Interest>();
            CreateMap<Interest, InterestUpdateDto>();
            CreateMap<InterestUpdateDto, Interest>();

            CreateMap<Skill, SkillListDto>();
            CreateMap<SkillListDto, Skill>();
            CreateMap<Skill, SkillAddDto>();
            CreateMap<SkillAddDto, Skill>();
            CreateMap<Skill, SkillUpdateDto>();
            CreateMap<SkillUpdateDto, Skill>();

            CreateMap<SocialMediaIcon, SocialMediaIconListDto>();
            CreateMap<SocialMediaIconListDto, SocialMediaIcon>();
            CreateMap<SocialMediaIcon, SocialMediaIconAddDto>();
            CreateMap<SocialMediaIconAddDto, SocialMediaIcon>();
            CreateMap<SocialMediaIcon, SocialMediaIconUpdateDto>();
            CreateMap<SocialMediaIconUpdateDto, SocialMediaIcon>();
        }
    }
}
