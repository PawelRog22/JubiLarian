#pragma checksum "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc5bc537a4995576cbbc33f1ccced0fdbb195bde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(JubiLarian.Pages.Products.Pages_Products_Ditails), @"mvc.1.0.razor-page", @"/Pages/Products/Ditails.cshtml")]
namespace JubiLarian.Pages.Products
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
#line 1 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\_ViewImports.cshtml"
using JubiLarian;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc5bc537a4995576cbbc33f1ccced0fdbb195bde", @"/Pages/Products/Ditails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a8f06fa1dba96a5dbf1dbc419846b8b1869648", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products_Ditails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
  
    ViewData["Title"] = "Szczegóły";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <h4>Product ");
#nullable restore
#line 11 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
           Write(Html.DisplayFor(model => model.ProductDitails.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDitails.ProductNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayFor(model => model.ProductDitails.ProductNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDitails.TypeProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayFor(model => model.ProductDitails.TypeProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDitails.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayFor(model => model.ProductDitails.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDitails.Destinayion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayFor(model => model.ProductDitails.Destinayion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <h4>Producent</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDitails.Producent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayFor(model => model.ProductDitails.Producent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDitails.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayFor(model => model.ProductDitails.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <h4>Szczegóły w cenie</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDitails.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayFor(model => model.ProductDitails.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDitails.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
       Write(Html.DisplayFor(model => model.ProductDitails.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" PLN\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <ul class=\"list-inline\">\r\n        <li class=\"list-inline-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc5bc537a4995576cbbc33f1ccced0fdbb195bde10903", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "D:\Dane\Programowanie\ASP .NET CORE\Nauka\Razor\JubiLarian\Pages\Products\Ditails.cshtml"
                                                           WriteLiteral(Model.ProductDitails.ProductNumber);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n        </li>\r\n        <li class=\"list-inline-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc5bc537a4995576cbbc33f1ccced0fdbb195bde13260", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JubiLarian.Pages.Products.DitalsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JubiLarian.Pages.Products.DitalsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JubiLarian.Pages.Products.DitalsModel>)PageContext?.ViewData;
        public JubiLarian.Pages.Products.DitalsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
