#pragma checksum "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e6652b9974be7ba89e85662c152d29986a56b51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoLists_Details), @"mvc.1.0.view", @"/Views/ToDoLists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDoLists/Details.cshtml", typeof(AspNetCore.Views_ToDoLists_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6652b9974be7ba89e85662c152d29986a56b51", @"/Views/ToDoLists/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f7f928e61db042c3893e2f60280f9a262c5d52", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDoLists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kanban.Models.ToDoList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 96, true);
            WriteLiteral("\r\n<div class=\"todolistDetails\">\r\n\r\n  <h1><strong>Task Details</strong></h1>\r\n\r\n  <h3>About Item ");
            EndContext();
            BeginContext(160, 36, false);
#line 11 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml"
            Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(196, 36, true);
            WriteLiteral("</h3>\r\n  <hr>\r\n  <p>Work Item Name: ");
            EndContext();
            BeginContext(233, 10, false);
#line 13 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml"
                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(243, 24, true);
            WriteLiteral("</p>\r\n  <p>Description: ");
            EndContext();
            BeginContext(268, 13, false);
#line 14 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml"
             Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(281, 21, true);
            WriteLiteral("</p>\r\n  <p>Priority: ");
            EndContext();
            BeginContext(303, 14, false);
#line 15 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml"
          Write(Model.Priority);

#line default
#line hidden
            EndContext();
            BeginContext(317, 24, true);
            WriteLiteral("</p>\r\n  <p>Completed? \r\n");
            EndContext();
#line 17 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml"
     if (@Model.CheckCompletion == true)
    {

#line default
#line hidden
            BeginContext(390, 40, true);
            WriteLiteral("      <span class=\"checkmark\">✔</span>\r\n");
            EndContext();
#line 20 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml"
    }
    else 
    {

#line default
#line hidden
            BeginContext(455, 40, true);
            WriteLiteral("      <span class=\"wrongmark\">✘</span>\r\n");
            EndContext();
#line 24 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(502, 23, true);
            WriteLiteral("  </p>\r\n  <hr>\r\n\r\n  <p>");
            EndContext();
            BeginContext(526, 68, false);
#line 28 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml"
Write(Html.ActionLink("Edit To Do", "Edit", new { id = Model.ToDoListId }));

#line default
#line hidden
            EndContext();
            BeginContext(594, 11, true);
            WriteLiteral("</p>\r\n  <p>");
            EndContext();
            BeginContext(606, 72, false);
#line 29 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\Kanban.Solution\Kanban\Views\ToDoLists\Details.cshtml"
Write(Html.ActionLink("Delete To Do", "Delete", new { id = Model.ToDoListId }));

#line default
#line hidden
            EndContext();
            BeginContext(678, 18, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n  ");
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
