#pragma checksum "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d6934ada24633f6b025a08fa2ca0393aade9e87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameTypes_Index), @"mvc.1.0.view", @"/Views/GameTypes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GameTypes/Index.cshtml", typeof(AspNetCore.Views_GameTypes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6934ada24633f6b025a08fa2ca0393aade9e87", @"/Views/GameTypes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883786770e7046949cc5e7d4e2293665b14a3dc8", @"/Views/_ViewImports.cshtml")]
    public class Views_GameTypes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketballTickets.Models.GameType>>
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
  
    ViewData["Title"] = "Game Types";

#line default
#line hidden
            BeginContext(103, 33, true);
            WriteLiteral("\r\n<h2 class=\"center center-bold\">");
            EndContext();
            BeginContext(137, 17, false);
#line 7 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(154, 60, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    <button class=\"btn btn-primary\">\r\n        ");
            EndContext();
            BeginContext(214, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c7f992b6f4841f2a8be059f71861ab2", async() => {
                BeginContext(237, 63, true);
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
            BeginContext(304, 107, true);
            WriteLiteral("\r\n    </button>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(412, 40, false);
#line 18 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(452, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(508, 41, false);
#line 21 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Order));

#line default
#line hidden
            EndContext();
            BeginContext(549, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(684, 38, true);
            WriteLiteral("            <tr class=\"colored-border\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 722, "\"", 809, 5);
            WriteAttributeValue("", 732, "location.href", 732, 13, true);
            WriteAttributeValue(" ", 745, "=", 746, 2, true);
            WriteAttributeValue(" ", 747, "\'", 748, 2, true);
#line 29 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
WriteAttributeValue("", 749, Url.Action("Details", "GameTypes", new { id = item.Id }), 749, 59, false);

#line default
#line hidden
            WriteAttributeValue("", 808, "\'", 808, 1, true);
            EndWriteAttribute();
            BeginContext(810, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(856, 39, false);
#line 31 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(895, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(963, 40, false);
#line 34 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Order));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 194, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div class=\"btn-group btn-group-toggle\">\r\n                        <label class=\"btn btn-primary\">\r\n                            ");
            EndContext();
            BeginContext(1197, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab19ca0fe344424d9efe6cbcb92c220b", async() => {
                BeginContext(1242, 50, true);
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
#line 39 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
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
            BeginContext(1296, 121, true);
            WriteLiteral("\r\n                        </label>\r\n                        <label class=\"btn btn-primary\">\r\n                            ");
            EndContext();
            BeginContext(1417, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ec9f6bea1bc43db8b8a0dac8a192da8", async() => {
                BeginContext(1464, 54, true);
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
#line 42 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
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
            BeginContext(1522, 106, true);
            WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 47 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\GameTypes\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1643, 28, true);
            WriteLiteral("        </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketballTickets.Models.GameType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
