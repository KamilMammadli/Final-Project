#pragma checksum "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4916593d593bb42a91fd704553b0ee180c9852d4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4916593d593bb42a91fd704553b0ee180c9852d4", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6f50e092e3d1f5fec8ad9ab1fd3955bc76692ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <ul class=""breadcrumb-list"">
                    <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
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
                            <h4 class=""widget-title"">Search</h4>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4916593d593bb42a91fd704553b0ee180c9852d45461", async() => {
                WriteLiteral(@"
                                <div class=""form-input"">
                                    <input type=""text"" placeholder=""Search... "">
                                    <button class=""button-search"" type=""submit"">
                                        <i class=""icon-magnifier""></i>
                                    </button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""single-widget mb-30"">
                            <h4 class=""widget-title"">Categories</h4>
                            <div class=""category-widget-list"">
                                <ul>
                                    <li><a href=""#"">Company</a></li>
                                    <li><a href=""#"">Fat</a></li>
                                    <li><a href=""#"">Nutrition</a></li>
                                    <li><a href=""#"">Protein</a></li>
                                    <li><a href=""#"">Wordpress</a></li>
                                </ul>
                            </div>
                        </div>

                        <div class=""single-widget mb-30"">
                            <h4 class=""widget-title"">Recent Posts</h4>

                            <div class=""recent-post-widget"">
");
#nullable restore
#line 59 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                 foreach (var item in ViewBag.Blogs)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"single-widget-post\">\r\n                                        <div class=\"post-thumb\">\r\n                                            <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4916593d593bb42a91fd704553b0ee180c9852d48616", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2680, "~/assets/images/blog/", 2680, 21, true);
#nullable restore
#line 63 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 2701, item.SmallImage, 2701, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                        </div>\r\n                                        <div class=\"post-info\">\r\n                                            <h6 class=\"post-title\"><a href=\"#\">");
#nullable restore
#line 66 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                            <div class=\"post-date\">");
#nullable restore
#line 67 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                              Write(item.CreatedAt.ToString("MMM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 70 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>

                        </div>
                        <div class=""single-widget mb-30"">
                            <h4 class=""widget-title"">Archives</h4>
                            <div class=""category-widget-list"">
                                <ul>
                                    <li><a href=""#"">May 2020</a></li>
                                    <li><a href=""#"">Oct 2021</a></li>
                                </ul>
                            </div>
                        </div>

                        <div class=""single-widget mb-30"">
                            <h4 class=""widget-title"">Tags</h4>

                            <ul class=""sidebar-tag"">
");
#nullable restore
#line 89 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                 foreach (var item in ViewBag.Tags)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a href=\"#\">");
#nullable restore
#line 91 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 92 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
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
                                    <h4><a href=""blog-details.html"">");
#nullable restore
#line 106 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <ul class=\"post-meta\">\r\n                                        <li class=\"post-author\">By <a href=\"#\">");
#nullable restore
#line 108 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                          Write(Model.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n                                        <li class=\"post-date\">");
#nullable restore
#line 109 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4916593d593bb42a91fd704553b0ee180c9852d414765", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5229, "~/assets/images/blog/", 5229, 21, true);
#nullable restore
#line 114 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 5250, Model.DetailImage, 5250, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </a>\r\n                                </div>\r\n                                <div class=\"latest-blog-content mt-20\">\r\n\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 121 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
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
#line 130 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                       foreach (var item in Model.BlogTags)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a href=\"#\">");
#nullable restore
#line 132 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                           Write(item.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</a>\r\n");
#nullable restore
#line 133 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
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
#line 140 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
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
#line 144 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
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
#line 148 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
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
#line 152 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
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
#line 156 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
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
                                    <h4>Related posts</h4>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
");
#nullable restore
#line 176 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                             foreach (var item in ViewBag.Blogs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-4 col-md-6"">
                                    <div class=""single-latest-blog mt-30"">
                                        <div class=""latest-blog-image"">
                                            <a href=""blog-details.html"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4916593d593bb42a91fd704553b0ee180c9852d422640", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9236, "~/assets/images/blog/", 9236, 21, true);
#nullable restore
#line 182 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 9257, item.Image, 9257, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </div>
                                        <div class=""latest-blog-content mt-20"">
                                            <h4><a href=""blog-details.html""> ");
#nullable restore
#line 187 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                            <ul class=\"post-meta\">\r\n                                                <li class=\"post-date\">");
#nullable restore
#line 189 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
                                                                 Write(item.CreatedAt.ToString("MMM dd yyyy "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            </ul>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 194 "C:\Users\Asus ROG\Desktop\Ruiz_BE\Ruiz\Views\Blog\Detail.cshtml"
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