#pragma checksum "C:\Users\User\source\repos\allevi\start\MVC\Views\Employee\CreateEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18978f6c11ab3aad7ed3783893387ab640a1f6da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_CreateEmployee), @"mvc.1.0.view", @"/Views/Employee/CreateEmployee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/CreateEmployee.cshtml", typeof(AspNetCore.Views_Employee_CreateEmployee))]
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
#line 1 "C:\Users\User\source\repos\allevi\start\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\allevi\start\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18978f6c11ab3aad7ed3783893387ab640a1f6da", @"/Views/Employee/CreateEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_CreateEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Facade.CreateEmployeeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Validations.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Employee/SaveEmployee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\allevi\start\MVC\Views\Employee\CreateEmployee.cshtml"
  
    ViewBag.Title = "Create Employee";

#line default
#line hidden
            BeginContext(85, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(89, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18978f6c11ab3aad7ed3783893387ab640a1f6da4967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(132, 258, true);
            WriteLiteral(@"
    <script>
        function ResetForm() {
            document.getElementById('TxtFName').value = """";
            document.getElementById('TxtLName').value = """";
            document.getElementById('TxtSalary').value = """";
        }
    </script>
");
            EndContext();
            BeginContext(393, 51, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<h2>Create Employee</h2>\r\n");
            EndContext();
            BeginContext(444, 1012, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18978f6c11ab3aad7ed3783893387ab640a1f6da6566", async() => {
                BeginContext(450, 21, true);
                WriteLiteral("\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(471, 964, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18978f6c11ab3aad7ed3783893387ab640a1f6da6970", async() => {
                    BeginContext(523, 96, true);
                    WriteLiteral("\r\n            <p>\r\n                First Name: <input type=\"text\" id=\"TxtFName\" name=\"FirstName\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 619, "\"", 643, 1);
#line 21 "C:\Users\User\source\repos\allevi\start\MVC\Views\Employee\CreateEmployee.cshtml"
WriteAttributeValue("", 627, Model.FirstName, 627, 16, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(644, 21, true);
                    WriteLiteral(" />\r\n                ");
                    EndContext();
                    BeginContext(666, 35, false);
#line 22 "C:\Users\User\source\repos\allevi\start\MVC\Views\Employee\CreateEmployee.cshtml"
           Write(Html.ValidationMessage("FirstName"));

#line default
#line hidden
                    EndContext();
                    BeginContext(701, 112, true);
                    WriteLiteral("\r\n            </p>\r\n            <p>\r\n                Last Name: <input type=\"text\" id=\"TxtLName\" name=\"LastName\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 813, "\"", 836, 1);
#line 25 "C:\Users\User\source\repos\allevi\start\MVC\Views\Employee\CreateEmployee.cshtml"
WriteAttributeValue("", 821, Model.LastName, 821, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(837, 21, true);
                    WriteLiteral(" />\r\n                ");
                    EndContext();
                    BeginContext(859, 34, false);
#line 26 "C:\Users\User\source\repos\allevi\start\MVC\Views\Employee\CreateEmployee.cshtml"
           Write(Html.ValidationMessage("LastName"));

#line default
#line hidden
                    EndContext();
                    BeginContext(893, 108, true);
                    WriteLiteral("\r\n            </p>\r\n            <p>\r\n                Salary: <input type=\"text\" id=\"TxtSalary\" name=\"Salary\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1001, "\"", 1022, 1);
#line 29 "C:\Users\User\source\repos\allevi\start\MVC\Views\Employee\CreateEmployee.cshtml"
WriteAttributeValue("", 1009, Model.Salary, 1009, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1023, 21, true);
                    WriteLiteral(" />\r\n                ");
                    EndContext();
                    BeginContext(1045, 32, false);
#line 30 "C:\Users\User\source\repos\allevi\start\MVC\Views\Employee\CreateEmployee.cshtml"
           Write(Html.ValidationMessage("Salary"));

#line default
#line hidden
                    EndContext();
                    BeginContext(1077, 351, true);
                    WriteLiteral(@"
            </p>
            <td colspan=""2"">
                <input type=""submit"" name=""BtnSubmit"" value=""Save Employee"" onclick=""return isValid();"" />
                <input type=""button"" name=""BtnReset"" value=""Reset"" onclick=""ResetForm()"" />
                <input type=""submit"" name=""BtnSubmit"" value=""Cancel"" />
            </td>
        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                BeginContext(1435, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1456, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Facade.CreateEmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
