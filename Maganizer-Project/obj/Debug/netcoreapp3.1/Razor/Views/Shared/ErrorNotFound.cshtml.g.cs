#pragma checksum "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\ErrorNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78a7bde4e778bd355a6cccf3fd32f3009982b762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ErrorNotFound), @"mvc.1.0.view", @"/Views/Shared/ErrorNotFound.cshtml")]
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
#line 1 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\_ViewImports.cshtml"
using Maganizer_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a7bde4e778bd355a6cccf3fd32f3009982b762", @"/Views/Shared/ErrorNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"453525a32fad66d68d7c3da0bc175a93fafb212f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ErrorNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\ErrorNotFound.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Page not found";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""error-404 not-found"">
    <div class=""container"">
        <header class=""page-header"">
            <h1 class=""page-title"">Oops! That page can&rsquo;t be found.</h1>
        </header>
        <!-- .page-header -->
        <div class=""page-content"">
            <p>It looks like nothing was found at this location.</p>
        </div>
        <!-- .page-content -->
    </div>
</section>
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