#pragma checksum "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76513b6a95f7d72a3bc848550a00591878aad969"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76513b6a95f7d72a3bc848550a00591878aad969", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678c42ba33e8df03150b76321767c34248fe5ad7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image Here!"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"detailed-main-container\">\r\n        <div class=\"detailed-center\">\r\n            <div class=\"detailed-post-date\">\r\n                <p>");
#nullable restore
#line 10 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Detail.cshtml"
              Write(Model.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 11 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Detail.cshtml"
              Write(Model.PostTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>\r\n                    <i class=\"far fa-eye\"></i>\r\n                    <span>");
#nullable restore
#line 14 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Detail.cshtml"
                     Write(Model.VisitedAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </p>\r\n            </div>\r\n            <div class=\"detailed-image\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "76513b6a95f7d72a3bc848550a00591878aad9695101", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 504, "~/images/PostsGallery/", 504, 22, true);
#nullable restore
#line 18 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Detail.cshtml"
AddHtmlAttributeValue("", 526, Model.FileName, 526, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"detailed-description\">\r\n                <p>");
#nullable restore
#line 21 "C:\Users\Code\Desktop\CODE_ACADEMY\Back-Home\OXU.az\asp-net-core-oxu-az-faridimanzade\Oxu.az\Oxu.az\Views\Home\Detail.cshtml"
              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News> Html { get; private set; }
    }
}
#pragma warning restore 1591
