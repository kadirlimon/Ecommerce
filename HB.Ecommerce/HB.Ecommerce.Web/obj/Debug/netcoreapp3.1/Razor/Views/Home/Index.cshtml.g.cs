#pragma checksum "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6e63eed8aaf694a40ad508547278a1998c5c353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\_ViewImports.cshtml"
using HB.Ecommerce.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\_ViewImports.cshtml"
using HB.Ecommerce.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e63eed8aaf694a40ad508547278a1998c5c353", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0361075b239c5effabd22f5dcd45722c6ded3c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InputOutputViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12 col-md-5\">\r\n        <div class=\"input-output-card\">\r\n            \r\n");
#nullable restore
#line 10 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
             if (TempData["FileNotSelected"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"alert alert-danger\">");
#nullable restore
#line 12 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
                                         Write(TempData["FileNotSelected"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
             if (Model.Commands != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"input-output-card-header\">\r\n                    <h3>Input File</h3>\r\n                </div>\r\n                <div class=\"input-output-card-content\">\r\n");
#nullable restore
#line 21 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
                     foreach (var item in Model.Commands)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 23 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
                      Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 26 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div class=\"col-sm-12 col-md-7\">\r\n        <div class=\"input-output-card\">\r\n");
#nullable restore
#line 32 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
             if (Model.Outputs != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"input-output-card-header\">\r\n                    <h3>Output</h3>\r\n                </div>\r\n                <div class=\"input-output-card-content\">\r\n");
#nullable restore
#line 38 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
                     foreach (var output in Model.Outputs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6>");
#nullable restore
#line 40 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
                       Write(output.Command);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p class=\"p-output\">");
#nullable restore
#line 41 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
                                       Write(output.Output);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <br />\r\n");
#nullable restore
#line 43 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 45 "C:\Users\klimon\Desktop\Kadir Test\Kadir Project\HB.Ecommerce\HB.Ecommerce\HB.Ecommerce.Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InputOutputViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
