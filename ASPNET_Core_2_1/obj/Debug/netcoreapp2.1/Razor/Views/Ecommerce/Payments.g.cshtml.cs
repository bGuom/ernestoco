#pragma checksum "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Ecommerce\Payments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f89b8156ac1c2ad22345d9f4b85b9c5cd085367"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ecommerce_Payments), @"mvc.1.0.view", @"/Views/Ecommerce/Payments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ecommerce/Payments.cshtml", typeof(AspNetCore.Views_Ecommerce_Payments))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f89b8156ac1c2ad22345d9f4b85b9c5cd085367", @"/Views/Ecommerce/Payments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Ecommerce_Payments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Ecommerce\Payments.cshtml"
  
    ViewData["Title"] = "Payments";

#line default
#line hidden
            BeginContext(46, 225, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>E-commerce payments</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 271, "\"", 318, 1);
#line 11 "E:\MicroServiceWebApp\ernestoco\ASPNET_Core_2_1\Views\Ecommerce\Payments.cshtml"
WriteAttributeValue("", 278, Url.Action("Dashboard_1", "Dashboards"), 278, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(319, 7502, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>E-commerce payments</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Payments</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>

<div class=""wrapper wrapper-content animated fadeInRight"">


    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""payment-card"">
                <i class=""fa fa-cc-visa payment-icon-big text-success""></i>
                <h2>
                    **** **** **** 1060
                </h2>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <small>
                            <strong>Expiry date:</strong> 10/16
                        </small>
                    </div>
                    <div class=""col-sm-6 text-right"">
                        <small>
                            <strong>Name:</strong>");
            WriteLiteral(@" David Williams
                        </small>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""payment-card"">
                <i class=""fa fa-cc-mastercard payment-icon-big text-warning""></i>
                <h2>
                    **** **** **** 7002
                </h2>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <small>
                            <strong>Expiry date:</strong> 10/16
                        </small>
                    </div>
                    <div class=""col-sm-6 text-right"">
                        <small>
                            <strong>Name:</strong> Anna Smith
                        </small>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""payment-card"">
                <i class=""fa fa-cc-discover payment-icon-big");
            WriteLiteral(@" text-danger""></i>
                <h2>
                    **** **** **** 3466
                </h2>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <small>
                            <strong>Expiry date:</strong> 10/16
                        </small>
                    </div>
                    <div class=""col-sm-6 text-right"">
                        <small>
                            <strong>Name:</strong> Morgan Stanch
                        </small>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <div class=""row"">

        <div class=""col-lg-12"">

            <div class=""ibox"">
                <div class=""ibox-title"">
                    Payment method
                </div>
                <div class=""ibox-content"">

                    <div class=""panel-group payments-method"" id=""accordion"">
                        <div class=""panel panel-default"">
            ");
            WriteLiteral(@"                <div class=""panel-heading"">
                                <div class=""pull-right"">
                                    <i class=""fa fa-cc-paypal text-success""></i>
                                </div>
                                <h5 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne"">PayPal</a>
                                </h5>
                            </div>
                            <div id=""collapseOne"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">

                                    <div class=""row"">
                                        <div class=""col-md-10"">
                                            <h2>Summary</h2>
                                            <strong>Product:</strong>: Name of product <br />
                                            <strong>Price:</strong>: <span class=""text-navy"">$452.90</span>

               ");
            WriteLiteral(@"                             <p class=""m-t"">
                                                Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do
                                                eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
                                                enim ad minim veniam, quis nostrud exercitation ullamco laboris
                                                nisi ut aliquip ex ea commodo consequat.

                                            </p>

                                            <a class=""btn btn-success"" href="""">
                                                <i class=""fa fa-cc-paypal"">
                                                </i>
                                                Purchase via PayPal
                                            </a>

                                        </div>

                                    </div>


                                </div>
                        ");
            WriteLiteral(@"    </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <div class=""pull-right"">
                                    <i class=""fa fa-cc-amex text-success""></i>
                                    <i class=""fa fa-cc-mastercard text-warning""></i>
                                    <i class=""fa fa-cc-discover text-danger""></i>
                                </div>
                                <h5 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseTwo"">Credit Card</a>
                                </h5>
                            </div>
                            <div id=""collapseTwo"" class=""panel-collapse collapse in"">
                                <div class=""panel-body"">

                                    <div class=""row"">
                                        <div class=""col-md");
            WriteLiteral(@"-4"">
                                            <h2>Summary</h2>
                                            <strong>Product:</strong>: Name of product <br />
                                            <strong>Price:</strong>: <span class=""text-navy"">$452.90</span>

                                            <p class=""m-t"">
                                                Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do
                                                eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
                                                enim ad minim veniam, quis nostrud exercitation ullamco laboris
                                                nisi ut aliquip ex ea commodo consequat.

                                            </p>
                                            <p>
                                                Duis aute irure dolor
                                                in reprehenderit in voluptate velit esse");
            WriteLiteral(@" cillum dolore eu fugiat
                                                nulla pariatur. Excepteur sint occaecat cupidatat.
                                            </p>
                                        </div>
                                        <div class=""col-md-8"">

                                            ");
            EndContext();
            BeginContext(7821, 3241, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c20eaa1ac13343d3b9514d6c4e02a64a", async() => {
                BeginContext(7857, 3198, true);
                WriteLiteral(@"
                                                <div class=""row"">
                                                    <div class=""col-12"">
                                                        <div class=""form-group"">
                                                            <label>CARD NUMBER</label>
                                                            <div class=""input-group"">
                                                                <input type=""text"" class=""form-control"" name=""Number"" placeholder=""Valid Card Number"" required />
                                                                <span class=""input-group-addon""><i class=""fa fa-credit-card""></i></span>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""row"">
        ");
                WriteLiteral(@"                                            <div class=""col-7 col-md-7"">
                                                        <div class=""form-group"">
                                                            <label>EXPIRATION DATE</label>
                                                            <input type=""text"" class=""form-control"" name=""Expiry"" placeholder=""MM / YY"" required />
                                                        </div>
                                                    </div>
                                                    <div class=""col-5 col-md-5 pull-right"">
                                                        <div class=""form-group"">
                                                            <label>CV CODE</label>
                                                            <input type=""text"" class=""form-control"" name=""CVC"" placeholder=""CVC"" required />
                                                        </div>
                                      ");
                WriteLiteral(@"              </div>
                                                </div>
                                                <div class=""row"">
                                                    <div class=""col-12"">
                                                        <div class=""form-group"">
                                                            <label>NAME OF CARD</label>
                                                            <input type=""text"" class=""form-control"" name=""nameCard"" placeholder=""NAME AND SURNAME"" />
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""row"">
                                                    <div class=""col-12"">
                                                        <button class=""btn btn-primary"" type=""submit"">Make a payment!</button>
                                  ");
                WriteLiteral("                  </div>\r\n                                                </div>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(11062, 338, true);
            WriteLiteral(@"

                                        </div>

                                    </div>






                                </div>
                            </div>
                        </div>
                    </div>

                </div>

            </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
