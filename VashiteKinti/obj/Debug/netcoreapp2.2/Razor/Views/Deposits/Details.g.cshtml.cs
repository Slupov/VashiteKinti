#pragma checksum "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c39a7319e15f5f2ce72cb4939604d8d397cf8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deposits_Details), @"mvc.1.0.view", @"/Views/Deposits/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Deposits/Details.cshtml", typeof(AspNetCore.Views_Deposits_Details))]
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
#line 1 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\_ViewImports.cshtml"
using VashiteKinti;

#line default
#line hidden
#line 2 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\_ViewImports.cshtml"
using VashiteKinti.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c39a7319e15f5f2ce72cb4939604d8d397cf8e", @"/Views/Deposits/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34cc15501b5324634a8cdac0bd93049c88fc0e0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Deposits_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VashiteKinti.Data.Models.Deposit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 139, true);
            WriteLiteral("\r\n<h1 id=\"text-orange\">Информация за депозит</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(226, 40, false);
#line 13 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bank));

#line default
#line hidden
            EndContext();
            BeginContext(266, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(330, 39, false);
#line 16 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bank.Id));

#line default
#line hidden
            EndContext();
            BeginContext(369, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(432, 40, false);
#line 19 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(472, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(536, 36, false);
#line 22 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(572, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(635, 45, false);
#line 25 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MinAmount));

#line default
#line hidden
            EndContext();
            BeginContext(680, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(744, 41, false);
#line 28 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.MinAmount));

#line default
#line hidden
            EndContext();
            BeginContext(785, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(848, 44, false);
#line 31 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Interest));

#line default
#line hidden
            EndContext();
            BeginContext(892, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(956, 40, false);
#line 34 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Interest));

#line default
#line hidden
            EndContext();
            BeginContext(996, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1059, 49, false);
#line 37 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentMethod));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1172, 45, false);
#line 40 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaymentMethod));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1280, 44, false);
#line 43 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Currency));

#line default
#line hidden
            EndContext();
            BeginContext(1324, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1388, 40, false);
#line 46 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
       Write(Html.DisplayFor(model => model.Currency));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1475, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91c39a7319e15f5f2ce72cb4939604d8d397cf8e9311", async() => {
                BeginContext(1521, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "D:\GitHubProjects\VashiteKintiStoyan\VashiteKinti\Views\Deposits\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1529, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1537, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91c39a7319e15f5f2ce72cb4939604d8d397cf8e11632", async() => {
                BeginContext(1559, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1575, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VashiteKinti.Data.Models.Deposit> Html { get; private set; }
    }
}
#pragma warning restore 1591
