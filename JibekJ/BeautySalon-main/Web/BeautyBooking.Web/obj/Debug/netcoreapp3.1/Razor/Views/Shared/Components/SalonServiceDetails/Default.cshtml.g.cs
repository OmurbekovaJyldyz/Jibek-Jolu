#pragma checksum "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Shared\Components\SalonServiceDetails\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "083dd62e1b09bc7b49468625888145d955d5db54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SalonServiceDetails_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SalonServiceDetails/Default.cshtml")]
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
#line 1 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\_ViewImports.cshtml"
using BeautyBooking.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\_ViewImports.cshtml"
using BeautyBooking.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"083dd62e1b09bc7b49468625888145d955d5db54", @"/Views/Shared/Components/SalonServiceDetails/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9061ceacb3f8e30506ec034bed1cdd1c222cf1d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SalonServiceDetails_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BeautyBooking.Web.ViewModels.SalonServices.SalonServiceDetailsViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Shared\Components\SalonServiceDetails\Default.cshtml"
  
    ViewData["Title"] = "Магазин";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"form-group row\">\n    <label class=\"col-sm-2 col-form-label\">Магазин</label>\n    <div class=\"col-sm-10\">\n        <div class=\"form-control\">");
#nullable restore
#line (9,36)-(9,51) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Shared\Components\SalonServiceDetails\Default.cshtml"
Write(Model.SalonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n</div>\n<div class=\"form-group row\">\n    <label class=\"col-sm-2 col-form-label\">Адрес</label>\n    <div class=\"col-sm-10\">\n        <div class=\"form-control\">");
#nullable restore
#line (15,36)-(15,55) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Shared\Components\SalonServiceDetails\Default.cshtml"
Write(Model.SalonCityName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line (15,58)-(15,76) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Shared\Components\SalonServiceDetails\Default.cshtml"
Write(Model.SalonAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n</div>\n<div class=\"form-group row\">\n    <label class=\"col-sm-2 col-form-label\">Товар</label>\n    <div class=\"col-sm-10\">\n        <div class=\"form-control\">");
#nullable restore
#line (21,36)-(21,53) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Shared\Components\SalonServiceDetails\Default.cshtml"
Write(Model.ServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeautyBooking.Web.ViewModels.SalonServices.SalonServiceDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591