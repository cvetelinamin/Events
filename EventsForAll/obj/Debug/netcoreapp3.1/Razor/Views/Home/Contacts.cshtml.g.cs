#pragma checksum "D:\EventsForAll\EventsForAll\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9053a03dbe3b13a5bd4acc3a2dd5ce3980c7e8a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacts), @"mvc.1.0.view", @"/Views/Home/Contacts.cshtml")]
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
#line 1 "D:\EventsForAll\EventsForAll\Views\_ViewImports.cshtml"
using EventsForAll;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EventsForAll\EventsForAll\Views\_ViewImports.cshtml"
using EventsForAll.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9053a03dbe3b13a5bd4acc3a2dd5ce3980c7e8a4", @"/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e56a3962d72c41747ebfb150f568e78985bb7ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\EventsForAll\EventsForAll\Views\Home\Contacts.cshtml"
  
    ViewData["Title"] = "Contacts";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""contact"" class=""mapWrap"">
    <div id=""googleMap"" style=""width:100%;""></div>
    <div id=""contact-area"">
        <div class=""container"">
            <h2 class=""block_title"">Hey !!!</h2>
            <div class=""row"">
                <div class=""col-xs-12"">
                </div>
                <div class=""col-sm-6"">
                    <div class=""moreDetails"">
                        <h2 class=""con-title"">More About me</h2>
                        <p> Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatum animi repudiandae nihil aspernatur repellat temporibus doloremque sint ea laboriosam, excepturi iure inventore rerum voluptatibus, suscipit totam, sit necessitatibus. Rerum, blanditiis. </p>
                        <ul class=""address"">
                            <li><i class=""pe-7s-map-marker""></i><span>1600 Pennsylvania Ave NW,<br>Washington, DC 20500,<br>United States</span></li>
                            <li><i class=""pe-7s-mail""></i><span>example@gmail.com</");
            WriteLiteral(@"span></li>
                            <li><i class=""pe-7s-phone""></i><span>+1-202-555-0144</span></li>
                            <li><i class=""pe-7s-global""></i><span><a href=""#"">www.themewagon.com</a></span></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <h2 class=""con-title"">Contact us</h2>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9053a03dbe3b13a5bd4acc3a2dd5ce3980c7e8a45272", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" id=""user_name"" placeholder=""Enter your name"">
                        </div>
                        <div class=""form-group"">
                            <input type=""email"" class=""form-control"" id=""your_email"" placeholder=""Enter your email"">
                        </div>
                        <div class=""form-group"">
                            <textarea name=""InputMessage"" id=""user_message"" class=""form-control"" rows=""5"" required></textarea>
                        </div>

                        <button type=""submit"" class=""btn medium"">Let us know</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div><!-- container -->
    </div><!-- contact-area -->
    <div id=""social"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <ul class=""scoialinks"">
                        <li class=""normal-txt"">Find us on</li>
                        <li class=""social-icons""><a class=""facebook"" href=""#""></a></li>
                        <li class=""social-icons""><a class=""twitter"" href=""#""></a></li>
                        <li class=""social-icons""><a class=""linkedin"" href=""#""></a></li>
                        <li class=""social-icons""><a class=""google-plus"" href=""#""></a></li>
                        <li class=""social-icons""><a class=""wordpress"" href=""#""></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div><!-- social -->
</section><!-- contact -->
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
