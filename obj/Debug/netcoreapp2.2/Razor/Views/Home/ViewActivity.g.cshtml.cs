#pragma checksum "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56c7372a14883f5bac457e533db8678d034dabdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewActivity), @"mvc.1.0.view", @"/Views/Home/ViewActivity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewActivity.cshtml", typeof(AspNetCore.Views_Home_ViewActivity))]
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
#line 1 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 2 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56c7372a14883f5bac457e533db8678d034dabdc", @"/Views/Home/ViewActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActivityE>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "HeaderPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
  
    ViewData["Title"] = "Activity";

#line default
#line hidden
            BeginContext(62, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(66, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56c7372a14883f5bac457e533db8678d034dabdc3657", async() => {
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
            EndContext();
            BeginContext(97, 65, true);
            WriteLiteral("\r\n\r\n<div class=\"row justify-content-between pt-4 px-4\">\r\n    <h1>");
            EndContext();
            BeginContext(163, 11, false);
#line 10 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(174, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 11 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
     if(Model.UserId == ViewBag.User.UserId)
    {

#line default
#line hidden
            BeginContext(234, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 244, "\"", 285, 3);
            WriteAttributeValue("", 251, "/activity/", 251, 10, true);
#line 13 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
WriteAttributeValue("", 261, Model.ActivityId, 261, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 278, "/delete", 278, 7, true);
            EndWriteAttribute();
            BeginContext(286, 69, true);
            WriteLiteral(" class=\"pt-2\"><button class=\"btn btn-secondary\">Delete</button></a>\r\n");
            EndContext();
#line 14 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
    }
    else
    {
        

#line default
#line hidden
#line 17 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
         if(Model.Participants.Any(participant => participant.User == ViewBag.User))
        {

#line default
#line hidden
            BeginContext(476, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 490, "\"", 534, 3);
            WriteAttributeValue("", 497, "/activity/", 497, 10, true);
#line 19 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
WriteAttributeValue("", 507, Model.ActivityId, 507, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 524, "/viewleave", 524, 10, true);
            EndWriteAttribute();
            BeginContext(535, 68, true);
            WriteLiteral(" class=\"pt-2\"><button class=\"btn btn-secondary\">Leave</button></a>\r\n");
            EndContext();
#line 20 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(639, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 653, "\"", 696, 3);
            WriteAttributeValue("", 660, "/activity/", 660, 10, true);
#line 23 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
WriteAttributeValue("", 670, Model.ActivityId, 670, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 687, "/viewjoin", 687, 9, true);
            EndWriteAttribute();
            BeginContext(697, 67, true);
            WriteLiteral(" class=\"pt-2\"><button class=\"btn btn-secondary\">Join</button></a>\r\n");
            EndContext();
#line 24 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
        }

#line default
#line hidden
#line 24 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
         
    }

#line default
#line hidden
            BeginContext(782, 171, true);
            WriteLiteral("</div>\r\n<div class=\"row px-4\">\r\n    <div class=\"px-4\">\r\n        <div class=\"px-4 pt-3 row\">\r\n            <h4>Event Coordinator:</h4>\r\n            <p class=\"px-4 pt-1 m-0\">");
            EndContext();
            BeginContext(954, 22, false);
#line 31 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
                                Write(Model.Coordinator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(976, 122, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"px-2 pt-3\">\r\n            <h4>Description:</h4>\r\n            <p class=\"px-4 m-0\">");
            EndContext();
            BeginContext(1099, 17, false);
#line 35 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
                           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1116, 152, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"px-4 pt-3 row\">\r\n            <h4>Participants:</h4>\r\n            <div class=\"w-100\"></div>\r\n            <ul>\r\n");
            EndContext();
#line 41 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
                 foreach(var participant in Model.Participants)
                {

#line default
#line hidden
            BeginContext(1352, 36, true);
            WriteLiteral("                    <p class=\"mb-1\">");
            EndContext();
            BeginContext(1389, 21, false);
#line 43 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
                               Write(participant.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1410, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 44 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/ViewActivity.cshtml"
                }

#line default
#line hidden
            BeginContext(1435, 55, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityE> Html { get; private set; }
    }
}
#pragma warning restore 1591
