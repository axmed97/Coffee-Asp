#pragma checksum "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5ad2766bc16fe77005433eae0b6c5b441ae2482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ad2766bc16fe77005433eae0b6c5b441ae2482", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8aff7eb677e48bfa3de37b20325a04738817e0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-capitalize btn btn-lg btn-block btn-primary w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["activeTab"] = "Product";
    int allProductCount = (int)ViewData["allProductCount"];
    int activePage = (int)ViewData["activePage"];
    int allPageCount = (int)(Math.Ceiling(((decimal)allProductCount / 4)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5ad2766bc16fe77005433eae0b6c5b441ae24826824", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
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
<table class=""table table-bordered table-hover table-striped w-100"">
    <thead class=""text-center"">
        <tr>
            <th></th>
            <th>Image</th>
            <th>Name</th>
            <th>Price</th>
        </tr>
    </thead>
    <tbody class=""text-center"">
");
#nullable restore
#line 21 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 838, "\"", 875, 2);
            WriteAttributeValue("", 845, "/Admin/Product/Detail/", 845, 22, true);
#nullable restore
#line 25 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 867, item.Id, 867, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">\r\n                        <i class=\"material-icons\">remove_red_eye</i>\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1021, "\"", 1056, 2);
            WriteAttributeValue("", 1028, "/Admin/Product/Edit/", 1028, 20, true);
#nullable restore
#line 28 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 1048, item.Id, 1048, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\r\n                        <i class=\"material-icons\">edit</i>\r\n                    </a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5ad2766bc16fe77005433eae0b6c5b441ae248210264", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1324, "\"", 1408, 12);
                WriteAttributeValue("", 1334, "return", 1334, 6, true);
                WriteAttributeValue(" ", 1340, "confirm(\'Are", 1341, 13, true);
                WriteAttributeValue(" ", 1353, "you", 1354, 4, true);
                WriteAttributeValue(" ", 1357, "sure", 1358, 5, true);
                WriteAttributeValue(" ", 1362, "you", 1363, 4, true);
                WriteAttributeValue(" ", 1366, "want", 1367, 5, true);
                WriteAttributeValue(" ", 1371, "to", 1372, 3, true);
                WriteAttributeValue(" ", 1374, "delete", 1375, 7, true);
                WriteAttributeValue(" ", 1381, "this", 1382, 5, true);
                WriteAttributeValue(" ", 1386, "product:", 1387, 9, true);
#nullable restore
#line 32 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 1395, item.Name, 1396, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1406, "\')", 1406, 2, true);
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
#line 31 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c5ad2766bc16fe77005433eae0b6c5b441ae248214352", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1595, "~/image/", 1595, 8, true);
#nullable restore
#line 37 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1603, item.Image, 1603, 13, false);

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
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 39 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
                 Write(item.HasDiscount == false ? item.Price : item.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<nav aria-label=\"Page navigation example\" style=\"margin: auto;\">\r\n    <ul class=\"pagination\">\r\n        <li class=\"page-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 1984, "\"", 2036, 2);
            WriteAttributeValue("", 1992, "page-link", 1992, 9, true);
#nullable restore
#line 48 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 2001, activePage == 1 ? "d-none" : "", 2002, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2037, "\"", 2085, 2);
            WriteAttributeValue("", 2044, "/Admin/Product/Index?page=", 2044, 26, true);
#nullable restore
#line 48 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 2070, activePage-1, 2070, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                <span aria-hidden=\"true\">&laquo;</span>\r\n                <span class=\"sr-only\">Previous</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 53 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
         for (int i = 1; i <= allPageCount; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2332, "\"", 2384, 2);
            WriteAttributeValue("", 2340, "page-item", 2340, 9, true);
#nullable restore
#line 55 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 2349, activePage == i ? "active" : "", 2350, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2406, "\"", 2441, 2);
            WriteAttributeValue("", 2413, "/Admin/Product/Index?page=", 2413, 26, true);
#nullable restore
#line 55 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 2439, i, 2439, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
                                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 56 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 2478, "\"", 2541, 2);
            WriteAttributeValue("", 2486, "page-item", 2486, 9, true);
#nullable restore
#line 57 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 2495, activePage == allPageCount ? "d-none" : "", 2496, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2577, "\"", 2625, 2);
            WriteAttributeValue("", 2584, "/Admin/Product/Index?page=", 2584, 26, true);
#nullable restore
#line 58 "C:\Users\lezgi\source\repos\CoffeeAsp\CoffeeAsp\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 2610, activePage+1, 2610, 15, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
