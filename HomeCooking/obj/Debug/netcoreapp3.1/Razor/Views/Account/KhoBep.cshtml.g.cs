#pragma checksum "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d69ed38c8a79de2e85f31b8c5e9640db8ff05d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_KhoBep), @"mvc.1.0.view", @"/Views/Account/KhoBep.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d69ed38c8a79de2e85f31b8c5e9640db8ff05d2", @"/Views/Account/KhoBep.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058566c1c9d668cee7524474e72fbcc4098501b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_KhoBep : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.ChiTietKhoBep>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
  
    ViewData["Title"] = "Account";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main id=""main"" role=""main"">
    <section data-section-id=""account"" data-section-type=""account"">
        <div class=""container container--flush"">
            <div class=""layout"">
                <!--list tác vụ-->
                <div class=""layout__section layout__section--secondary"">
                    <div class=""card card--sticky hidden-pocket"">
                        <div class=""card__section card__section--tight"">

                            <div class=""card__linklist"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 673, "\"", 710, 1);
#nullable restore
#line 16 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 680, Url.Action("Index","Account"), 680, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">Thông tin cá nhân</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 802, "\"", 841, 1);
#nullable restore
#line 17 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 809, Url.Action("Invoice","Account"), 809, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">Đơn hàng của tôi </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 933, "\"", 977, 1);
#nullable restore
#line 18 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 940, Url.Action("FollowedFood","Account"), 940, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">Thực phẩm đã theo dõi</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1073, "\"", 1111, 1);
#nullable restore
#line 19 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 1080, Url.Action("KhoBep","Account"), 1080, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card__linklist-item link text--strong"">Kho bếp của tôi</a>
                                <a href=""#"" class=""card__linklist-item link"" data-no-instant="""" onclick=""logOutTK()"">Đăng xuất</a>
                            </div>
                        </div>
                    </div>
                </div>
                <!--layout tác vụ -->
                <div class=""layout__section"">
                    <div class=""card"">
                        <div class=""card__section card__section--tight"">
                            <h1 class=""heading h1"">Kho bếp online </h1>
                        </div>
                        <div class=""card__section"">
                            <table class=""table"" border=""1"">
                                <tr style=""background-color:gray"">
                                    <th>
                                        Tên thực phẩm
                                    </th>

                                    <th>
                                ");
            WriteLiteral(@"        Ngày sản xuất
                                    </th>
                                    <th>
                                        Ngày hết hạn
                                    </th>
                                    <th>
                                        Số lượng hiện tại
                                    </th>
                                    <th>
                                        Đơn vị tính
                                    </th>

                                    <th>
                                        Trạng thái
                                    </th>
                                    <th>
                                        Thao tác
                                    </th>
                                </tr>
");
#nullable restore
#line 58 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3167, "\"", 3356, 1);
#nullable restore
#line 62 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 3174, Url.Action("Index","Food", new { id = item.IdInvoiceNavigation.ChiTietHoaDonKhachHangs.FirstOrDefault(p => p.IdLoHang == item.IdLoHang).IdLoHangNavigation.IdFoodNavigation.IdFood }), 3174, 182, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 63 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.IdInvoiceNavigation.ChiTietHoaDonKhachHangs.FirstOrDefault(p => p.IdLoHang == item.IdLoHang).IdLoHangNavigation.IdFoodNavigation.NameFood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                           </a>\r\n                                            </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 68 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IdInvoiceNavigation.ChiTietHoaDonKhachHangs.FirstOrDefault(p => p.IdLoHang == item.IdLoHang).IdLoHangNavigation.NgaySanXuat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 71 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IdInvoiceNavigation.ChiTietHoaDonKhachHangs.FirstOrDefault(p => p.IdLoHang == item.IdLoHang).IdLoHangNavigation.NgayHetHan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 74 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.SoLuongTrongChiTietHoDonKhachHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 77 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IdInvoiceNavigation.ChiTietHoaDonKhachHangs.FirstOrDefault(p => p.IdLoHang == item.IdLoHang).IdLoHangNavigation.IdFoodNavigation.DonViTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 80 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5076, "\"", 5208, 1);
#nullable restore
#line 84 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 5083, Url.Action("DeleteKhoBep","Account", new { IdKhoBep = item.IdKhoBep, IdInvoice = item.IdInvoice, IdLoHang = item.IdLoHang }), 5083, 125, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa thực phẩm</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 87 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </table>
                        </div>
                        <div class=""card__section card__section--tight"">
                            <h1 class=""heading h1"">Các món ăn gợi ý phù hợp với các nguyên liệu hiện tại </h1>
                        </div>
                        <div class=""card__section"">
                            <table class=""table"" border=""1"">
                                <tr style=""background-color:gray"">
                                    <th>
                                        Hình ảnh
                                    </th>

                                    <th>
                                        Tên công thức
                                    </th>
                                    <th>
                                        Mô tả món ăn
                                    </th>
                                    <th>
                                        Thao tác
                                    </th>
  ");
            WriteLiteral("                              </tr>\r\n");
#nullable restore
#line 110 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                 foreach (CongThucNauAn item in ViewBag.ListAvailable)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 6674, "\"", 6697, 1);
#nullable restore
#line 114 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 6680, item.LinkHinhAnh, 6680, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 117 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                       Write(item.TenCongThuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td >\r\n                                            ");
#nullable restore
#line 120 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                       Write(item.MoTaMonAn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 7153, "\"", 7221, 1);
#nullable restore
#line 123 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 7160, Url.Action("Index","CongThuc", new { id = item.IdCongThuc }), 7160, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem chi tiết</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 126 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\KhoBep.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.ChiTietKhoBep>> Html { get; private set; }
    }
}
#pragma warning restore 1591
