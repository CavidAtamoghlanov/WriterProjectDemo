#pragma checksum "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Views\Shared\Components\CategoryListDashboard\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9fcebf1f774ec6a19a1504e303f20f7c10ade2583efe823ecc4ae226f8564584"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryListDashboard/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Views\_ViewImports.cshtml"
using CoreDemoProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Views\_ViewImports.cshtml"
using CoreDemoProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
using EntityLayer.Concretes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9fcebf1f774ec6a19a1504e303f20f7c10ade2583efe823ecc4ae226f8564584", @"/Views/Shared/Components/CategoryListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9852309f3612d8a962512895afa2477f447c8fa412b239e7e0996c1584876ed3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Project Status</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Kategory Name </th>
                                <th> Status </th>
                                <th> Islemler </th>
                            </tr>
                        </thead>
                        <tbody>
                           
");
#nullable restore
#line 21 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td> ");
#nullable restore
#line 24 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                    Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 25 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                    Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td> ");
#nullable restore
#line 26 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                    Write(item.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                                    <td>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                    </td>
                                </tr>
");
#nullable restore
#line 33 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
