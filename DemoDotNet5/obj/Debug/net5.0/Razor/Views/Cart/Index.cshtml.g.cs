#pragma checksum "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bf80f4ece4a2a6ca83114d389b5642c799215c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\_ViewImports.cshtml"
using DemoDotNet5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\_ViewImports.cshtml"
using DemoDotNet5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bf80f4ece4a2a6ca83114d389b5642c799215c0", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"906744715971c90226ceeb223efdb4d38725c44e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Delete product ?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout1.cshtml";
    var carts = ViewBag.carts;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"col-lg-12 col-md-12\">\r\n    <!--shopping cart area start -->\r\n    <div class=\"shopping_cart_area\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf80f4ece4a2a6ca83114d389b5642c799215c06479", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""table_desc"">
                        <div class=""cart_page table-responsive"">
                            <table>
                                <thead>
                                    <tr>
                                        <th>Delete</th>
                                        <th class=""product_thumb"">Image</th>
                                        <th class=""product_name"">Product</th>
                                        <th class=""product-price"">Price</th>
                                        <th>Quantity</th>
                                        <th>Action</th>
                                        <th class=""product_total"">Total</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 30 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                       
                                        var total = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                     if (carts != null)
                                    {
                                     
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                         foreach (var cart in carts)
                                        {
                                            string txt_class = "quantity_" + cart.Product.Id;
                                            var totalItem = cart.Product.Price * cart.Quantity;
                                            total += totalItem;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n                                                <td class=\"product_remove\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf80f4ece4a2a6ca83114d389b5642c799215c08955", async() => {
                    WriteLiteral("<i class=\"fa fa-trash-o\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                                                                                                                                                           WriteLiteral(cart.Product.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                                <td class=\"product_thumb\"><a href=\"#\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9bf80f4ece4a2a6ca83114d389b5642c799215c011748", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2206, "~/images/", 2206, 9, true);
#nullable restore
#line 43 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 2215, cart.Product.ImageName, 2215, 23, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a></td>\r\n                                                <td class=\"product_name\"><a href=\"#\">");
#nullable restore
#line 44 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                                                                Write(cart.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                                <td class=\"product-price\">");
#nullable restore
#line 45 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                                                     Write(String.Format("{0:n0}", cart.Product.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td class=\"product_quantity\"><input type=\"number\"");
                BeginWriteAttribute("class", " class=\"", 2594, "\"", 2612, 1);
#nullable restore
#line 46 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2602, txt_class, 2602, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2613, "\"", 2635, 1);
#nullable restore
#line 46 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2621, cart.Quantity, 2621, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                                                <td><a data-id=\"");
#nullable restore
#line 47 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                                           Write(cart.Product.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"updateCart checkout_btn btn btn-dark text-white\">Update</a></td>\r\n                                                <td class=\"product_total\">");
#nullable restore
#line 48 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                                                     Write(String.Format("{0:n0}", totalItem));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <sup>VNĐ</sup></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 50 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr colspan=\"6\">\r\n                                            Your cart is currently empty\r\n                                        </tr>\r\n");
#nullable restore
#line 57 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <!--coupon code area start-->
            <div class=""coupon_area"">
                <div class=""row"">
                    <div class=""col-lg-6 col-md-6"">
                        <div class=""coupon_code"">
                            <h3>Coupon</h3>
                            <div class=""coupon_inner"">
                                <p>Enter your coupon code if you have one.</p>
                                <input placeholder=""Coupon code"" type=""text"">
                                <button type=""submit"">Apply coupon</button>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6"">
                        <div class=""coupon_code"">
                            <h3>Cart Totals</h3>
                            <div");
                WriteLiteral(" class=\"coupon_inner\">\r\n                                <div class=\"cart_subtotal\">\r\n                                    <p>Subtotal</p>\r\n                                    <p class=\"cart_amount\">");
#nullable restore
#line 83 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                                      Write(String.Format("{0:n0}", total));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <sup>VNĐ</sup></p>
                                </div>
                                <div class=""cart_subtotal "">
                                    <p>Shipping</p>
                                    <p class=""cart_amount"">Freeship</p>
                                </div>
                                <a href=""#"">Calculate shipping</a>

                                <div class=""cart_subtotal"">
                                    <p>Total</p>
                                    <p class=""cart_amount"">");
#nullable restore
#line 93 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                                      Write(String.Format("{0:n0}", total));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <sup>VNĐ</sup></p>\r\n                                </div>\r\n                                <div class=\"checkout_btn\">\r\n                                    <!-- Check xem có sản phẩm nào trong giỏ hàng chưa-->\r\n");
#nullable restore
#line 97 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                     if (carts == null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf80f4ece4a2a6ca83114d389b5642c799215c019707", async() => {
                    WriteLiteral("Back to Shopping Cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 100 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bf80f4ece4a2a6ca83114d389b5642c799215c021500", async() => {
                    WriteLiteral("Proceed to Checkout");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 104 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!--coupon code area end-->\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <!--shopping cart area end -->\r\n</div>\r\n\r\n\r\n<!-- Viết ajax gọi update -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    $(document).ready(function () {
        $("".updateCart"").click(function (event) {
            event.preventDefault();
            var quantity = $("".quantity_"" + $(this).attr(""data-id"")).val();
            console.log(quantity);
            $.ajax({
                type: ""POST"",
                url:""");
#nullable restore
#line 128 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                Write(Url.Action("UpdateCart", "Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                data: {\r\n                    productId: $(this).attr(\"data-id\"),\r\n                    quantity:quantity\r\n                },\r\n                success: function (result) {\r\n                    window.location.href = \'");
#nullable restore
#line 134 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Cart\Index.cshtml"
                                       Write(Url.Action("Index","Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                }\r\n            });\r\n        });\r\n    });\r\n    </script>\r\n\r\n");
            }
            );
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
