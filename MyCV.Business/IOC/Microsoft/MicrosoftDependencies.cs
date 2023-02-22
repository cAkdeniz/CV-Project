using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCV.Business.Concrete;
using MyCV.Business.FluentValidation;
using MyCV.Business.Interfaces;
using MyCV.DataAccess.Concrete.Dapper;
using MyCV.DataAccess.Interfaces;
using MyCV.DTOs.DTOs.AppUserDTOs;
using MyCV.DTOs.DTOs.CertificationDTOs;
using MyCV.DTOs.DTOs.EducationDTOs;
using MyCV.DTOs.DTOs.InterestDTOs;
using MyCV.DTOs.DTOs.ProjectDTOs;
using MyCV.DTOs.DTOs.SkillDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MyCV.Business.IOC.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(con => new SqlConnection(configuration.GetConnectionString("connectionMSSQL")));

            services.AddScoped(typeof(IGenericDal<>), typeof(DpGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IAppUserDal, DpAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<ISocialMediaIconDal, DpSocialMediaIconRepository>();
            services.AddScoped<ISocialMediaService, SocialMediaIconManager>();

            services.AddTransient<IValidator<AppUserPasswordDto>, AppUserPasswordDtoValidator>();
            services.AddTransient<IValidator<CertificationAddDto>, CertificationAddDtoValidator>();
            services.AddTransient<IValidator<CertificationUpdateDto>, CertificationUpdateDtoValidator>();
            services.AddTransient<IValidator<EducationAddDto>, EducationAddDtoValidator>();
            services.AddTransient<IValidator<EducationUpdateDto>, EducationUpdateDtoValidator>();
            services.AddTransient<IValidator<ProjectUpdateDto>, ProjectUpdateDtoValidator>();
            services.AddTransient<IValidator<InterestAddDto>, InterestAddDtoValidator>();
            services.AddTransient<IValidator<InterestUpdateDto>, InterestUpdateDtoValidator>();
            services.AddTransient<IValidator<SkillAddDto>, SkillAddDtoValidator>();
            services.AddTransient<IValidator<SkillUpdateDto>, SkillUpdateDtoValidator>();
        }
    }
}
