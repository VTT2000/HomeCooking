#pragma checksum "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d35b375fc9be4229d81e20b34b8b497723d1bdfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_FollowedFood), @"mvc.1.0.view", @"/Views/Account/FollowedFood.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d35b375fc9be4229d81e20b34b8b497723d1bdfc", @"/Views/Account/FollowedFood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058566c1c9d668cee7524474e72fbcc4098501b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_FollowedFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.TheoDoiThucPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFollowedFood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
  
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
            BeginWriteAttribute("href", " href=\"", 674, "\"", 711, 1);
#nullable restore
#line 16 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
WriteAttributeValue("", 681, Url.Action("Index","Account"), 681, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link \">Thông tin cá nhân</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 804, "\"", 843, 1);
#nullable restore
#line 17 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
WriteAttributeValue("", 811, Url.Action("Invoice","Account"), 811, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link \">Đơn hàng của tôi </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 936, "\"", 980, 1);
#nullable restore
#line 18 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
WriteAttributeValue("", 943, Url.Action("FollowedFood","Account"), 943, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link text--strong\">Thực phẩm đã theo dõi</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1089, "\"", 1127, 1);
#nullable restore
#line 19 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
WriteAttributeValue("", 1096, Url.Action("KhoBep","Account"), 1096, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card__linklist-item link"">Kho bếp của tôi</a>
                                <a href=""#"" class=""card__linklist-item link"" data-no-instant="""" onclick=""logOutTK()"">Đăng xuất</a>
                            </div>
                        </div>
                    </div>
                </div>
                <!--layout tác vụ -->
                <div class=""layout__section"">
                    <div class=""card"">
                        <div class=""card__section card__section--tight"">
                            <h1 class=""heading h1""> Các thực phẩm đã theo dõi </h1>
                        </div>
                        <div class=""card__section"">
                            <table class=""table"" border=""1"">
                                <tr style=""background-color:gray"">
                                    <th>
                                        Id theo dõi
                                    </th>
                                    <th>
                                     ");
            WriteLiteral(@"   Tên thực phẩm
                                    </th>
                                    <th>
                                        Số lượng trên một sản phẩm
                                    </th>
                                    <th>
                                        Đơn vị tính
                                    </th>
                                    <th>
                                        Tình trạng
                                    </th>
                                    <th>
                                        Thao tác
                                    </th>
                                </tr>
");
#nullable restore
#line 53 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 57 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IdTheoDoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3230, "\"", 3290, 1);
#nullable restore
#line 60 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
WriteAttributeValue("", 3237, Url.Action("Index","Food", new { id = item.IdFood }), 3237, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 61 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.IdFoodNavigation.NameFood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 65 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IdFoodNavigation.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 68 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IdFoodNavigation.DonViTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 71 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IdFoodNavigation.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d35b375fc9be4229d81e20b34b8b497723d1bdfc11168", async() => {
                WriteLiteral("Bỏ theo dõi");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
                                                                                 WriteLiteral(item.IdTheoDoi);

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
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 77 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Account\FollowedFood.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.TheoDoiThucPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
