#pragma checksum "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3dd7f51935ec7a4378d07e0c0d887fb857767ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grupa7_Index), @"mvc.1.0.view", @"/Views/Grupa7/Index.cshtml")]
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
#line 1 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\_ViewImports.cshtml"
using Zadaća_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\_ViewImports.cshtml"
using Zadaća_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3dd7f51935ec7a4378d07e0c0d887fb857767ed", @"/Views/Grupa7/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460c7271c4cba02325645e41d89e1cce477d1bf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Grupa7_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Zadaća_4.Models.Donacija>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 5%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align: center"">Doniraj.ba - Aplikacija za donatore dobrog srca</h1>
<img src=""https://www.ox.ac.uk/sites/files/oxford/styles/ow_medium_feature/s3/field/field_image_main/Helping%20banner.jpg"" style=""width: 100%"" />
<h3 style=""margin-top: 3%"">Pomozite ljudima kojima je to potrebno, uz mogućnost skrivanja podataka o donatoru!</h3>
<h2 style=""margin-top: 3%"">Registrovane donacije:</h2>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 15 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SerijskiBroj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vrsta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OpisSadrzaja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Protuvrijednost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PosebnaPrigoda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Javna));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Posiljalac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Primalac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerijskiBroj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vrsta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OpisSadrzaja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Protuvrijednost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PosebnaPrigoda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Javna));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Posiljalac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Primalac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\Ehlimana\source\repos\Zadaća 4\Zadaća 4\Views\Grupa7\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div style=\"text-align: center;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3dd7f51935ec7a4378d07e0c0d887fb857767ed10433", async() => {
                WriteLiteral("Dodaj novu donaciju");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <a class=\"btn btn-primary\" href=\"https://www.youtube.com/watch?v=wDk59eIT6zI\" style=\"margin-top: 5%\">Filantropska playlista</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Zadaća_4.Models.Donacija>> Html { get; private set; }
    }
}
#pragma warning restore 1591
