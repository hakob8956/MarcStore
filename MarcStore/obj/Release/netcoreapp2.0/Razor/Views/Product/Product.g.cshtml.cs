#pragma checksum "D:\Programming\MarcStore\src\MarcStore\Views\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82f0c8f23b70f3214ab498dbaad5969c1cabf354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Product), @"mvc.1.0.view", @"/Views/Product/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Product.cshtml", typeof(AspNetCore.Views_Product_Product))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82f0c8f23b70f3214ab498dbaad5969c1cabf354", @"/Views/Product/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b4b4bac9e06ec9f825f8086c249be8058f9b3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Programming\MarcStore\src\MarcStore\Views\Product\Product.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(48, 40, true);
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"h1 text-center\">");
            EndContext();
            BeginContext(89, 10, false);
#line 7 "D:\Programming\MarcStore\src\MarcStore\Views\Product\Product.cshtml"
                          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(99, 131, true);
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div class=\"pull-right\">\r\n    <h3 class=\"h3\">\r\n        <span class=\"pull-right label label-primary\">\r\n            ");
            EndContext();
            BeginContext(231, 25, false);
#line 13 "D:\Programming\MarcStore\src\MarcStore\Views\Product\Product.cshtml"
       Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(256, 50, true);
            WriteLiteral("\r\n        </span>\r\n    </h3>\r\n    <br /><br />\r\n\r\n");
            EndContext();
#line 18 "D:\Programming\MarcStore\src\MarcStore\Views\Product\Product.cshtml"
     using (Html.BeginForm("AddToCart", "Cart", FormMethod.Post, new { id = Model.ProductID }))
    {

#line default
#line hidden
            BeginContext(410, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(418, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5958d86145f94f70810b24e56ad1b82a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 20 "D:\Programming\MarcStore\src\MarcStore\Views\Product\Product.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductID);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(461, 47, true);
            WriteLiteral("\r\n        <input type=\"hidden\" name=\"returnUrl\"");
            EndContext();
            BeginWriteAttribute("value", "\r\n               value=\"", 508, "\"", 579, 1);
#line 22 "D:\Programming\MarcStore\src\MarcStore\Views\Product\Product.cshtml"
WriteAttributeValue("", 532, ViewContext.HttpContext.Request.PathAndQuery(), 532, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(580, 183, true);
            WriteLiteral(" />\r\n        <span class=\"lead\">\r\n\r\n            <button type=\"submit\" class=\"btn btn-success btn-sm pull-right\">\r\n                Add To Cart\r\n            </button>\r\n        </span>\r\n");
            EndContext();
#line 29 "D:\Programming\MarcStore\src\MarcStore\Views\Product\Product.cshtml"
    }

#line default
#line hidden
            BeginContext(770, 130, true);
            WriteLiteral("</div>\r\n<div>\r\n    <img style=\" display: inline-block;\r\n                     height: auto;\r\n                     max-width: 100%;\"");
            EndContext();
            BeginWriteAttribute("src", "\r\n         src=\"", 900, "\"", 991, 1);
#line 35 "D:\Programming\MarcStore\src\MarcStore\Views\Product\Product.cshtml"
WriteAttributeValue("", 916, Url.Action("GetImage", "Product",
               new { Model.ProductID }), 916, 75, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(992, 144, true);
            WriteLiteral(" class=\"img-fluid\" alt=\"Responsive image\">\r\n\r\n</div>\r\n<div class=\"text-justife\" style=\"margin-bottom:70px;display:inline-block;width:85%\">\r\n    ");
            EndContext();
            BeginContext(1137, 10, false);
#line 40 "D:\Programming\MarcStore\src\MarcStore\Views\Product\Product.cshtml"
Write(Model.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 1059, true);
            WriteLiteral(@";
</div>
<br />
<div id=""disqus_thread"" class=""panel-footer""></div>
<script>

    /**
    *  RECOMMENDED CONFIGURATION VARIABLES: EDIT AND UNCOMMENT THE SECTION BELOW TO INSERT DYNAMIC VALUES FROM YOUR PLATFORM OR CMS.
    *  LEARN WHY DEFINING THESE VARIABLES IS IMPORTANT: https://disqus.com/admin/universalcode/#configuration-variables*/
    /*
    var disqus_config = function () {
    this.page.url = PAGE_URL;  // Replace PAGE_URL with your page's canonical URL variable
    this.page.identifier = PAGE_IDENTIFIER; // Replace PAGE_IDENTIFIER with your page's unique identifier variable
    };
    */
    (function () { // DON'T EDIT BELOW THIS LINE
        var d = document, s = d.createElement('script');
        s.src = 'https://magazin-2.disqus.com/embed.js';
        s.setAttribute('data-timestamp', +new Date());
        (d.head || d.body).appendChild(s);
    })();
</script>
<noscript>Please enable JavaScript to view the Comments</noscript>
<script id=""dsq-count-scr"" src=""//magazin-2.dis");
            WriteLiteral("qus.com/count.js\" async></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
