#pragma checksum "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7904b291e372e58a249863acd17884e1ae5bb739"
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
#nullable restore
#line 1 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Home\Index.cshtml"
using BeautyBooking.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Home\Index.cshtml"
using BeautyBooking.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7904b291e372e58a249863acd17884e1ae5bb739", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9061ceacb3f8e30506ec034bed1cdd1c222cf1d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Home\Index.cshtml"
    
    this.ViewData["Title"] = "Главная страница Jibek-Jolu";
    //List<Tovar> tov;
    //List<string> coordinats;

    //using (var db = new JibekDbContext())
    //{
    //    tov = db.Tovars.ToList();
    //    foreach (var t in Model.Tovar)
    //    {

    //        //coordinats.Add();
    //        //Console.WriteLine(t.dolg);

    //    }
    //}


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<hr class=""bg-dark mx-4"" style=""height: 6px;"" />

<div class=""departments"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col text-center"">
                <div class=""section_title"">У нас Вы найдете</div>
                <div class=""section_subtitle"">разнообразие товаров</div>
            </div>
        </div>
        <div class=""row dept_row"">
            <div class=""col"">
                <div class=""dept_slider_container_outer"">
                    <div class=""dept_slider_container"">

                        <!-- Slider -->
                        <div class=""owl-carousel owl-theme dept_slider"">

");
#nullable restore
#line 42 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Home\Index.cshtml"
                             foreach (var category in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Slide -->\n                                <div class=\"owl-item dept_item\">\n                                    <div class=\"dept_image\"><img");
            BeginWriteAttribute("src", " src=\"", 1385, "\"", 1409, 1);
#nullable restore
#line (45,71)-(45,89) 30 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1391, category.ImageUrl, 1391, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1410, "\"", 1416, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\n                                    <div class=\"dept_content\">\n                                        <div class=\"dept_title\">");
#nullable restore
#line (47,66)-(47,79) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Home\Index.cshtml"
Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                        <div class=\"dept_link\"><a>");
#nullable restore
#line (48,68)-(48,88) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Home\Index.cshtml"
Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\n                                    </div>\n                                </div>");
#nullable restore
#line 50 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Home\Index.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <!-- Dept Slider Nav -->
                    <div class=""dept_slider_nav""><i class=""fa fa-chevron-right"" aria-hidden=""true""></i></div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col"">
                <div class=""button services_button ml-auto mr-auto"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7904b291e372e58a249863acd17884e1ae5bb7398564", async() => {
                WriteLiteral("<span>Подробнее</span><span>Подробнее</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n       \n    </div>\n</div>\n\n<hr class=\"bg-dark mx-4\" style=\"height: 6px;\" />\n<!--test -->\n<!DOCTYPE html>\n<html>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7904b291e372e58a249863acd17884e1ae5bb73910347", async() => {
                WriteLiteral(@"
    <title>Geolocation</title>
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.8.0/dist/leaflet.css"" />
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet-routing-machine@latest/dist/leaflet-routing-machine.css"" />

    <style>
        body {
            margin: 0;
            padding: 0;
        }
    </style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7904b291e372e58a249863acd17884e1ae5bb73911655", async() => {
                WriteLiteral(@"
    <div id=""map"" style=""width:100%; height: 80vh""></div>
    <script src=""https://unpkg.com/leaflet@1.8.0/dist/leaflet.js""></script>
    <script src=""https://unpkg.com/leaflet-routing-machine@latest/dist/leaflet-routing-machine.js""></script>


    <script>

        var map = L.map('map').setView([41.45632213015565, 74.44214272182636], 10);
        mapLink = ""<a href='http://openstreetmap.org'>OpenStreetMap</a>"";
        L.tileLayer('http://{s}.tile.osm.org/{z}/{x}/{y}.png', { attribution: 'Leaflet &copy; ' + mapLink + ', contribution', maxZoom: 18 }).addTo(map);

        var taxiIcon = L.icon({
            iconUrl: ""<a href='https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQs9rCWoSinq7iM4lIkhHGmH2-AphOLbFFCEQ&usqp=CAU'</a>"",
                    iconSize: [100, 100]
        })
        $.get(""");
#nullable restore
#line (105,17)-(105,52) 6 "C:\Users\User\Downloads\BeautySalon-main\BeautySalon-main\Web\BeautyBooking.Web\Views\Home\Index.cshtml"
Write(Url.Action("GetAllLocation","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",function (data,status){})
        var marker = L.marker([42.87468339519376, 74.53901491702995], { icon: taxiIcon }).addTo(map);
       

        map.on('click', function (e) {
            console.log(e)
            var newMarker = L.marker([e.latlng.lat, e.latlng.lng]).addTo(map);
            L.Routing.control({
                waypoints: [
                    L.latLng(42.8450730380312, 74.58748163446711),
                    L.latLng(e.latlng.lat, e.latlng.lng)
                ]
            }).on('routesfound', function (e) {
                var routes = e.routes;
                console.log(routes);

                e.routes[0].coordinates.forEach(function (coord, index) {
                    setTimeout(function () {
                        marker.setLatLng([coord.lat, coord.lng]);
                    }, 100 * index)
                })

            }).addTo(map);
        });


    </script>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<!-- FAQ & News -->

<div class=""stuff"">
    <div class=""container"">
        <div class=""row"">

            <!-- FAQ -->
            <div class=""col-lg-7 align-items-center"">
                <div class=""faq"">
                    <div class=""faq_title"">О нашем приложении</div>
                    <div class=""elements_accordions"">
                        <div class=""accordions"">

                            <div class=""accordion_container"">
                                <div class=""accordion d-flex flex-row align-items-center active""><div>Что это за сайт?</div></div>
                                <div class=""accordion_panel"">
                                    <div>
                                        <p>
                                            Наше приложение отличная платформа для ваших удобных покупок.
                                        </p>
                                    </div>
                                </div>
                            </div>

                            <di");
            WriteLiteral(@"v class=""accordion_container"">
                                <div class=""accordion d-flex flex-row align-items-center""><div> Спасибо, что выбрали нас. </div></div>
                                <div class=""accordion_panel"">
                                    <div>
                                        <p>
                                           Надеемся вам понравится наше приложение. Удачи!
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<hr class=""bg-dark mx-4"" style=""height: 6px;"" />
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591