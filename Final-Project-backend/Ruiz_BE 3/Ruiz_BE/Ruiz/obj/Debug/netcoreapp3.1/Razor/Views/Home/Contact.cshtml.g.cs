#pragma checksum "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb254d8d822cc88a444a173da42134eef4aeb9e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\_ViewImports.cshtml"
using Ruiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\_ViewImports.cshtml"
using Ruiz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\_ViewImports.cshtml"
using Ruiz.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb254d8d822cc88a444a173da42134eef4aeb9e5", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6f50e092e3d1f5fec8ad9ab1fd3955bc76692ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://hasthemes.com/file/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <div class=""breadcrumb-area"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <ul class=""breadcrumb-list"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"">Contact Us Page</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <main class=""page-content section-ptb"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-7 col-sm-12"">
                        <div class=""contact-form"">
                            <div class=""contact-form-info"">
                                <div class=""contact-title"">
                                    <h3>TELL US YOUR PROJECT,ADVICE,COMPLAINT</h3>
                                </div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb254d8d822cc88a444a173da42134eef4aeb9e55584", async() => {
                WriteLiteral(@"
                                    <div class=""contact-page-form"">
                                        <div class=""contact-input"">
                                            <div class=""contact-inner"">
                                                <input name=""con_name"" type=""text"" placeholder=""Name *"">
                                            </div>
                                            <div class=""contact-inner"">
                                                <input name=""con_email"" type=""email"" placeholder=""Email *"">
                                            </div>
                                            <div class=""contact-inner"">
                                                <input name=""con_phone"" type=""text"" placeholder=""Phone *"">
                                            </div>
                                            <div class=""contact-inner"">
                                                <input name=""con_subject"" type=""text"" placeholder=""Subject *"">
 ");
                WriteLiteral(@"                                           </div>
                                            <div class=""contact-inner contact-message"">
                                                <textarea name=""con_message"" placeholder=""Message *""></textarea>
                                            </div>
                                        </div>
                                        <div class=""contact-submit-btn"">
                                            <button class=""submit-btn"" type=""submit"">Send Email</button>
                                            <p class=""form-messege""></p>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-5 col-sm-12"">
                        <div class=""contact-infor"">
                            <div class=""contact-title"">
                                <h3>CONTACT US</h3>
                            </div>
                            <div class=""contact-dec"">
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ullam nam ex odio expedita,
                                    officia temporibus ipsum, placeat magni quibusdam sint, atque distinctio
                                </p>
                            </div>
                            <div class=""contact-address"">
                                <ul>
                                    <li>Address : ");
#nullable restore
#line 70 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Home\Contact.cshtml"
                                             Write(Model.Setting.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 70 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Home\Contact.cshtml"
                                                                    Write(Model.Setting.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li>Email: ");
#nullable restore
#line 71 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Home\Contact.cshtml"
                                          Write(Model.Setting.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li>Phone: ");
#nullable restore
#line 72 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Home\Contact.cshtml"
                                          Write(Model.Setting.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                            <div class=\"work-hours\">\r\n                                <h5>Working hours</h5>\r\n                                <p><strong>");
#nullable restore
#line 77 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Home\Contact.cshtml"
                                      Write(Model.Setting.WorkdayStartDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &ndash; ");
#nullable restore
#line 77 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Home\Contact.cshtml"
                                                                             Write(Model.Setting.WorkdayFinishDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>: &nbsp;");
#nullable restore
#line 77 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Home\Contact.cshtml"
                                                                                                                             Write(Model.Setting.WorkdayStartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &ndash; ");
#nullable restore
#line 77 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Home\Contact.cshtml"
                                                                                                                                                                     Write(Model.Setting.WorkdayFinishTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </main>\r\n\r\n\r\n      ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
