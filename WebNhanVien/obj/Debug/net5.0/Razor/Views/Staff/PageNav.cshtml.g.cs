#pragma checksum "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08b67e385269cbd1273dbfec5054168c1998c499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_PageNav), @"mvc.1.0.view", @"/Views/Staff/PageNav.cshtml")]
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
#line 1 "D:\tempGit\Webnv\WebNhanVien\Views\_ViewImports.cshtml"
using WebNhanVien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\tempGit\Webnv\WebNhanVien\Views\_ViewImports.cshtml"
using WebNhanVien.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml"
using WebNhanVien.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b67e385269cbd1273dbfec5054168c1998c499", @"/Views/Staff/PageNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1d7e80300dc912c2758fd0ef6f2e649df7aead", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_PageNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pagenav.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml"
  
    Layout = "StaffLayout";
    var ageMin = (int)ViewBag.ageMin;
    var ageMax = (int)ViewBag.ageMax;
    var currentPage = (string)@ViewBag.currentPage;
    var pageNunber = (int)ViewBag.pageNumber;
    var keyBox = (string)@ViewBag.keyBox;
    var keyPhongBan = (string)@ViewBag.keyPhongBan;

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"text\" id=\"keyBox\"");
            BeginWriteAttribute("value", " value=\"", 372, "\"", 387, 1);
#nullable restore
#line 11 "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml"
WriteAttributeValue("", 380, keyBox, 380, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n<input type=\"text\" id=\"keyPhongBan\"");
            BeginWriteAttribute("value", " value=\"", 435, "\"", 455, 1);
#nullable restore
#line 12 "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml"
WriteAttributeValue("", 443, keyPhongBan, 443, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden  />\r\n<input type=\"number\" id=\"pageNumber\"");
            BeginWriteAttribute("value", " value=\"", 505, "\"", 524, 1);
#nullable restore
#line 13 "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml"
WriteAttributeValue("", 513, pageNunber, 513, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n<input type=\"number\" id=\"ageMin\"");
            BeginWriteAttribute("value", " value=\"", 569, "\"", 584, 1);
#nullable restore
#line 14 "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml"
WriteAttributeValue("", 577, ageMin, 577, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n<input type=\"number\" id=\"ageMax\"");
            BeginWriteAttribute("value", " value=\"", 629, "\"", 644, 1);
#nullable restore
#line 15 "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml"
WriteAttributeValue("", 637, ageMax, 637, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n<input type=\"number\" id=\"TemppageNumber\"");
            BeginWriteAttribute("value", " value=\"", 697, "\"", 716, 1);
#nullable restore
#line 16 "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml"
WriteAttributeValue("", 705, pageNunber, 705, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n<input type=\"text\" id=\"currentPage\"");
            BeginWriteAttribute("value", " value=\"", 764, "\"", 784, 1);
#nullable restore
#line 17 "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml"
WriteAttributeValue("", 772, currentPage, 772, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden />
<nav aria-label=""Page navigation"">
    <ul class=""pagination pagination-lg justify-content-center"" id=""listPage"">
        <li class=""page-item "" id=""startList"">
            <a class=""page-link"" tabindex=""-1""><i class=""fas fa-caret-left""></i></a>
        </li>
        <li class=""page-item"" id=""endList"">
            <a class=""page-link"" tabindex=""-1""><i class=""fas fa-caret-right""></i></a>
        </li>
    </ul>
</nav>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\tempGit\Webnv\WebNhanVien\Views\Staff\PageNav.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08b67e385269cbd1273dbfec5054168c1998c4997490", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
