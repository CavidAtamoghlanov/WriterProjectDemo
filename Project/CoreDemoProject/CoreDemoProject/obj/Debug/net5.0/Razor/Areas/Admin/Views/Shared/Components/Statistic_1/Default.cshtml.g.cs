#pragma checksum "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Areas\Admin\Views\Shared\Components\Statistic_1\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5f0145b4aa0226bda16be4a723627657d754c4d64f4a79f19b078cbb34472ef9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic_1_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic_1/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5f0145b4aa0226bda16be4a723627657d754c4d64f4a79f19b078cbb34472ef9", @"/Areas/Admin/Views/Shared/Components/Statistic_1/Default.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Components_Statistic_1_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""widget style1"">
            <div class=""row"">
                <div class=""col-4 text-center"">
                    <i class=""fa fa-trophy fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Toplam Blog Say </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 10 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Areas\Admin\Views\Shared\Components\Statistic_1\Default.cshtml"
                                     Write(ViewBag.count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 navy-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-cloud fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Today degrees </span>
                    <h2 class=""font-bold"">26'C</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 lazur-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-envelope-o fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Mesaj sayi </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 36 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Areas\Admin\Views\Shared\Components\Statistic_1\Default.cshtml"
                                     Write(ViewBag.ContactCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 yellow-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-music fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Umumi Comment Say </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 49 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Areas\Admin\Views\Shared\Components\Statistic_1\Default.cshtml"
                                     Write(ViewBag.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
