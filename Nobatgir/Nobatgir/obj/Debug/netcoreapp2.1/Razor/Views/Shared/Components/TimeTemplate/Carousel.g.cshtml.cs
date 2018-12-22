#pragma checksum "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "482d30370cc3c8d11c2d1dd6504a2e07dd44e2e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TimeTemplate_Carousel), @"mvc.1.0.view", @"/Views/Shared/Components/TimeTemplate/Carousel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TimeTemplate/Carousel.cshtml", typeof(AspNetCore.Views_Shared_Components_TimeTemplate_Carousel))]
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
#line 1 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"482d30370cc3c8d11c2d1dd6504a2e07dd44e2e5", @"/Views/Shared/Components/TimeTemplate/Carousel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6070da3a106ce176a3725f683aab549e20ce4c3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TimeTemplate_Carousel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TimeTemplateViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTurn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Expert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
  
    int index = 1;

#line default
#line hidden
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
 if (Model == null)
{
    return;
}

#line default
#line hidden
            BeginContext(141, 557, true);
            WriteLiteral(@"

<div class=""row well"">

    <div class=""col-12"" id=""calendar-nav"">
        
        <div class=""row no-gutters"">

            <a href=""#carouselExampleControls"" role=""button"" data-slide=""prev"" class=""carousel-nav-right"">
                <i class=""fa fa-chevron-right"" aria-hidden=""true""></i>
                <span>هفته قبلی</span>
            </a>

            <div id=""carouselExampleControls"" class=""carousel slide  flex-grow-1"" data-ride=""carousel"" data-interval=""false"" data-wrap=""false"">
                <div class=""carousel-inner"">

");
            EndContext();
#line 28 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                      
                        bool iscontinue = true;
                        int i = 1;
                    

#line default
#line hidden
            BeginContext(830, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 32 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                     while (iscontinue)
                    {


                        string c = "";
                        if (i == 1)
                        {
                            c = "active";
                        }


#line default
#line hidden
            BeginContext(1074, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1102, "\"", 1127, 3);
            WriteAttributeValue("", 1110, "carousel-item", 1110, 13, true);
#line 42 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
WriteAttributeValue(" ", 1123, c, 1124, 2, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1126, "", 1127, 1, true);
            EndWriteAttribute();
            BeginContext(1128, 89, true);
            WriteLiteral(">\r\n                            <ul class=\"nav nav-tabs\" id=\"myTab1\" role=\"tablist\">\r\n\r\n\r\n");
            EndContext();
#line 46 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                                 for (; i <= Model.Count; i++)
                                {
                                    var item = Model[i - 1];

                                    c = "";
                                    if (i == 1)
                                    {
                                        c = "active";
                                    }


#line default
#line hidden
            BeginContext(1609, 101, true);
            WriteLiteral("                                    <li class=\"nav-item\">\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1710, "\"", 1743, 4);
            WriteAttributeValue("", 1718, "btn", 1718, 3, true);
            WriteAttributeValue(" ", 1721, "btn-light", 1722, 10, true);
            WriteAttributeValue(" ", 1731, "nav-link", 1732, 9, true);
#line 57 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
WriteAttributeValue(" ", 1740, c, 1741, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1744, 105, true);
            WriteLiteral(" style=\"margin-left: 5px\" id=\"home-tab\" onclick=\"$(\'.nav-link\').removeClass(\'active\');\" data-toggle=\"tab\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1849, "\"", 1863, 2);
            WriteAttributeValue("", 1856, "#tab_", 1856, 5, true);
#line 57 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
WriteAttributeValue("", 1861, i, 1861, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1864, 54, true);
            WriteLiteral(" role=\"tab\" aria-controls=\"home\" aria-selected=\"true\">");
            EndContext();
            BeginContext(1919, 58, false);
#line 57 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                                                                                                                                                                                                                                                     Write(Nobatgir.Lib.persianDateTime.GetPersianDateShort(item.Day));

#line default
#line hidden
            EndContext();
            BeginContext(1977, 49, true);
            WriteLiteral("</a>\r\n                                    </li>\r\n");
            EndContext();
#line 59 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"

                                    if (i < Model.Count - 1 && ((int) item.Day.DayOfWeek + 1) % 7 > ((int) Model[i].Day.DayOfWeek + 1) % 7)

                                        //if (i % 7 == 0)
                                    {
                                        i++;
                                        break;
                                    }
                                    if (i == Model.Count)
                                    {
                                        iscontinue = false;
                                    }
                                }

#line default
#line hidden
            BeginContext(2635, 71, true);
            WriteLiteral("\r\n\r\n                            </ul>\r\n                        </div>\r\n");
            EndContext();
#line 76 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                    }

#line default
#line hidden
            BeginContext(2729, 378, true);
            WriteLiteral(@"



                </div>

            </div>

            <a href=""#carouselExampleControls"" role=""button"" data-slide=""next"" class=""carousel-nav-left"">
                <span>هفته بعدی</span>
                <i class=""fa fa-chevron-left"" aria-hidden=""true""></i>
            </a>
        </div>
    </div>
    <div class=""tab-content col-12"" id=""myTabContent"">

");
            EndContext();
#line 93 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
           index = 1; 

#line default
#line hidden
            BeginContext(3132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 95 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
         foreach (var item in Model)
        {
            string c = "";
            if (index == 1)
            {
                c = "active";
            }


#line default
#line hidden
            BeginContext(3303, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3319, "\"", 3348, 4);
            WriteAttributeValue("", 3327, "tab-pane", 3327, 8, true);
            WriteAttributeValue(" ", 3335, "fade", 3336, 5, true);
            WriteAttributeValue(" ", 3340, "show", 3341, 5, true);
#line 103 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
WriteAttributeValue(" ", 3345, c, 3346, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3349, "\"", 3364, 2);
            WriteAttributeValue("", 3354, "tab_", 3354, 4, true);
#line 103 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
WriteAttributeValue("", 3358, index, 3358, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3365, 87, true);
            WriteLiteral(" role=\"tabpanel\" aria-labelledby=\"home-tab\">\r\n\r\n                <div class=\"row p-2\">\r\n");
            EndContext();
#line 106 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                     foreach (var turn in item.Turns)
                    {

#line default
#line hidden
            BeginContext(3530, 58, true);
            WriteLiteral("                        <div class=\"col-4 col-md-2 p-1\">\r\n");
            EndContext();
#line 109 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                             if (turn.Status == TurnStatuses.Free)
                            {

#line default
#line hidden
            BeginContext(3687, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3719, 568, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ed0cfae57e4ac1aca156b4e5b1b2e9", async() => {
                BeginContext(3784, 74, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"turndate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3858, "\"", 3875, 1);
#line 112 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
WriteAttributeValue("", 3866, item.Day, 3866, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3876, 71, true);
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"time\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3947, "\"", 3965, 1);
#line 113 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
WriteAttributeValue("", 3955, turn.Time, 3955, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3966, 139, true);
                WriteLiteral(">\r\n\r\n                                    <button type=\"submit\" class=\"btn btn-success btn-block\">\r\n                                        ");
                EndContext();
                BeginContext(4106, 9, false);
#line 116 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                                   Write(turn.Time);

#line default
#line hidden
                EndContext();
                BeginContext(4115, 165, true);
                WriteLiteral("<br />\r\n                                        <span class=\"small\">قابل رزرو</span>\r\n                                    </button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4287, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 120 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                            }
                            else if (turn.Status == TurnStatuses.Completed)
                            {

#line default
#line hidden
            BeginContext(4428, 120, true);
            WriteLiteral("                                <button class=\"btn btn-danger btn-block\" disabled>\r\n                                    ");
            EndContext();
            BeginContext(4549, 9, false);
#line 124 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                               Write(turn.Time);

#line default
#line hidden
            EndContext();
            BeginContext(4558, 150, true);
            WriteLiteral("\r\n                                <br />\r\n                                <span class=\"small\">رزرو شده</span>\r\n                            </button>\r\n");
            EndContext();
#line 128 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                        }
                        else if (turn.Status == TurnStatuses.Reserve)
                        {

#line default
#line hidden
            BeginContext(4833, 113, true);
            WriteLiteral("                            <button class=\"btn btn-warning btn-block\" disabled>\r\n                                ");
            EndContext();
            BeginContext(4947, 9, false);
#line 132 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                           Write(turn.Time);

#line default
#line hidden
            EndContext();
            BeginContext(4956, 141, true);
            WriteLiteral("\r\n                            <br />\r\n                            <span class=\"small\">در حال رزرو</span>\r\n                        </button>\r\n");
            EndContext();
#line 136 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                    }

#line default
#line hidden
            BeginContext(5120, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#line 138 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"
                    }

#line default
#line hidden
            BeginContext(5175, 44, true);
            WriteLiteral("                </div>\r\n            </div>\r\n");
            EndContext();
#line 141 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TimeTemplate\Carousel.cshtml"

            index++;
        }

#line default
#line hidden
            BeginContext(5254, 32, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TimeTemplateViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
