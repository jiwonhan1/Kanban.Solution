#pragma checksum "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dfd222db28c5911a4b97e98cfd8b3d1d726a518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoLists_Delete), @"mvc.1.0.view", @"/Views/ToDoLists/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDoLists/Delete.cshtml", typeof(AspNetCore.Views_ToDoLists_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dfd222db28c5911a4b97e98cfd8b3d1d726a518", @"/Views/ToDoLists/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f7f928e61db042c3893e2f60280f9a262c5d52", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDoLists_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kanban.Models.ToDoList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 86, true);
            WriteLiteral("\r\n<div class=\"todolistDelete\">\r\n\r\n  <h1><strong>Delete this To Do?</strong></h1>\r\n\r\n  ");
            EndContext();
            BeginContext(150, 40, false);
#line 11 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(190, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(194, 36, false);
#line 11 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(230, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 13 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Delete.cshtml"
   using (Html.BeginForm())
  {

#line default
#line hidden
            BeginContext(268, 84, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" class=\"w3-button w3-green w3-round-large\">\r\n");
            EndContext();
#line 16 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Delete.cshtml"
  }

#line default
#line hidden
            BeginContext(357, 5, true);
            WriteLiteral("  <p>");
            EndContext();
            BeginContext(363, 46, false);
#line 17 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Delete.cshtml"
Write(Html.ActionLink("Back to To Do List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(409, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kanban.Models.ToDoList> Html { get; private set; }
    }
}
#pragma warning restore 1591
