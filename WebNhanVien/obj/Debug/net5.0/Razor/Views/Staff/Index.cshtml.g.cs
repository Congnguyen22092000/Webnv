#pragma checksum "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8575608ff47b2febe26001688660e1997bf9ec19"
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
#line 1 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\_ViewImports.cshtml"
using WebNhanVien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\_ViewImports.cshtml"
using WebNhanVien.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8575608ff47b2febe26001688660e1997bf9ec19", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1d7e80300dc912c2758fd0ef6f2e649df7aead", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebNhanVien.Models.NhanVien>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Staff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: grid; margin: 20px; color:rgb(0,0,0)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/staff/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: grid; margin: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/staff/CreateNV"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family: Arial, Helvetica, sans-serif;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
  
    ViewData["Title"] = "Danh Sách Nhân Viên";
    
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 style=\"text-align: center;\">");
#nullable restore
#line 13 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>\r\n\r\n    <div>\r\n        <div style=\"border-radius: 3px; left: 42%; position: relative; background-color: #28a745; margin: 20px 0; max-width: 15%; padding: 1%; font-size: 22px; text-align: center; color: #ffff;\">Ô tìm kiếm</div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8575608ff47b2febe26001688660e1997bf9ec198297", async() => {
                WriteLiteral("\r\n\r\n\r\n            <input name=\"key\" type=\"search\" class=\"form-control rounded\" placeholder=\"Từ Khóa Cần Tìm\" aria-label=\"Search\"\r\n                   aria-describedby=\"search-addon\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
<div>

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
#line 56 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
         foreach (var item in Model)
        {
            var i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
               Write(item.maNhanVien);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
               Write(item.hoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 71 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
               Write(item.ngaySinh.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
               Write(item.soDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
               Write(item.chucVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
            WriteLiteral("\r\n\r\n                    <a class=\"btn btn-info\" id=\"myBtnEdit\" style=\"background-color:#28a745;border-color:#28a745;\"  data-toggle=\"modal\" data-target=\"#editNV-");
#nullable restore
#line 85 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                                                                                                                                       Write(Model.IndexOf(item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Sửa</a>\r\n\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 2242, "\"", 2274, 2);
            WriteAttributeValue("", 2247, "editNV-", 2247, 7, true);
#nullable restore
#line 87 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 2254, Model.IndexOf(item), 2254, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""modal"" style=""display: none;  position: fixed;  z-index: 9999999999;  left: 0; top: 0; width: 100%;  height: 100%;overflow: auto;  background-color: rgb(0,0,0);  background-color: rgba(0,0,0,0.4); -webkit-animation-name: fadeIn; -webkit-animation-duration: 0.4s; animation-name: fadeIn; animation-duration: 0.4s;"">

                        <!-- Modal content -->
                        <div class=""modal-content"" style="" position: relative; top: 18%; max-width: 60%; margin: auto; min-height: 30%; background-color: #fefefe; width: 100%; -webkit-animation-name: slideIn; -webkit-animation-duration: 0.4s; animation-name: slideIn; animation-duration: 0.4s; -webkit-animation-name: slideIn; -webkit-animation-duration: 0.4s; animation-name: slideIn; animation-duration: 0.4s;"">
                            <div class=""modal-header"" style="" padding: 2px 16px; background-color: #5cb85c; color: white; text-align: center;display: block;"">
                                <span id=""closeBtnEdit"">&times;</span>
   ");
            WriteLiteral("                             <h2 style=\"padding: 15px;\">Sửa hồ sơ nhân viên</h2>\r\n                            </div>\r\n                            <div class=\"modal-body\" style=\"padding: 2px 16px;\">\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8575608ff47b2febe26001688660e1997bf9ec1915242", async() => {
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 100 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                     using (Html.BeginForm())
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <label type=\"text\" name=\"maNhanVien\">Mã nhân viên</label>\r\n                                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"maNhanVien\" id=\"maNhanVienEdit\"");
                BeginWriteAttribute("value", " value=", 3961, "", 3984, 1);
#nullable restore
#line 104 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 3968, item.maNhanVien, 3968, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n                                        <input name=\"maNhanVien\"");
                BeginWriteAttribute("value", " value=\"", 4062, "\"", 4086, 1);
#nullable restore
#line 105 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 4070, item.maNhanVien, 4070, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n");
                WriteLiteral("                                        <label type=\"text\" name=\"hoTen\">Họ và tên</label>\r\n                                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"hoTen\" id=\"hoTenEdit\"");
                BeginWriteAttribute("value", " value=\"", 4307, "\"", 4326, 1);
#nullable restore
#line 108 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 4315, item.hoTen, 4315, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <span id=\"ErrorMgsEdit\" class=\"text-danger\"></span>\r\n");
                WriteLiteral("                                        <label type=\"date\" name=\"ngaySinh\">Ngày sinh</label>\r\n                                        <input style=\"margin-bottom: 15px;\" name=\"ngaySinh\" type=\"date\" id=\"ngaySinhEdit\"");
                BeginWriteAttribute("value", " value=\"", 4644, "\"", 4689, 1);
#nullable restore
#line 113 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 4652, item.ngaySinh.ToString("yyyy-MM-dd"), 4652, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("                                        <label type=\"text\" name=\"soDT\">Số điện thoại</label>\r\n                                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"soDT\" id=\"soDTEdit\"");
                BeginWriteAttribute("value", " value=\"", 4904, "\"", 4922, 1);
#nullable restore
#line 116 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 4912, item.soDT, 4912, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("                                        <label type=\"text\" name=\"chucVu\">Chức vụ</label>\r\n                                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"chucVu\" id=\"chucVuEdit\"");
                BeginWriteAttribute("value", " value=\"", 5137, "\"", 5157, 1);
#nullable restore
#line 119 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 5145, item.chucVu, 5145, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("                                        <input style=\"margin-bottom: 15px;\" type=\"submit\" id=\"EditBtn\" ");
                WriteLiteral(" class=\"btn btn-success\" value=\"Sửa\" />\r\n");
#nullable restore
#line 122 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"


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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                        #closeBtnEdit {
                            color: white;
                            float: right;
                            font-size: 28px;
                            font-weight: bold;
                        }

                            #closeBtnEdit:hover,
                            #closeBtnEdit:focus {
                                color: #000;
                                text-decoration: none;
                                cursor: pointer;
                            }
                    </style>
                    


");
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-warning\" style=\"background-color:#900c0c; border-color:#900c0c;color:#ffffff;\" data-toggle=\"modal\" data-target=\"#NV-");
#nullable restore
#line 152 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                                                                                                                                                        Write(Model.IndexOf(item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xóa</button>\r\n                    <div class=\"modal\"");
            BeginWriteAttribute("id", " id=\"", 6711, "\"", 6739, 2);
            WriteAttributeValue("", 6716, "NV-", 6716, 3, true);
#nullable restore
#line 153 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 6719, Model.IndexOf(item), 6719, 20, false);

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
            BeginWriteAttribute("id", " id=\"", 7314, "\"", 7339, 2);
            WriteAttributeValue("", 7319, "Huy-", 7319, 4, true);
#nullable restore
#line 159 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 7323, item.maNhanVien, 7323, 16, false);

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
#line 164 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                                                        Write(item.hoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                                    <button class=""btn btn-danger delBtn"" style=""background-color:#900c0c;color:#ffffff""");
            BeginWriteAttribute("id", " id=\"", 8017, "\"", 8038, 1);
#nullable restore
#line 168 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 8022, item.maNhanVien, 8022, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</button>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 175 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8575608ff47b2febe26001688660e1997bf9ec1926224", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
        .closeBtnCreate {
            color: white;
            float: right;
            font-size: 28px;
            font-weight: bold;
        }

            .closeBtnCreate:hover,
            .closeBtnCreate:focus {
                color: #000;
                text-decoration: none;
                cursor: pointer;
            }
    </style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8575608ff47b2febe26001688660e1997bf9ec1927645", async() => {
                WriteLiteral(@"


    <!-- Trigger/Open The Modal -->
    <button class=""btn btn-outline-success"" id=""myBtn"">Thêm nhân viên</button>

    <!-- The Modal -->
    <div id=""myModal"" class=""modal"" style=""display: none; position: fixed; z-index: 1; left: 0; top: 0; width: 100%; height: 100%; overflow: auto; background-color: rgb(0,0,0);  background-color: rgba(0,0,0,0.4); -webkit-animation-name: fadeIn; -webkit-animation-duration: 0.4s; animation-name: fadeIn; animation-duration: 0.4s;"">

        <!-- Modal content -->
        <div class=""modal-content"" style="" position: relative; top: 18%; max-width: 60%; margin: auto; min-height: 30%; background-color: #fefefe; width: 100%; -webkit-animation-name: slideIn; -webkit-animation-duration: 0.4s; animation-name: slideIn; animation-duration: 0.4s; -webkit-animation-name: slideIn; -webkit-animation-duration: 0.4s; animation-name: slideIn; animation-duration: 0.4s;"">
            <div class=""modal-header"" style="" padding: 2px 16px; background-color: #5cb85c; color: white; text");
                WriteLiteral(@"-align: center;display: block;"">
                <span class=""closeBtnCreate"">&times;</span>
                <h2 style=""padding: 15px;"">Thêm hồ sơ nhân viên mới</h2>
            </div>
            <div class=""modal-body"" style=""padding: 2px 16px;"">

                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8575608ff47b2febe26001688660e1997bf9ec1929259", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 221 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                      
                        var maNV = ViewBag.maNV;
                    

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n");
#nullable restore
#line 225 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
                     using (Html.BeginForm())
                    {


#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <label type=\"text\" name=\"maNhanVien\">Mã nhân viên</label>\r\n                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"maNhanVien\" id=\"maNhanVien\"");
                    BeginWriteAttribute("value", " value=", 10664, "", 10676, 1);
#nullable restore
#line 229 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 10671, maNV, 10671, 5, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" disabled />\r\n                        <input name=\"maNhanVien\"");
                    BeginWriteAttribute("value", " value=\"", 10738, "\"", 10751, 1);
#nullable restore
#line 230 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
WriteAttributeValue("", 10746, maNV, 10746, 5, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" hidden />\r\n");
                    WriteLiteral("                        <label type=\"text\" name=\"hoTen\">Họ và tên</label>\r\n                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"hoTen\" id=\"hoTen\" />\r\n                        <span id=\"ErrorMgs\" class=\"text-danger\"></span>\r\n");
                    WriteLiteral("                        <label type=\"date\" name=\"ngaySinh\">Ngày sinh</label>\r\n                        <input style=\"margin-bottom: 15px;\" name=\"ngaySinh\" type=\"date\" id=\"ngaySinh\" />\r\n");
                    WriteLiteral("                        <label type=\"text\" name=\"soDT\">Số điện thoại</label>\r\n                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"soDT\" id=\"soDT\" />\r\n");
                    WriteLiteral("                        <label type=\"text\" name=\"chucVu\">Chức vụ</label>\r\n                        <input style=\"margin-bottom: 15px;\" type=\"text\" name=\"chucVu\" id=\"chucVu\" />\r\n");
                    WriteLiteral("                        <input style=\"margin-bottom: 15px;\" type=\"submit\" id=\"SubmitBtn\" disabled class=\"btn btn-success\" value=\"Thêm mới\" />\r\n");
#nullable restore
#line 247 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"


                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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

    <script>
        // Get the modal
        var modal = document.getElementById(""myModal"");


        var btn = document.getElementById(""myBtn"");


        var span = document.getElementsByClassName(""closeBtnCreate"")[0];




        btn.onclick = function () {
            modal.style.display = ""block"";
        }


        span.onclick = function () {
            modal.style.display = ""none"";
        }


        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = ""none"";
            }
        }
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 294 "C:\Users\cong\Downloads\WebNhanVien\WebNhanVien\Views\Staff\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8575608ff47b2febe26001688660e1997bf9ec1935952", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
