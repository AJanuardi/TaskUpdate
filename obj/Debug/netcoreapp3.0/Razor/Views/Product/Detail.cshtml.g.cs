#pragma checksum "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8341fe335b386816dd36f87dcf2ed9de2c835431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8341fe335b386816dd36f87dcf2ed9de2c835431", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa69464cafd4d76600b45784b8a784724c641a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Our Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 4 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\Product\Detail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<p>Is Your Favorite Isn\'t?</p>\n\n<div class=\"text-center\">\n");
#nullable restore
#line 9 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\Product\Detail.cshtml"
  
        
        var x = ViewBag.items;
        foreach (var i in x)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n                <h6>");
#nullable restore
#line 15 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\Product\Detail.cshtml"
               Write(i.nama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                <div>\n                <img");
            BeginWriteAttribute("src", " src=", 306, "", 318, 1);
#nullable restore
#line 17 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\Product\Detail.cshtml"
WriteAttributeValue("", 311, i.foto, 311, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200px\">\n                </div>\n                ");
#nullable restore
#line 19 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\Product\Detail.cshtml"
           Write(i.deskripsi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <h6>Rating: ");
#nullable restore
#line 20 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\Product\Detail.cshtml"
                       Write(i.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                <h6>Harga: Rp.");
#nullable restore
#line 21 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\Product\Detail.cshtml"
                         Write(i.harga);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                <a href=\"https://localhost:5001/Home/Add/1\">Buy it Now</a>             \n            </div> \n");
#nullable restore
#line 24 "D:\Users\bsi50130\Downloads\TaskPertama(Berhasil Delete)\Views\Product\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
