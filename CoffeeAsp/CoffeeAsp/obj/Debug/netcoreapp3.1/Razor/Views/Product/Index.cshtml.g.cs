#pragma checksum "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d29552611c03defa70c1184bc85790f56529495d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\_ViewImports.cshtml"
using CoffeeAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\_ViewImports.cshtml"
using CoffeeAsp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\_ViewImports.cshtml"
using CoffeeAsp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29552611c03defa70c1184bc85790f56529495d", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8aff7eb677e48bfa3de37b20325a04738817e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductIndexVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/product/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-search", "cofee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/product/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/product/addProductAjax.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
  
    ViewData["activeLink"] = "Shop";
    int allProductCount = (int)ViewData["allProductCount"];
    int activePage = (int)ViewData["activePage"];
    int allPageCount = (int)(Math.Ceiling(((decimal)allProductCount / 9)));

#line default
#line hidden
#nullable disable
            DefineSection("Links", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d29552611c03defa70c1184bc85790f56529495d6981", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
#nullable restore
#line 11 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Title", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"head-title\">\r\n                    <h1>Products</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("<div style=\"clear: both;\"></div>\r\n<!-- Product Section Start -->\r\n<section class=\"product-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-9\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 33 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                     foreach (var item in Model.products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-12 col-sm-12 col-md-6 col-lg-4 col-xl-4\">\r\n                            <div class=\"product-item\">\r\n                                <div class=\"product-img\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1194, "\"", 1225, 2);
            WriteAttributeValue("", 1201, "/Product/Detail/", 1201, 16, true);
#nullable restore
#line 38 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1217, item.Id, 1217, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d29552611c03defa70c1184bc85790f56529495d10082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1279, "~/image/", 1279, 8, true);
#nullable restore
#line 39 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1287, item.Image, 1287, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <div class=\"product-bg\"></div>\r\n                                    </a>\r\n");
#nullable restore
#line 42 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                                     if (User.Identity.IsAuthenticated)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"product-link add-product\"");
            BeginWriteAttribute("href", " href=\"", 1612, "\"", 1637, 2);
            WriteAttributeValue("", 1619, "/Cart/Add/", 1619, 10, true);
#nullable restore
#line 44 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1629, item.Id, 1629, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">add to cart</a>\r\n");
#nullable restore
#line 45 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"product-link\" href=\"/Auth/Login\">add to cart</a>\r\n");
#nullable restore
#line 49 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"product-text\">\r\n                                    <h5><a href=\"#\">");
#nullable restore
#line 52 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                    <div class=\"product-price d-flex justify-content-center align-items-center\">\r\n                                        <span");
            BeginWriteAttribute("class", " class=\"", 2247, "\"", 2299, 1);
#nullable restore
#line 54 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 2255, item.HasDiscount == true ? "through" : "", 2255, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">$");
#nullable restore
#line 54 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                                                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span");
            BeginWriteAttribute("class", " class=\"", 2367, "\"", 2419, 1);
#nullable restore
#line 55 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 2375, item.HasDiscount == false ? "d-none" : "", 2375, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">$");
#nullable restore
#line 55 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                                                                                               Write(item.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 60 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12\">\r\n                        <div class=\"product-pagination d-flex justify-content-center align-items-center mt-5\">\r\n                            <a href=\"/Product/Index?page=1\"");
            BeginWriteAttribute("class", " class=\"", 2878, "\"", 2920, 1);
#nullable restore
#line 63 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 2886, activePage == 1 ? "d-none" : "", 2886, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fas fa-angle-double-left\"></i>\r\n                            </a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3062, "\"", 3104, 2);
            WriteAttributeValue("", 3069, "/Product/Index?page=", 3069, 20, true);
#nullable restore
#line 66 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 3089, activePage-1, 3089, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3105, "\"", 3147, 1);
#nullable restore
#line 66 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 3113, activePage == 1 ? "d-none" : "", 3113, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fas fa-chevron-left\"></i>\r\n                            </a>\r\n");
#nullable restore
#line 69 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                             for (int i = 1; i <= allPageCount; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 3389, "\"", 3418, 2);
            WriteAttributeValue("", 3396, "/Product/Index?page=", 3396, 20, true);
#nullable restore
#line 71 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 3416, i, 3416, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3419, "\"", 3472, 1);
#nullable restore
#line 71 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 3427, activePage == i ? "active-pagination" : "", 3427, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 72 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 3543, "\"", 3585, 2);
            WriteAttributeValue("", 3550, "/Product/Index?page=", 3550, 20, true);
#nullable restore
#line 73 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 3570, activePage+1, 3570, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3586, "\"", 3639, 1);
#nullable restore
#line 73 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 3594, activePage == allPageCount ? "d-none" : "", 3594, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fas fa-chevron-right\"></i>\r\n                            </a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3777, "\"", 3819, 2);
            WriteAttributeValue("", 3784, "/Product/Index?page=", 3784, 20, true);
#nullable restore
#line 76 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 3804, allPageCount, 3804, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3820, "\"", 3873, 1);
#nullable restore
#line 76 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
WriteAttributeValue("", 3828, activePage == allPageCount ? "d-none" : "", 3828, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""fas fa-angle-double-right""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3"">
                <div class=""range-input"">
                    <h5>filter by price</h5>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d29552611c03defa70c1184bc85790f56529495d21143", async() => {
                WriteLiteral("\r\n                        <input id=\"range\" type=\"range\" min=\"12\" max=\"600\" value=\"600\">\r\n                        <div class=\"range-price d-flex justify-content-between align-items-center\">\r\n                            <span>Price: <span class=\"from\">$");
#nullable restore
#line 89 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                                                        Write(Model.products.Min(m => m.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> - <span class=\"from-to\">$");
#nullable restore
#line 89 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Views\Product\Index.cshtml"
                                                                                                                          Write(Model.products.Max(p => p.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></span>\r\n                            <button type=\"submit\">filter</button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""category my-5"">
                    <h5>product categories</h5>
                    <h6><a href=""#"">Accessories</a></h6>
                    <h6><a href=""#"">Bean Varieties</a></h6>
                    <h6><a href=""#"">Coffee Cups</a></h6>
                    <h6><a href=""#"">Espresso Machines</a></h6>
                    <h6><a href=""#"">Fresh Coffee</a></h6>
                    <h6><a href=""#"">Italian Coffee</a></h6>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d29552611c03defa70c1184bc85790f56529495d24197", async() => {
                WriteLiteral(@"
                    <div class=""form-group product-search d-flex align-items-center justify-content-between"">
                        <input type=""text"" id=""productName"" placeholder=""search"" >
                        <button type=""submit"">
                            <i class=""fas fa-search""></i>
                        </button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-search", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["search"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Product Section End -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d29552611c03defa70c1184bc85790f56529495d27135", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d29552611c03defa70c1184bc85790f56529495d28235", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
