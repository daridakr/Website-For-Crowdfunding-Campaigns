#pragma checksum "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b81f27e778f9e1650957371f8e52b6eb523fb265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campaign_GetAllCampaignes), @"mvc.1.0.view", @"/Views/Campaign/GetAllCampaignes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81f27e778f9e1650957371f8e52b6eb523fb265", @"/Views/Campaign/GetAllCampaignes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f89c92acaa7905817fd0165b37be0b486437ba7", @"/Views/_ViewImports.cshtml")]
    public class Views_Campaign_GetAllCampaignes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntitiesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Campaign", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchCampaignes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
  
    string strTitle = "Кампании";
    ViewBag.Title = strTitle;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-5 mx-auto text-center mt-1\">\r\n    <h3 class=\"display-4\" style=\"color: white\">");
#nullable restore
#line 9 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                          Write(strTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
</div>
<div class=""mt-5"">
    <div class=""row d-flex justify-content-center"">
        <div class=""col-md-10"">
            <div class=""card p-3 py-4"">
                <h5>Найдите интересующий вас проект и поддержите его!</h5>
                <div class=""row g-3 mt-2"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b81f27e778f9e1650957371f8e52b6eb523fb2656287", async() => {
                WriteLiteral(@"
                        <div class=""col-md-9""> <input type=""text"" class=""form-control"" placeholder=""Поиск кампаний..."" name=""name""> </div>
                        <div class=""col-md-3""> <input type=""submit"" class=""btn btn-warning btn-icon mt-3 mb-sm-0"" value=""Найти""/> </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""mt-3"">
                    <a data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"" class=""advanced""> Advance Search With Filters <i class=""fa fa-angle-down""></i> </a>
                    <div class=""collapse"" id=""collapseExample"">
                        <div class=""card card-body"">
                            <div class=""row"">
                                <div class=""col-md-4""> <input type=""text"" placeholder=""Property ID"" class=""form-control""> </div>
                                <div class=""col-md-4""> <input type=""text"" class=""form-control"" placeholder=""Search by MAP""> </div>
                                <div class=""col-md-4""> <input type=""text"" class=""form-control"" placeholder=""Search by Country""> </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
            WriteLiteral("\n<br />\r\n<br />\r\n<!-- Кампании -->\r\n<div class=\"col-md-10 mx-auto text-center\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 43 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
             if (Model.Campaigns.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                 foreach(Campaign entity in Model.Campaigns)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-6 col-sm-6 col-md-6 mb-4 col-lg-4\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2320, "\"", 2359, 2);
            WriteAttributeValue("", 2327, "/campaign/getcampaign/", 2327, 22, true);
#nullable restore
#line 48 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
WriteAttributeValue("", 2349, entity.Id, 2349, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card shadow\" style=\"background-image: url(~/wwwroot/img/77.jpg); background-color: white\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2536, "\"", 2559, 1);
#nullable restore
#line 50 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
WriteAttributeValue("", 2542, entity.CoverPath, 2542, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                        <div class=\"card-body\"");
            BeginWriteAttribute("style", " style=\"", 2630, "\"", 2638, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"tab-content\" id=\"myTabContent\">\r\n                                <div style=\"text-align: right\">\r\n");
#nullable restore
#line 54 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                     if (entity.AverageRating < 20.0) for (int i = 0; i < 5; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fa fa-star\"></i> ");
#nullable restore
#line 56 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                       }
                                    else if (entity.AverageRating < 40.0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-star\" style=\"color: #fb6340\"></i> ");
#nullable restore
#line 58 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                        for (int i = 0; i < 4; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 61 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                        }
                                    }
                                    else if (entity.AverageRating < 60.0)
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fa fa-star\" style=\"color: #fb6340\"></i> ");
#nullable restore
#line 67 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                              }
                                        for (int i = 0; i < 3; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 71 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                        }
                                    }
                                    else if (entity.AverageRating < 80.0)
                                    {
                                        for (int i = 0; i < 3; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fa fa-star\" style=\"color: #fb6340\"></i> ");
#nullable restore
#line 77 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                              }
                                        for (int i = 0; i < 2; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 81 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                        }
                                    }
                                    else if (entity.AverageRating < 100.0)
                                    {
                                        for (int i = 0; i < 4; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fa fa-star\" style=\"color: #fb6340\"></i> ");
#nullable restore
#line 87 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 89 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                    }
                                    else if (entity.AverageRating == 100.0)
                                    {
                                        for (int i = 0; i < 5; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fa fa-star\" style=\"color: #fb6340\"></i>");
#nullable restore
#line 94 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                             }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <h5>");
#nullable restore
#line 97 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                               Write(entity.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 98 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                   string title = @Model.Subjects.Where(sub => sub.Id == @entity.ThemeId).Select(sub => sub.Title).First(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h3 class=\"display-3\" style=\"font-size:15px; color: #525f7f\">");
#nullable restore
#line 99 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                        Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <div class=\"tab-pane fade show active\" id=\"tabs-icons-text-1\" role=\"tabpanel\" aria-labelledby=\"tabs-icons-text-1-tab\">\r\n                                    <p class=\"description\">");
#nullable restore
#line 101 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                      Write(entity.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"row justify-content-center\">\r\n                                    <div class=\"col-lg-6\">\r\n");
            WriteLiteral("                                        <div style=\"text-align: left; margin-top: 10px\">\r\n");
#nullable restore
#line 112 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                               var percent = (entity.TotalMoneyAmount / entity.RequiredMoneyAmount) * 100;
                                                percent = Math.Round(percent); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h3 class=\"display-3\" style=\"font-size:15px; color: #525f7f\">Средний рейтинг ");
#nullable restore
#line 114 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                                                    Write(entity.AverageRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                            <h3 class=\"display-3\" style=\"font-size:15px; color: #525f7f\">Завершено на ");
#nullable restore
#line 115 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                                                 Write(percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h3>\r\n\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"col-lg-6 mt-5 mt-lg-0\"");
            BeginWriteAttribute("style", " style=\"", 7456, "\"", 7464, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                                        <div style=\"text-align: right; margin-top: 10px\">\r\n                                            <h3 class=\"display-3\" style=\"font-size:15px; color: #525f7f\">Дата окончания ");
#nullable restore
#line 125 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                                                   Write(entity.EndDate.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                            <h3 class=\"display-3\" style=\"font-size:15px; color: #525f7f\">Собрано ");
#nullable restore
#line 126 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                                            Write(entity.TotalMoneyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 126 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                                                                                                                                     Write(entity.RequiredMoneyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" руб.</h3>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
                <br />
            </div>
");
#nullable restore
#line 136 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Учёба\Базы Данных\Курсовая\CrowdfundingSite — копия\CrowdfundingSite\Views\Campaign\GetAllCampaignes.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntitiesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
