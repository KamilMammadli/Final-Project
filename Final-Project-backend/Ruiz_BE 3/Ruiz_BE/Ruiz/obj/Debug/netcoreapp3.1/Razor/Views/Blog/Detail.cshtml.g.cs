#pragma checksum "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41c4526d21228ecb7d0db850e8c9a59a60167c7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c4526d21228ecb7d0db850e8c9a59a60167c7a", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6f50e092e3d1f5fec8ad9ab1fd3955bc76692ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
  
    Setting setting = layoutService.GetSetting();

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"breadcrumb-area\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <ul class=\"breadcrumb-list\">\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c4526d21228ecb7d0db850e8c9a59a60167c7a5229", async() => {
                WriteLiteral("Home");
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
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"">Blog Details</li>
                </ul>
            </div>
        </div>
    </div>
</div>

<div class=""main-content-wrap shop-page section-ptb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 order-lg-1 order-2"">
                <div class=""blog-sidebar-wrap"">
                    <div class=""blog-sidebar-widget-area"">

                        <div class=""single-widget search-widget mb-30"">
                         
                        </div>
                        <div class=""single-widget mb-30"">
                           
                        </div>

                        <div class=""single-widget mb-30"">
                            <h4 class=""widget-title"">Recent Posts</h4>

                            <div class=""recent-post-widget"">
");
#nullable restore
#line 42 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                 foreach (var item in ViewBag.Blogs)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"single-widget-post\">\r\n                                        <div class=\"post-thumb\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c4526d21228ecb7d0db850e8c9a59a60167c7a7966", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "41c4526d21228ecb7d0db850e8c9a59a60167c7a8182", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1666, "~/assets/images/blog/", 1666, 21, true);
#nullable restore
#line 46 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 1687, item.Image, 1687, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                     WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"post-info\">\r\n                                            <h6 class=\"post-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c4526d21228ecb7d0db850e8c9a59a60167c7a11865", async() => {
#nullable restore
#line 49 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                                            WriteLiteral(item.Id);

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
            WriteLiteral("</h6>\r\n                                            <div class=\"post-date\">");
#nullable restore
#line 50 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                              Write(item.CreatedAt.ToString("MMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 53 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>

                        </div>
                        <div class=""single-widget mb-30"">
                           
                           
                        </div>

                        <div class=""single-widget mb-30"">
                            <h4 class=""widget-title"">Tags</h4>

                            <ul class=""sidebar-tag"">
");
#nullable restore
#line 67 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                 foreach (var item in ViewBag.Tags)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a href=\"#\">");
#nullable restore
#line 69 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 70 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-lg-9 order-lg-2 order-1"">

                <div class=""blog-wrapper"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""single-blog-wrap mb-40"">
                                <div class=""latest-blog-content mt-0"">
                                    <h4><a href=""#"">");
#nullable restore
#line 84 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <ul class=\"post-meta\">\r\n                                        <li class=\"post-author\">By <a href=\"#\">");
#nullable restore
#line 86 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                          Write(Model.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n                                        <li class=\"post-date\">");
#nullable restore
#line 87 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                         Write(Model.CreatedAt.ToString("MMMM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    </ul>
                                </div>
                                <div class=""latest-blog-image"">
                                    <a href=""blog-details.html"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "41c4526d21228ecb7d0db850e8c9a59a60167c7a18014", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3901, "~/assets/images/blog/", 3901, 21, true);
#nullable restore
#line 92 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 3922, Model.Image, 3922, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </a>\r\n                                </div>\r\n                                <div class=\"latest-blog-content mt-20\">\r\n\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 99 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                   Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>

                                </div>

                                <div class=""meta-sharing"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-lg-6"">
                                            <div class=""entry-meta mt-15"">
                                                Tags: ");
#nullable restore
#line 108 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                       foreach (var item in Model.BlogBTags)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a href=\"#\">");
#nullable restore
#line 110 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                           Write(item.BTag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</a>\r\n");
#nullable restore
#line 111 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                        <div class=""col-lg-6"">
                                            <ul class=""social-icons text-end"">
                                                <li>
                                                    <a class=""facebook social-icon"" href=""#"" title=""Facebook""
                                                       target=""_blank"">");
#nullable restore
#line 118 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                  Write(Html.Raw(@setting.FbIcon));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                </li>
                                                <li>
                                                    <a class=""twitter social-icon"" href=""#"" title=""Twitter""
                                                       target=""_blank"">");
#nullable restore
#line 122 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                  Write(Html.Raw(@setting.TwitterIcon));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                </li>
                                                <li>
                                                    <a class=""instagram social-icon"" href=""#"" title=""Instagram""
                                                       target=""_blank"">");
#nullable restore
#line 126 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                  Write(Html.Raw(setting.InstagramIcon));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                </li>
                                                <li>
                                                    <a class=""linkedin social-icon"" href=""#"" title=""Linkedin""
                                                       target=""_blank"">");
#nullable restore
#line 130 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                  Write(Html.Raw(setting.LinkedinIcon));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                </li>
                                                <li>
                                                    <a class=""rss social-icon"" href=""#"" title=""Rss""
                                                       target=""_blank"">");
#nullable restore
#line 134 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                  Write(Html.Raw(setting.RssIcon));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>

                    <div class=""related-post-blog-area"">
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""section-title"">
                                    <h4>Blogs</h4>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
");
#nullable restore
#line 154 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                             foreach (var item in ViewBag.Blogs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-4 col-md-6"">
                                    <div class=""single-latest-blog mt-30"">
                                        <div class=""latest-blog-image"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c4526d21228ecb7d0db850e8c9a59a60167c7a25795", async() => {
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "41c4526d21228ecb7d0db850e8c9a59a60167c7a26099", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7915, "~/assets/images/blog/", 7915, 21, true);
#nullable restore
#line 160 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 7936, item.Image, 7936, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 159 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                     WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"latest-blog-content mt-20\">\r\n                                            <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c4526d21228ecb7d0db850e8c9a59a60167c7a29863", async() => {
                WriteLiteral(" ");
#nullable restore
#line 165 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 165 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                         WriteLiteral(item.Id);

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
            WriteLiteral("</h4>\r\n                                            <ul class=\"post-meta\">\r\n                                                <li class=\"post-date\">");
#nullable restore
#line 167 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                 Write(item.CreatedAt.ToString("MMM dd yyyy "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            </ul>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 172 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Ruiz.Services.LayoutService layoutService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
