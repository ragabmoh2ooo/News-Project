#pragma checksum "C:\Users\pc\source\repos\New folder (9)\Views\News\TeamMember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f0c6a5761f45175bcc9d61f430aff379d7b51c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_TeamMember), @"mvc.1.0.view", @"/Views/News/TeamMember.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f0c6a5761f45175bcc9d61f430aff379d7b51c4", @"/Views/News/TeamMember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5c40e49913cc97aeb1cd64b81dd48b152bebce", @"/Views/_ViewImports.cshtml")]
    public class Views_News_TeamMember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Team>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pc\source\repos\New folder (9)\Views\News\TeamMember.cshtml"
  
    ViewData["Title"] = "TeamMember";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- ======= TeamMember Section ======= -->\r\n<section id=\"services\" class=\"services\">\r\n    <div class=\"container\" data-aos=\"fade-up\">\r\n\r\n        <div class=\"section-title\">\r\n            <h2>TeamMember</h2>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\pc\source\repos\New folder (9)\Views\News\TeamMember.cshtml"
             if (Model.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\pc\source\repos\New folder (9)\Views\News\TeamMember.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\" data-aos=\"zoom-in\" data-aos-delay=\"100\">\r\n                        <div class=\"icon-box\">\r\n                            <div class=\"icon\">");
#nullable restore
#line 19 "C:\Users\pc\source\repos\New folder (9)\Views\News\TeamMember.cshtml"
                                         Write(item.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 707, "\"", 714, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\pc\source\repos\New folder (9)\Views\News\TeamMember.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <p>");
#nullable restore
#line 21 "C:\Users\pc\source\repos\New folder (9)\Views\News\TeamMember.cshtml"
                          Write(item.JopTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 24 "C:\Users\pc\source\repos\New folder (9)\Views\News\TeamMember.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\pc\source\repos\New folder (9)\Views\News\TeamMember.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</section><!-- End Services Section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591
