#pragma checksum "C:\Users\BHills\GIT\hills-side-projects\CharacterCreator\CharacterCreator\Views\CharacterCreator\GenerateCharacter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afe16ecc98bfb61ac25d6914c50c2e308992ae8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CharacterCreator_GenerateCharacter), @"mvc.1.0.view", @"/Views/CharacterCreator/GenerateCharacter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CharacterCreator/GenerateCharacter.cshtml", typeof(AspNetCore.Views_CharacterCreator_GenerateCharacter))]
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
#line 1 "C:\Users\BHills\GIT\hills-side-projects\CharacterCreator\CharacterCreator\Views\_ViewImports.cshtml"
using CharacterCreator;

#line default
#line hidden
#line 2 "C:\Users\BHills\GIT\hills-side-projects\CharacterCreator\CharacterCreator\Views\_ViewImports.cshtml"
using CharacterCreator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afe16ecc98bfb61ac25d6914c50c2e308992ae8c", @"/Views/CharacterCreator/GenerateCharacter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4c8f086dd28ee7a54e35b40a864f8b79bba1323", @"/Views/_ViewImports.cshtml")]
    public class Views_CharacterCreator_GenerateCharacter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DDCharacter>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Forms/Charesult.pdf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\BHills\GIT\hills-side-projects\CharacterCreator\CharacterCreator\Views\CharacterCreator\GenerateCharacter.cshtml"
  
    ViewData["Title"] = "GenerateCharacter";

#line default
#line hidden
            BeginContext(73, 48, true);
            WriteLiteral("\r\n<h1>Character Created. Safe Travels!!</h1>\r\n\r\n");
            EndContext();
            BeginContext(349, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(353, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afe16ecc98bfb61ac25d6914c50c2e308992ae8c4169", async() => {
                BeginContext(386, 19, false);
#line 14 "C:\Users\BHills\GIT\hills-side-projects\CharacterCreator\CharacterCreator\Views\CharacterCreator\GenerateCharacter.cshtml"
                           Write(Model.CharacterName);

#line default
#line hidden
                EndContext();
                BeginContext(405, 24, true);
                WriteLiteral("\'s Character Sheet (PDF)");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DDCharacter> Html { get; private set; }
    }
}
#pragma warning restore 1591