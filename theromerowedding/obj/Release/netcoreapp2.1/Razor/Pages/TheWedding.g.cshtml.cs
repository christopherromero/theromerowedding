#pragma checksum "C:\source\repos\GitHub\theromerowedding\theromerowedding\Pages\TheWedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c1f1a75d4d96d160e1e2dbe38840d67caa0fc8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(theromerowedding.Pages.Pages_TheWedding), @"mvc.1.0.razor-page", @"/Pages/TheWedding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/TheWedding.cshtml", typeof(theromerowedding.Pages.Pages_TheWedding), null)]
namespace theromerowedding.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\source\repos\GitHub\theromerowedding\theromerowedding\Pages\_ViewImports.cshtml"
using theromerowedding;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c1f1a75d4d96d160e1e2dbe38840d67caa0fc8a", @"/Pages/TheWedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b4386e11899e6eff569f9001d67e24f751be62e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TheWedding : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hero-images"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/barn.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\source\repos\GitHub\theromerowedding\theromerowedding\Pages\TheWedding.cshtml"
  
    ViewData["Title"] = "THE WEDDING";

#line default
#line hidden
            BeginContext(78, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(83, 23, false);
#line 6 "C:\source\repos\GitHub\theromerowedding\theromerowedding\Pages\TheWedding.cshtml"
Write(ViewData["The Wedding"]);

#line default
#line hidden
            EndContext();
            BeginContext(106, 81, true);
            WriteLiteral("</h2>\r\n<br /><br />\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(187, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f25677ebb84e46c997fc5dba7541aca9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(238, 828, true);
            WriteLiteral(@"
        <div class=""col-lg-6"">
            <h1>WHEN</h1>
            <h3>
                Saturday, May 4, 2019
                <br />
                Ceremony: 4:00 PM
                <br />
                Reception to follow.
                <br />
            </h3>
        </div>
        <div class=""col-lg-6"">
            <h1>WHERE</h1>
            <h3>
                <a href=""https://mistymorningbarn.com/"" target=""_blank"">Misty Morning Barn at Clutch Farm</a><br />
                <a href=""https://goo.gl/maps/JZixu96bzix"" target=""_blank"">
                    18810 Misty Morning Lane<br />
                    Fort Myers, Florida 33913<br />
                </a>
                <a href=""tel:2398870069"" target=""_blank"">(239) 887-0069</a>
            </h3>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheWeddingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TheWeddingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TheWeddingModel>)PageContext?.ViewData;
        public TheWeddingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
