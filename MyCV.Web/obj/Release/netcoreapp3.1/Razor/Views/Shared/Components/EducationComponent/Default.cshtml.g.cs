#pragma checksum "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\EducationComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f41fed5d2660708437390bce8532c31182fe949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EducationComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EducationComponent/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\_ViewImports.cshtml"
using MyCV.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\_ViewImports.cshtml"
using MyCV.DTOs.DTOs.AppUserDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\_ViewImports.cshtml"
using MyCV.DTOs.DTOs.CertificationDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\_ViewImports.cshtml"
using MyCV.DTOs.DTOs.EducationDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\_ViewImports.cshtml"
using MyCV.DTOs.DTOs.InterestDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\_ViewImports.cshtml"
using MyCV.DTOs.DTOs.ProjectDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\_ViewImports.cshtml"
using MyCV.DTOs.DTOs.SkillDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\_ViewImports.cshtml"
using MyCV.DTOs.DTOs.SocialMediaIconDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f41fed5d2660708437390bce8532c31182fe949", @"/Views/Shared/Components/EducationComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa0f30427194db7fcdb1c5f6e94ed574b7acf0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EducationComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EducationListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <section class=\"resume-section\" id=\"education\">\r\n        <div class=\"resume-section-content\">\r\n            <h2 class=\"mb-5\">Eğitim</h2>\r\n");
#nullable restore
#line 5 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\EducationComponent\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"d-flex flex-column flex-md-row justify-content-between mb-5\">\r\n                    <div class=\"flex-grow-1\">\r\n                        <h3 class=\"mb-2\">");
#nullable restore
#line 9 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\EducationComponent\Default.cshtml"
                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <div style=\"color:black\" class=\"subheading\">");
#nullable restore
#line 10 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\EducationComponent\Default.cshtml"
                                                               Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <p style=\"color:black\"><strong>Not: </strong>");
#nullable restore
#line 11 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\EducationComponent\Default.cshtml"
                                                                Write(item.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 11 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\EducationComponent\Default.cshtml"
                                                                              Write(item.MaxPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"flex-shrink-0\"><span class=\"text-primary\">");
#nullable restore
#line 13 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\EducationComponent\Default.cshtml"
                                                                     Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 13 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\EducationComponent\Default.cshtml"
                                                                                       Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                </div>\r\n");
#nullable restore
#line 15 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\EducationComponent\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EducationListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
