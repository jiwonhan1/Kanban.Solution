#pragma checksum "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1badb75d8374bf22239f6bef071c67118aed8ecf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Create), @"mvc.1.0.view", @"/Views/Projects/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Create.cshtml", typeof(AspNetCore.Views_Projects_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1badb75d8374bf22239f6bef071c67118aed8ecf", @"/Views/Projects/Create.cshtml")]
    public class Views_Projects_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kanban.Models.Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 80, true);
            WriteLiteral("\r\n<div class=\"projectCreate\">\r\n  <h1><strong>Add a new Project</strong></h1>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
   using (Html.BeginForm())
  {
    

#line default
#line hidden
            BeginContext(181, 26, false);
#line 12 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
Write(Html.Label("Project Name"));

#line default
#line hidden
            EndContext();
            BeginContext(214, 43, false);
#line 13 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
Write(Html.TextBoxFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(266, 25, false);
#line 15 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
            EndContext();
            BeginContext(298, 40, false);
#line 16 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
Write(Html.TextAreaFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(347, 27, false);
#line 18 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
Write(Html.Label("Kick Off Date"));

#line default
#line hidden
            EndContext();
            BeginContext(381, 63, false);
#line 19 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
Write(Html.TextBoxFor(model => model.KickOffDate, new {@type="date"}));

#line default
#line hidden
            EndContext();
            BeginContext(457, 22, false);
#line 21 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
Write(Html.Label("Due Date"));

#line default
#line hidden
            EndContext();
            BeginContext(486, 59, false);
#line 22 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
Write(Html.TextBoxFor(model => model.DueDate, new {@type="date"}));

#line default
#line hidden
            EndContext();
            BeginContext(547, 51, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new product\">\r\n");
            EndContext();
            BeginContext(605, 37, false);
#line 25 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
Write(Html.Label("Is this Project Active?"));

#line default
#line hidden
            EndContext();
            BeginContext(649, 51, false);
#line 26 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
Write(Html.CheckBoxFor(model => model.ActiveStatus, true));

#line default
#line hidden
            EndContext();
#line 26 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Create.cshtml"
                                                        
  }

#line default
#line hidden
            BeginContext(707, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kanban.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
