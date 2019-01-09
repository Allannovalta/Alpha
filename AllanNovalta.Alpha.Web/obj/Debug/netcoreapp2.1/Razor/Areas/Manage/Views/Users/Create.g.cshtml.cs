#pragma checksum "C:\Users\ALLAN_Novalta\Documents\Projects\Alpha\AllanNovalta.Alpha.Web\Areas\Manage\Views\Users\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05e7eca625e6f7526e1adc5ad3cc146fdf14482d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Users_Create), @"mvc.1.0.view", @"/Areas/Manage/Views/Users/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Users/Create.cshtml", typeof(AspNetCore.Areas_Manage_Views_Users_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e7eca625e6f7526e1adc5ad3cc146fdf14482d", @"/Areas/Manage/Views/Users/Create.cshtml")]
    public class Areas_Manage_Views_Users_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllanNovalta.Alpha.Web.Areas.Manage.ViewModels.Users.CreateUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/users/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/user/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ALLAN_Novalta\Documents\Projects\Alpha\AllanNovalta.Alpha.Web\Areas\Manage\Views\Users\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(171, 26, true);
            WriteLiteral("\r\n<h2>Create User</h2>\r\n\r\n");
            EndContext();
            BeginContext(197, 2714, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0367910d541549a4a38ce87ba634e528", async() => {
                BeginContext(247, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(254, 23, false);
#line 10 "C:\Users\ALLAN_Novalta\Documents\Projects\Alpha\AllanNovalta.Alpha.Web\Areas\Manage\Views\Users\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(277, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(284, 24, false);
#line 11 "C:\Users\ALLAN_Novalta\Documents\Projects\Alpha\AllanNovalta.Alpha.Web\Areas\Manage\Views\Users\Create.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(308, 1918, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""emailAddress"">Email Address</label>
        <input type=""email"" class=""form-control"" id=""emailAddress"" asp-for=""EmailAddress"" aria-describedby=""emailAddressHelp"" placeholder=""Enter email address"">
        <small id=""emailAddressHelp"" class=""form-text text-muted"">Email Address is required.</small>
    </div>
    <div class=""form-group"">
        <label for=""password"">Password</label>
        <input type=""password"" class=""form-control"" id=""password"" asp-for=""Password"" aria-describedby=""passwordHelp"" placeholder=""Enter password"">
        <small id=""passwordHelp"" class=""form-text text-muted"">Password is required.</small>
    </div>
    <div class=""form-group"">
        <label for=""confirmPassword"">Confirm Password</label>
        <input type=""password"" class=""form-control"" id=""confirmPassword"" asp-for=""ConfirmPassword"" aria-describedby=""confirmPasswordHelp"" placeholder=""Enter password confirmation"">
        <small id=""confirmPasswordHelp"" class=""form-t");
                WriteLiteral(@"ext text-muted"">Password Confirmation is required.</small>
    </div>
    <hr />
    <div class=""form-group"">
        <label for=""firstName"">First Name</label>
        <input type=""text"" class=""form-control"" id=""firstName"" asp-for=""FirstName"" aria-describedby=""firstNameHelp"" placeholder=""Enter first name"">
        <small id=""firstNameHelp"" class=""form-text text-muted"">First name is required.</small>
    </div>
    <div class=""form-group"">
        <label for=""lastName"">Last Name</label>
        <input type=""text"" class=""form-control"" id=""lastName"" asp-for=""LastName"" aria-describedby=""lastNameHelp"" placeholder=""Enter last name"">
        <small id=""lastNameHelp"" class=""form-text text-muted"">Last name is required.</small>
    </div>
    <div class=""form-group"">
        <label for=""gender"">Gender</label>
        <select class=""form-control"" id=""gender"" asp-for=""Gender"">
");
                EndContext();
#line 41 "C:\Users\ALLAN_Novalta\Documents\Projects\Alpha\AllanNovalta.Alpha.Web\Areas\Manage\Views\Users\Create.cshtml"
              
                var options = Enum.GetValues(typeof(AllanNovalta.Alpha.Web.Infrastructure.Data.Enums.Gender)).Cast<AllanNovalta.Alpha.Web.Infrastructure.Data.Enums.Gender>();

                foreach (AllanNovalta.Alpha.Web.Infrastructure.Data.Enums.Gender option in options)
                {

#line default
#line hidden
                BeginContext(2540, 27, true);
                WriteLiteral("                    <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2567, "\"", 2582, 1);
#line 46 "C:\Users\ALLAN_Novalta\Documents\Projects\Alpha\AllanNovalta.Alpha.Web\Areas\Manage\Views\Users\Create.cshtml"
WriteAttributeValue("", 2575, option, 2575, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2583, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2585, 17, false);
#line 46 "C:\Users\ALLAN_Novalta\Documents\Projects\Alpha\AllanNovalta.Alpha.Web\Areas\Manage\Views\Users\Create.cshtml"
                                       Write(option.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2602, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 47 "C:\Users\ALLAN_Novalta\Documents\Projects\Alpha\AllanNovalta.Alpha.Web\Areas\Manage\Views\Users\Create.cshtml"
                }
            

#line default
#line hidden
                BeginContext(2647, 191, true);
                WriteLiteral("        </select>\r\n        <small id=\"genderHelp\" class=\"form-text text-muted\">Gender is required.</small>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    ");
                EndContext();
                BeginContext(2838, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d9e4c3c14094ccf928eff16bbc0b470", async() => {
                    BeginContext(2892, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
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
                EndContext();
                BeginContext(2902, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2911, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllanNovalta.Alpha.Web.Areas.Manage.ViewModels.Users.CreateUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591