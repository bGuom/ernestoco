#pragma checksum "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Forms\Autocomplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "936a3620007cc2db81f55e0ee2c00bfea847ef2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forms_Autocomplete), @"mvc.1.0.view", @"/Views/Forms/Autocomplete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forms/Autocomplete.cshtml", typeof(AspNetCore.Views_Forms_Autocomplete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936a3620007cc2db81f55e0ee2c00bfea847ef2d", @"/Views/Forms/Autocomplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Forms_Autocomplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/typehead/bootstrap3-typeahead.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Forms\Autocomplete.cshtml"
  
    ViewData["Title"] = "Autocomplete";

#line default
#line hidden
            BeginContext(50, 218, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Autocomplete</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 268, "\"", 315, 1);
#line 11 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Forms\Autocomplete.cshtml"
WriteAttributeValue("", 275, Url.Action("Dashboard_1", "Dashboards"), 275, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(316, 12407, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Forms</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Autocomplete</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">
    </div>
</div>
<div class=""wrapper wrapper-content animated fadeIn"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Autocomplete - Bootstrap Typehead</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
 ");
            WriteLiteral(@"                               <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <strong>Autocomplete - typehead</strong><br />
                    The Typeahead plugin from Twitter's Bootstrap 2 ready to use with Bootstrap 3 and Bootstrap 4. Full documentation can be found: <a href=""https://github.com/bassjobsen/Bootstrap-3-Typeahead"" target=""_blank"">https://github.com/bassjobsen/Bootstrap-3-Typeahead</a>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-6"">
       ");
            WriteLiteral(@"     <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Basic example - data-*</h5>
                </div>
                <div class=""ibox-content"">
                    <p>
                        Basic example via data attributes: <span class=""text-muted"">(type 'item...')</span>
                    </p>
                    <input type=""text"" placeholder=""item..."" data-provide=""typeahead"" data-source='[""item 1"",""item 2"",""item 3""]' class=""form-control"" />
                    <pre class=""m-t-sm"">
&lt;input type=""text""
data-provide=""typeahead""
data-source='[""item 1"",""item 2"",""item 3""]'
placeholder=""item...""
class=""form-control"" /&gt;</pre>
                </div>
            </div>
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Loading collection</h5>
                </div>
                <div class=""ibox-content"">
                    <p>
                        Load collection from json file <span class=""");
            WriteLiteral(@"text-muted"">(type 'Arg...')</span>
                    </p>
                    <input type=""text"" placeholder=""item..."" class=""typeahead_2 form-control"" />
                    <pre class=""m-t-sm"">
$.get('js/api/typehead_collection.json', function(data){
    $("".typeahead_2"").typeahead({ source:data.countries });
},'json'); </pre>
                </div>
            </div>
        </div>
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Basic example - javascript</h5>
                </div>
                <div class=""ibox-content"">
                    <p>
                        Basic example via javascript <span class=""text-muted"">(type 'item...')</span>
                    </p>
                    <input type=""text"" placeholder=""item..."" class=""typeahead_1 form-control"" />
                    <pre class=""m-t-sm"">
$('.typeahead_1').typeahead({
    source: [""item 1"",""item 2"",""item 3""]
}); </pre>
             ");
            WriteLiteral(@"   </div>
            </div>
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Loading more complex object</h5>
                </div>
                <div class=""ibox-content"">
                    <p>
                        Load json object - required 'name' attribute <span class=""text-muted"">(type 'Afg...')</span>
                    </p>
                    <input type=""text"" placeholder=""item..."" class=""typeahead_3 form-control"" />
                    <pre class=""m-t-sm"">
$('.typeahead_3').typeahead({
    source: [
        {""name"": ""Afghanistan"", ""code"": ""AF"", ""ccn0"": ""040""},
        {""name"": ""Land Islands"", ""code"": ""AX"", ""ccn0"": ""050""},
        {""name"": ""Albania"", ""code"": ""AL"",""ccn0"": ""060""},
        {""name"": ""Algeria"", ""code"": ""DZ"",""ccn0"": ""070""}
    ]
}); </pre>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
               ");
            WriteLiteral(@" <div class=""ibox-title"">
                    <h5>Options</h5>
                </div>
                <div class=""ibox-content"">
                    <p>Options can be passed via data attributes or JavaScript. For data attributes, append the option name to <code>data-</code>, as in <code>data-source=""""</code>.</p>
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Type</th>
                                <th>Default</th>
                                <th>Description</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>source</td>
                                <td>array, function</td>
                                <td>[ ]</td>
                                <td>The data source to query against. May be an array of strings, an array ");
            WriteLiteral(@"of JSON object with a name property or a function. The function accepts two arguments, the <code>query</code> value in the input field and the <code>process</code> callback. The function may be used synchronously by returning the data source directly or asynchronously via the <code>process</code> callback's single argument.</td>
                            </tr>
                            <tr>
                                <td>items</td>
                                <td>number</td>
                                <td>8</td>
                                <td>The max number of items to display in the dropdown. Can also be set to 'all'</td>
                            </tr>
                            <tr>
                                <td>minLength</td>
                                <td>number</td>
                                <td>1</td>
                                <td>The minimum character length needed before triggering autocomplete suggestions. You can set it to 0 so suggestion");
            WriteLiteral(@" are shown even when there is no text when lookup function is called.</td>
                            </tr>
                            <tr>
                                <td>showHintOnFocus</td>
                                <td>boolean</td>
                                <td>false</td>
                                <td>If hints should be shown when applicable as soon as the input gets focus.</td>
                            </tr>
                            <tr>
                                <td>scrollHeight</td>
                                <td>number, function</td>
                                <td>0</td>
                                <td>Number of pixels the scrollable parent container scrolled down (scrolled out the viewport).</td>
                            </tr>
                            <tr>
                                <td>matcher</td>
                                <td>function</td>
                                <td>case insensitive</td>
                 ");
            WriteLiteral(@"               <td>The method used to determine if a query matches an item. Accepts a single argument, the <code>item</code> against which to test the query. Access the current query with <code>this.query</code>. Return a boolean <code>true</code> if query is a match.</td>
                            </tr>
                            <tr>
                                <td>sorter</td>
                                <td>function</td>
                                <td>exact match,<br> case sensitive,<br> case insensitive</td>
                                <td>Method used to sort autocomplete results. Accepts a single argument <code>items</code> and has the scope of the typeahead instance. Reference the current query with <code>this.query</code>.</td>
                            </tr>
                            <tr>
                                <td>updater</td>
                                <td>function</td>
                                <td>returns selected item</td>
                  ");
            WriteLiteral(@"              <td>The method used to return selected item. Accepts a single argument, the <code>item</code> and has the scope of the typeahead instance.</td>
                            </tr>
                            <tr>
                                <td>highlighter</td>
                                <td>function</td>
                                <td>highlights all default matches</td>
                                <td>Method used to highlight autocomplete results. Accepts a single argument <code>item</code> and has the scope of the typeahead instance. Should return html.</td>
                            </tr>
                            <tr>
                                <td>displayText</td>
                                <td>function</td>
                                <td>item.name || item</td>
                                <td>Method used to get textual representation of an item of the sources. Accepts a single argument <code>item</code> and has the scope of the typeahead in");
            WriteLiteral(@"stance. Should return a String.</td>
                            </tr>
                            <tr>
                                <td>autoSelect</td>
                                <td>boolean</td>
                                <td>true</td>
                                <td>Allows you to dictate whether or not the first suggestion is selected automatically. Turning autoselect off also means that the input won't clear if nothing is selected and <kbd>enter</kbd> or <kbd>tab</kbd> is hit.</td>
                            </tr>
                            <tr>
                                <td>afterSelect</td>
                                <td>function</td>
                                <td>$.noop()</td>
                                <td>Call back function to execute after selected an item. It gets the current active item in parameter if any.</td>
                            </tr>
                            <tr>
                                <td>delay</td>
                  ");
            WriteLiteral(@"              <td>integer</td>
                                <td>0</td>
                                <td>Adds a delay between lookups.</td>
                            </tr>
                            <tr></tr>
                            <tr>
                                <td>addItem</td>
                                <td>JSON object</td>
                                <td>false</td>
                                <td>Adds an item to the end of the list, for example ""New Entry"". This could be used, for example, to pop a dialog when an item is not found in the list of data. Example: <a href=""http://cl.ly/image/2u170I1q1G3A/addItem.png"">http://cl.ly/image/2u170I1q1G3A/addItem.png</a></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class=""footer"">
        <div class=""float-right"">
            10GB of <strong>250GB</strong> Free.
        </div>
       ");
            WriteLiteral(" <div>\r\n            <strong>Copyright</strong> Example Company &copy; 2014-2015\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(12741, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(12747, 148, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8d10e34294b4c2d948676b90e5042ce", async() => {
                    BeginContext(12799, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(12809, 66, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc4fc76be86f4dd9a73372997f5094f1", async() => {
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
                    BeginContext(12875, 6, true);
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
                BeginContext(12895, 813, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {


            $('.typeahead_1').typeahead({
                source: [""item 1"", ""item 2"", ""item 3""]
            });

            $.get('../api/typehead_collection.json', function (data) {
                $("".typeahead_2"").typeahead({ source: data.countries });
            }, 'json');

            $('.typeahead_3').typeahead({
                source: [
                    { ""name"": ""Afghanistan"", ""code"": ""AF"", ""ccn0"": ""040"" },
                    { ""name"": ""Land Islands"", ""code"": ""AX"", ""ccn0"": ""050"" },
                    { ""name"": ""Albania"", ""code"": ""AL"", ""ccn0"": ""060"" },
                    { ""name"": ""Algeria"", ""code"": ""DZ"", ""ccn0"": ""070"" }
                ]
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
