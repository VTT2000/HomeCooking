#pragma checksum "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786ff75006f04906fc18bd1ed13861288509b4a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThanhToan_Index), @"mvc.1.0.view", @"/Views/ThanhToan/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786ff75006f04906fc18bd1ed13861288509b4a9", @"/Views/ThanhToan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058566c1c9d668cee7524474e72fbcc4098501b8", @"/Views/_ViewImports.cshtml")]
    public class Views_ThanhToan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.GioHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/checkout.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo__image logo__image--medium"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/ThanhToan/ThanhToanThuong"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit_checkout animate-floating-labels"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-customer-information-form", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-email-or-phone", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
  
    ViewBag.Title = "Thanh toan";
    Layout = "_Layout";
    KhachHang a = ViewBag.KhachHang as KhachHang;

#line default
#line hidden
#nullable disable
            WriteLiteral("<html lang=\"vi\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786ff75006f04906fc18bd1ed13861288509b4a98272", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "786ff75006f04906fc18bd1ed13861288509b4a98534", async() => {
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
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786ff75006f04906fc18bd1ed13861288509b4a910416", async() => {
                WriteLiteral("\r\n    <div class=\"content\" data-content=\"\">\r\n        <div class=\"wrap\">\r\n            <div class=\"main\">\r\n                <header class=\"main__header\" role=\"banner\">\r\n                    <a class=\"logo logo--left\" href=\"#\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "786ff75006f04906fc18bd1ed13861288509b4a910947", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                    </a>
                    <h1 class=""visually-hidden"">
                        Thông tin khách hàng
                    </h1>
                    <nav aria-label=""Điều hướng"">
                        <ol class=""breadcrumb "" role=""list"">
                            <li class=""breadcrumb__item breadcrumb__item--completed"">
                                <a class=""breadcrumb__link"" href=""#"">Giỏ hàng</a>
                                <svg class=""icon-svg icon-svg--color-adaptive-light icon-svg--size-10 breadcrumb__chevron-icon"" aria-hidden=""true"" focusable=""false""> <use xlink:href=""#chevron-right""></use> </svg>
                            </li>
                            <li class=""breadcrumb__item breadcrumb__item--blank"">
                                <span class=""breadcrumb__text"">thanh toán</span>
                            </li>
                        </ol>
                    </nav>
                </header>
                <main class=""main__content"" role=""main""");
                WriteLiteral(">\r\n                    <div class=\"step\" data-step=\"contact_information\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786ff75006f04906fc18bd1ed13861288509b4a913402", async() => {
                    WriteLiteral(@"
                            <div class=""step__sections"">
                                <!--Thông tin khách hàng-->
                                <div class=""section section--contact-information"">
                                    <div class=""section__header"">
                                        <div class=""layout-flex layout-flex--tight-vertical layout-flex--loose-horizontal layout-flex--wrap"">
                                            <h2 class=""section__title layout-flex__item layout-flex__item--stretch"" id=""main-header"" tabindex=""-1"">
                                                Thông tin liên lạc
                                            </h2>
                                        </div>
                                    </div>
                                    <div class=""section__content"">
                                        <div class=""logged-in-customer-information"">
                                            <p class=""logged-in-customer-information__paragraph");
                    WriteLiteral("\">\r\n                                                <span class=\"page-main__emphasis\">Tên khách hàng : ");
#nullable restore
#line 50 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
                                                                                              Write(a.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>\r\n");
                    WriteLiteral(@"                                            </p>
                                        </div>
                                        <div class=""'fieldset'"">
                                            <div class=""field field--required field--show-floating-label"">
                                                <div class=""field__input-wrapper"">
                                                    <label class=""field__label field__label--visible"" for=""checkout_shipping_address_city"">Email</label>
                                                    <input disabled placeholder=""Địa chỉ"" class=""field__input"" aria-required=""true"" size=""30"" type=""text""");
                    BeginWriteAttribute("value", " value=\"", 3862, "\"", 3878, 1);
#nullable restore
#line 59 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
WriteAttributeValue("", 3870, a.Email, 3870, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                                                </div>
                                            </div>
                                            <div class=""field field--required field--show-floating-label"">
                                                <div class=""field__input-wrapper"">
                                                    <label class=""field__label field__label--visible"" for=""checkout_shipping_address_city"">Địa chỉ</label>
                                                    <input disabled placeholder=""Điện thoại"" class=""field__input"" aria-required=""true"" size=""30"" type=""text""");
                    BeginWriteAttribute("value", " value=\"", 4494, "\"", 4511, 1);
#nullable restore
#line 65 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
WriteAttributeValue("", 4502, a.DiaChi, 4502, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                                                </div>
                                            </div>
                                            <div class=""field field--required field--show-floating-label"">
                                                <div class=""field__input-wrapper"">
                                                    <label class=""field__label field__label--visible"" for=""checkout_shipping_address_city"">Ngày nhận hàng</label>
                                                    
                                                    <input id=""dateDelivery000"" name=""dateDelivery"" placeholder=""Ngày nhận"" class=""field__input"" aria-required=""true"" size=""30"" type=""datetime""");
                    BeginWriteAttribute("value", " value=\"", 5223, "\"", 5255, 1);
#nullable restore
#line 72 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
WriteAttributeValue("", 5231, DateTime.Now.AddDays(1), 5231, 24, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <!--phuong thuc giao hàng-->
                                <div class=""section"">
                                    <div class=""section__header"">
                                        <h2 class=""section__title"">
                                            Phương thức thanh toán
                                        </h2>
                                    </div>
                                    <div class=""section__content"">
                                        <div class=""content-box"">
                                            <div class=""content-box__row"">
                                                <div class=""radio-wrapper"">
                                                    <button name=""button"" type=");
                    WriteLiteral(@"""submit"" id=""continue_button"" class=""step__footer__continue-btn btn"" aria-busy=""false"">
                                                        <span class=""btn__content"">Thanh toán thường (nhận tiền khi giao hàng)</span>
                                                    </button>
                                                </div>
                                            </div>
                                            <div class=""content-box__row"">
                                                <div class=""radio-wrapper"">
                                                    <script src=""https://www.paypal.com/sdk/js?client-id=AeNgWBwjVxAurOZjItvopDzG3j82L2BHC8UJp3_I9NvIbbZHs7JyWk-i7cNsKH2St2FWoyEKviQG_1oH&disable-funding=credit,card"">
                                                    </script>
                                                    <div id=""paypal-button-container""></div>
                                                    <script>
                                        ");
                    WriteLiteral(@"                paypal.Buttons({
                                                            createOrder: function (data, actions) {
                                                                // This function sets up the details of the transaction, including the amount and line item details.
                                                                return actions.order.create({
                                                                    purchase_units: [{
                                                                        amount: {
                                                                            value: ");
#nullable restore
#line 107 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
                                                                              Write(ViewBag.TongTien);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                                                        }
                                                                    }]
                                                                });
                                                            },
                                                            onApprove: function (data, actions) {
                                                                // This function captures the funds from the transaction.
                                                                return actions.order.capture().then(function (details) {
                                                                    // This function shows a transaction success message to your buyer.
                                                                    alert('Thanh toán Paypal thành công bởi ' +
                                                                        details.payer.name.given_name);
                                           ");
                    WriteLiteral(@"                         location.href = 'https://' + location.host + '/ThanhToan/ThanhToanPaypal?dateDelivery=' + document.getElementById('dateDelivery000').value;
                                                                });
                                                            }
                                                        }).render('#paypal-button-container');
                                                        //This function displays Smart Payment Buttons on your web page.
                                                    </script>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class=""step__footer"" data-step-footer="""">
                                    <a class=""step__footer__previous-link""");
                    BeginWriteAttribute("href", " href=\"", 9970, "\"", 10007, 1);
#nullable restore
#line 131 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
WriteAttributeValue("", 9977, Url.Action("Index","GioHang"), 9977, 30, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("><span class=\"step__footer__previous-link-content\">Trở lại giỏ hàng</span></a>\r\n                                </div>\r\n                            </div>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </main>
                <footer class=""main__footer"" role=""contentinfo"">
                    <ul class=""policy-list"" role=""list"">
                        <li class=""policy-list__item "">
                            <a>Chính sách đổi trả hàng</a>
                        </li>
                        <li class=""policy-list__item "">
                            <a>Chính sách giao hàng</a>
                        </li>
                        <li class=""policy-list__item "">
                            <a>Chính sách bảo mật</a>
                        </li>
                        <li class=""policy-list__item "">
                            <a>Điều khoản sử dụng</a>
                        </li>
                    </ul>




                </footer>
            </div>
            <aside class=""sidebar"" role=""complementary"">
                <div class=""sidebar__header"">


                </div>
                <div class=""sidebar__content"">
   ");
                WriteLiteral(@"                 <div id=""order-summary"" class=""order-summary order-summary--is-collapsed"" data-order-summary="""">

                        <div class=""order-summary__sections"">
                            <div class=""order-summary__section order-summary__section--product-list"">
                                <div class=""order-summary__section__content"">
                                    <table class=""product-table"">
                                        <thead class=""product-table__header"">
                                            <tr>
                                                <th scope=""col""><span");
                BeginWriteAttribute("class", " class=\"", 11846, "\"", 11854, 0);
                EndWriteAttribute();
                WriteLiteral(">Hình ảnh</span></th>\r\n                                                <th scope=\"col\"><span");
                BeginWriteAttribute("class", " class=\"", 11947, "\"", 11955, 0);
                EndWriteAttribute();
                WriteLiteral(">Thông tin sản phẩm</span></th>\r\n                                                <th scope=\"col\"><span");
                BeginWriteAttribute("class", " class=\"", 12058, "\"", 12066, 0);
                EndWriteAttribute();
                WriteLiteral(">Giá</span></th>\r\n                                            </tr>\r\n                                        </thead>\r\n                                        <tbody data-order-summary-section=\"line-items\">\r\n");
#nullable restore
#line 178 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <tr class=""product"" data-product-id="""" data-variant-id="""" data-product-type="""" data-customer-ready-visible="""">
                                                    <td class=""product__image"">
                                                        <div class=""product-thumbnail "">
                                                            <div class=""product-thumbnail__wrapper"">
                                                                <img");
                BeginWriteAttribute("alt", " alt=\"", 12897, "\"", 12918, 1);
#nullable restore
#line 184 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
WriteAttributeValue("", 12903, item.zNameFood, 12903, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"product-thumbnail__image\"");
                BeginWriteAttribute("src", " src=\"", 12952, "\"", 12976, 1);
#nullable restore
#line 184 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
WriteAttributeValue("", 12958, item.zLinkHinhAnh, 12958, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                            </div>

                                                        </div>

                                                    </td>
                                                    <th class=""product__description"" scope=""row"">
                                                        <span class=""product__description__name order-summary__emphasis"">");
#nullable restore
#line 191 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
                                                                                                                    Write(item.zNameFood);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                        <br />\r\n                                                        <span class=\"product__description__variant order-summary__small-text\">Số lượng: ");
#nullable restore
#line 193 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
                                                                                                                                   Write(item.zSoLuong);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                                    </th>

                                                    <td class=""product__price"">
                                                        <span class=""order-summary__emphasis skeleton-while-loading"">");
#nullable restore
#line 197 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
                                                                                                                Write(item.zThanhTien);

#line default
#line hidden
#nullable disable
                WriteLiteral("₫</span>\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 200 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </tbody>
                                    </table>

                                </div>
                            </div>

                            <div class=""order-summary__section order-summary__section--total-lines"" data-order-summary-section=""payment-lines"">
                                <table class=""total-line-table"">
                                    <thead>
                                        <tr>
                                        </tr>
                                    </thead>
");
                WriteLiteral(@"                                    <tfoot class=""total-line-table__footer"">
                                        <tr class=""total-line"">
                                            <th class=""total-line__name payment-due-label"" scope=""row"">
                                                <span class=""payment-due-label__total"">Tổng cộng</span>
                                            </th>
                                            <td class=""total-line__price payment-due"" data-presentment-currency=""VND"">
                                                <span class=""payment-due__price skeleton-while-loading--lg"" data-checkout-payment-due-target="""">
                                                    ");
#nullable restore
#line 243 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\ThanhToan\Index.cshtml"
                                               Write(ViewBag.TongTien);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"₫
                                                </span>
                                            </td>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div id=""partial-icon-symbols"" class=""icon-symbols"" data-tg-refresh=""partial-icon-symbols"" data-tg-refresh-always=""true"">
                        <svg xmlns=""http://www.w3.org/2000/svg"">
                            <symbol id=""close""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 16 16""><path d=""M15.1 2.3L13.7.9 8 6.6 2.3.9.9 2.3 6.6 8 .9 13.7l1.4 1.4L8 9.4l5.7 5.7 1.4-1.4L9.4 8""></path></svg></symbol>
                            <symbol id=""spinner-small""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 32 32""><path d=""M32 16c0 8.837-7.163 16-16 16S0 24.837 0 16 7.163 0 16 0v2C8.268 2 2 8.268 2 16s6.268 14 14 14 14-6.268 14-14h2z""></path></");
                WriteLiteral(@"svg></symbol>
                            <symbol id=""spinner-button""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 20 20""><path d=""M20 10c0 5.523-4.477 10-10 10S0 15.523 0 10 4.477 0 10 0v2c-4.418 0-8 3.582-8 8s3.582 8 8 8 8-3.582 8-8h2z""></path></svg></symbol>
                            <symbol id=""chevron-right""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 10 10""><path d=""M2 1l1-1 4 4 1 1-1 1-4 4-1-1 4-4""></path></svg></symbol>
                            <symbol id=""down-arrow""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 12 12""><path d=""M10.817 7.624l-4.375 4.2c-.245.235-.64.235-.884 0l-4.375-4.2c-.244-.234-.244-.614 0-.848.245-.235.64-.235.884 0L5.375 9.95V.6c0-.332.28-.6.625-.6s.625.268.625.6v9.35l3.308-3.174c.122-.117.282-.176.442-.176.16 0 .32.06.442.176.244.234.244.614 0 .848""></path></svg></symbol>
                        </svg>
                    </div>
                </div>
            </aside>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.GioHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
