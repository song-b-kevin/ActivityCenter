#pragma checksum "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8019db825374876be26a180d305a756931a3b862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8019db825374876be26a180d305a756931a3b862", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ActivityE>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
  
    ViewData["Title"] = "Dojo Activity Center";

#line default
#line hidden
            BeginContext(80, 172, true);
            WriteLiteral("\r\n\r\n<div class=\"border-bottom row justify-content-between p-4\">\r\n    <h1>Dojo Activity Center</h1>\r\n    <div class=\"pt-3\">\r\n        <p class=\"d-inline-block mr-4\">Welcome, ");
            EndContext();
            BeginContext(253, 17, false);
#line 10 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                                           Write(ViewBag.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(270, 15, true);
            WriteLiteral("!</p>\r\n        ");
            EndContext();
            BeginContext(285, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8019db825374876be26a180d305a756931a3b8624769", async() => {
                BeginContext(330, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(340, 498, true);
            WriteLiteral(@"
    </div>
</div>
<div class=""p-4"">
    <table class=""table table-bordered"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"">Activity</th>
                <th scope=""col"">Date and Time</th>
                <th scope=""col"">Duration</th>
                <th scope=""col"">Event Coordinator</th>
                <th scope=""col"">No. of Participants</th>
                <th scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 27 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
             foreach(var activity in Model)
            {

#line default
#line hidden
            BeginContext(898, 48, true);
            WriteLiteral("                <tr>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 946, "\"", 983, 2);
            WriteAttributeValue("", 953, "/activity/", 953, 10, true);
#line 30 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 963, activity.ActivityId, 963, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(984, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(986, 14, false);
#line 30 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                                                            Write(activity.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1000, 35, true);
            WriteLiteral("</a></td>\r\n                    <td>");
            EndContext();
            BeginContext(1036, 31, false);
#line 31 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                   Write(activity.Date.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 6, true);
            WriteLiteral(" &#64 ");
            EndContext();
            BeginContext(1074, 33, false);
#line 31 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                                                         Write(activity.Time.ToString("h:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1107, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1139, 17, false);
#line 32 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                   Write(activity.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1156, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1158, 21, false);
#line 32 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                                      Write(activity.DurationUnit);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1211, 25, false);
#line 33 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                   Write(activity.Coordinator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1268, 27, false);
#line 34 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                   Write(activity.Participants.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1295, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 35 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                     if(activity.UserId == ViewBag.User.UserId)
                    {

#line default
#line hidden
            BeginContext(1390, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1420, "\"", 1464, 3);
            WriteAttributeValue("", 1427, "/activity/", 1427, 10, true);
#line 37 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1437, activity.ActivityId, 1437, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1457, "/delete", 1457, 7, true);
            EndWriteAttribute();
            BeginContext(1465, 18, true);
            WriteLiteral(">Delete</a></td>\r\n");
            EndContext();
#line 38 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#line 41 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                         if(activity.Participants.Any(participant => participant.User == ViewBag.User))
                        {

#line default
#line hidden
            BeginContext(1687, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1721, "\"", 1764, 3);
            WriteAttributeValue("", 1728, "/activity/", 1728, 10, true);
#line 43 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1738, activity.ActivityId, 1738, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1758, "/leave", 1758, 6, true);
            EndWriteAttribute();
            BeginContext(1765, 17, true);
            WriteLiteral(">Leave</a></td>\r\n");
            EndContext();
#line 44 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                        }
                        else
                        {
                            DateTime activityStart = DateTime.Parse(activity.Date.ToString("MM/dd/yy") + " " + activity.Time.ToString("h:mm:ss tt"));
                            

#line default
#line hidden
#line 48 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                             if(activity.DurationUnit == "Hours")
                            {
                                DateTime activityEnd = DateTime.Parse(activity.Date.ToString("MM/dd/yy") + " " + activity.Time.AddHours(activity.Duration).ToString("h:mm:ss tt"));
                            }
                            else if(activity.DurationUnit == "Minutes")
                            {
                                DateTime activityEnd = DateTime.Parse(activity.Date.ToString("MM/dd/yy") + " " + activity.Time.AddMinutes(activity.Duration).ToString("h:mm:ss tt"));
                            }
                            else if(activity.DurationUnit == "Days")
                            {
                                DateTime activityEnd = DateTime.Parse(activity.Date.ToString("MM/dd/yy") + " " + activity.Time.AddDays(activity.Duration).ToString("h:mm:ss tt"));
                            }

#line default
#line hidden
#line 59 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                             

                            bool overlap = false;


#line default
#line hidden
            BeginContext(3012, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3046, "\"", 3088, 3);
            WriteAttributeValue("", 3053, "/activity/", 3053, 10, true);
#line 63 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 3063, activity.ActivityId, 3063, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 3083, "/join", 3083, 5, true);
            EndWriteAttribute();
            BeginContext(3089, 16, true);
            WriteLiteral(">Join</a></td>\r\n");
            EndContext();
#line 64 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                        }

#line default
#line hidden
#line 64 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(3155, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 67 "/Users/kevinsong/Desktop/Coding_Dojo/Exams/ActivityCenter/Views/Home/Home.cshtml"
            }

#line default
#line hidden
            BeginContext(3193, 36, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            EndContext();
            BeginContext(3229, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8019db825374876be26a180d305a756931a3b86215335", async() => {
                BeginContext(3279, 85, true);
                WriteLiteral("<button type=\"submit\" class=\"float-right btn btn-secondary\">Add New Activity</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3368, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ActivityE>> Html { get; private set; }
    }
}
#pragma warning restore 1591