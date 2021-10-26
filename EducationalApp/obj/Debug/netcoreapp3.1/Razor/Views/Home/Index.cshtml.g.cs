#pragma checksum "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537bb8b03b7fc7bea7d1260e3c5eefca32b941fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\_ViewImports.cshtml"
using EducationalApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\_ViewImports.cshtml"
using EducationalApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\_ViewImports.cshtml"
using EducationalApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\_ViewImports.cshtml"
using EducationalApp.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"537bb8b03b7fc7bea7d1260e3c5eefca32b941fb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b07c8b08f2bc9f8781b4b234ded0f93150216a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Read", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blogs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Главная";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h3 class=\"h3\" style=\"font-weight:400\">Статьи</h3>\r\n");
#nullable restore
#line 7 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Статьи отсутствуют</p>\r\n");
#nullable restore
#line 10 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
             foreach (var s in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card m-3\" style=\"width: 18rem; border-width: 3px \">\r\n");
#nullable restore
#line 17 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
                 if (s.Blog.ImagePath != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 498, "\"", 529, 2);
            WriteAttributeValue("", 504, "/images/", 504, 8, true);
#nullable restore
#line 19 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 512, s.Blog.ImagePath, 512, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" class=\"card-img-top p-2\">\r\n");
#nullable restore
#line 20 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img height=\"200\" src=\"/images/BlogDefault.jpg\" class=\"card-img-top p-2\">\r\n");
#nullable restore
#line 24 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\" style=\"font-weight:400\">");
#nullable restore
#line 26 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
                                                              Write(s.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h6 class=\"card-subtitle mb-2 text-muted\">Автор: ");
#nullable restore
#line 27 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
                                                                Write(s.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                    <p class=\"card-text\">");
#nullable restore
#line 29 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
                                    Write(s.Blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "537bb8b03b7fc7bea7d1260e3c5eefca32b941fb8416", async() => {
                WriteLiteral("Читать");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
                                                                  WriteLiteral(s.Blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 35 "C:\Users\Shamil\Documents\CSharpProjects\PetExamples\EducationalApp\EducationalApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591