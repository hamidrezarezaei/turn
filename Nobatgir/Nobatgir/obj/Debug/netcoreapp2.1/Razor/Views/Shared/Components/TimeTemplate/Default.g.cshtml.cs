#pragma checksum "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd64c832d22be9209d68192f22374e6bc9b675f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TimeTemplate_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TimeTemplate/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TimeTemplate/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TimeTemplate_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd64c832d22be9209d68192f22374e6bc9b675f1", @"/Views/Shared/Components/TimeTemplate/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d57ee4652f325ebd4f07b5bf30285fdd9185c51", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TimeTemplate_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TimeTemplateViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
  
    int index = 1;

#line default
#line hidden
            BeginContext(65, 89, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <ul class=\"nav nav-tabs col-12\" id=\"myTab\" role=\"tablist\">\r\n\r\n");
            EndContext();
#line 11 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
         foreach (var item in Model)
        {
            string c = "";
            if (index == 1)
            {
                c = "active";
            }


#line default
#line hidden
            BeginContext(323, 53, true);
            WriteLiteral("            <li class=\"nav-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 376, "\"", 395, 2);
            WriteAttributeValue("", 384, "nav-link", 384, 8, true);
#line 20 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
WriteAttributeValue(" ", 392, c, 393, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(396, 32, true);
            WriteLiteral(" id=\"home-tab\" data-toggle=\"tab\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 428, "\"", 446, 2);
            WriteAttributeValue("", 435, "#tab_", 435, 5, true);
#line 20 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
WriteAttributeValue("", 440, index, 440, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 54, true);
            WriteLiteral(" role=\"tab\" aria-controls=\"home\" aria-selected=\"true\">");
            EndContext();
            BeginContext(502, 12, false);
#line 20 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                                                                                                                                          Write(item.FullDay);

#line default
#line hidden
            EndContext();
            BeginContext(514, 25, true);
            WriteLiteral("</a>\r\n            </li>\r\n");
            EndContext();
#line 22 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"

            index++;
        }

#line default
#line hidden
            BeginContext(574, 71, true);
            WriteLiteral("\r\n    </ul>\r\n    <div class=\"tab-content col-12\" id=\"myTabContent\">\r\n\r\n");
            EndContext();
#line 29 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
           index = 1; 

#line default
#line hidden
            BeginContext(670, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
         foreach (var item in Model)
        {
            string c = "";
            if (index == 1)
            {
                c = "active";
            }


#line default
#line hidden
            BeginContext(841, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 857, "\"", 894, 6);
            WriteAttributeValue("", 865, "tab-pane", 865, 8, true);
            WriteAttributeValue(" ", 873, "fade", 874, 5, true);
            WriteAttributeValue(" ", 878, "show", 879, 5, true);
            WriteAttributeValue(" ", 883, "row", 884, 4, true);
            WriteAttributeValue(" ", 887, "p-2", 888, 4, true);
#line 39 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
WriteAttributeValue(" ", 891, c, 892, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 895, "\"", 910, 2);
            WriteAttributeValue("", 900, "tab_", 900, 4, true);
#line 39 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
WriteAttributeValue("", 904, index, 904, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(911, 48, true);
            WriteLiteral(" role=\"tabpanel\" aria-labelledby=\"home-tab\">\r\n\r\n");
            EndContext();
#line 41 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                 foreach (var turn in item.Turns)
                {

#line default
#line hidden
            BeginContext(1029, 57, true);
            WriteLiteral("                    <a class=\"btn btn-success col-2 m-2\">");
            EndContext();
            BeginContext(1087, 9, false);
#line 43 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                                                    Write(turn.Time);

#line default
#line hidden
            EndContext();
            BeginContext(1096, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 44 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1121, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 47 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Default.cshtml"

            index++;
        }

#line default
#line hidden
            BeginContext(1178, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TimeTemplateViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
