#pragma checksum "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\Steps\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb3161f74e46936aff947f20259d0fe75675b066"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Steps_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Steps/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Steps/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Steps_Default))]
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
#line 1 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.Model;

#line default
#line hidden
#line 2 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.Data;

#line default
#line hidden
#line 3 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.ViewModel;

#line default
#line hidden
#line 4 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.Util;

#line default
#line hidden
#line 5 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.Services;

#line default
#line hidden
#line 7 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\_ViewImports.cshtml"
using Nobatgir.Areas.Admin.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3161f74e46936aff947f20259d0fe75675b066", @"/Views/Shared/Components/Steps/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6070da3a106ce176a3725f683aab549e20ce4c3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Steps_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StepsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 92, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-12\">\r\n        <div class=\"row steps well\">\r\n\r\n");
            EndContext();
#line 8 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\Steps\Default.cshtml"
             for (var i = 0; i < Model.StepNames.Count; i++)
            {
                var c = Model.CurrentStep > i ? "done" : Model.CurrentStep == i ? "current" : "";


#line default
#line hidden
            BeginContext(293, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 313, "\"", 335, 3);
            WriteAttributeValue("", 321, "col-4", 321, 5, true);
            WriteAttributeValue(" ", 326, "astep", 327, 6, true);
#line 12 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\Steps\Default.cshtml"
WriteAttributeValue(" ", 332, c, 333, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(336, 52, true);
            WriteLiteral(">\r\n                    <span class=\"stepnumber\">\r\n\r\n");
            EndContext();
#line 15 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\Steps\Default.cshtml"
                         if (Model.CurrentStep <= i)
                        {

#line default
#line hidden
            BeginContext(469, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(505, 5, false);
#line 17 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\Steps\Default.cshtml"
                              Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(511, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 18 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\Steps\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(604, 57, true);
            WriteLiteral("                            <i class=\"fa fa-check\"></i>\r\n");
            EndContext();
#line 22 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\Steps\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(688, 75, true);
            WriteLiteral("\r\n                    </span>\r\n                    <span class=\"steptitle\">");
            EndContext();
            BeginContext(764, 28, false);
#line 25 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\Steps\Default.cshtml"
                                       Write(Html.Raw(Model.StepNames[i]));

#line default
#line hidden
            EndContext();
            BeginContext(792, 33, true);
            WriteLiteral("</span>\r\n                </div>\r\n");
            EndContext();
#line 27 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\Steps\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(840, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1297, 40, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Repository Repository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StepsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
