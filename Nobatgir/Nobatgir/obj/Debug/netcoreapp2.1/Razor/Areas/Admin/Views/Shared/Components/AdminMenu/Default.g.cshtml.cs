#pragma checksum "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbba8471010bf712c9d315a8609001484bd520c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_AdminMenu_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/AdminMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Components/AdminMenu/Default.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_Components_AdminMenu_Default))]
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
#line 1 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Nobatgir.Model;

#line default
#line hidden
#line 2 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Nobatgir.Data;

#line default
#line hidden
#line 3 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Nobatgir.ViewModel;

#line default
#line hidden
#line 4 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Nobatgir.Util;

#line default
#line hidden
#line 5 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Nobatgir.Services;

#line default
#line hidden
#line 7 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\_ViewImports.cshtml"
using Nobatgir.Areas.Admin.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbba8471010bf712c9d315a8609001484bd520c0", @"/Areas/Admin/Views/Shared/Components/AdminMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d57ee4652f325ebd4f07b5bf30285fdd9185c51", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_AdminMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Nobatgir.Model.ActCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 27, true);
            WriteLiteral("\r\n<ul class=\"admin-menu\">\r\n");
            EndContext();
#line 4 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml"
     foreach (var cat in Model)
    {
        string className = "admin-menu-item";

        //if (item.Controller.ToLower() == currentController.ToLower())
        //{
        //    className += " active";

        //}


#line default
#line hidden
            BeginContext(306, 64, true);
            WriteLiteral("        <li>\r\n        <li class=\"admin-menu-item\">\r\n            ");
            EndContext();
            BeginContext(371, 9, false);
#line 16 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml"
       Write(cat.Title);

#line default
#line hidden
            EndContext();
            BeginContext(380, 31, true);
            WriteLiteral("\r\n        </li>\r\n        <ul>\r\n");
            EndContext();
#line 19 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml"
             foreach (var act in cat.Acts.OrderBy(x => x.OrderIndex))
            {

#line default
#line hidden
            BeginContext(497, 19, true);
            WriteLiteral("                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 516, "\"", 534, 1);
#line 21 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml"
WriteAttributeValue("", 524, className, 524, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(535, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(558, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98697b3f5ed44b9686da17901deed4ca", async() => {
                BeginContext(647, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(674, 9, false);
#line 23 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml"
                   Write(act.Title);

#line default
#line hidden
                EndContext();
                BeginContext(683, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-area", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["area"] = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 22 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml"
                                                  WriteLiteral(act.ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 22 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml"
                                                                                   WriteLiteral(act.ActName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(709, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 26 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(749, 30, true);
            WriteLiteral("        </ul>\r\n        </li>\r\n");
            EndContext();
#line 29 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Areas\Admin\Views\Shared\Components\AdminMenu\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(786, 5, true);
            WriteLiteral("</ul>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Repository repository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Nobatgir.Model.ActCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
