#pragma checksum "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\CertificationComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a61174bbe45e864d14084f2df01d595acaa95e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CertificationComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CertificationComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a61174bbe45e864d14084f2df01d595acaa95e0", @"/Views/Shared/Components/CertificationComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa0f30427194db7fcdb1c5f6e94ed574b7acf0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CertificationComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CertificationListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <section class=\"resume-section\" id=\"awards\">\r\n        <div class=\"resume-section-content\">\r\n            <h2 class=\"mb-5\">Sertifikalar</h2>\r\n            <ul class=\"fa-ul mb-0\">\r\n");
#nullable restore
#line 7 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\CertificationComponent\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <span class=\"fa-li\"><i class=\"fas fa-trophy text-warning\"></i></span>\r\n                        <h4>");
#nullable restore
#line 11 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\CertificationComponent\Default.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </li>\r\n");
#nullable restore
#line 13 "C:\Users\User\Documents\C#Projects\MyCV\MyCV.Web\Views\Shared\Components\CertificationComponent\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CertificationListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
