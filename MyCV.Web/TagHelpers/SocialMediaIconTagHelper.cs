using Microsoft.AspNetCore.Razor.TagHelpers;
using MyCV.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Web.TagHelpers
{
    [HtmlTargetElement("GetIcon")]
    public class SocialMediaIconTagHelper: TagHelper
    {
        private ISocialMediaService _socialMediaService;
        public SocialMediaIconTagHelper(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public int AppUserId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var icons = _socialMediaService.GetByUserId(AppUserId);
            string data = "<div class='social - icons'>";

            foreach (var item in icons)
            {
                data += $"<a class='social - icon' href='{item.Link}'><i class='{item.Icon} fa-4x mr-2' style='color:blue'></i></a>";
            }

            data += "</div>";

            output.Content.SetHtmlContent(data);
        }
    }
}
