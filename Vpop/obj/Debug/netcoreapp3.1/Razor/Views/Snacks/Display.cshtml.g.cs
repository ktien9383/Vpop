#pragma checksum "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Snacks\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb4449e90a8082b2a587d353d0772acdaf41490d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Snacks_Display), @"mvc.1.0.view", @"/Views/Snacks/Display.cshtml")]
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
#line 1 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\_ViewImports.cshtml"
using Vpop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\_ViewImports.cshtml"
using Vpop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb4449e90a8082b2a587d353d0772acdaf41490d", @"/Views/Snacks/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba5a60320d960d3c6a8413692e2664b2809d234", @"/Views/_ViewImports.cshtml")]
    public class Views_Snacks_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Snacks\Display.cshtml"
  
    ViewData["Title"] = "Snacks Order Confirmation Page";
    Layout = "_MainMenu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <p>");
#nullable restore
#line 7 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Snacks\Display.cshtml"
  Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

    <table class=""table"">
        <tr>
            <th>
                Order Number
            </th>
            <th>
                Customer Name
            </th>
            <th>
                Category
            </th>
            <th>
                Item
            </th>   
            <th>
                Price
            </th>
             <th>
                Order Date
            </th>   
        </tr>
        <tr>
            <td>");
#nullable restore
#line 31 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Snacks\Display.cshtml"
           Write(ViewBag.order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Snacks\Display.cshtml"
           Write(ViewBag.order.Custname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Snacks\Display.cshtml"
           Write(ViewBag.order.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Snacks\Display.cshtml"
           Write(ViewBag.order.Item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>$");
#nullable restore
#line 35 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Snacks\Display.cshtml"
            Write(ViewBag.order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Snacks\Display.cshtml"
           Write(ViewBag.order.Currdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n");
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
