#pragma checksum "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Shared\FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6a7172e76cdd6cd657ce4cd11d42d5cc1ecf249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FooterPartial), @"mvc.1.0.view", @"/Views/Shared/FooterPartial.cshtml")]
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
#line 2 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\_ViewImports.cshtml"
using CrowdfundingSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\_ViewImports.cshtml"
using CrowdfundingSite.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\_ViewImports.cshtml"
using CrowdfundingSite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\_ViewImports.cshtml"
using CloudinaryDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\_ViewImports.cshtml"
using CloudinaryDotNet.Actions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a7172e76cdd6cd657ce4cd11d42d5cc1ecf249", @"/Views/Shared/FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f89c92acaa7905817fd0165b37be0b486437ba7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <!-- End Navbar -->
<footer class=""footer"" style=""background-color: #344675"">
    <div class=""container"">
        <div class=""row row-grid align-items-center mb-5"">
            <div class=""col-lg-6"">
                <h3 class=""navbar-brand"" style=""color:white"">Crowdfunding camp</h3>
                <h4 class=""text-white display-1"" style=""color:white; font-size: 15px"">Новый способ помогать хорошим идеям</h4><br />
                <h4 class=""mb-0 font-weight-light"" style=""color:white; font-size: 15px"">Авторизируйтесь, чтобы создать проект</h4>
            </div>
            <div class=""col-lg-6 text-lg-center btn-wrapper"">
                <button target=""_blank"" href=""https://www.facebook.com/CreativeTim/"" rel=""nofollow"" class=""btn-icon-only rounded-circle btn btn-facebook"" data-toggle=""tooltip"" data-original-title=""Like us"">
                    <span class=""btn-inner--icon""><i class=""fab fa-facebook""></i></span>
                </button>
                <button target=""_blank"" href=""https://twitter.com/creati");
            WriteLiteral(@"vetim"" rel=""nofollow"" class=""btn btn-icon-only rounded-circle"" data-toggle=""tooltip"" data-original-title=""Follow us"" style=""background-color: #5181b8"">
                    <span class=""btn-inner--icon""><i class=""fa fa-vk""  style=""color: white""></i></span>
                </button>
                <button target=""_blank"" href=""https://dribbble.com/creativetim"" rel=""nofollow"" class=""btn btn-icon-only btn-google-plus rounded-circle"" data-toggle=""tooltip"" data-original-title=""Follow us"">
                    <span class=""btn-inner--icon""><i class=""fa fa-google""></i></span>
                </button>
            </div>
        </div>
        <hr />
        <div class=""row align-items-center justify-content-md-between"">
            <div class=""col-md-6"">
                <div class=""copyright"">
                    &copy; 2021 <a");
            BeginWriteAttribute("href", " href=\"", 1855, "\"", 1862, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Crowdfundcamp.com</a>\n                </div>\n            </div>\n            <div class=\"col-md-6\">\n                <ul class=\"nav nav-footer justify-content-end\">\n                    <li class=\"nav-item\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2111, "\"", 2118, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\" target=\"_blank\">Главная</a>\n                    </li>\n                    <li class=\"nav-item\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2259, "\"", 2266, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\" target=\"_blank\">Аккаунт</a>\n                    </li>\n                    <li class=\"nav-item\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2407, "\"", 2414, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\" target=\"_blank\">Поиск</a>\n                    </li>\n                </ul>\n            </div>\n        </div>\n    </div>\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
