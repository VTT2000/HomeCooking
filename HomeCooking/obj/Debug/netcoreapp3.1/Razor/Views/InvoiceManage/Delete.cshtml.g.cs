#pragma checksum "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c85cd3015b3f90bbfacfa1e922f35f3e11d67eb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvoiceManage_Delete), @"mvc.1.0.view", @"/Views/InvoiceManage/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c85cd3015b3f90bbfacfa1e922f35f3e11d67eb1", @"/Views/InvoiceManage/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058566c1c9d668cee7524474e72fbcc4098501b8", @"/Views/_ViewImports.cshtml")]
    public class Views_InvoiceManage_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeCooking.Models.HoaDonKhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/admin/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""content"">

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
            WriteLiteral(@"       <li class=""nav-item"">
                                    <a class=""nav-link"" data-widget=""navbar-search"" href=""#"" role=""button"">
                                        <i class=""fas fa-search""></i>
                                    </a>
                                    <div class=""navbar-search-block"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85cd3015b3f90bbfacfa1e922f35f3e11d67eb16585", async() => {
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
                        <h1>Delete</h1>

                        <h3>Are you sure you want to delete this?</h3>
                        <div>
                            <h4>HoaDonKhachHang</h4>
                            <hr />
           ");
            WriteLiteral("                 <dl class=\"row\">\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 75 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 78 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 81 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 84 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 87 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.TongTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 90 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.TongTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 93 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.PhuongThucThanhToan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 96 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.PhuongThucThanhToan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 99 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 102 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 105 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.IdKhNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 108 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.IdKhNavigation.IdKh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 111 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.IdNvNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 114 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.IdNvNavigation.IdNv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                            </dl>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85cd3015b3f90bbfacfa1e922f35f3e11d67eb116188", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c85cd3015b3f90bbfacfa1e922f35f3e11d67eb116479", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 119 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\InvoiceManage\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdInvoice);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85cd3015b3f90bbfacfa1e922f35f3e11d67eb118336", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <!-- /.card-footer-->\r\n                </div>\r\n                <!-- /.card -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeCooking.Models.HoaDonKhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
