#pragma checksum "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Miscellaneous\LiveFavicon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb94d425d00a29b76f0b368fc957e5dec9b073d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Miscellaneous_LiveFavicon), @"mvc.1.0.view", @"/Views/Miscellaneous/LiveFavicon.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Miscellaneous/LiveFavicon.cshtml", typeof(AspNetCore.Views_Miscellaneous_LiveFavicon))]
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
#line 1 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\_ViewImports.cshtml"
using ASPNET_Core_2_1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb94d425d00a29b76f0b368fc957e5dec9b073d", @"/Views/Miscellaneous/LiveFavicon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Miscellaneous_LiveFavicon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/tinycon/tinycon.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Miscellaneous\LiveFavicon.cshtml"
  
    ViewData["Title"] = "LiveFavicon";

#line default
#line hidden
            BeginContext(49, 213, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Tinycon</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 262, "\"", 309, 1);
#line 11 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Miscellaneous\LiveFavicon.cshtml"
WriteAttributeValue("", 269, Url.Action("Dashboard_1", "Dashboards"), 269, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(310, 3178, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Miscellaneous</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Tinycon</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content  animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Tinycon</h5>
                </div>

                <div class=""ibox-content"">

                    <strong>A small library for manipulating the favicon</strong>
                    <p>
                        Tinycon allows the addition of alert bubbles and changing the favicon image. Tinycon gracefully falls back to a number in title approach for browsers that don't support canvas or dynamic favicons.
                    </p>

                    <p>
                       ");
            WriteLiteral(@" Alerts in the favicon allow users to pin a tab and easily see if their attention is needed.
                    </p>

                    <div class=""text-center p-lg"">

                        <a href=""#"" class=""btn btn-white"" id=""iconExample1"">Set icon to 1</a>
                        <a href=""#"" class=""btn btn-white"" id=""iconExample2"">Set icon to 1000</a>
                        <a href=""#"" class=""btn btn-white"" id=""iconExample3"">Set icon to string 'In'</a>
                        <a href=""#"" class=""btn btn-primary"" id=""iconExample4"">Set icon with custom color</a>

                    </div>

                    <h3>
                        <a aria-hidden=""true"" href=""#options"" class=""anchor"" id=""user-content-options""><span class=""octicon octicon-link""></span></a>Options
                    </h3>
                    <p>Tinycon can take a range of options to customise the look</p>
                    <ul class=""task-list"">
                        <li>width: the width of the alert bubble</l");
            WriteLiteral(@"i>
                        <li>height: the height of the alert bubble</li>
                        <li>font: a css string to use for the fontface (recommended to leave this)</li>
                        <li>colour: the foreground font colour</li>
                        <li>background: the alert bubble background colour</li>
                        <li>fallback: should we fallback to a number in brackets for browsers that don't support canvas/dynamic favicons? Boolean, or use the string 'force' to ensure a title update even in supported browsers.</li>
                        <li>abbreviate: should tinycon shrink large numbers such as 1000 to an abbreviated version (1k). Boolean, defaults to true</li>
                    </ul>

                    <p><strong>Example usage</strong></p>
                    <pre>
Tinycon.setBubble(6);
Tinycon.setOptions({
    width: 7,
    height: 9,
    font: '10px arial',
    colour: '#ffffff',
    background: '#549A2F',
    fallback: true
});
              ");
            WriteLiteral("              </pre>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3506, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3512, 134, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cf7b131ba6f428f88111d6fde2c8598", async() => {
                    BeginContext(3564, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(3574, 52, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1963cc0d1ef04cb784be5a30e661c6e8", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3626, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3646, 982, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            $('#iconExample1').click(function () {

                Tinycon.setBubble(1);

                Tinycon.setOptions({
                    background: '#f03d25'
                });
            });

            $('#iconExample2').click(function () {

                Tinycon.setBubble(1000);

                Tinycon.setOptions({
                    background: '#f03d25'
                });
            });

            $('#iconExample3').click(function () {

                Tinycon.setBubble('In');

                Tinycon.setOptions({
                    background: '#f03d25'
                });
            });

            $('#iconExample4').click(function () {

                Tinycon.setOptions({
                    background: '#e0913b'
                });
                Tinycon.setBubble(8);

            });

        });
    </script>
");
                EndContext();
            }
            );
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
