#pragma checksum "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c1f7dd62d96b53d0c061e487409eb9534fa2d1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Site_Details_partial), @"mvc.1.0.view", @"/Areas/Admin/Views/Site/Details_partial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Site/Details_partial.cshtml", typeof(AspNetCore.Areas_Admin_Views_Site_Details_partial))]
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
#line 1 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Nobatgir.Model;

#line default
#line hidden
#line 2 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Nobatgir.Data;

#line default
#line hidden
#line 3 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1f7dd62d96b53d0c061e487409eb9534fa2d1b", @"/Areas/Admin/Views/Site/Details_partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6af81e192758d2bfde91ed6c14e671b122ee7e13", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Site_Details_partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Site>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 128, true);
            WriteLiteral("\r\n<div class=\"admin-data-box\">\r\n    <table class=\"table detail table-striped\">\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(142, 44, false);
#line 7 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(186, 22, true);
            WriteLiteral(":\r\n            </td>\r\n");
            EndContext();
#line 9 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
             if (ViewBag.ActionType == "create" || ViewBag.ActionType == "edit")
            {

#line default
#line hidden
            BeginContext(305, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(325, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b1064b2930549ddb7601e07f5db47c9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 11 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsActive);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(353, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 12 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(408, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(451, 40, false);
#line 16 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
               Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(491, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 18 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
            }

#line default
#line hidden
            BeginContext(531, 63, true);
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(595, 40, false);
#line 22 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(635, 22, true);
            WriteLiteral(":\r\n            </td>\r\n");
            EndContext();
#line 24 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
             if (ViewBag.ActionType == "create" || ViewBag.ActionType == "edit")
            {

#line default
#line hidden
            BeginContext(754, 32, true);
            WriteLiteral("                <td class=\"ltr\">");
            EndContext();
            BeginContext(786, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f02c1bc92600420fa8ec8191f5a41642", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 26 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(831, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(886, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(929, 36, false);
#line 31 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(965, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 33 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
            }

#line default
#line hidden
            BeginContext(1005, 63, true);
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1069, 41, false);
#line 37 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 22, true);
            WriteLiteral(":\r\n            </td>\r\n");
            EndContext();
#line 39 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
             if (ViewBag.ActionType == "create" || ViewBag.ActionType == "edit")
            {

#line default
#line hidden
            BeginContext(1229, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1249, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "447f1d4020f34696ac7a835ef4e0eff3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 41 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1295, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 42 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1350, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1393, 37, false);
#line 46 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 48 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
            }

#line default
#line hidden
            BeginContext(1470, 63, true);
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1534, 42, false);
#line 52 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
           Write(Html.DisplayNameFor(model => model.Domain));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 22, true);
            WriteLiteral(":\r\n            </td>\r\n");
            EndContext();
#line 54 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
             if (ViewBag.ActionType == "create" || ViewBag.ActionType == "edit")
            {

#line default
#line hidden
            BeginContext(1695, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1715, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39fb3edbd614466896c1e8eb6a249923", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 56 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Domain);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1762, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 57 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1817, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1860, 38, false);
#line 61 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
               Write(Html.DisplayFor(model => model.Domain));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 63 "D:\Turn\Nobatgir\Nobatgir\Areas\Admin\Views\Site\Details_partial.cshtml"
            }

#line default
#line hidden
            BeginContext(1938, 45, true);
            WriteLiteral("        </tr>\r\n\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Site> Html { get; private set; }
    }
}
#pragma warning restore 1591
