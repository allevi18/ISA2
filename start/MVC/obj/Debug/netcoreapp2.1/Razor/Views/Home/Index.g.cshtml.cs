#pragma checksum "C:\Users\User\Source\Repos\allevi\start\MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce531716946987664c9294a84c6dfcc743ee1e3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\User\Source\Repos\allevi\start\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "C:\Users\User\Source\Repos\allevi\start\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce531716946987664c9294a84c6dfcc743ee1e3b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\Source\Repos\allevi\start\MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "ASP .NET Core MVC";

#line default
#line hidden
            BeginContext(53, 35, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1>");
            EndContext();
            BeginContext(89, 17, false);
#line 6 "C:\Users\User\Source\Repos\allevi\start\MVC\Views\Home\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(106, 805, true);
            WriteLiteral(@"</h1>
</div>

<div class=""row"">
    <div class=""col-md-4"">
        <h2>Welcome to ASP .NET Core MVC</h2>
        <p>
            ASP .NET Core MVC is a rich framework for building web apps
            and APIs using the Model-View-Controller design pattern
        </p>
    </div>

    <div class=""col-md-4"">
        <h2>What is ASP .NET Core MVC?</h2>
        <p>
            The ASP .NET Core MVC framework is a lightweight, open source,
            highly testable presentation framework optimized for use with ASP.NET Core.
        </p> 
        <p>
            <a class=""btn btn-default""
                href=""https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-2.1"">
                Read more &raquo;
            </a>
        </p>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
