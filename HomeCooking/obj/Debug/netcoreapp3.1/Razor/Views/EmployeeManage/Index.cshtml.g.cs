#pragma checksum "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\EmployeeManage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ad89e0a2f64ba24b56ae793ee5b615c30f0f909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeManage_Index), @"mvc.1.0.view", @"/Views/EmployeeManage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad89e0a2f64ba24b56ae793ee5b615c30f0f909", @"/Views/EmployeeManage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058566c1c9d668cee7524474e72fbcc4098501b8", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeManage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "C:\Users\DELL\Downloads\HomeCooking\HomeCooking\HomeCooking\Views\EmployeeManage\Index.cshtml"
  
  ViewData["Title"] = "Index";
  Layout = "~/Views/Shared/admin/_AdminLayout.cshtml";

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
                <li class=""nav-item"">
                  <a class=""nav-link"" data-widget=""navbar-search"" href=""#"" role=""button"">
                    <i class=""fas fa-search""></i>
                  </a>
                  <div class=""navb");
            WriteLiteral("ar-search-block\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ad89e0a2f64ba24b56ae793ee5b615c30f0f9095037", async() => {
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
            <h4>Quản lý nhân viên</h4>

            <p>
            </p>
            <table class=""table"" border=""1"">
              <tr style=""background-color:gray"">
                <th>
                  Tên nhân viên
                </th>
                <th width=""200px"">
                  Email
                </th>
                <th width=""250px"">
                  SĐT
                </th>
                <th width=""2");
            WriteLiteral(@"50px"">
                  Địa chỉ
                </th>
                <th width=""250px"">
                  Password
                </th>
                <th width=""250px"">
                  Quyền
                </th>
              </tr>
            </table>
          </div>

          <!-- /.card-footer-->
        </div>
        <!-- /.card -->
      </div>
    </div>
  </div>
</section>
");
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
