#pragma checksum "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1aabac045f1106d64a7fdbeb395a6aee32de802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\_ViewImports.cshtml"
using Oxu.az;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\_ViewImports.cshtml"
using Oxu.az.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1aabac045f1106d64a7fdbeb395a6aee32de802", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678c42ba33e8df03150b76321767c34248fe5ad7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/PostsGallery/cimerlik.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Cimerlik"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/PostsGallery/yagislihava.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Rainy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image Here!"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<!-- ======================================================= SLIDER AREA -->
<div class=""slider-area"">
    <div class=""slider-container-center"">
        <div class=""slider-container"">
            <div class=""owl-carousel owl-theme news-carousel"">
                <div class=""item"">
                    <div class=""slider-item-container"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a1aabac045f1106d64a7fdbeb395a6aee32de8025664", async() => {
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
            WriteLiteral(@"
                        <div class=""slider-content"">
                            <div class=""date-view-container"">
                                <div class=""slider-date"">
                                    <p>29 Iyul</p>
                                    <p>19:40</p>
                                </div>
                                <div class=""slider-view"">
                                    <p>7450</p>
                                </div>
                            </div>
                            <div class=""slider-description"">
                                <p>Prezident İsmayıllıda modul tipli xəstəxananın açılışında - YENİLƏNİB+FOTO</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""item"">
                    <div class=""slider-item-container"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a1aabac045f1106d64a7fdbeb395a6aee32de8027707", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""slider-content"">
                            <div class=""date-view-container"">
                                <div class=""slider-date"">
                                    <p>28 Iyul</p>
                                    <p>13:30</p>
                                </div>
                                <div class=""slider-view"">
                                    <p>5465</p>
                                </div>
                            </div>
                            <div class=""slider-description"">
                                <p>Bölgələrdə yağış yağıb, dolu düşüb, sel gəlib – FAKTİKİ HAVA</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- ======================================================= SLIDER AREA-->
<!-- ======================================================= MAIN NEWS -->
<main>
    <div class=""cont");
            WriteLiteral("ent-main-container\">\r\n        <div class=\"main-center\">\r\n");
#nullable restore
#line 58 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
              
                foreach (var post in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"news-card\">\r\n                        <div class=\"news-posted-date\">\r\n                            <div class=\"posted-day\">\r\n                                <p>");
#nullable restore
#line 64 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
                              Write(post.PostDate.Substring(post.PostDate.IndexOf(" ") + 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>");
#nullable restore
#line 65 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
                              Write(post.PostDate.Substring(0, post.PostDate.IndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"posted-time\">\r\n                                <p>");
#nullable restore
#line 68 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
                              Write(post.PostTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"post-image\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a1aabac045f1106d64a7fdbeb395a6aee32de80211761", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3286, "~/images/PostsGallery/", 3286, 22, true);
#nullable restore
#line 72 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3308, post.FileName, 3308, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"post-description\">\r\n                            <p>\r\n                                <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 3515, "\"", 3572, 1);
#nullable restore
#line 76 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
WriteAttributeValue("", 3522, Url.Action("Detail", "Home", new { id = post.id}), 3522, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
                                                                                                        Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </p>
                        </div>
                        <div class=""post-attributes"">
                            <div class=""post-detail"" isClicked=""false"">
                                <i class=""far fa-thumbs-up""></i>
                                <span>");
#nullable restore
#line 82 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
                                 Write(post.LikeAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"post-detail\" isClicked=\"false\">\r\n                                <i class=\"far fa-thumbs-down\"></i>\r\n                                <span>");
#nullable restore
#line 86 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
                                 Write(post.DislikeAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"post-detail\">\r\n                                <i class=\"far fa-eye\"></i>\r\n                                <span>");
#nullable restore
#line 90 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
                                 Write(post.VisitedAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 94 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</main>\r\n<!-- ======================================================= MAIN NEWS -->\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            //================================================ LIKE
            $("".post-detail:nth-child(1)"").click(function () {
                let clickedItem = $(this)

                if (clickedItem.attr(""isClicked"") == ""false"") {

                    let data_ = {
                        PostTitle: clickedItem.parent().siblings("".post-description"").children().children().text(),
                        Category: 1
                    }

                    $.ajax({
                        url: ""/Home/IncreasePostAffect"",
                        data: data_,
                        dataType: ""json"",

                        success: function (data) {

                            clickedItem.children(""span"").text(data.LikeAmount)
                            clickedItem.siblings().eq(0).children(""span"").text(data.DislikeAmount)
                            clickedItem.siblings().eq(1).children(""span"").text(data.VisitedAmount)

                WriteLiteral(@"
                            clickedItem.css({
                                ""background-color"": ""green"",
                                ""color"": ""white"",
                                ""cursor"": ""default""
                            })

                            clickedItem.attr(""isClicked"", ""true"")
                            clickedItem.siblings().attr(""isClicked"", ""true"")
                            clickedItem.siblings().css({ ""cursor"": ""default"" })

                            console.log(""Liked"")
                        },

                        error: function () {
                            alert(""Cannot Get Data"")
                        }
                    });
                }
            });

            //================================================ DISLIKE
            $("".post-detail:nth-child(2)"").click(function () {
                let clickedItem = $(this)

                if (clickedItem.attr(""isClicked"") == ""false"") {

                    let data_ ");
                WriteLiteral(@"= {
                        PostTitle: clickedItem.parent().siblings("".post-description"").children().children().text(),
                        Category: 2
                    }

                    $.ajax({
                        url: ""/Home/IncreasePostAffect"",
                        data: data_,
                        dataType: ""json"",

                        success: function (data) {

                            clickedItem.siblings().eq(0).children(""span"").text(data.LikeAmount)
                            clickedItem.children(""span"").text(data.DislikeAmount)
                            clickedItem.siblings().eq(1).children(""span"").text(data.VisitedAmount)

                            clickedItem.css({
                                ""background-color"": ""red"",
                                ""color"": ""white"",
                                ""cursor"": ""default""
                            })

                            clickedItem.attr(""isClicked"", ""true"")
                     ");
                WriteLiteral(@"       clickedItem.siblings().attr(""isClicked"", ""true"")
                            clickedItem.siblings().css({ ""cursor"": ""default"" })

                            console.log(""Disliked"")
                        },

                        error: function () {
                            alert(""Cannot Get Data"")
                        }
                    });
                }
            });

            //================================================ VISITED
            $("".post-description p a"").click(function () {
                let clickedItem = $(this)

                let data_ = {
                    PostTitle: clickedItem.text(),
                    Category: 3
                }

                $.ajax({
                    url: ""/Home/IncreasePostAffect"",
                    data: data_,
                    dataType: ""json"",

                    success: function (data) {

                        clickedItem.parent().parent().siblings("".post-attributes"").children(");
                WriteLiteral(@""".post-detail:nth-child(1)"").children(""span"").text(data.LikeAmount)
                        clickedItem.parent().parent().siblings("".post-attributes"").children("".post-detail:nth-child(2)"").children(""span"").text(data.DislikeAmount)
                        clickedItem.parent().parent().siblings("".post-attributes"").children("".post-detail:nth-child(3)"").children(""span"").text(data.VisitedAmount)

                        console.log(""Visited"")
                    },

                    error: function () {
                        alert(""Cannot Get Data"")
                    }
                });
            });


        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591