#pragma checksum "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747da39752c7a3902ec38a2291defea8a845a929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bowls_Index), @"mvc.1.0.view", @"/Views/Bowls/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747da39752c7a3902ec38a2291defea8a845a929", @"/Views/Bowls/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba5a60320d960d3c6a8413692e2664b2809d234", @"/Views/_ViewImports.cshtml")]
    public class Views_Bowls_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vpop.ViewModels.OrderBowlsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bowls", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
  
    ViewData["Title"] = "Bowls Order Page";
    Layout = "_MainMenu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <h3 style=\"text-align: center\">Bowls Order Form</h3>\r\n\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "747da39752c7a3902ec38a2291defea8a845a9294639", async() => {
                WriteLiteral("\r\n      <div>\r\n            <input type=\"hidden\" name=\"Custname\" value=\" \">\r\n      </div>\r\n      <div>\r\n          <label>Pick a bowl below</label><br />\r\n          <p>\r\n");
#nullable restore
#line 17 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
               foreach (var category in Model.CategoryChoices)
              {

#line default
#line hidden
#nullable disable
                WriteLiteral("                 <input type=\"radio\" name=\"Category\"");
                BeginWriteAttribute("id", " id=\"", 549, "\"", 567, 1);
#nullable restore
#line 19 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 554, category.Key, 554, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 568, "\"", 591, 1);
#nullable restore
#line 19 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 576, category.Value, 576, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 592, "", 631, 1);
#nullable restore
#line 19 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 601, category.Key == "Rice Bowl", 601, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                 <label");
                BeginWriteAttribute("for", " for=\"", 658, "\"", 677, 1);
#nullable restore
#line 20 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 664, category.Key, 664, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
                                       Write(category.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> \r\n");
#nullable restore
#line 21 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "747da39752c7a3902ec38a2291defea8a845a9297426", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 23 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Category);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </p>\r\n      </div>\r\n      <div>\r\n          <label>Pick a protein below</label><br />\r\n          <p>\r\n");
#nullable restore
#line 29 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
               foreach (var protein in Model.Protein1)
              {

#line default
#line hidden
#nullable disable
                WriteLiteral("                 <input type=\"radio\" name=\"Item\"");
                BeginWriteAttribute("id", " id=\"", 1033, "\"", 1050, 1);
#nullable restore
#line 31 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 1038, protein.Key, 1038, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1051, "\"", 1073, 1);
#nullable restore
#line 31 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 1059, protein.Value, 1059, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 1074, "", 1110, 1);
#nullable restore
#line 31 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 1083, protein.Key == "Veggie ", 1083, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                 <label");
                BeginWriteAttribute("for", " for=\"", 1137, "\"", 1155, 1);
#nullable restore
#line 32 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 1143, protein.Key, 1143, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
                                      Write(protein.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> \r\n");
#nullable restore
#line 33 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n");
#nullable restore
#line 35 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
               foreach (var protein in Model.Protein2)
              {

#line default
#line hidden
#nullable disable
                WriteLiteral("                 <input type=\"radio\" name=\"Item\"");
                BeginWriteAttribute("id", " id=\"", 1340, "\"", 1357, 1);
#nullable restore
#line 37 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 1345, protein.Key, 1345, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1358, "\"", 1380, 1);
#nullable restore
#line 37 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 1366, protein.Value, 1366, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 1381, "", 1417, 1);
#nullable restore
#line 37 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 1390, protein.Key == "Veggie ", 1390, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                 <label");
                BeginWriteAttribute("for", " for=\"", 1444, "\"", 1462, 1);
#nullable restore
#line 38 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 1450, protein.Key, 1450, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
                                      Write(protein.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>   \r\n");
#nullable restore
#line 39 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "747da39752c7a3902ec38a2291defea8a845a92913762", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 40 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Item);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </p>\r\n      </div>\r\n       <div>\r\n           <p>\r\n               <input type=\"hidden\" name=\"Currdate\"");
                BeginWriteAttribute("value", " value=\"", 1674, "\"", 1718, 1);
#nullable restore
#line 45 "C:\Users\janice_pc\source\repos\capstone-project\Vpop\Vpop\Views\Bowls\Index.cshtml"
WriteAttributeValue("", 1682, DateTime.Now.ToString("MM/dd/yyyy"), 1682, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n           </p>\r\n       </div>\r\n       <div>\r\n           <p>\r\n              <input type=\"submit\" value=\"Submit\">\r\n           </p>\r\n       </div>\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            WriteLiteral("\r\n <hr />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vpop.ViewModels.OrderBowlsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591