#pragma checksum "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d076591a7f51d615d89f0dc0ea1e1178ec75589d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Slider_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Slider/Index.cshtml")]
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
#line 1 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\_ViewImports.cshtml"
using CoffeeAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\_ViewImports.cshtml"
using CoffeeAsp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\_ViewImports.cshtml"
using CoffeeAsp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d076591a7f51d615d89f0dc0ea1e1178ec75589d", @"/Areas/Admin/Views/Slider/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8aff7eb677e48bfa3de37b20325a04738817e0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Slider_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sliders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Slider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-lg btn-primary text-capitalize"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["activeTab"] = "Slider";
    int allSlideCount = (int)ViewData["allSliderCount"];
    int activePage = (int)ViewData["activePage"];
    int allPageCount = (int)(Math.Ceiling(((decimal)allSlideCount / 3)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d076591a7f51d615d89f0dc0ea1e1178ec75589d5926", async() => {
                WriteLiteral("create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
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
<table class=""w-100 table table-bordered table-striped table-hover"">
    <thead class=""text-center"">
        <tr>
            <th></th>
            <th>Image</th>
            <th>Header</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody class=""text-center"">
");
#nullable restore
#line 21 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 836, "\"", 872, 2);
            WriteAttributeValue("", 843, "/Admin/Slider/Detail/", 843, 21, true);
#nullable restore
#line 25 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
WriteAttributeValue("", 864, item.Id, 864, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">\r\n                        <i class=\"material-icons\">remove_red_eye</i>\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1018, "\"", 1052, 2);
            WriteAttributeValue("", 1025, "/Admin/Slider/Edit/", 1025, 19, true);
#nullable restore
#line 28 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
WriteAttributeValue("", 1044, item.Id, 1044, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\r\n                        <i class=\"material-icons\">edit</i>\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1188, "\"", 1224, 2);
            WriteAttributeValue("", 1195, "/Admin/Slider/Delete/", 1195, 21, true);
#nullable restore
#line 31 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
WriteAttributeValue("", 1216, item.Id, 1216, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\r\n                        <i class=\"material-icons\">delete</i>\r\n                    </a>\r\n                </td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d076591a7f51d615d89f0dc0ea1e1178ec75589d9989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1392, "~/image/", 1392, 8, true);
#nullable restore
#line 35 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
AddHtmlAttributeValue("", 1400, item.Image, 1400, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
               Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<nav aria-label=\"Page navigation example\" style=\"margin: auto;\">\r\n    <ul class=\"pagination\">\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 1702, "\"", 1754, 2);
            WriteAttributeValue("", 1710, "page-item", 1710, 9, true);
#nullable restore
#line 45 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
WriteAttributeValue(" ", 1719, activePage == 1 ? "d-none" : "", 1720, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1790, "\"", 1837, 2);
            WriteAttributeValue("", 1797, "/Admin/Slider/Index?page=", 1797, 25, true);
#nullable restore
#line 46 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
WriteAttributeValue("", 1822, activePage-1, 1822, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                <span aria-hidden=\"true\">&laquo;</span>\r\n                <span class=\"sr-only\">Previous</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 51 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
         for (int i = 1; i <= allPageCount; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2084, "\"", 2136, 2);
            WriteAttributeValue("", 2092, "page-item", 2092, 9, true);
#nullable restore
#line 53 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
WriteAttributeValue(" ", 2101, activePage == i ? "active" : "", 2102, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2158, "\"", 2192, 2);
            WriteAttributeValue("", 2165, "/Admin/Slider/Index?page=", 2165, 25, true);
#nullable restore
#line 53 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
WriteAttributeValue("", 2190, i, 2190, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
                                                                                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 54 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 2229, "\"", 2292, 2);
            WriteAttributeValue("", 2237, "page-item", 2237, 9, true);
#nullable restore
#line 55 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
WriteAttributeValue(" ", 2246, activePage == allPageCount ? "d-none" : "", 2247, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2328, "\"", 2375, 2);
            WriteAttributeValue("", 2335, "/Admin/Slider/Index?page=", 2335, 25, true);
#nullable restore
#line 56 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Slider\Index.cshtml"
WriteAttributeValue("", 2360, activePage+1, 2360, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                <span aria-hidden=\"true\">&raquo;</span>\r\n                <span class=\"sr-only\">Next</span>\r\n            </a>\r\n        </li>\r\n    </ul>\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sliders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
