#pragma checksum "C:\Users\Yasmin\source\repos\GiftShop\GiftShop\Views\Balloons\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c68e87c878fdc088f3ddedcf3ea2e21ebb26f91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Balloons_Details), @"mvc.1.0.view", @"/Views/Balloons/Details.cshtml")]
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
#line 1 "C:\Users\Yasmin\source\repos\GiftShop\GiftShop\Views\_ViewImports.cshtml"
using GiftShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasmin\source\repos\GiftShop\GiftShop\Views\_ViewImports.cshtml"
using GiftShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c68e87c878fdc088f3ddedcf3ea2e21ebb26f91", @"/Views/Balloons/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76bf88a984abc5baf4514d0e27765589a2879c58", @"/Views/_ViewImports.cshtml")]
    public class Views_Balloons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Balloons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Yasmin\source\repos\GiftShop\GiftShop\Views\Balloons\Details.cshtml"
  
    var Balloon = (BalloonModel)ViewData["Balloon"];
    Layout = "WebLayout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<center>
    <nav class=""navbar navbar-expand-sm bg-dark navbar-dark"">

        <a class=""navbar-brand"" href=""/Home""><img style=""height:30px; width:30px;"" src=""https://cdn0.iconfinder.com/data/icons/flowers-and-leaves/47/flower_9-512.png"" /></a>

        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Home/Privacy"">Privacy</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Home/ContactUs""><i class=""fa fa-fw fa-envelope""></i>Contact Us</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Balloons/Create"">Add a Product</a>
            </li>
        </ul>
    </nav>
</center>

<center>
    <div class=""card"" style=""width: 18rem;"">
        <div class=""card-body"">
            <img style=""width:200px; height:200px""");
            BeginWriteAttribute("src", " src=\"", 978, "\"", 1005, 1);
#nullable restore
#line 29 "C:\Users\Yasmin\source\repos\GiftShop\GiftShop\Views\Balloons\Details.cshtml"
WriteAttributeValue("", 984, Balloon.BalloonImage, 984, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1006, "\"", 1033, 1);
#nullable restore
#line 29 "C:\Users\Yasmin\source\repos\GiftShop\GiftShop\Views\Balloons\Details.cshtml"
WriteAttributeValue("", 1012, Balloon.BalloonImage, 1012, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        </div>\r\n        <ul class=\"list-group list-group-flush\">\r\n            <li class=\"list-group-item\">Balloon ID: ");
#nullable restore
#line 33 "C:\Users\Yasmin\source\repos\GiftShop\GiftShop\Views\Balloons\Details.cshtml"
                                               Write(Balloon.BalloonId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">Balloon Name: ");
#nullable restore
#line 34 "C:\Users\Yasmin\source\repos\GiftShop\GiftShop\Views\Balloons\Details.cshtml"
                                                 Write(Balloon.BalloonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">Balloon Price ");
#nullable restore
#line 35 "C:\Users\Yasmin\source\repos\GiftShop\GiftShop\Views\Balloons\Details.cshtml"
                                                 Write(Balloon.BalloonPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n\r\n        </ul>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c68e87c878fdc088f3ddedcf3ea2e21ebb26f916663", async() => {
                WriteLiteral("Back to Balloons");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</center>");
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
