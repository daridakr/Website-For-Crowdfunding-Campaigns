#pragma checksum "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe2c7692e41230935ca9fb7407a0117717ae81b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe2c7692e41230935ca9fb7407a0117717ae81b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f89c92acaa7905817fd0165b37be0b486437ba7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntitiesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Begin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-icon mt-3 mb-sm-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
      
        string strTitle = "Краудфандинг";
        ViewBag.Title = strTitle;
        int countOfCampaign = Model.Campaigns.Count();
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"page-header\">\n        <div class=\"col px-0\">\n            <div class=\"row align-items-center justify-content-center\">\n                <div class=\"col-lg-6 text-center\">\n                    <h1 class=\"text-white display-1\">");
#nullable restore
#line 11 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                                                Write(strTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                    <h2 class=\"display-4 font-weight-normal text-white\" style=\"font-size: 20px\">Новый способ помогать хорошим идеям</h2>\n                    <div class=\"btn-wrapper mt-4\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffe2c7692e41230935ca9fb7407a0117717ae81b5722", async() => {
                WriteLiteral("\n                            <span class=\"btn-inner--icon\"><i class=\"ni ni-button-play\"></i></span>\n                            <span class=\"btn-inner--text\">Начать</span>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
    <center>
        <div>
            <div id=""tagcloud"" style=""width: 950px; height: 300px;""></div>
        </div>
    </center>
    <br />
    <br />
    <div class=""col-md-8 mx-auto text-center"">
        <h3 class=""display-3"" style=""color: white"">Популярные проекты</h3>
");
#nullable restore
#line 32 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
         if (Model.Campaigns.Any())
        {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
     foreach (Campaign entity in Model.Campaigns)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"google.com\">\n        <div class=\"card shadow\" style=\"background-image: url(~/wwwroot/img/77.jpg); background-color: white\">\n            <div class=\"card-body\"");
            BeginWriteAttribute("style", " style=\"", 1572, "\"", 1580, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"tab-content\" id=\"myTabContent\">\n                    <div style=\"text-align: right\">\n");
#nullable restore
#line 41 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                         if (entity.AverageRating < 20.0) for (int i = 0; i < 5; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-star\"></i>\n");
#nullable restore
#line 44 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                            }
                        else if (entity.AverageRating < 40.0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-star\" style=\"color: #fb6340\"></i>\n");
#nullable restore
#line 47 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                            for (int i = 0; i < 5; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 50 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                            }
                        }
                        else if (entity.AverageRating < 60.0)
                        {
                            for (int i = 0; i < 2; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-star\" style=\"color: #fb6340\"></i>\n");
#nullable restore
#line 57 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                            }
                            for (int i = 0; i < 40; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 61 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                            }
                        }
                         else if (entity.AverageRating < 80.0)
                        {
                            for (int i = 0; i < 3; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-star\" style=\"color: #fb6340\"></i>\n");
#nullable restore
#line 68 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                            }
                            for (int i = 0; i < 2; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 72 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                            }
                        }
                        else if (entity.AverageRating < 100.0)
                        {
                            for (int i = 0; i < 4; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-star\" style=\"color: #fb6340\"></i>\n");
#nullable restore
#line 79 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-star\"></i>\r\n");
#nullable restore
#line 81 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                        }
                        else if (entity.AverageRating == 100.0)
                        {
                            for (int i = 0; i < 5; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-star\" style=\"color: #fb6340\"></i>\n");
#nullable restore
#line 87 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                    <h1>");
#nullable restore
#line 90 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                   Write(entity.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 91 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                       string title = @Model.Subjects.Where(sub => sub.Id == @entity.ThemeId).Select(sub => sub.Title).First(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"display-3\" style=\"font-size:15px; color: #525f7f\">");
#nullable restore
#line 92 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                                                                            Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <div class=\"tab-pane fade show active\" id=\"tabs-icons-text-1\" role=\"tabpanel\" aria-labelledby=\"tabs-icons-text-1-tab\">\n                        <p class=\"description\">");
#nullable restore
#line 94 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                                          Write(entity.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-6"">
                            <div style=""text-align: left"">
                                <span class=""badge badge-pill badge-default text-uppercase"">Default</span>
                                <span class=""badge badge-pill badge-default text-uppercase"">Default</span>
                                <span class=""badge badge-pill badge-default text-uppercase"">Default</span>
                                <span class=""badge badge-pill badge-default text-uppercase"">Default</span>
                            </div>
                            <div style=""text-align: left; margin-top: 10px"">
");
#nullable restore
#line 105 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                                   
                                    var percent = (entity.TotalMoneyAmount / entity.RequiredMoneyAmount) * 100;
                                    percent = Math.Round(percent);
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h3 class=\"display-3\" style=\"font-size:15px; color: #525f7f\">Средний рейтинг ");
#nullable restore
#line 109 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                                                                                                        Write(entity.AverageRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                <h3 class=\"display-3\" style=\"font-size:15px; color: #525f7f\">Завершено на ");
#nullable restore
#line 110 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                                                                                                     Write(percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h3>\n\n                            </div>\n                        </div>\n                        <div class=\"col-lg-6 mt-5 mt-lg-0\"");
            BeginWriteAttribute("style", " style=\"", 5772, "\"", 5780, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div style=""text-align: right"">
                                <span class=""badge badge-pill badge-default text-uppercase"">Default</span>
                                <span class=""badge badge-pill badge-default text-uppercase"">Default</span>
                            </div>
                            <div style=""text-align: right; margin-top: 10px"">
                                <h3 class=""display-3"" style=""font-size:15px; color: #525f7f"">Дата окончания ");
#nullable restore
#line 120 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                                                                                                       Write(entity.EndDate.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                <h3 class=\"display-3\" style=\"font-size:15px; color: #525f7f\">Собрано ");
#nullable restore
#line 121 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                                                                                                Write(entity.TotalMoneyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 121 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                                                                                                                         Write(entity.RequiredMoneyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" у.е.</h3>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </a>\n    <br />\n");
#nullable restore
#line 130 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\даша\Documents\CrowdfundingSite\CrowdfundingSite\Views\Home\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <br />
    <br />
    <div class=""col-md-8 mx-auto text-center"">
        <h3 class=""display-4"" style=""color: white"">Последние</h3>
        <div class=""card shadow"">
            <div class=""card-body"">
                <div class=""tab-content"" id=""myTabContent"">
                    <div class=""tab-pane fade show active"" id=""tabs-icons-text-1"" role=""tabpanel"" aria-labelledby=""tabs-icons-text-1-tab"">
                        <p class=""description"">Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth.</p>
                        <p class=""description"">Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse.</p>
                    </div>
                    <div class=""tab-pane fade"" id=""tabs-icons-text-2"" role=""tabpanel"" aria-labelledby=""tabs-icon");
            WriteLiteral(@"s-text-2-tab"">
                        <p class=""description"">Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.</p>
                    </div>
                    <div class=""tab-pane fade"" id=""tabs-icons-text-3"" role=""tabpanel"" aria-labelledby=""tabs-icons-text-3-tab"">
                        <p class=""description"">Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>");
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
