#pragma checksum "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f732868649b3a3422067a1d300bf8b68834dfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mailbox_ComposeEmail), @"mvc.1.0.view", @"/Views/Mailbox/ComposeEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mailbox/ComposeEmail.cshtml", typeof(AspNetCore.Views_Mailbox_ComposeEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f732868649b3a3422067a1d300bf8b68834dfe", @"/Views/Mailbox/ComposeEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Mailbox_ComposeEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/summernote/summernote-bs4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/summernote/summernote-bs4.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
  
    ViewData["Title"] = "ComposeEmail";

#line default
#line hidden
            BeginContext(50, 310, true);
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""row"">
        <div class=""col-lg-3"">
            <div class=""ibox "">
                <div class=""ibox-content mailbox-content"">
                    <div class=""file-manager"">
                        <a class=""btn btn-block btn-primary compose-mail""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 360, "\"", 405, 1);
#line 12 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 367, Url.Action("ComposeEmail", "Mailbox"), 367, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(406, 225, true);
            WriteLiteral(">Compose Mail</a>\r\n                        <div class=\"space-25\"></div>\r\n                        <h5>Folders</h5>\r\n                        <ul class=\"folder-list m-b-md\" style=\"padding: 0\">\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 631, "\"", 669, 1);
#line 16 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 638, Url.Action("Inbox", "Mailbox"), 638, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(670, 138, true);
            WriteLiteral("> <i class=\"fa fa-inbox \"></i> Inbox <span class=\"label label-warning float-right\">16</span> </a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 808, "\"", 846, 1);
#line 17 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 815, Url.Action("Inbox", "Mailbox"), 815, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(847, 89, true);
            WriteLiteral("> <i class=\"fa fa-envelope-o\"></i> Send Mail</a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 936, "\"", 974, 1);
#line 18 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 943, Url.Action("Inbox", "Mailbox"), 943, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(975, 90, true);
            WriteLiteral("> <i class=\"fa fa-certificate\"></i> Important</a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1065, "\"", 1103, 1);
#line 19 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 1072, Url.Action("Inbox", "Mailbox"), 1072, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1104, 141, true);
            WriteLiteral("> <i class=\"fa fa-file-text-o\"></i> Drafts <span class=\"label label-danger float-right\">2</span></a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1245, "\"", 1283, 1);
#line 20 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 1252, Url.Action("Inbox", "Mailbox"), 1252, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1284, 1911, true);
            WriteLiteral(@"> <i class=""fa fa-trash-o""></i> Trash</a></li>
                        </ul>
                        <h5>Categories</h5>
                        <ul class=""category-list"" style=""padding: 0"">
                            <li><a href=""#""> <i class=""fa fa-circle text-navy""></i> Work </a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-danger""></i> Documents</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-primary""></i> Social</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-info""></i> Advertising</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-warning""></i> Clients</a></li>
                        </ul>

                        <h5 class=""tag-title"">Labels</h5>
                        <ul class=""tag-list"" style=""padding: 0"">
                            <li><a href=""""><i class=""fa fa-tag""></i> Family</a></li>
                            <li><a href=""""><i class=""fa fa-tag"">");
            WriteLiteral(@"</i> Work</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Home</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Children</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Holidays</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Music</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Photography</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Film</a></li>
                        </ul>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-9 animated fadeInRight"">
            <div class=""mail-box-header"">
                <div class=""float-right tooltip-demo"">
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3195, "\"", 3233, 1);
#line 50 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 3202, Url.Action("Inbox", "Mailbox"), 3202, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3234, 164, true);
            WriteLiteral(" class=\"btn btn-white btn-sm\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Move to draft folder\"><i class=\"fa fa-pencil\"></i> Draft</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3398, "\"", 3436, 1);
#line 51 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 3405, Url.Action("Inbox", "Mailbox"), 3405, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3437, 362, true);
            WriteLiteral(@" class=""btn btn-danger btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Discard email""><i class=""fa fa-times""></i> Discard</a>
                </div>
                <h2>
                    Compse mail
                </h2>
            </div>
            <div class=""mail-box"">


                <div class=""mail-body"">

                    ");
            EndContext();
            BeginContext(3799, 628, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f907e87b7a4cbf827b2718acdccf26", async() => {
                BeginContext(3818, 602, true);
                WriteLiteral(@"
                        <div class=""form-group row"">
                            <label class=""col-sm-2 col-form-label"">To:</label>

                            <div class=""col-sm-10""><input type=""text"" class=""form-control"" value=""alex.smith@corporat.com""></div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-sm-2 col-form-label"">Subject:</label>

                            <div class=""col-sm-10""><input type=""text"" class=""form-control"" value=""""></div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4427, 992, true);
            WriteLiteral(@"

                </div>

                <div class=""mail-text h-200"">

                    <div class=""summernote"">
                        <h3>Hello Jonathan! </h3>
                        dummy text of the printing and typesetting industry. <strong>Lorem Ipsum has been the industry's</strong> standard dummy text ever since the 1500s,
                        when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic
                        typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with
                        <br />
                        <br />

                    </div>
                    <div class=""clearfix""></div>
                </div>
                <div class=""mail-body text-right tooltip-demo"">
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5419, "\"", 5457, 1);
#line 91 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 5426, Url.Action("Inbox", "Mailbox"), 5426, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5458, 148, true);
            WriteLiteral(" class=\"btn btn-sm btn-primary\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Send\"><i class=\"fa fa-reply\"></i> Send</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5606, "\"", 5644, 1);
#line 92 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 5613, Url.Action("Inbox", "Mailbox"), 5613, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5645, 158, true);
            WriteLiteral(" class=\"btn btn-white btn-sm\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Discard email\"><i class=\"fa fa-times\"></i> Discard</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5803, "\"", 5841, 1);
#line 93 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Mailbox\ComposeEmail.cshtml"
WriteAttributeValue("", 5810, Url.Action("Inbox", "Mailbox"), 5810, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5842, 276, true);
            WriteLiteral(@" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Move to draft folder""><i class=""fa fa-pencil""></i> Draft</a>
                </div>
                <div class=""clearfix""></div>



            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(6135, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(6137, 142, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b95860cfe7b4804becc58776c7e3c8f", async() => {
                    BeginContext(6189, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(6195, 68, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e26c74db22094fb3adeb8cc6571691d5", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(6263, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6279, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(6286, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6306, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6312, 140, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b5666fb23340f1879c87d1882efe2a", async() => {
                    BeginContext(6364, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(6374, 58, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a06a8a94dda4607a2cd69fc0d0b2f67", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(6432, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6452, 162, true);
                WriteLiteral("\r\n\r\n\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n\r\n            $(\'.summernote\').summernote();\r\n\r\n        });\r\n\r\n    </script>\r\n");
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
