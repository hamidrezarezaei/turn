#pragma checksum "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "911bbc56073f7af7fbe0fce3b19fe8d59b260113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TurnFields_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TurnFields/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TurnFields/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TurnFields_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"911bbc56073f7af7fbe0fce3b19fe8d59b260113", @"/Views/Shared/Components/TurnFields/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6070da3a106ce176a3725f683aab549e20ce4c3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TurnFields_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TurnFieldsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 97, true);
            WriteLiteral("\r\n<div class=\"row\" id=\"turnfields\">\r\n\r\n    <div class=\"form-control col-12 type-html\">زمان: ساعت ");
            EndContext();
            BeginContext(126, 15, false);
#line 5 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
                                                     Write(Model.Turn.Time);

#line default
#line hidden
            EndContext();
            BeginContext(141, 5, true);
            WriteLiteral(" روز ");
            EndContext();
            BeginContext(147, 26, false);
#line 5 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
                                                                          Write(Model.Turn.TurnDatePersian);

#line default
#line hidden
            EndContext();
            BeginContext(173, 14, true);
            WriteLiteral("</div>\r\n\r\n    ");
            EndContext();
            BeginContext(187, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91b095017eac4b48b21e322d8af5e6fb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 7 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Turn.ID);

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
            BeginContext(235, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
     for (int i = 0; i < Model.ExpertFields.Count; i++)
    {

#line default
#line hidden
            BeginContext(303, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(311, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d57037f46754a7fab6c82cdea4fff3b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 11 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ExpertFields[i].ID);

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
            BeginContext(370, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"

        if (Model.IsVeify)
        {
            if (Model.ExpertFields[i].FieldType != FieldTypes.HTML)
            {

#line default
#line hidden
            BeginContext(497, 69, true);
            WriteLiteral("                <div class=\"col-12 mt-2 form-control verifyfields\">\r\n");
            EndContext();
#line 18 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
                      
                        string v = Model.ExpertFields[i].Value;
                        if (v == "true")
                        {
                            v = "بله";
                        }
                        else if (v == "false")
                        {
                            v = "خیر";
                        }
                    

#line default
#line hidden
            BeginContext(956, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(977, 27, false);
#line 29 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
               Write(Model.ExpertFields[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1004, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(1008, 1, false);
#line 29 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
                                              Write(v);

#line default
#line hidden
            EndContext();
            BeginContext(1009, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 31 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
            }
        }
        else
        {
            switch (Model.ExpertFields[i].FieldType)
            {
                case FieldTypes.TextBox:


#line default
#line hidden
            BeginContext(1199, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1223, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec2e7c66fecf43d6951b3f04b074f5cc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 39 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ExpertFields[i].Value);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
AddHtmlAttributeValue("", 1282, Model.ExpertFields[i].Placeholder, 1282, 34, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
AddHtmlAttributeValue("", 1325, Model.ExpertFields[i].CssClass, 1325, 31, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 1356, "form-control", 1357, 13, true);
            AddHtmlAttributeValue(" ", 1369, "fields", 1370, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1380, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"


                    break;

                case FieldTypes.TextArea:


#line default
#line hidden
            BeginContext(1461, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1485, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e717cd8b2754bb5a812975f34950943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 46 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ExpertFields[i].Value);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 46 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
AddHtmlAttributeValue("", 1547, Model.ExpertFields[i].Placeholder, 1547, 34, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 46 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
AddHtmlAttributeValue("", 1590, Model.ExpertFields[i].CssClass, 1590, 31, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 1621, "form-control", 1622, 13, true);
            AddHtmlAttributeValue(" ", 1634, "fields", 1635, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1654, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
                    break;

                case FieldTypes.CheckBox:


#line default
#line hidden
            BeginContext(1731, 24, true);
            WriteLiteral("                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1755, "\"", 1801, 2);
#line 51 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
WriteAttributeValue("", 1763, Model.ExpertFields[i].CssClass, 1763, 31, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1794, "fields", 1795, 7, true);
            EndWriteAttribute();
            BeginContext(1802, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(1829, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3731445ac59f4e56ba53a3480e6fbb16", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 52 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ExpertFields[i].Value);

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
            BeginContext(1893, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1919, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "107803c45be84f66b4f387fd222bd171", async() => {
                BeginContext(1966, 27, false);
#line 53 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
                                                                 Write(Model.ExpertFields[i].Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 53 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ExpertFields[i].Value);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2001, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 55 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"

                    break;

                case FieldTypes.HTML:


#line default
#line hidden
            BeginContext(2104, 24, true);
            WriteLiteral("                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2128, "\"", 2184, 3);
            WriteAttributeValue("", 2136, "type-html", 2136, 9, true);
#line 60 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
WriteAttributeValue(" ", 2145, Model.ExpertFields[i].CssClass, 2146, 31, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2177, "fields", 2178, 7, true);
            EndWriteAttribute();
            BeginContext(2185, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(2213, 37, false);
#line 61 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
                   Write(Html.Raw(Model.ExpertFields[i].Value));

#line default
#line hidden
            EndContext();
            BeginContext(2250, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 63 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"

                    break;

                case FieldTypes.ComboBox:

                        

#line default
#line hidden
            BeginContext(2382, 160, false);
#line 68 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
                   Write(Html.DropDownListFor(x => x.ExpertFields[i].Value, Model.ExpertFields[i].SourceValues, new { @class = Model.ExpertFields[i].CssClass + " form-control fields" }));

#line default
#line hidden
            EndContext();
#line 68 "E:\Projects\Nobatgir\GIT\Nobatgir\Nobatgir\Views\Shared\Components\TurnFields\Default.cshtml"
                                                                                                                                                                                         

                    break;

                case FieldTypes.RadioButton:


                    break;
            }
        }
    }

#line default
#line hidden
            BeginContext(2687, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TurnFieldsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
