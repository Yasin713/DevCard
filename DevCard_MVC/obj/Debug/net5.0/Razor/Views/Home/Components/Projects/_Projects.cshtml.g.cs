#pragma checksum "C:\Users\Mehdi\source\repos\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b489fd773f9067cdd910fd1e940453b1efc3c1bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Projects__Projects), @"mvc.1.0.view", @"/Views/Home/Components/Projects/_Projects.cshtml")]
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
#line 1 "C:\Users\Mehdi\source\repos\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehdi\source\repos\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b489fd773f9067cdd910fd1e940453b1efc3c1bb", @"/Views/Home/Components/Projects/_Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520493a69a7d20751d0e9831363d66b394bf2f41", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Components_Projects__Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container\">\r\n\t\t\t\t<h2 class=\"section-title font-weight-bold mb-5\">خاص ترین پروژه ها</h2>\r\n\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\Mehdi\source\repos\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
                      
						foreach(var project in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-md-6 mb-5\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"card project-card\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"row no-gutters\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-lg-4 card-img-holder\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b489fd773f9067cdd910fd1e940453b1efc3c1bb4602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 394, "~/assets/images/project/", 394, 24, true);
#nullable restore
#line 12 "C:\Users\Mehdi\source\repos\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
AddHtmlAttributeValue("", 418, project.Image, 418, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-lg-8\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<h5 class=\"card-title\"><a href=\"project.html\" class=\"theme-link\">");
#nullable restore
#line 16 "C:\Users\Mehdi\source\repos\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
                                                                                                                    Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\Mehdi\source\repos\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
                                                                        Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"card-text\"><small class=\"text-muted\">Client: Google</small></p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 24 "C:\Users\Mehdi\source\repos\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
						}
					

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591