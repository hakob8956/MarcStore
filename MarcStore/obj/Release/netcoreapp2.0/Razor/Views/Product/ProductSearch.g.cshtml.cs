#pragma checksum "D:\Programming\MarcStore\src\MarcStore\Views\Product\ProductSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e39a1bd0831b18501c7f2560896c6aa7788b051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductSearch), @"mvc.1.0.view", @"/Views/Product/ProductSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductSearch.cshtml", typeof(AspNetCore.Views_Product_ProductSearch))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e39a1bd0831b18501c7f2560896c6aa7788b051", @"/Views/Product/ProductSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b4b4bac9e06ec9f825f8086c249be8058f9b3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 26, true);
            WriteLiteral("<div id=\"searchresults\">\r\n");
            EndContext();
#line 3 "D:\Programming\MarcStore\src\MarcStore\Views\Product\ProductSearch.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#line 5 "D:\Programming\MarcStore\src\MarcStore\Views\Product\ProductSearch.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
            BeginContext(149, 36, false);
#line 7 "D:\Programming\MarcStore\src\MarcStore\Views\Product\ProductSearch.cshtml"
       Write(Html.Partial("ProductSummary", item));

#line default
#line hidden
            EndContext();
#line 7 "D:\Programming\MarcStore\src\MarcStore\Views\Product\ProductSearch.cshtml"
                                                 
        }

#line default
#line hidden
#line 8 "D:\Programming\MarcStore\src\MarcStore\Views\Product\ProductSearch.cshtml"
         
    }
    else
    {

#line default
#line hidden
            BeginContext(222, 49, true);
            WriteLiteral("       <h2 class=\"alert-warning\">Not Found</h2>\r\n");
            EndContext();
#line 13 "D:\Programming\MarcStore\src\MarcStore\Views\Product\ProductSearch.cshtml"
    }

#line default
#line hidden
            BeginContext(278, 10, true);
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591