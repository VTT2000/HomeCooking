#pragma checksum "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1cb773a448f2c4dbb5511630d9988ddcd1a231f"
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
#nullable restore
#line 105 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1cb773a448f2c4dbb5511630d9988ddcd1a231f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058566c1c9d668cee7524474e72fbcc4098501b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.ThucPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/thit.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/do an.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Second slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../GioHang/ThemGioHang"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("product_form_id_6806124495026_1624509122e13fa354"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-item__action-list button-stack"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Trang chủ";
    Layout = "_Layout";
    List<LoHang> list0 = ViewBag.LoHangs as List<LoHang>;
    List<KhuyenMai> list1 = ViewBag.KhuyenMais as List<KhuyenMai>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1cb773a448f2c4dbb5511630d9988ddcd1a231f8236", async() => {
                WriteLiteral("\r\n\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1cb773a448f2c4dbb5511630d9988ddcd1a231f9210", async() => {
                WriteLiteral(@"

    <!-- body-->
    <main id=""main"" role=""main"">
        <!-- slider-->

        <div id=""shopify-section-slideshow"" class=""shopify-section"">
            <section data-section-id=""slideshow"" data-section-type=""slideshow"">
                <div id=""carouselExampleIndicators slideshow slideshow--preserve-ratio slideshow--edge2edge flickity-enabled is-draggable"" class=""carousel slide"" data-ride=""carousel"">
                    <ol class=""carousel-indicators"">
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                    </ol>
                    <div class=""carousel-inner flickity-viewport "">
                        <div class=""carousel-item active"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1cb773a448f2c4dbb5511630d9988ddcd1a231f10358", async() => {
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
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"carousel-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1cb773a448f2c4dbb5511630d9988ddcd1a231f11739", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </section>
        </div>

        <!-- end slider-->
        <!-- list sản phẩm-->
        <div id=""shopify-section-item"" class=""shopify-section"">
            <section class=""section"" data-section-id="""" data-section-type=""featured-collection"">
                <div class=""container"">
                    <header cla");
                WriteLiteral(@"ss=""section__header"">
                        <div class=""section__header-stack"">
                            <h2 class=""section__title heading h3"">TOP SẢN PHẨM TRONG MÙA DỊCH</h2>

                        </div>
                        <a href=""#"" class=""section__action-link link"">View all</a>
                    </header>
                </div>
                <!-- sản phẩm-->
                <div class=""container "">
                    <div class=""scroller"">
                        <div class=""scroller__inner"">
                            <div class=""product-list product-list--vertical product-list--scrollable flickity-enabled"" tabindex=""0"">
");
#nullable restore
#line 67 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                 foreach(var item in Model.ToList())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div>
                                    <div>


                                        <div class=""product-item product-item--vertical 1/4--lap 1/5--desk 1/6--wide is-selected"" style="" left: 0%;"">
                                            <a");
                BeginWriteAttribute("href", " href=\"", 3474, "\"", 3533, 1);
#nullable restore
#line 74 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
WriteAttributeValue("", 3481, Url.Action("Index","Food",new { id = item.IdFood }), 3481, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"product-item__image-wrapper product-item__image-wrapper--with-secondary\">\r\n                                                <div class=\"aspect-ratio \" style=\"padding-bottom: 100.0%\">\r\n                                                    <img");
                BeginWriteAttribute("class", " class=\"", 3781, "\"", 3789, 0);
                EndWriteAttribute();
                WriteLiteral(" sizes=\"216px\"");
                BeginWriteAttribute("srcset", " srcset=\"", 3804, "\"", 3813, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    <img");
                BeginWriteAttribute("src", " src=\"", 3873, "\"", 3896, 1);
#nullable restore
#line 77 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
WriteAttributeValue("", 3879, item.LinkHinhAnh, 3879, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                </div>\r\n                                            </a><div class=\"product-item__info\">\r\n                                                    <div class=\"product-item__info-inner\">\r\n");
                WriteLiteral("                                                        <a");
                BeginWriteAttribute("href", " href=\"", 4336, "\"", 4395, 1);
#nullable restore
#line 82 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
WriteAttributeValue("", 4343, Url.Action("Index","Food",new { id = item.IdFood }), 4343, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"product-item__title text--strong link\">");
#nullable restore
#line 82 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                                                                                                                                                Write(item.NameFood);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                        <div class=\"product-item__price-list price-list\">\r\n");
#nullable restore
#line 84 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                                             if (list1.FirstOrDefault(p => p.IdKhuyenMai == item.IdKhuyenMai) != null)
                                                            {
                                                                var sale = item.Price * (100 - list1.FirstOrDefault(p => p.IdKhuyenMai == item.IdKhuyenMai).PhanTramKhuyenMai) / 100;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <span class=\"price price--highlight\">\r\n                                                                    <span class=\"visually-hidden\">Giá sale</span>");
#nullable restore
#line 88 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                                                                                            Write(sale);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"₫
                                                                </span>
                                                                <span class=""price price--compare"">
                                                                    <span class=""visually-hidden"">Giá gốc</span>");
#nullable restore
#line 91 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                                                                                           Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("₫\r\n                                                                </span>\r\n");
#nullable restore
#line 93 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <span class=\"price price--highlight\">\r\n                                                                    <span class=\"visually-hidden\">Giá gốc</span>");
#nullable restore
#line 97 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                                                                                           Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("₫\r\n                                                                </span>\r\n");
#nullable restore
#line 99 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                        </div>\r\n                                                        \r\n");
#nullable restore
#line 103 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                                         if (list0.FindAll(p => p.IdFood == item.IdFood).FirstOrDefault(p => p.SoLuong > 0) != null)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <span class=\"product-item__inventory inventory inventory--high\">Còn hàng</span>\r\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1cb773a448f2c4dbb5511630d9988ddcd1a231f22029", async() => {
                    WriteLiteral("\r\n                                                                <input type=\"hidden\" name=\"IdFood\"");
                    BeginWriteAttribute("value", " value=\"", 7051, "\"", 7071, 1);
#nullable restore
#line 108 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
WriteAttributeValue("", 7059, item.IdFood, 7059, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                                                <input type=\"hidden\" name=\"strURL\"");
                    BeginWriteAttribute("value", " value=\"", 7173, "\"", 7213, 1);
#nullable restore
#line 109 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
WriteAttributeValue("", 7181, Context.Request.GetDisplayUrl(), 7181, 32, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                                                                <button type=""submit"" class=""product-item__action-button button button--small button--primary"" data-action=""add-to-cart"">Thêm vào giỏ</button>
                                                            ");
                }
                );
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
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 112 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <span class=\"product-item__inventory inventory inventory--high\">Hết hàng</span>\r\n");
#nullable restore
#line 116 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                    </div>
                                                
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 124 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                
                            </div>
                        </div>
                    </div>
                </div>
                <!-- end sản phẩm-->
            </section>
        </div>
        <!-- end list sản phẩm-->
    </main>

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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.ThucPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
