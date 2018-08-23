#pragma checksum "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452d848140a2034d32f16555b93054c86b49349a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "D:\Programming\MarcStore\src\MarcStore\Views\_ViewImports.cshtml"
using MarcStore.Models;

#line default
#line hidden
#line 2 "D:\Programming\MarcStore\src\MarcStore\Views\_ViewImports.cshtml"
using MarcStore.Models.ViewModels;

#line default
#line hidden
#line 3 "D:\Programming\MarcStore\src\MarcStore\Views\_ViewImports.cshtml"
using MarcStore.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452d848140a2034d32f16555b93054c86b49349a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b4b4bac9e06ec9f825f8086c249be8058f9b3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(27, 298, true);
            WriteLiteral(@"
<h2>Your cart</h2>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Quantity</th>
            <th>Item</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 14 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
         foreach (var line in Model.Cart.Lines)
        {

#line default
#line hidden
            BeginContext(385, 58, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">");
            EndContext();
            BeginContext(444, 13, false);
#line 17 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
                                   Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(457, 45, true);
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
            EndContext();
            BeginContext(503, 17, false);
#line 18 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
                                 Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(520, 46, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
            EndContext();
            BeginContext(567, 32, false);
#line 19 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
                                  Write(line.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(599, 68, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(669, 50, false);
#line 21 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
                Write((line.Quantity * line.Product.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(720, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 24 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
                     using (Html.BeginForm("RemoveFromCart", "Cart", FormMethod.Post))
                    {

#line default
#line hidden
            BeginContext(878, 61, true);
            WriteLiteral("                        <input type=\"hidden\" name=\"ProductID\"");
            EndContext();
            BeginWriteAttribute("value", "\r\n                               value=\"", 939, "\"", 1002, 1);
#line 27 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 979, line.Product.ProductID, 979, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1003, 66, true);
            WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"returnUrl\"");
            EndContext();
            BeginWriteAttribute("value", "\r\n                               value=\"", 1069, "\"", 1125, 1);
#line 29 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1109, Model.ReturnUrl, 1109, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1126, 153, true);
            WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-block\">\r\n                            Remove\r\n                        </button>\r\n");
            EndContext();
#line 33 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1302, 44, true);
            WriteLiteral("                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 37 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1357, 154, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1512, 44, false);
#line 43 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
           Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1556, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 46 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
                 if (Cart.UnLock)
                {
                    

#line default
#line hidden
#line 48 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
                     using (Html.BeginForm("CleanCart", "Cart", FormMethod.Post))
                    {

#line default
#line hidden
            BeginContext(1755, 61, true);
            WriteLiteral("                        <input type=\"hidden\" name=\"returnUrl\"");
            EndContext();
            BeginWriteAttribute("value", "\r\n                               value=\"", 1816, "\"", 1872, 1);
#line 51 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1856, Model.ReturnUrl, 1856, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1873, 172, true);
            WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"center-block  btn btn-danger btn-sm\">\r\n                            Remove All\r\n                        </button>\r\n");
            EndContext();
#line 55 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"

                    }

#line default
#line hidden
#line 56 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2089, 117, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2206, "\"", 2229, 1);
#line 64 "D:\Programming\MarcStore\src\MarcStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2213, Model.ReturnUrl, 2213, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2230, 28, true);
            WriteLiteral(">Continue shopping</a>\r\n    ");
            EndContext();
            BeginContext(2258, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6d94cb75c1493c94250fa5d9e8207a", async() => {
                BeginContext(2330, 24, true);
                WriteLiteral("\r\n        Checkout\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2358, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
