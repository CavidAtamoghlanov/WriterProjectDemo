#pragma checksum "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Areas\Admin\Views\Shared\Components\Statistic_2\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cfb9a94350737b9bcd487bf23dae1f9836285e5b738d301e6928d64b10e29ef9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic_2_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic_2/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cfb9a94350737b9bcd487bf23dae1f9836285e5b738d301e6928d64b10e29ef9", @"/Areas/Admin/Views/Shared/Components/Statistic_2/Default.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Components_Statistic_2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""widget navy-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">Dashboard</h1>

                <h3 class=""font-bold no-margins"">
                  MyProject
                </h3>
                <small>Proje daxilindeki Admin Paneldir bUra</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart1""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget lazur-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">  Son Eklenen bloglar</h1>

                <h3 class=""font-bold no-margins"">
                  
                    ");
#nullable restore
#line 24 "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Areas\Admin\Views\Shared\Components\Statistic_2\Default.cshtml"
               Write(ViewBag.TakeEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart2""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget yellw-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">$ 50,992</h1>

                <h3 class=""font-bold no-margins"">
                    Half-year revenue margin
                </h3>
                <small>Sales marketing.</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart3""></div>
            </div>
        </div>
    </div>
</div>");
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