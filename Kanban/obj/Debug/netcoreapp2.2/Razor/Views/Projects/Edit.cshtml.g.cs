#pragma checksum "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79c6a8cae54a4796ed54f79961e91b32024155f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Edit), @"mvc.1.0.view", @"/Views/Projects/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Edit.cshtml", typeof(AspNetCore.Views_Projects_Edit))]
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
#line 1 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\_ViewImports.cshtml"
using Kanban;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79c6a8cae54a4796ed54f79961e91b32024155f5", @"/Views/Projects/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f7f928e61db042c3893e2f60280f9a262c5d52", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kanban.Models.Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 80, true);
            WriteLiteral("\r\n<div class=\"projectEdit\">\r\n\r\n  <h1><strong>Edit this project</strong></h1>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
   using (Html.BeginForm())
  {
    

#line default
#line hidden
            BeginContext(181, 40, false);
#line 13 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.HiddenFor(model => model.ProjectId));

#line default
#line hidden
            EndContext();
            BeginContext(230, 26, false);
#line 15 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.Label("Project Name"));

#line default
#line hidden
            EndContext();
            BeginContext(263, 42, false);
#line 16 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.EditorFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(309, 82, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" class=\"w3-button w3-green w3-round-large\">\r\n");
            EndContext();
#line 19 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
  }

#line default
#line hidden
            BeginContext(396, 7, true);
            WriteLiteral("\r\n  <p>");
            EndContext();
            BeginContext(404, 48, false);
#line 21 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\Projects\Edit.cshtml"
Write(Html.ActionLink("Back to project list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(452, 12, true);
            WriteLiteral("</p>\r\n</div>");
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
