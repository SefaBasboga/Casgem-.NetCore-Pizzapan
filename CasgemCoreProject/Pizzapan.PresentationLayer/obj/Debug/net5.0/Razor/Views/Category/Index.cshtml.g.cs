#pragma checksum "D:\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e58027f768f526f9d19cab81796c9f1fb6e92534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "D:\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.PresentationLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58027f768f526f9d19cab81796c9f1fb6e92534", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c048b2b0d912b1a24d44281a4c9620aee323d701", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pizzapan.EntityLayer.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kategori Listesi</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kategori Adı</th>\r\n        <th>Kategori Ürünleri</th>\r\n        <th>Sitede Gör</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "D:\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Category\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n            <td>");
#nullable restore
#line 21 "D:\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Category\Index.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-info\">Kategori Ürünleri</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-warning\">Sitede Gör</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 715, "\"", 763, 2);
            WriteAttributeValue("", 722, "/Category/DeleteCategory/", 722, 25, true);
#nullable restore
#line 25 "D:\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Category\Index.cshtml"
WriteAttributeValue("", 747, item.CategoryID, 747, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 828, "\"", 876, 2);
            WriteAttributeValue("", 835, "/Category/UpdateCategory/", 835, 25, true);
#nullable restore
#line 26 "D:\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Category\Index.cshtml"
WriteAttributeValue("", 860, item.CategoryID, 860, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 28 "D:\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</table>\r\n<td><a href=\"/Category/AddCategory\" class=\"btn btn-outline-primary\">Yeni Kategori Girişi</a></td>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pizzapan.EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
