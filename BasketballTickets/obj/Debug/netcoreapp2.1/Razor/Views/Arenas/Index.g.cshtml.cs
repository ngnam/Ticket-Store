#pragma checksum "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "296c78eaabc214f4fc1f30e48917c26d0326a64a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Arenas_Index), @"mvc.1.0.view", @"/Views/Arenas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Arenas/Index.cshtml", typeof(AspNetCore.Views_Arenas_Index))]
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
#line 1 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\_ViewImports.cshtml"
using BasketballTickets;

#line default
#line hidden
#line 2 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\_ViewImports.cshtml"
using BasketballTickets.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296c78eaabc214f4fc1f30e48917c26d0326a64a", @"/Views/Arenas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883786770e7046949cc5e7d4e2293665b14a3dc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Arenas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketballTickets.Models.Arena>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
  
    ViewData["Title"] = "Arenas";

#line default
#line hidden
            BeginContext(96, 33, true);
            WriteLiteral("\r\n<h2 class=\"center center-bold\">");
            EndContext();
            BeginContext(130, 17, false);
#line 7 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(147, 60, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    <button class=\"btn btn-primary\">\r\n        ");
            EndContext();
            BeginContext(207, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "170a9c405c8443ea98716fe81aa41310", async() => {
                BeginContext(230, 63, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-plus-sign\"></span> Create New ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(297, 107, true);
            WriteLiteral("\r\n    </button>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(405, 40, false);
#line 18 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(445, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(501, 44, false);
#line 21 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(545, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
            BeginContext(671, 38, true);
            WriteLiteral("            <tr class=\"colored-border\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 709, "\"", 793, 5);
            WriteAttributeValue("", 719, "location.href", 719, 13, true);
            WriteAttributeValue(" ", 732, "=", 733, 2, true);
            WriteAttributeValue(" ", 734, "\'", 735, 2, true);
#line 28 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
WriteAttributeValue("", 736, Url.Action("Details", "Arenas", new { id = item.Id }), 736, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 792, "\'", 792, 1, true);
            EndWriteAttribute();
            BeginContext(794, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(840, 39, false);
#line 30 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(879, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(947, 43, false);
#line 33 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(990, 194, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div class=\"btn-group btn-group-toggle\">\r\n                        <label class=\"btn btn-primary\">\r\n                            ");
            EndContext();
            BeginContext(1184, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c129550b6264b5a940bee7e48c9daed", async() => {
                BeginContext(1229, 50, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-cog\"></span> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1283, 121, true);
            WriteLiteral("\r\n                        </label>\r\n                        <label class=\"btn btn-primary\">\r\n                            ");
            EndContext();
            BeginContext(1404, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8464eb20081a42db8078e6a99e4813f7", async() => {
                BeginContext(1451, 54, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-trash\"></span> Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1509, 106, true);
            WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 46 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Arenas\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1626, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketballTickets.Models.Arena>> Html { get; private set; }
    }
}
#pragma warning restore 1591
