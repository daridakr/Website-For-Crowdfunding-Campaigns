#pragma checksum "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8f70561f131f3e260960b6c281dabb1f3011e10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetategsPartial), @"mvc.1.0.view", @"/Views/Shared/MetategsPartial.cshtml")]
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
#line 2 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\_ViewImports.cshtml"
using CrowdfundingSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\_ViewImports.cshtml"
using CrowdfundingSite.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\_ViewImports.cshtml"
using CrowdfundingSite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\_ViewImports.cshtml"
using CloudinaryDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\_ViewImports.cshtml"
using CloudinaryDotNet.Actions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
using CrowdfundingSite.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f70561f131f3e260960b6c281dabb1f3011e10", @"/Views/Shared/MetategsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f89c92acaa7905817fd0165b37be0b486437ba7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetategsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n<meta name=\"author\" content=\"Daria Krivushkina\">\n<meta name=\"keywords\" content=\"crowdfunding, crowd\">\n<meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 274, "\"", 284, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 7 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<title>");
#nullable restore
#line 9 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
  Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title> ");
#nullable restore
#line 9 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
                              }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<title>");
#nullable restore
#line 12 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
  Write(Config.SiteTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>");
#nullable restore
#line 12 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 450, "\"", 480, 1);
#nullable restore
#line 15 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
WriteAttributeValue("", 460, ViewBag.Description, 460, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 16 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 547, "\"", 577, 1);
#nullable restore
#line 19 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
WriteAttributeValue("", 557, ViewBag.Description, 557, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 20 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 638, "\"", 665, 1);
#nullable restore
#line 23 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
WriteAttributeValue("", 648, ViewBag.Keywords, 648, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 23 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Shared\MetategsPartial.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
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
