#pragma checksum "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98507081950f9b1d36841250011ba37312210662"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Salons_Details), @"mvc.1.0.view", @"/Areas/Manager/Views/Salons/Details.cshtml")]
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
#line 1 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\_ViewImports.cshtml"
using BeautyBooking.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\_ViewImports.cshtml"
using BeautyBooking.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98507081950f9b1d36841250011ba37312210662", @"/Areas/Manager/Views/Salons/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9061ceacb3f8e30506ec034bed1cdd1c222cf1d3", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manager_Views_Salons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BeautyBooking.Web.ViewModels.Salons.SalonWithServicesViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Manager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Salons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeServiceAvailableStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/rating-static.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
  
    this.ViewData["Title"] = "Salon Manager: " + Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row row-eq-height\">\n    <!-- Info Box -->\n    <div class=\"col-lg-5 info_box_col\">\n        <div class=\"info_box\">\n            <div class=\"info_image\"><img");
            BeginWriteAttribute("src", " src=\"", 302, "\"", 323, 1);
#nullable restore
#line (10,47)-(10,62) 29 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
WriteAttributeValue("", 308, Model.ImageUrl, 308, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 324, "\"", 330, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n            <div class=\"info_content\">\n                <div class=\"info_title\">");
#nullable restore
#line (12,42)-(12,52) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <div class=\"info_text\">Категория: <strong>");
#nullable restore
#line (13,60)-(13,78) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\n                <div class=\"info_text\">Город: <strong>");
#nullable restore
#line (14,56)-(14,70) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
Write(Model.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\n                <div class=\"info_text\">Адрес: <strong>");
#nullable restore
#line (15,56)-(15,69) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></div>
                <div class=""info_text"">
                    Рейтинг: &nbsp;&nbsp;
                    <span class=""star-rating"">
                        <span class=""fa fa-star-o"" data-rating=""1""></span>
                        <span class=""fa fa-star-o"" data-rating=""2""></span>
                        <span class=""fa fa-star-o"" data-rating=""3""></span>
                        <span class=""fa fa-star-o"" data-rating=""4""></span>
                        <span class=""fa fa-star-o"" data-rating=""5""></span>
                        <input type=""hidden"" name=""whatever1"" class=""rating-value""");
            BeginWriteAttribute("value", " value=\"", 1284, "\"", 1305, 1);
#nullable restore
#line (24,91)-(24,104) 30 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
WriteAttributeValue("", 1292, Model.Rating, 1292, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    </span>\n                    <span>&nbsp; ( ");
#nullable restore
#line (26,37)-(26,63) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
Write(Model.Rating.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5.00 ) из ");
#nullable restore
#line (26,77)-(26,94) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
Write(Model.RatersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" голосов</span>
                </div>
            </div>
        </div>
    </div>
    <!-- Panel -->
    <div class=""col-lg-7"">
        <h1>Услуги:</h1>
        <table class=""table table-bordered"">
            <thead class=""thead-light"">
                <tr>
                    <th scope=""col"">Название</th>
                    <th scope=""col"">Доступность</th>
                    <th scope=""col"">Вкл/Выкл из списка</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 43 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
                 foreach (var service in Model.Services)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <th scope=\"row\">");
#nullable restore
#line (46,42)-(46,61) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
Write(service.ServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <td>\n");
#nullable restore
#line 48 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
                             if (service.Available == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span style=\"font-family:Arial, FontAwesome\" class=\"text-success\">&#xf00c;</span>\n");
#nullable restore
#line 51 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span style=\"font-family:Arial, FontAwesome\" class=\"text-danger\">&#xf00d;</span>\n");
#nullable restore
#line 55 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98507081950f9b1d36841250011ba3731221066212708", async() => {
                WriteLiteral("\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98507081950f9b1d36841250011ba3731221066212997", async() => {
                    WriteLiteral("\n                                    Вкл/Выкл\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-salonId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line (61,61)-(61,69) 13 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["salonId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-salonId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["salonId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line (61,93)-(61,110) 13 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
WriteLiteral(service.ServiceId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["serviceId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-serviceId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["serviceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 67 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n<hr class=\"bg-dark mx-4\" style=\"height: 6px;\" />\n\n<div>\n    ");
#nullable restore
#line (75,6)-(75,69) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
Write(await Component.InvokeAsync("AllAppointmentsBySalon", Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98507081950f9b1d36841250011ba3731221066218833", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 79 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Areas\Manager\Views\Salons\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeautyBooking.Web.ViewModels.Salons.SalonWithServicesViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
