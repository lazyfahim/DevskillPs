#pragma checksum "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/Home/StudentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8590d262bf242fae3bb26299fbb16320cc8496d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StudentDetails), @"mvc.1.0.view", @"/Views/Home/StudentDetails.cshtml")]
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
#line 1 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/_ViewImports.cshtml"
using DevskillSystem.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/_ViewImports.cshtml"
using DevskillSystem.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/Home/StudentDetails.cshtml"
using DevSkillSystem.FrameWork;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8590d262bf242fae3bb26299fbb16320cc8496d3", @"/Views/Home/StudentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8383ec2e27a69ade9e94104e2486ff300d4f921a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StudentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevSkillSystem.FrameWork.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GradeInSubject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/Home/StudentDetails.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>title</h2>\n");
#nullable restore
#line 10 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/Home/StudentDetails.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 11 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/Home/StudentDetails.cshtml"
Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Enroll to Course</h3>\n\n\n<div class=\"container center_div\" style=\"width: 50rem;\">\n    <h2>Insert Student</h2>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8590d262bf242fae3bb26299fbb16320cc8496d35501", async() => {
                WriteLiteral("\n        <div class=\"form-group col-md-4\" >\n        <input data-val=\"true\" \n                     \n                    name=\"studentId\" \n                    type=\"hidden\"");
                BeginWriteAttribute("value", " \n                    value=\"", 529, "\"", 567, 1);
#nullable restore
#line 23 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/Home/StudentDetails.cshtml"
WriteAttributeValue("", 558, Model.Id, 558, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        \n\n            <label  class=\"col-md-2\">Subject Id</label>\n            <div class=\"col-md-10\">\n                <input name=\"subjectId\" class=\"form-control\"/>\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8590d262bf242fae3bb26299fbb16320cc8496d36550", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 29 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/Home/StudentDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
            <label  class=""col-md-2"">CGPA</label>
            <div class=""col-md-10"">
                <input name=""grade"" class=""form-control""/>
            </div>
        </div>
        <input class=""btn btn-primary"" type=""submit"" value=""Save"" />
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n\n<h3>Enrolled Courses</h3>\n<ul>\n");
#nullable restore
#line 44 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/Home/StudentDetails.cshtml"
 foreach (Grade grade in Model.Gardes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 46 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/Home/StudentDetails.cshtml"
   Write(grade.Subject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 47 "/home/lazyfahim/Desktop/devskilSolve/DevskillPs/DevskillSystem/DevskillSystem.web/Views/Home/StudentDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevSkillSystem.FrameWork.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
