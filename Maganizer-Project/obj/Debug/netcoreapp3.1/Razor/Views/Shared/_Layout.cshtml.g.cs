#pragma checksum "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c066077f5bb281419ff0e5d30dca2fe606f0b4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c066077f5bb281419ff0e5d30dca2fe606f0b4a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"453525a32fad66d68d7c3da0bc175a93fafb212f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavBarInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Maganizer WordPress Theme"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://preview.spraythemes.com/maganizer/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c066077f5bb281419ff0e5d30dca2fe606f0b4a6108", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 5 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""profile"" href=""http://gmpg.org/xfn/11"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/all.min.css"">
    <link rel=""preload""
          href=""https://fonts.googleapis.com/css?family=Poppins%3A400%2C500%2C700%7CRaleway%3A500%2C600%7CRoboto%3A100%2C100italic%2C200%2C200italic%2C300%2C300italic%2C400%2C400italic%2C500%2C500italic%2C600%2C600italic%2C700%2C700italic%2C800%2C800italic%2C900%2C900italic%7CRoboto%20Slab%3A100%2C100italic%2C200%2C200italic%2C300%2C300italic%2C400%2C400italic%2C500%2C500italic%2C600%2C600italic%2C700%2C700italic%2C800%2C800italic%2C900%2C900italic&subset=latin%2Clatin-ext&display=swap""
          as=""style"" onload=""this.onload=null;this.rel='stylesheet'"">
    <meta name=""robots"" content=""noindex,nofollow"">
    <link rel=""dns-prefetch"" href=""//fonts.googleapis.com"">
    <link rel=""alternate"" type=""application/rss+xml"" title=""Maganizer WordPress Theme");
                WriteLiteral(@" &raquo; Feed""
          href=""https://preview.spraythemes.com/maganizer/feed/"">
    <link rel=""alternate"" type=""application/rss+xml"" title=""Maganizer WordPress Theme &raquo; Comments Feed""
          href=""https://preview.spraythemes.com/maganizer/comments/feed/"">
    <link rel=""preload"" id=""wp-block-library-css""
          href=""https://preview.spraythemes.com/maganizer/wp-includes/css/dist/block-library/style.min.css"" as=""style""
          onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <link rel=""preload"" id=""wp-block-library-theme-css""
          href=""https://preview.spraythemes.com/maganizer/wp-includes/css/dist/block-library/theme.min.css"" as=""style""
          onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <link data-minify=""1"" rel=""preload"" id=""wc-block-vendors-style-css""
          href=""https://preview.spraythemes.com/maganizer/wp-content/cache/min/1/maganizer/wp-content/plugins/woocommerce/packages/woocommerce-blocks/build/ve");
                WriteLiteral(@"ndors-style-696a07b27d826107c883ee13c3bf0f1d.css""
          as=""style"" onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <link data-minify=""1"" rel=""preload"" id=""wc-block-style-css""
          href=""https://preview.spraythemes.com/maganizer/wp-content/cache/min/1/maganizer/wp-content/plugins/woocommerce/packages/woocommerce-blocks/build/style-619198ef5e47ed70e638b84c92e064f4.css""
          as=""style"" onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <link data-minify=""1"" rel=""preload"" id=""contact-form-7-css""
          href=""https://preview.spraythemes.com/maganizer/wp-content/cache/min/1/maganizer/wp-content/plugins/contact-form-7/includes/css/styles-ec4e57bff0e835ef28b4c89cb1717afb.css""
          as=""style"" onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <link data-minify=""1"" rel=""preload"" id=""woocommerce-layout-css""
          href=""https://preview.spraythemes.com/maganizer/wp-content/cache/min/1/maganizer/w");
                WriteLiteral(@"p-content/plugins/woocommerce/assets/css/woocommerce-layout-cc005ffd959c6bb1743989183a963496.css""
          as=""style"" onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <link rel=""preload"" id=""woocommerce-smallscreen-css""
          href=""https://preview.spraythemes.com/maganizer/wp-content/cache/busting/1/maganizer/wp-content/plugins/woocommerce/assets/css/woocommerce-smallscreen-5.0.0.css""
          as=""style"" onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css""
          media=""only screen and (max-width: 768px)"">
    <link data-minify=""1"" rel=""preload"" id=""woocommerce-general-css""
          href=""https://preview.spraythemes.com/maganizer/wp-content/cache/min/1/maganizer/wp-content/plugins/woocommerce/assets/css/woocommerce-cc40354525cf8823ccc9a7aae64db877.css""
          as=""style"" onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <style id=""woocommerce-inline-inline-css"" type=""text/css"">
        .woocommerce form .form-row .");
                WriteLiteral(@"required {
            visibility: visible
        }
    </style>
    <link data-minify=""1"" rel=""preload"" id=""maganizer-style-css""
          href=""https://preview.spraythemes.com/maganizer/wp-content/cache/min/1/maganizer/wp-content/themes/maganizer/style-bcc325fd19686fb7147f5ca545eac7b6.css""
          as=""style"" onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <link rel=""preload"" id=""bootstrap-css""
          href=""https://preview.spraythemes.com/maganizer/wp-content/themes/maganizer/css/bootstrap-grid.min.css""
          as=""style"" onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <link rel=""preload"" id=""owl-carousel-css""
          href=""https://preview.spraythemes.com/maganizer/wp-content/themes/maganizer/css/owl.carousel.min.css"" as=""style""
          onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <link rel=""preload"" id=""font-awesome-four-css""
          href=""https://preview.spraythemes.com/maganize");
                WriteLiteral(@"r/wp-content/themes/maganizer/css/all.min.css"" as=""style""
          onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <link data-minify=""1"" rel=""preload"" id=""maganizer-blocks-main-style-css""
          href=""https://preview.spraythemes.com/maganizer/wp-content/cache/min/1/maganizer/wp-content/themes/maganizer/css/wps_style-c4183db079b4e89a7a8d7a285e67dd35.css""
          as=""style"" onload=""this.onload=null;this.rel='stylesheet'"" type=""text/css"" media=""all"">
    <script type=""text/javascript"" src=""js/jquery.min-3.5.1.js"" id=""jquery-core-js""></script>
    <link rel=""https://api.w.org/"" href=""https://preview.spraythemes.com/maganizer/wp-json/"">
    <link rel=""alternate"" type=""application/json""
          href=""https://preview.spraythemes.com/maganizer/wp-json/wp/v2/pages/3571"">
    <link rel=""EditURI"" type=""application/rsd+xml"" title=""RSD""
          href=""https://preview.spraythemes.com/maganizer/xmlrpc.php?rsd"">
    <link rel=""wlwmanifest"" type=""application/wlwmanifest+xml");
                WriteLiteral(@"""
          href=""https://preview.spraythemes.com/maganizer/wp-includes/wlwmanifest.xml"">
    <meta name=""generator"" content=""WordPress 5.6.2"">
    <meta name=""generator"" content=""WooCommerce 5.0.0"">
    <link rel=""canonical"" href=""https://preview.spraythemes.com/maganizer/magazine-4/"">
    <link rel=""shortlink"" href=""https://preview.spraythemes.com/maganizer/?p=3571"">
    <style type=""text/css"">
        .ae_data .elementor-editor-element-setting {
            display: none !important
        }
    </style>
    <noscript>
        <style>
            .woocommerce-product-gallery {
                opacity: 1 !important
            }
        </style>
    </noscript>
    <link rel=""icon"" href=""images/cropped-01-progress-32x32.gif"" sizes=""32x32"">
    <link rel=""icon"" href=""images/cropped-01-progress-192x192.gif"" sizes=""192x192"">
    <link rel=""apple-touch-icon"" href=""images/cropped-01-progress-180x180.gif"">
    <meta name=""msapplication-TileImage""
          content=""https://preview.spraytheme");
                WriteLiteral(@"s.com/maganizer/wp-content/uploads/2020/07/cropped-01-progress-270x270.gif"">
    <script>
        /*! loadCSS rel=preload polyfill. [c]2017 Filament Group, Inc. MIT License */
        (function (w) {
            ""use strict""; if (!w.loadCSS) { w.loadCSS = function () { } }
            var rp = loadCSS.relpreload = {}; rp.support = (function () {
                var ret; try { ret = w.document.createElement(""link"").relList.supports(""preload"") } catch (e) { ret = !1 }
                return function () { return ret }
            })(); rp.bindMediaToggle = function (link) {
                var finalMedia = link.media || ""all""; function enableStylesheet() { link.media = finalMedia }
                if (link.addEventListener) { link.addEventListener(""load"", enableStylesheet) } else if (link.attachEvent) { link.attachEvent(""onload"", enableStylesheet) }
                setTimeout(function () { link.rel = ""stylesheet""; link.media = ""only x"" }); setTimeout(enableStylesheet, 3000)
            }; rp.poly = f");
                WriteLiteral(@"unction () {
                if (rp.support()) { return }
                var links = w.document.getElementsByTagName(""link""); for (var i = 0; i < links.length; i++) { var link = links[i]; if (link.rel === ""preload"" && link.getAttribute(""as"") === ""style"" && !link.getAttribute(""data-loadcss"")) { link.setAttribute(""data-loadcss"", !0); rp.bindMediaToggle(link) } }
            }; if (!rp.support()) { rp.poly(); var run = w.setInterval(rp.poly, 500); if (w.addEventListener) { w.addEventListener(""load"", function () { rp.poly(); w.clearInterval(run) }) } else if (w.attachEvent) { w.attachEvent(""onload"", function () { rp.poly(); w.clearInterval(run) }) } }
            if (typeof exports !== ""undefined"") { exports.loadCSS = loadCSS }
            else { w.loadCSS = loadCSS }
        }(typeof global !== ""undefined"" ? global : this))
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c066077f5bb281419ff0e5d30dca2fe606f0b4a17040", async() => {
                WriteLiteral("\r\n    <header class=\"main-header\">\r\n        <div class=\"very-top\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c066077f5bb281419ff0e5d30dca2fe606f0b4a17385", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"top-layer\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col logo\">\r\n                        <a>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c066077f5bb281419ff0e5d30dca2fe606f0b4a18804", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"header-search col-5\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c066077f5bb281419ff0e5d30dca2fe606f0b4a20124", async() => {
                    WriteLiteral(@"
                            <label>
                                <span class=""screen-reader-text"">Search for:</span> <input type=""search""
                                                                                           class=""search-field"" placeholder=""Search &hellip;""");
                    BeginWriteAttribute("value", " value=\"", 10119, "\"", 10127, 0);
                    EndWriteAttribute();
                    WriteLiteral(" name=\"s\" />\r\n                            </label>\r\n                            <input type=\"submit\" class=\"search-submit\" value=\"Search\" />\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n");
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <div class=\"container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n           ");
#nullable restore
#line 168 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\_Layout.cshtml"
      Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <footer id=""footer"" class=""main-footer"">
        <div data-elementor-type=""wp-post"" data-elementor-id=""2649"" class=""elementor elementor-2649"" data-elementor-settings=""[]"">
            <div class=""elementor-inner"">
                <div class=""elementor-section-wrap"">
                    <section class=""elementor-section elementor-top-section elementor-element elementor-element-f666deb elementor-section-boxed elementor-section-height-default elementor-section-height-default"" data-id=""f666deb"" data-element_type=""section"" data-settings=""{&quot;background_background&quot;:&quot;classic&quot;}"">
                        <div class=""elementor-container elementor-column-gap-default"">
                            <div class=""elementor-row"">
                                <div class=""elementor-column elementor-col-33 elementor-top-column elementor-element elementor-element-80f72fa"" data-id=""80f72fa"" data-element_type=""column"">
                                    <div class=""e");
                WriteLiteral(@"lementor-column-wrap elementor-element-populated"">
                                        <div class=""elementor-widget-wrap"">
                                            <div class=""elementor-element elementor-element-bef3c80 elementor-widget elementor-widget-logo-uploader"" data-id=""bef3c80"" data-element_type=""widget"" data-widget_type=""logo-uploader.default"">
                                                <div class=""elementor-widget-container"">
                                                    <div class=""logo-uploader"">
                                                        <a href=""https://preview.spraythemes.com/maganizer/"">
                                                            <img src=""https://preview.spraythemes.com/maganizer/wp-content/uploads/2020/12/white-1.svg"" alt=""Maganizer WordPress Theme"">
                                                        </a>
                                                    </div>
                                                </div>
            ");
                WriteLiteral(@"                                </div>
                                            <div class=""elementor-element elementor-element-fa1ea8a elementor-widget elementor-widget-text-editor"" data-id=""fa1ea8a"" data-element_type=""widget"" data-widget_type=""text-editor.default"">
                                                <div class=""elementor-widget-container"">
                                                    <div class=""elementor-text-editor elementor-clearfix"">
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""elementor-element elementor-element-cd3c29e elementor-widget elementor-widget-shortcode"" data-id=""cd3c29e"" data-element_type=""widget"" data-widget_type=""shortcode.default"">
                                                <div class=""elementor-widget-container"">
                                                    <div class=""el");
                WriteLiteral(@"ementor-shortcode""></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""elementor-column elementor-col-33 elementor-top-column elementor-element elementor-element-e8d6f71"" data-id=""e8d6f71"" data-element_type=""column"">
                                    <div class=""elementor-column-wrap elementor-element-populated"">
                                        <div class=""elementor-widget-wrap"">
                                            <div class=""elementor-element elementor-element-8d7c5ef elementor-widget elementor-widget-simple-post-list"" data-id=""8d7c5ef"" data-element_type=""widget"" data-widget_type=""simple-post-list.default"">
                                                <div class=""elementor-widget-container"">
                                                    <di");
                WriteLiteral(@"v class=""simple-post-list"">
                                                        <div class=""main-title"">
                                                            <div class=""left-side-text"">
                                                                <h2><span class=""first-class"">Editor</span><span class=""highlight"">Pic</span></h2>
                                                                <span id=""sub-text-new"" class=""sub-text-new"">Most Read post</span>
                                                            </div>
                                                            <span class=""post-counter"">
                                                                <a href=""https://preview.spraythemes.com/maganizer/category/mix-of-art/"">See All</a>
                                                            </span>
                                                        </div>
                                                        <div class=""post-content"">
                   ");
                WriteLiteral(@"                                         <div class=""left-post-list-package vertic-post-ss"">
                                                                <div class=""list-post"">
                                                                    <div class=""post-image-left"">
                                                                        <div class=""height-sizer""></div>
                                                                        <noscript data-img=""https://preview.spraythemes.com/maganizer/wp-content/uploads/2020/05/ma-in-black-aviator-sunglasses-with-purple-smoke-917594-scaled-140x100.jpg"" data-webp=""https://preview.spraythemes.com/maganizer/wp-content/uploads/2020/05/ma-in-black-aviator-sunglasses-with-purple-smoke-917594-scaled-140x100.jpg.webp"" data-alt=""Stylish man in black aviator sunglasses with purple smoke"" data-class=""attachment-maganizer-small-post-thumb size-maganizer-small-post-thumb wp-post-image"" data-height=""100"" data-width=""140"" class=""ewww_webp""><img width=""140"" he");
                WriteLiteral(@"ight=""100"" src=""https://preview.spraythemes.com/maganizer/wp-content/uploads/2020/05/ma-in-black-aviator-sunglasses-with-purple-smoke-917594-scaled-140x100.jpg"" class=""attachment-maganizer-small-post-thumb size-maganizer-small-post-thumb wp-post-image"" alt=""Stylish man in black aviator sunglasses with purple smoke"" loading=""lazy"" data-eio=""j"" /></noscript>
                                                                    </div>
                                                                    <div class=""content-section-right"">
                                                                        <div class=""post-meta-data"">
                                                                            <span class=""posted-by black"">By</span>
                                                                            <a href=""https://preview.spraythemes.com/maganizer/author/admin/"" class=""meta-links author redlink"">WPSmart</a>
                                                                           ");
                WriteLiteral(@" <span class=""meta-links post-date black placeright"">11 months ago</span>
                                                                        </div>
                                                                        <a href=""https://preview.spraythemes.com/maganizer/2020/05/30/stylish-man-in-black-aviator-sunglasses-with-purple-smoke/"">
                                                                            <h2 class=""simple-title-color"">
                                                                                Stylish man in black aviator sunglasses with purple smoke
                                                                            </h2>
                                                                        </a>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                ");
                WriteLiteral(@"        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""elementor-column elementor-col-33 elementor-top-column elementor-element elementor-element-6ad88e3"" data-id=""6ad88e3"" data-element_type=""column"">
                                    <div class=""elementor-column-wrap elementor-element-populated"">
                                        <div class=""elementor-widget-wrap"">
                                            <div class=""elementor-element elementor-element-00ae696 elementor-widget elementor-widget-all_tag_list"" data-id=""00ae696"" data-element_type=""widget"" data-widget_type=""all_tag_list.default"">
                                                <div class=""elementor-widget-container"">
              ");
                WriteLiteral(@"                                      <div id=""tags"" class=""tags-cloud"">
                                                        


                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </div>
    </footer>
    <div class=""footer-credit-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""footer-bar-set"">
                    <div class=""left-section-text"">
                        <div class=""rules"">
                            <p>
                                © 2020 <a href=""https://preview.spraythemes.com/maganizer"">Maganizer WordPress Theme</a>
         ");
                WriteLiteral(@"                   </p>
                        </div>
                        <div class=""rules"">
                            <p>
                                Design And developed By <a href=""https://spraythemes.com"">
                                    WPSmart
                                </a>
                            </p>
                        </div>
                    </div>
                    <div class=""right-side-social "">
                        <ul>
                            <li class=""back-to-top"" id=""backtotop"">
                                <i class=""fa fa-angle-double-up""></i>
                            </li>
                            <li>
                                <a href=""https://www.facebook.com/envato"">
                                    <i class=""fab fa-facebook-f""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""http://twitter.com/envato"">
   ");
                WriteLiteral(@"                                 <i class=""fab fa-twitter""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""http://youtube.com/envato"">
                                    <i class=""fab fa-youtube""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""http://instagram.com/envato"">
                                    <i class=""fab fa-instagram""></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type=""text/javascript"" src=""/js/jquery.min.js""></script>
    <script src=""/js/jquery-ui.js"" type=""text/javascript""></script>
    <link href=""/css/jquery-ui.css""
          rel=""stylesheet"" type=""text/css"" />
    <script type=""text/javascript"">");
                WriteLiteral("\n            $(document).ready(function () {\r\n                $.ajax({\r\n                    url: \'");
#nullable restore
#line 327 "D:\Study\Course 2\IT\Семестровая работа 2\Backend\Project_News_Site\Maganizer-Project\Views\Shared\_Layout.cshtml"
                     Write(Url.Action("GetTags", "Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                    type: \"GET\",\r\n                    dataType: \'html\',\r\n                    success: function (data) {\r\n                        $(\'#tags\').html(data);\r\n                    }\r\n                });\r\n            });      \r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n</html>\r\n");
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
