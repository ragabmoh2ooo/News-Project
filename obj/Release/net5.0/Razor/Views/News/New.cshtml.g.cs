#pragma checksum "C:\Users\pc\source\repos\New folder (9)\Views\News\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2216ec49c7721f45d35a6cacecd07945e7c55ee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_New), @"mvc.1.0.view", @"/Views/News/New.cshtml")]
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
#line 1 "C:\Users\pc\source\repos\New folder (9)\Views\_ViewImports.cshtml"
using Project_n9ws;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\source\repos\New folder (9)\Views\_ViewImports.cshtml"
using Project_n9ws.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\source\repos\New folder (9)\Views\_ViewImports.cshtml"
using Project_n9ws.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc\source\repos\New folder (9)\Views\_ViewImports.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pc\source\repos\New folder (9)\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2216ec49c7721f45d35a6cacecd07945e7c55ee7", @"/Views/News/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5c40e49913cc97aeb1cd64b81dd48b152bebce", @"/Views/_ViewImports.cshtml")]
    public class Views_News_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<New>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/mohsalah.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\pc\source\repos\New folder (9)\Views\News\New.cshtml"
  
    ViewData["Title"] = "New";
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-UK");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"wrapper col-md-12\">\r\n    <div class=\"section-title \">\r\n        <h2>");
#nullable restore
#line 9 "C:\Users\pc\source\repos\New folder (9)\Views\News\New.cshtml"
       Write(ViewBag.TypeNews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 12 "C:\Users\pc\source\repos\New folder (9)\Views\News\New.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row mb-3\">\r\n                <div class=\"col-lg-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2216ec49c7721f45d35a6cacecd07945e7c55ee75912", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-8 pt-4 pt-lg-0 content\">\r\n                    <h2 class=\"m-2\">");
#nullable restore
#line 20 "C:\Users\pc\source\repos\New folder (9)\Views\News\New.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;<span style=\"font-size:.9rem\">");
#nullable restore
#line 20 "C:\Users\pc\source\repos\New folder (9)\Views\News\New.cshtml"
                                                                              Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                    <p style=\"font-size:1.7rem;line-height:2.9rem\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\pc\source\repos\New folder (9)\Views\News\New.cshtml"
                   Write(item.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <div class=""d-flex justify-content-between  mt-2 mb-2"">

                        <a class=""like"">

                            <i class=""fas fa-thumbs-up Add""></i> <input class=""qty1"" name=""qty1"" readonly=""readonly"" type=""text"" value=""0"" />
                        </a>
                        <a class=""dislike"">

                            <i class=""fas fa-thumbs-down Add""></i> <input class=""qty2"" name=""qty2"" readonly=""readonly"" type=""text"" value=""0"" />
                        </a>

                    </div>
                </div>
            </div>
");
#nullable restore
#line 38 "C:\Users\pc\source\repos\New folder (9)\Views\News\New.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n");
#nullable restore
#line 43 "C:\Users\pc\source\repos\New folder (9)\Views\News\New.cshtml"
Write(await Html.PartialAsync("_CommentsPartialView", new UserCommentsViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\pc\source\repos\New folder (9)\Views\News\New.cshtml"
Write(Component.InvokeAsync("Comment"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<New>> Html { get; private set; }
    }
}
#pragma warning restore 1591
