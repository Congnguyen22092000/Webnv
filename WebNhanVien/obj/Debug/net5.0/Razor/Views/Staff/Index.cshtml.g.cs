#pragma checksum "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7606e1401c15d08c30987106910664f56811c2d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
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
#line 1 "D:\WebNhanVien\WebNhanVien\Views\_ViewImports.cshtml"
using WebNhanVien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebNhanVien\WebNhanVien\Views\_ViewImports.cshtml"
using WebNhanVien.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7606e1401c15d08c30987106910664f56811c2d1", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1d7e80300dc912c2758fd0ef6f2e649df7aead", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebNhanVien.Models.NhanVien>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Staffcss/test.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: grid; margin: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/staff/CreateNV"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Staff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 30px;margin-left: 20px;max-width: 85.5%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: grid; margin: 20px; color:rgb(0,0,0)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/staff/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
  
    ViewData["Title"] = "Danh Sách Nhân Viên";



#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7606e1401c15d08c30987106910664f56811c2d18030", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1 style=\"text-align: center;\">");
#nullable restore
#line 12 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>\r\n   \r\n\r\n\r\n    <div style=\" display: -webkit-box;\r\n\">\r\n");
            WriteLiteral(@"


        <!-- Trigger/Open The Modal -->
        <button class=""btn btn-outline-success btnCreate"" id=""myBtn"">Thêm nhân viên</button>

        <!-- The Modal -->
        <div id=""myModal"" class=""modal"" style=""display: none; position: fixed; z-index: 1; left: 0; top: 0; width: 100%; height: 100%; overflow: auto; background-color: rgb(0,0,0);  background-color: rgba(0,0,0,0.4); -webkit-animation-name: fadeIn; -webkit-animation-duration: 0.4s; animation-name: fadeIn; animation-duration: 0.4s;"">

            <!-- Modal content -->
            <div class=""modal-content"" style="" position: relative; top: 18%; max-width: 60%; margin: auto; min-height: 30%; background-color: #fefefe; width: 100%; -webkit-animation-name: slideIn; -webkit-animation-duration: 0.4s; animation-name: slideIn; animation-duration: 0.4s; -webkit-animation-name: slideIn; -webkit-animation-duration: 0.4s; animation-name: slideIn; animation-duration: 0.4s;"">
                <div class=""modal-header"" style="" padding: 2px 16px; backgro");
            WriteLiteral(@"und-color: #5cb85c; color: white; text-align: center;display: block;"">
                    <span class=""closeBtnCreate"">&times;</span>
                    <h2 style=""padding: 15px;"">Thêm hồ sơ nhân viên mới</h2>
                </div>
                <div class=""modal-body"" style=""padding: 2px 16px;"">

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7606e1401c15d08c30987106910664f56811c2d111010", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                          
                            var maNV = ViewBag.maNV;
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                         using (Html.BeginForm())
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <label type=\"text\" name=\"maNhanVien\">Mã nhân viên</label>\r\n                            <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"maNhanVien\" id=\"maNhanVien\"");
                BeginWriteAttribute("value", " value=", 2262, "", 2274, 1);
#nullable restore
#line 46 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 2269, maNV, 2269, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n                            <input name=\"maNhanVien\"");
                BeginWriteAttribute("value", " value=\"", 2340, "\"", 2353, 1);
#nullable restore
#line 47 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 2348, maNV, 2348, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n");
                WriteLiteral(@"                            <label type=""text"" name=""hoTen"">Họ và tên</label>
                            <input style=""margin-bottom: 15px;"" type=""text"" name=""hoTen"" id=""hoTen"" />
                            <span id=""ErrorMgs"" class=""text-danger""></span>
");
                WriteLiteral("                            <label type=\"date\" name=\"ngaySinh\">Ngày sinh</label>\r\n                            <input style=\"margin-bottom: 15px;\" name=\"ngaySinh\" type=\"date\" id=\"ngaySinh\" />\r\n");
                WriteLiteral("                            <label type=\"text\" name=\"soDT\">Số điện thoại</label>\r\n                            <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"soDT\" id=\"soDT\" />\r\n");
                WriteLiteral("                            <label type=\"text\" name=\"chucVu\">Chức vụ</label>\r\n                            <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"chucVu\" id=\"chucVu\" />\r\n");
                WriteLiteral("                            <input style=\"margin-bottom: 15px;\" type=\"submit\" id=\"SubmitBtn\" disabled class=\"btn btn-success\" value=\"Thêm mới\" />\r\n");
#nullable restore
#line 64 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"


                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"" style=""padding: 20px 16px; background-color: #5cb85c; color: #2da949f7; }"">
                                                                                                                                                       
                </div>
            </div>

        </div>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7606e1401c15d08c30987106910664f56811c2d115917", async() => {
                WriteLiteral("\r\n\r\n\r\n            <input id=\"SearchBox\" name=\"key\" type=\"search\" class=\"form-control rounded\" placeholder=\"Từ Khóa Cần Tìm\" aria-label=\"Search\"\r\n                   aria-describedby=\"search-addon\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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


<table class=""table  table-dark table-striped"">
    <thead>
        <tr>
            <th>
                Mã nhân viên
            </th>
            <th>
                Họ Tên
            </th>
            <th>
                Ngày Sinh
            </th>
            <th>
                Số điện thoại
            </th>

            <th>
                Chức vụ
            </th>

            <th></th>
        </tr>
    </thead>
    
    <tbody id=""StaffTable"">
");
#nullable restore
#line 113 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
         foreach (var item in Model)
        {
            var i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 118 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
               Write(item.maNhanVien);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 123 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
               Write(item.hoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 128 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
               Write(item.ngaySinh.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 131 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
               Write(item.soDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 135 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
               Write(item.chucVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
            WriteLiteral("\r\n\r\n                    <a class=\"click btn btn-info\"");
            BeginWriteAttribute("id", " id=\"", 5430, "\"", 5459, 2);
            WriteAttributeValue("", 5435, "btn_", 5435, 4, true);
#nullable restore
#line 142 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 5439, Model.IndexOf(item), 5439, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color:#28a745;border-color:#28a745;cursor: pointer;\" data-toggle=\"modal\" data-target=\"#editNV-");
#nullable restore
#line 142 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                                                                                                                                                                           Write(Model.IndexOf(item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Sửa</a>\r\n\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 5630, "\"", 5662, 2);
            WriteAttributeValue("", 5635, "editNV-", 5635, 7, true);
#nullable restore
#line 144 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 5642, Model.IndexOf(item), 5642, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5663, "\"", 5701, 2);
            WriteAttributeValue("", 5671, "modalEdit_", 5671, 10, true);
#nullable restore
#line 144 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 5681, Model.IndexOf(item), 5681, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""display: none;  position: fixed;  z-index: 9999999999;  left: 0; top: 0; width: 100%;  height: 100%;overflow: auto;  background-color: rgb(0,0,0);  background-color: rgba(0,0,0,0.4); -webkit-animation-name: fadeIn; -webkit-animation-duration: 0.4s; animation-name: fadeIn; animation-duration: 0.4s;"">

                        <!-- Modal content -->
                        <div class=""modal-content"" style="" position: relative; top: 18%; max-width: 60%; margin: auto; min-height: 30%; background-color: #fefefe; width: 100%; -webkit-animation-name: slideIn; -webkit-animation-duration: 0.4s; animation-name: slideIn; animation-duration: 0.4s; -webkit-animation-name: slideIn; -webkit-animation-duration: 0.4s; animation-name: slideIn; animation-duration: 0.4s;"">
                            <div class=""modal-header"" style="" padding: 2px 16px; background-color: #5cb85c; color: white; text-align: center;display: block;"">
                                <span");
            BeginWriteAttribute("id", " id=\"", 6674, "\"", 6712, 2);
            WriteAttributeValue("", 6679, "closeBtnEdit_", 6679, 13, true);
#nullable restore
#line 149 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 6692, Model.IndexOf(item), 6692, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&times;</span>\r\n                                <h2 style=\"padding: 15px;\">Sửa hồ sơ nhân viên</h2>\r\n                            </div>\r\n                            <div class=\"modal-body\" style=\"padding: 2px 16px;\">\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7606e1401c15d08c30987106910664f56811c2d123899", async() => {
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 157 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                     using (Html.BeginForm())
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <label type=\"text\" name=\"maNhanVien\">Mã nhân viên</label>\r\n                                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"maNhanVien\"");
                BeginWriteAttribute("id", " id=\"", 7375, "\"", 7405, 2);
                WriteAttributeValue("", 7380, "maNV-", 7380, 5, true);
#nullable restore
#line 161 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 7385, Model.IndexOf(item), 7385, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=", 7406, "", 7429, 1);
#nullable restore
#line 161 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 7413, item.maNhanVien, 7413, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n                                        <input name=\"maNhanVien\"");
                BeginWriteAttribute("value", " value=\"", 7507, "\"", 7531, 1);
#nullable restore
#line 162 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 7515, item.maNhanVien, 7515, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n");
                WriteLiteral("                                        <label type=\"text\" name=\"hoTen\">Họ và tên</label>\r\n                                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"hoTen\"");
                BeginWriteAttribute("id", " id=\"", 7737, "\"", 7768, 2);
                WriteAttributeValue("", 7742, "hoTen-", 7742, 6, true);
#nullable restore
#line 165 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 7748, Model.IndexOf(item), 7748, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"test\"");
                BeginWriteAttribute("value", " value=\"", 7782, "\"", 7801, 1);
#nullable restore
#line 165 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 7790, item.hoTen, 7790, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <span");
                BeginWriteAttribute("id", " id=\"", 7852, "\"", 7894, 2);
                WriteAttributeValue("", 7857, "errormesageHoTen-", 7857, 17, true);
#nullable restore
#line 166 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 7874, Model.IndexOf(item), 7874, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"text-danger\"></span>\r\n");
                WriteLiteral("                                        <label type=\"date\" name=\"ngaySinh\">Ngày sinh</label>\r\n                                        <input style=\"margin-bottom: 15px;\" name=\"ngaySinh\" type=\"date\"");
                BeginWriteAttribute("id", " id=\"", 8126, "\"", 8160, 2);
                WriteAttributeValue("", 8131, "ngaySinh-", 8131, 9, true);
#nullable restore
#line 170 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 8140, Model.IndexOf(item), 8140, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 8161, "\"", 8206, 1);
#nullable restore
#line 170 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 8169, item.ngaySinh.ToString("yyyy-MM-dd"), 8169, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("                                        <label type=\"text\" name=\"soDT\">Số điện thoại</label>\r\n                                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"soDT\"");
                BeginWriteAttribute("id", " id=\"", 8409, "\"", 8439, 2);
                WriteAttributeValue("", 8414, "soDT-", 8414, 5, true);
#nullable restore
#line 174 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 8419, Model.IndexOf(item), 8419, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 8440, "\"", 8458, 1);
#nullable restore
#line 174 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 8448, item.soDT, 8448, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("                                        <label type=\"text\" name=\"chucVu\">Chức vụ</label>\r\n                                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"chucVu\"");
                BeginWriteAttribute("id", " id=\"", 8657, "\"", 8689, 2);
                WriteAttributeValue("", 8662, "chucVu-", 8662, 7, true);
#nullable restore
#line 177 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 8669, Model.IndexOf(item), 8669, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 8690, "\"", 8710, 1);
#nullable restore
#line 177 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 8698, item.chucVu, 8698, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("                                        <input style=\"margin-bottom: 15px;\" type=\"submit\"");
                BeginWriteAttribute("id", " id=\"", 8807, "\"", 8840, 2);
                WriteAttributeValue("", 8812, "EditBtn-", 8812, 8, true);
#nullable restore
#line 179 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 8820, Model.IndexOf(item), 8820, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\" value=\"Sửa\" />\r\n");
#nullable restore
#line 180 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"


                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""modal-footer"" style=""padding: 20px 16px; background-color: #5cb85c; color: #2da949f7; }"">

                            </div>
                        </div>

                    </div>
                    <style>
                        #closeBtnEdit_");
#nullable restore
#line 192 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                 Write(Model.IndexOf(item));

#line default
#line hidden
#nullable disable
            WriteLiteral(" {\r\n                            color: white;\r\n                            float: right;\r\n                            font-size: 28px;\r\n                            font-weight: bold;\r\n                        }\r\n\r\n                            #closeBtnEdit_");
#nullable restore
#line 199 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                     Write(Model.IndexOf(item));

#line default
#line hidden
#nullable disable
            WriteLiteral(":hover,\r\n                            #closeBtnEdit_");
#nullable restore
#line 200 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                     Write(Model.IndexOf(item));

#line default
#line hidden
#nullable disable
            WriteLiteral(":focus {\r\n                                color: #000;\r\n                                text-decoration: none;\r\n                                cursor: pointer;\r\n                            }\r\n                    </style>\r\n                   \r\n\r\n\r\n");
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-warning\" style=\"background-color:#900c0c; border-color:#900c0c;color:#ffffff;\" data-toggle=\"modal\" data-target=\"#NV-");
#nullable restore
#line 210 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                                                                                                                                                        Write(Model.IndexOf(item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xóa</button>\r\n                    <div class=\"modal\"");
            BeginWriteAttribute("id", " id=\"", 10310, "\"", 10338, 2);
            WriteAttributeValue("", 10315, "NV-", 10315, 3, true);
#nullable restore
#line 211 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 10318, Model.IndexOf(item), 10318, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""false"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <i class='fas fa-exclamation-triangle'></i>
                                    <h5 style=""color:#000000;"" class=""modal-title"">Bạn Có Chắc Muốn Xóa</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""");
            BeginWriteAttribute("id", " id=\"", 10913, "\"", 10938, 2);
            WriteAttributeValue("", 10918, "Huy-", 10918, 4, true);
#nullable restore
#line 217 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 10922, item.maNhanVien, 10922, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"" style=""text-align: center;"">
                                    <span style=""color:red;"">");
#nullable restore
#line 222 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                                        Write(item.hoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                                    <button class=""btn btn-danger delBtn"" style=""background-color:#900c0c;color:#ffffff""");
            BeginWriteAttribute("id", " id=\"", 11616, "\"", 11637, 1);
#nullable restore
#line 226 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 11621, item.maNhanVien, 11621, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</button>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 233 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 243 "D:\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7606e1401c15d08c30987106910664f56811c2d138294", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebNhanVien.Models.NhanVien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
