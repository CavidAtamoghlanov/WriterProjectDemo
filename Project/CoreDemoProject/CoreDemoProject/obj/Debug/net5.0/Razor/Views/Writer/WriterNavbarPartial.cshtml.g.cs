#pragma checksum "C:\Users\Cavid\Documents\WriterProjectDemo\Project\CoreDemoProject\CoreDemoProject\Views\Writer\WriterNavbarPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8bd402dba074a3b450353840783262da5fa9353753011662f07d885c6bcaeba2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterNavbarPartial), @"mvc.1.0.view", @"/Views/Writer/WriterNavbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8bd402dba074a3b450353840783262da5fa9353753011662f07d885c6bcaeba2", @"/Views/Writer/WriterNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9852309f3612d8a962512895afa2477f447c8fa412b239e7e0996c1584876ed3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Writer_WriterNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/writer/assets/images/faces/face1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"sidebar sidebar-offcanvas\" id=\"sidebar\">\r\n    <ul class=\"nav\">\r\n        <li class=\"nav-item nav-profile\">\r\n            <a href=\"#\" class=\"nav-link\">\r\n                <div class=\"nav-profile-image\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8bd402dba074a3b450353840783262da5fa9353753011662f07d885c6bcaeba24414", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <span class=""login-status online""></span>
                    <!--change to offline or busy as needed-->
                </div>
                <div class=""nav-profile-text d-flex flex-column"">
                    <span class=""font-weight-bold mb-2"">David Grey. H</span>
                    <span class=""text-secondary text-small"">Project Manager</span>
                </div>
                <i class=""mdi mdi-bookmark-check text-success nav-profile-badge""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""../../index.html"">
                <span class=""menu-title"">Dashboard</span>
                <i class=""mdi mdi-home menu-icon""></i>
            </a>
        </li>
        
        <li class=""nav-item"">
            <a class=""nav-link"" href=""../../pages/icons/mdi.html"">
                <span class=""menu-title"">Profilim</span>
                <i class=""mdi mdi-contacts menu-icon""></i>
            </a>
        </li>
 ");
            WriteLiteral(@"       <li class=""nav-item"">
            <a class=""nav-link"" href=""../../pages/forms/basic_elements.html"">
                <span class=""menu-title"">Bloglarim</span>
                <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""../../pages/charts/chartjs.html"">
                <span class=""menu-title"">Yeni Blog</span>
                <i class=""mdi mdi-chart-bar menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""../../pages/tables/basic-table.html"">
                <span class=""menu-title"">Mesajlar</span>
                <i class=""mdi mdi-message menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""../../pages/tables/basic-table.html"">
                <span class=""menu-title"">Siteye Git</span>
                <i class=""mdi mdi-car menu-icon""></i>
            <");
            WriteLiteral(@"/a>
        </li>

        <li class=""nav-item"">
            <a class=""nav-link"" href=""../../pages/tables/basic-table.html"">
                <span class=""menu-title"">Ayarlar</span>
                <i class=""mdi mdi-settings menu-icon""></i>
            </a>
        </li>

        <li class=""nav-item"">
            <a class=""nav-link"" href=""../../pages/tables/basic-table.html"">
                <span class=""menu-title"">Cikis yap</span>
                <i class=""mdi mdi-logout menu-icon""></i>
            </a>
        </li>
      
    </ul>
</nav>");
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