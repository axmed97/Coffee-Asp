#pragma checksum "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed9dd6aaa2c97702af20de87ca67ab398f151c36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Brand_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Brand/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed9dd6aaa2c97702af20de87ca67ab398f151c36", @"/Areas/Admin/Views/Brand/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8aff7eb677e48bfa3de37b20325a04738817e0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Brand_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Brands>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Brand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-lg btn-primary w-100 text-capitalize"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["activeTab"] = "Brand";
    int allBrandCount = (int)ViewData["allBrandCount"];
    int activePage = (int)ViewData["activePage"];
    int allPageCount = (int)(Math.Ceiling(((decimal)allBrandCount / 3)));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed9dd6aaa2c97702af20de87ca67ab398f151c366765", async() => {
                WriteLiteral("create");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table table-bordered table-striped table-hover w-100\">\r\n    <thead class=\"text-center\">\r\n        <tr>\r\n            <th></th>\r\n            <th>Image</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody class=\"text-center\">\r\n");
#nullable restore
#line 18 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 769, "\"", 804, 2);
            WriteAttributeValue("", 776, "/Admin/Brand/Detail/", 776, 20, true);
#nullable restore
#line 22 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
WriteAttributeValue("", 796, item.Id, 796, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">\r\n                        <i class=\"material-icons\">remove_red_eye</i>\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 950, "\"", 983, 2);
            WriteAttributeValue("", 957, "/Admin/Brand/Edit/", 957, 18, true);
#nullable restore
#line 25 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
WriteAttributeValue("", 975, item.Id, 975, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\r\n                        <i class=\"material-icons\">edit</i>\r\n                    </a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed9dd6aaa2c97702af20de87ca67ab398f151c3610151", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1251, "\"", 1329, 11);
                WriteAttributeValue("", 1261, "return", 1261, 6, true);
                WriteAttributeValue(" ", 1267, "confirm(\'Are", 1268, 13, true);
                WriteAttributeValue(" ", 1280, "you", 1281, 4, true);
                WriteAttributeValue(" ", 1284, "sure", 1285, 5, true);
                WriteAttributeValue(" ", 1289, "you", 1290, 4, true);
                WriteAttributeValue(" ", 1293, "want", 1294, 5, true);
                WriteAttributeValue(" ", 1298, "to", 1299, 3, true);
                WriteAttributeValue(" ", 1301, "delete", 1302, 7, true);
                WriteAttributeValue(" ", 1308, "image:", 1309, 7, true);
#nullable restore
#line 29 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
WriteAttributeValue(" ", 1315, item.Image, 1316, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1327, "\')", 1327, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <i class=\"material-icons\">delete</i>\r\n                        </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed9dd6aaa2c97702af20de87ca67ab398f151c3614162", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1516, "~/image/", 1516, 8, true);
#nullable restore
#line 34 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
AddHtmlAttributeValue("", 1524, item.Image, 1524, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<nav aria-label=\"Page navigation example\" style=\"margin: auto;\">\r\n    <ul class=\"pagination\">\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 1741, "\"", 1793, 2);
            WriteAttributeValue("", 1749, "page-item", 1749, 9, true);
#nullable restore
#line 42 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
WriteAttributeValue(" ", 1758, activePage == 1 ? "d-none" : "", 1759, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1829, "\"", 1875, 2);
            WriteAttributeValue("", 1836, "/Admin/Brand/Index?page=", 1836, 24, true);
#nullable restore
#line 43 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
WriteAttributeValue("", 1860, activePage-1, 1860, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                <span aria-hidden=\"true\">&laquo;</span>\r\n                <span class=\"sr-only\">Previous</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 48 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
         for (int i = 1; i <= allPageCount; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2122, "\"", 2174, 2);
            WriteAttributeValue("", 2130, "page-item", 2130, 9, true);
#nullable restore
#line 50 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
WriteAttributeValue(" ", 2139, activePage == i ? "active" : "", 2140, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2196, "\"", 2229, 2);
            WriteAttributeValue("", 2203, "/Admin/Brand/Index?page=", 2203, 24, true);
#nullable restore
#line 50 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
WriteAttributeValue("", 2227, i, 2227, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 2266, "\"", 2329, 2);
            WriteAttributeValue("", 2274, "page-item", 2274, 9, true);
#nullable restore
#line 52 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
WriteAttributeValue(" ", 2283, activePage == allPageCount ? "d-none" : "", 2284, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2365, "\"", 2411, 2);
            WriteAttributeValue("", 2372, "/Admin/Brand/Index?page=", 2372, 24, true);
#nullable restore
#line 53 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Brand\Index.cshtml"
WriteAttributeValue("", 2396, activePage+1, 2396, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                <span aria-hidden=\"true\">&raquo;</span>\r\n                <span class=\"sr-only\">Next</span>\r\n            </a>\r\n        </li>\r\n    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Brands>> Html { get; private set; }
    }
}
#pragma warning restore 1591
