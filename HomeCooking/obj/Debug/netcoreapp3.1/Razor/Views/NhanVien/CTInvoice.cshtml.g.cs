#pragma checksum "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed02373601878249c10198b99389902a53759838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_CTInvoice), @"mvc.1.0.view", @"/Views/NhanVien/CTInvoice.cshtml")]
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
#line 1 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\_ViewImports.cshtml"
using HomeCooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\_ViewImports.cshtml"
using HomeCooking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed02373601878249c10198b99389902a53759838", @"/Views/NhanVien/CTInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058566c1c9d668cee7524474e72fbcc4098501b8", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_CTInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.ChiTietHoaDonKhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
  
    ViewData["Title"] = "Chi tiết hóa đơn";
    Layout = "~/Views/Shared/admin/_NhanVienLayout.cshtml";

    KhachHang a = ViewBag.KhachHang as KhachHang;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content"">

    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <!-- Default box -->
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Title</h3>
                        <!-- Navbar -->
                        <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
                            <!-- Left navbar links -->
                            <ul class=""navbar-nav"">
                                <li class=""nav-item"">
                                    <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
                                </li>

                            </ul>

                            <!-- Right navbar links -->
                            <ul class=""navbar-nav ml-auto"">
                                <!-- Navbar Search -->
                             ");
            WriteLiteral(@"   <li class=""nav-item"">
                                    <a class=""nav-link"" data-widget=""navbar-search"" href=""#"" role=""button"">
                                        <i class=""fas fa-search""></i>
                                    </a>
                                    <div class=""navbar-search-block"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed02373601878249c10198b99389902a537598385501", async() => {
                WriteLiteral(@"
                                            <div class=""input-group input-group-sm"">
                                                <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                                                <div class=""input-group-append"">
                                                    <button class=""btn btn-navbar"" type=""submit"">
                                                        <i class=""fas fa-search""></i>
                                                    </button>
                                                    <button class=""btn btn-navbar"" type=""button"" data-widget=""navbar-search"">
                                                        <i class=""fas fa-times""></i>
                                                    </button>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </li>



                            </ul>
                        </nav>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"" title=""Remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"" style=""margin-left: 320px;"">
                        <h4>Chi tiết hóa đơn</h4>

                        <dl class=""row"">
                            <dt class=""col-sm-2"">
                                Tên khách hàng
                            </dt>
                  ");
            WriteLiteral("          <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 75 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                           Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                Email\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 81 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                           Write(a.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                Địa chỉ\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 87 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                           Write(a.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </dd>
                        </dl>

                        <table class=""table"" border=""1"">
                            <tr style=""background-color:gray"">
                                <th>
                                    Tên thực phẩm
                                </th>
                                <th>
                                    Số lượng trên một sản phẩm
                                </th>
                                <th>
                                    Đơn vị tính
                                </th>
                                <th>
                                    Số lượng sản phẩm
                                </th>
                                <th>
                                    Thuộc lô hàng
                                </th>
                                <th>
                                    Tổng tiền
                                </th>
                            </tr>
");
#nullable restore
#line 112 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 116 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdLoHangNavigation.IdFoodNavigation.NameFood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 119 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdLoHangNavigation.IdFoodNavigation.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 122 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdLoHangNavigation.IdFoodNavigation.DonViTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 125 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 128 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdLoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 131 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.GiaTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 134 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\NhanVien\CTInvoice.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </table>\r\n                        \r\n                    </div>\r\n\r\n                    <!-- /.card-footer-->\r\n                </div>\r\n                <!-- /.card -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.ChiTietHoaDonKhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591