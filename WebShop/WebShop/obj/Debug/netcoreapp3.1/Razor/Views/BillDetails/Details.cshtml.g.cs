#pragma checksum "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193229f77b76c38b10c58f06057227e4cefcd751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BillDetails_Details), @"mvc.1.0.view", @"/Views/BillDetails/Details.cshtml")]
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
#line 1 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\_ViewImports.cshtml"
using WebShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\_ViewImports.cshtml"
using WebShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193229f77b76c38b10c58f06057227e4cefcd751", @"/Views/BillDetails/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf6e511299f0cda60cf4de484793b6cb35bd75b1", @"/Views/_ViewImports.cshtml")]
    public class Views_BillDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop.Models.BillDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("no_underline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Chi tiết sản phẩm</h1>\r\n<div>\r\n    <hr class=\"mb-3\" />\r\n    <div class=\"row pb-lg-0\">\r\n        <div class=\"col-sm\">\r\n            <dl class=\"row\">\r\n\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 15 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 18 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
               Write(Html.DisplayFor(model => model.Product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 21 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Money));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 24 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
               Write(Html.DisplayFor(model => model.Money));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 27 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 30 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
               Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 33 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TotalMoney));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 36 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
               Write(Html.DisplayFor(model => model.TotalMoney));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 39 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Bill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 42 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
               Write(Html.DisplayFor(model => model.Bill.BillId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div class=\"col-sm\">\r\n            <div class=\"text-center font-weight-bold\">");
#nullable restore
#line 47 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
                                                 Write(Html.DisplayNameFor(model => model.Product.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "193229f77b76c38b10c58f06057227e4cefcd7518680", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1758, "~/images/", 1758, 9, true);
#nullable restore
#line 49 "D:\project-git\web-shop-yugioh\WebShop\WebShop\Views\BillDetails\Details.cshtml"
AddHtmlAttributeValue("", 1767, Html.DisplayFor(model => model.Product.Image), 1767, 46, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <hr class=\"mb-3\" />\r\n</div>\r\n<div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "193229f77b76c38b10c58f06057227e4cefcd75110452", async() => {
                WriteLiteral("<i class=\"fas fa-arrow-left\"></i> Về trang quản lý");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop.Models.BillDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
