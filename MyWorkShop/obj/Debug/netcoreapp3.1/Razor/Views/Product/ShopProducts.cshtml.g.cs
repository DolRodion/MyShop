#pragma checksum "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f86ac0641cea723d5fbd9defc111422f8d23fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShopProducts), @"mvc.1.0.view", @"/Views/Product/ShopProducts.cshtml")]
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
#line 1 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\_ViewImports.cshtml"
using MyWorkShop;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f86ac0641cea723d5fbd9defc111422f8d23fc", @"/Views/Product/ShopProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3aba8f9267e87ad298b2b4ff5acc2860117209", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShopProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Product/ShopProducts"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <h2> ???????????? </h2>\r\n    <br />\r\n    <br />\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f86ac0641cea723d5fbd9defc111422f8d23fc4244", async() => {
                WriteLiteral("\r\n        <h3> ?????????????? </h3>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm\">\r\n                <select class=\"standart\" name=\"Manufacturer\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f86ac0641cea723d5fbd9defc111422f8d23fc4690", async() => {
                    WriteLiteral("???? ??????????????");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                      
                        foreach (var item in ViewBag.Manufacturer)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f86ac0641cea723d5fbd9defc111422f8d23fc6054", async() => {
#nullable restore
#line 15 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>
            <div class=""col-sm"">
                <span><input placeholder=""????"" class=""numberSize"" type=""number"" name=""PriceFrom""/> - <input placeholder=""????"" class=""numberSize"" type=""number"" name=""PriceBefore"" /></span>
            </div>
            <div class=""col-sm"">
                <span class=""checkVal""><input type=""checkbox"" name=""Avaliable"" value=""true""> - ?? ??????????????</span>
                <input style=""width: 50%;"" type=""submit"" class=""btn btn-success standart"" value=""??????????????"" />
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <hr />\r\n\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 34 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                  
                    foreach (var item in ViewBag.Petyh)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                   Write(Html.Raw("<div class=\"col-sm-3 productContainer\">"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                   Write(Html.Raw("<div>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>  ");
#nullable restore
#line 39 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                         Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n");
#nullable restore
#line 40 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                        if (@item.FilePatch == string.Empty)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"/img/404.jpg\" alt=\"Sample Image\" />\r\n");
#nullable restore
#line 43 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 1774, "\"", 1795, 1);
#nullable restore
#line 46 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
WriteAttributeValue("", 1780, item.FilePatch, 1780, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Sample Image\" />\r\n");
#nullable restore
#line 47 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                        }



#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"color: silver;\"><b>");
#nullable restore
#line 50 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                                                Write(item.ManufacturerProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>  </p>\r\n");
#nullable restore
#line 51 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                        if (@item.Discount != 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p> <b> ????????: </b> ");
#nullable restore
#line 53 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                                          Write(item.PriceProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??. <span class=\"Disc\">???????????? : ");
#nullable restore
#line 53 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                                                                                            Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % </span></p>\r\n");
#nullable restore
#line 54 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p> <b> ????????: </b> ");
#nullable restore
#line 57 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                                          Write(item.PriceProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??. </p>\r\n");
#nullable restore
#line 58 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                        }


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p> <b> ?????? ????????????: </b> ");
#nullable restore
#line 60 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                                            Write(item.TypeProdycts);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 61 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                        if (@item.IsAvaliable)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>??????????????????: <b style=\"color: darkgreen;\">?? ??????????????</b></p>\r\n");
#nullable restore
#line 64 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>??????????????????: <b style=\"color: red;\">???? ?? ??????????????</b></p>\r\n");
#nullable restore
#line 68 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f86ac0641cea723d5fbd9defc111422f8d23fc15280", async() => {
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"??????????????????\" class=\"btn btn-warning\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2840, "/Product/ViewShopProduct/", 2840, 25, true);
#nullable restore
#line 70 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
AddHtmlAttributeValue("", 2865, item.Id, 2865, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                   Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                   Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\User\source\repos\MyWorkShop\MyWorkShop\Views\Product\ShopProducts.cshtml"
                                           
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n</div>\r\n");
            WriteLiteral(@"        <style scoped>

            .row .productContainer {
                position: relative;
                margin-bottom: 20px;
                padding: 0 10px;
            }

                .row .productContainer div {
                    border: 1px solid silver;
                    padding: 5px 10px;
                }

                    .row .productContainer div p {
                        margin: 0;
                        padding: 0;
                        line-height: 1.5;
                    }

                .row .productContainer img {
                    height: 220px;
                    width: 100%;
                }

                .row .productContainer h3 {
                    text-align: center;
                }

            .Disc {
                background-color: yellow;
                color: red;
                padding: 3px;
                font-weight: bold;
            }

            .numberSize {
                width: 47%;
          ");
            WriteLiteral(@"      height: 38px;
                text-indent: 10px;
            }

            .standart {
                width:100%;
                height: 38px;
                font-size: 16px;
            }

            .checkVal{
                font-size: 16px;
                margin-right:10px;
            }
            form {
                text-align: center;
            }
        </style>
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
