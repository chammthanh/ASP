#pragma checksum "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "448cad9d6dd9063d0a9d25e57bc08f652fdbd970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#line 1 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\_ViewImports.cshtml"
using Cake_Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\_ViewImports.cshtml"
using Cake_Store.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"448cad9d6dd9063d0a9d25e57bc08f652fdbd970", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a585b3b7e7f0c555ef684ea5c821d9ca6e16a37", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "Giỏ hàng";
    List<Cart> lstCart = ViewBag.Cart;
    var tongtien = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""breadcrumb__text"">
                    <h2>Shopping cart</h2>
                </div>
            </div>
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""breadcrumb__links"">
                    <a href=""./index.html"">Home</a>
                    <span>Shopping cart</span>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Shopping Cart Section Begin -->
<section class=""shopping-cart spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""shopping__cart__table"">
                    <table>
                        <thead>
                            <tr>
                                <th>Product</th>
                                <th>Quantity</th>
                  ");
            WriteLiteral("              <th>Total</th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 41 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
                             if (lstCart != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
                                 foreach (Cart item in lstCart)
                                {
                                    var total = item.soluong * item.price;
                                    tongtien += total;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"product__cart__item\">\r\n                                            <div class=\"product__cart__item__pic\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "448cad9d6dd9063d0a9d25e57bc08f652fdbd9707753", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1913, "~/img/shop/", 1913, 11, true);
#nullable restore
#line 50 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
AddHtmlAttributeValue("", 1924, item.Image, 1924, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"product__cart__item__text\">\r\n                                                <h6>");
#nullable restore
#line 53 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
                                               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <p>");
#nullable restore
#line 54 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
                                              Write(item.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                <h5>");
#nullable restore
#line 55 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
                                               Write(item.price.ToString("#,#"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"đ</h5>
                                            </div>
                                        </td>
                                        <td class=""quantity__item"">
                                            <div class=""quantity"">
                                                <div class=""pro-qty"">
                                                    <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 2683, "\"", 2704, 1);
#nullable restore
#line 61 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
WriteAttributeValue("", 2691, item.soluong, 2691, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                </div>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td class=\"cart__price\"> ");
#nullable restore
#line 65 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
                                                            Write(total.ToString("#,#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</td>\r\n                                        <td class=\"cart__close\"><span class=\"icon_close\"></span></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 68 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
                                 

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p> Không có sản phẩm nào trong giỏ hàng</p>\r\n");
#nullable restore
#line 75 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </tbody>
                    </table>
                </div>
                <div class=""row"">
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""continue__btn"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448cad9d6dd9063d0a9d25e57bc08f652fdbd97013219", async() => {
                WriteLiteral("Continue Shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""continue__btn update__btn"">
                            <a href=""#""><i class=""fa fa-spinner""></i> Update cart</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""cart__discount"">
                    <h6>Discount codes</h6>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448cad9d6dd9063d0a9d25e57bc08f652fdbd97015128", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" placeholder=\"Coupon code\">\r\n                        <button type=\"submit\">Apply</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"cart__total\">\r\n                    <h6>Cart total</h6>\r\n                    <ul>\r\n                        <li>Total <span>");
#nullable restore
#line 104 "D:\DOAN\ASP\DA_ASP\ASP\NguyenThiThanhTram_PhamHoangAn\Cake_Store\Cake_Store\Views\Home\Cart.cshtml"
                                   Write(tongtien.ToString("#,#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</span></li>\r\n                    </ul>\r\n                    <a href=\"#\" class=\"primary-btn\">Proceed to checkout</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
