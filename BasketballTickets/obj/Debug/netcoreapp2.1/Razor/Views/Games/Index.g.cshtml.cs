#pragma checksum "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4512d6574be2fae211155f2f9041db7ec83a33e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Index), @"mvc.1.0.view", @"/Views/Games/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Games/Index.cshtml", typeof(AspNetCore.Views_Games_Index))]
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
#line 3 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4512d6574be2fae211155f2f9041db7ec83a33e5", @"/Views/Games/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883786770e7046949cc5e7d4e2293665b14a3dc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketballTickets.Models.Game>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("64px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
  
    ViewData["Title"] = "Games";

#line default
#line hidden
            BeginContext(232, 33, true);
            WriteLiteral("\r\n<h2 class=\"center center-bold\">");
            EndContext();
            BeginContext(266, 22, false);
#line 11 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
                          Write(ViewData["GamesTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(288, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 13 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
 if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
{ 

#line default
#line hidden
            BeginContext(365, 63, true);
            WriteLiteral("    <p>\r\n        <button class=\"btn btn-primary\">\r\n            ");
            EndContext();
            BeginContext(428, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7aeecca32dda445a9104325e2ffe896b", async() => {
                BeginContext(451, 63, true);
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
            BeginContext(518, 31, true);
            WriteLiteral("\r\n        </button>\r\n    </p>\r\n");
            EndContext();
#line 20 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
}

#line default
#line hidden
            BeginContext(552, 27, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            EndContext();
#line 23 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(620, 504, true);
            WriteLiteral(@"        <div id=""game-selection"" class=""row colored-border"">
            <div class=""col-md-3"">
                <p class=""day"">Tuesday</p>
                <h3 class=""dayNumber bold"">Jan 15</h3>
                <p class=""time"">7:30 PM</p>
                <p class=""venue"">STAPLES Center</p>
            </div>
            <div class=""col-md-6"">
                <br /><br />
                <div class=""row"">
                    <div class=""col-md-3"">
                        <text class=""bold"">");
            EndContext();
            BeginContext(1125, 18, false);
#line 36 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
                                      Write(item.AwayTeam.City);

#line default
#line hidden
            EndContext();
            BeginContext(1143, 84, true);
            WriteLiteral("</text>\r\n                        <br />\r\n                        <text class=\"bold\">");
            EndContext();
            BeginContext(1228, 18, false);
#line 38 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
                                      Write(item.AwayTeam.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 105, true);
            WriteLiteral("</text>\r\n                    </div>\r\n                    <div class=\"col-md-2\">\r\n                        ");
            EndContext();
            BeginContext(1351, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "08ed655e98624e75801ff8e5b030a7d0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 41 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
                      WriteLiteral(item.AwayTeam.LogoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 41 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1439, 156, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-1 center\">\r\n                        <br />\r\n                        <text class=\"bold\">");
            EndContext();
            BeginContext(1596, 106, true);
            WriteLiteral("@</text>\r\n                    </div>\r\n                    <div class=\"col-md-2\">\r\n                        ");
            EndContext();
            BeginContext(1702, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ac058c5a5e4841eca8b94746298c7f29", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 48 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
                      WriteLiteral(item.HomeTeam.LogoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 48 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1790, 117, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <text class=\"bold\">");
            EndContext();
            BeginContext(1908, 18, false);
#line 51 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
                                      Write(item.HomeTeam.City);

#line default
#line hidden
            EndContext();
            BeginContext(1926, 84, true);
            WriteLiteral("</text>\r\n                        <br />\r\n                        <text class=\"bold\">");
            EndContext();
            BeginContext(2011, 18, false);
#line 53 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
                                      Write(item.HomeTeam.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2029, 147, true);
            WriteLiteral("</text>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n                <br /><br />\r\n");
            EndContext();
#line 59 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
                 if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                {

#line default
#line hidden
            BeginContext(2275, 147, true);
            WriteLiteral("                    <div class=\"btn-group btn-group-toggle\">\r\n                        <label class=\"btn btn-primary\">\r\n                            ");
            EndContext();
            BeginContext(2422, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6202cb5d89c24e5dbe81339843ffc7aa", async() => {
                BeginContext(2467, 50, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-cog\"></span> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
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
            BeginContext(2521, 121, true);
            WriteLiteral("\r\n                        </label>\r\n                        <label class=\"btn btn-primary\">\r\n                            ");
            EndContext();
            BeginContext(2642, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fd61770e37f420d983c4cf1794cbc25", async() => {
                BeginContext(2689, 54, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-trash\"></span> Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
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
            BeginContext(2747, 64, true);
            WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n");
            EndContext();
#line 69 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2871, 175, true);
            WriteLiteral("                    <button class=\"btn btn-success\">\r\n                        <a>Buy Tickets <span class=\"glyphicon glyphicon-tag\"></span></a>\r\n                    </button>\r\n");
            EndContext();
#line 75 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3065, 37, true);
            WriteLiteral("            </div>\r\n        </div> \r\n");
            EndContext();
#line 78 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(3109, 14, true);
            WriteLiteral("</div>\r\n<!--\r\n");
            EndContext();
#line 81 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(3156, 30, true);
            WriteLiteral("    <tr class=\"colored-border\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3186, "\"", 3269, 5);
            WriteAttributeValue("", 3196, "location.href", 3196, 13, true);
            WriteAttributeValue(" ", 3209, "=", 3210, 2, true);
            WriteAttributeValue(" ", 3211, "\'", 3212, 2, true);
#line 83 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
WriteAttributeValue("", 3213, Url.Action("Details", "Games", new { id = item.Id }), 3213, 55, false);

#line default
#line hidden
            WriteAttributeValue("", 3268, "\'", 3268, 1, true);
            EndWriteAttribute();
            BeginContext(3270, 29, true);
            WriteLiteral(">\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3300, 39, false);
#line 85 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(3339, 57, true);
            WriteLiteral("\r\n            \r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3396, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff021797e27e4697aeccd8172485faa9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 89 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
          WriteLiteral(item.AwayTeam.LogoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#line 89 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3483, 41, true);
            WriteLiteral("\r\n            <text class=\"center-bold\"> ");
            EndContext();
            BeginContext(3525, 23, true);
            WriteLiteral("@ </text>\r\n            ");
            EndContext();
            BeginContext(3548, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b25d6ec851124cfa9c4c4cf1e9e6b441", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 91 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
          WriteLiteral(item.HomeTeam.LogoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#line 91 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3635, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3679, 48, false);
#line 94 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.GameType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3727, 31, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n");
            EndContext();
#line 97 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
             if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(3849, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3865, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c0a05b9c0b485e9c935604066d6b08", async() => {
                BeginContext(3910, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
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
            BeginContext(3918, 33, true);
            WriteLiteral("<span> |</span>\r\n                ");
            EndContext();
            BeginContext(3951, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f9650430d9048aca0a34a5dee1ca616", async() => {
                BeginContext(3998, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
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
            BeginContext(4008, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 101 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4025, 26, true);
            WriteLiteral("        </td>\r\n    </tr>\r\n");
            EndContext();
#line 104 "D:\Visual Studio Projects\BasketballTickets\BasketballTickets\Views\Games\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4054, 5, true);
            WriteLiteral("-->\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketballTickets.Models.Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591
