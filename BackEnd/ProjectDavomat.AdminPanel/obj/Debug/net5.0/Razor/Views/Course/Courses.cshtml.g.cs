#pragma checksum "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\Course\Courses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e556be31d1908a5d146a601f45957a6bd96625d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Courses), @"mvc.1.0.view", @"/Views/Course/Courses.cshtml")]
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
#line 1 "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\_ViewImports.cshtml"
using ProjectDavomat.AdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\_ViewImports.cshtml"
using ProjectDavomat.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e556be31d1908a5d146a601f45957a6bd96625d3", @"/Views/Course/Courses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7251a478fd4fcf3af1fa194b53f8864f7d939d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Courses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addcourses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\Course\Courses.cshtml"
  
    ViewData["Title"] = "Course Page";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row blok mt-5"">
        <div class=""col-xs-11"">
            <div class=""box data-table"">
                <div class=""box-header position-relative table-header mt-2"">
                    <div class=""d-flex justify-content-between mt-3 mx-4 com-header"">
                        <h3>Course</h3>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e556be31d1908a5d146a601f45957a6bd96625d34295", async() => {
                WriteLiteral("\r\n                            <span class=\"btn btn-success\"><i class=\"las la-plus\"></i>Add Course</span>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                <div class=""jadval box-body table-responsive no-padding"">
                    <table class=""table table-hover"">
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Duration</th>
                            <th>TeacherId</th>
                            <th>Image</th>
                            <th>Action</th>
                        </tr>
");
#nullable restore
#line 27 "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\Course\Courses.cshtml"
                     foreach(var itam in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <tr>\r\n                            <td>");
#nullable restore
#line 30 "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\Course\Courses.cshtml"
                           Write(itam.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\Course\Courses.cshtml"
                           Write(itam.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td>
                                <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal""
                                    data-bs-target=""#infoModal"">Duration</button>

                                <!-- Modal -->
                                <div class=""modal fade"" id=""infoModal"" tabindex=""-1""
                                    aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                    <div class=""modal-dialog modal-dialog-scrollable"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""exampleModalLabel""> Full duration
                                                    </h5>
                                                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""
                                                    aria-");
            WriteLiteral("label=\"Close\"></button>\r\n                                            </div>\r\n                                            <div class=\"modal-body\">\r\n                                               ");
#nullable restore
#line 48 "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\Course\Courses.cshtml"
                                          Write(itam.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-secondary""
                                                    data-bs-dismiss=""modal"">Close</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td>");
#nullable restore
#line 58 "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\Course\Courses.cshtml"
                           Write(itam.TeacherId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 59 "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\Course\Courses.cshtml"
                           Write(itam.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""cell"">
                                <a href=""../Infos/internet_Info.html"">
                                    <span class=""btn btn-success"">Edite</span>
                                </a>
                                <button type=""button"" class=""btn btn-danger"" data-bs-toggle=""modal""
                                    data-bs-target=""#deleteModal"">Delete</button>

                                <!-- Modal -->
                                <div class=""modal fade"" id=""deleteModal"" tabindex=""-1""
                                    aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                    <div class=""modal-dialog modal-dialog-scrollable"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""exampleModalLabel"">Alert</h5>
                             ");
            WriteLiteral(@"                   <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""
                                                    aria-label=""Close""></button>
                                            </div>
                                            <div class=""modal-body"">
                                                <h4>Are you realy want delete this course?</h4>
                                            </div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-secondary""
                                                    data-bs-dismiss=""modal"">Close</button>
                                                <button type=""button"" class=""btn btn-primary"">I am sure</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            ");
            WriteLiteral("</td>\r\n                    </tr>   \r\n");
#nullable restore
#line 90 "D:\RTM-WebSite\ControlSystem\ProjectDavomat.AdminPanel\Views\Course\Courses.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div><!-- /.box-body -->\r\n            </div><!-- /.box -->\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
