#pragma checksum "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29f010fa4e71a3142c839104ad99a815b1e005d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
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
#line 1 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using TodoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using TodoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29f010fa4e71a3142c839104ad99a815b1e005d4", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e792f848ddb1c77f0fb0ebf2bd3f0066a55b0d7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TodoApp.Entities.TodoListItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n</style>\r\n<h1>Qu???n l?? t??c v???</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29f010fa4e71a3142c839104ad99a815b1e005d43800", async() => {
                WriteLiteral("Th??m t??c v???");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
 using (Html.BeginForm("Index", "Todo", FormMethod.Get, new { @class = "form-inline" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\" style=\"margin-bottom: 10px; margin-left: -15px\">\r\n        <input type=\"Text\" class=\"form-control mx-sm-3\"");
            BeginWriteAttribute("value", " value=\"", 470, "\"", 494, 1);
#nullable restore
#line 18 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
WriteAttributeValue("", 478, ViewBag.keyWork, 478, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"keywork\" placeholder=\"Nh???p t??c v??? c???n t??m\">\r\n");
            WriteLiteral("    </div>\r\n    <hr />\r\n");
#nullable restore
#line 22 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AddDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Status\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
         foreach (var item in @ViewBag.list2_incomplete)
        {
            if (!item.Index)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 46 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td >\r\n                        ");
#nullable restore
#line 49 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(item.AddDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 52 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                         if (item.IsCompleted)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Completed</p> ");
#nullable restore
#line 53 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>InCompleted</p>\r\n");
#nullable restore
#line 57 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { @id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 61 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { @id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 62 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(Html.ActionLink("Completed", "Completed", new { @id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 63 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(Html.ActionLink("MoveUp", "MoveUp", new { @id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 66 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 72 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(item.AddDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 78 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                         if (item.IsCompleted)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Completed</p> ");
#nullable restore
#line 79 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>InCompleted</p>\r\n");
#nullable restore
#line 83 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 86 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { @id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 87 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { @id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 88 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(Html.ActionLink("Completed", "Completed", new { @id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 89 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                   Write(Html.ActionLink("MoveDown", "MoveDown", new { @id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 92 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"

            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n<div style=\"font-weight:bold\">T??c v??? ho??n th??nh</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 108 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
         foreach (var item in @ViewBag.list1_completed)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 114 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
#nullable restore
#line 117 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
               Write(item.AddDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 120 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                     if (item.IsCompleted)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Completed</p> ");
#nullable restore
#line 121 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                                      }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>InCompleted</p>\r\n");
#nullable restore
#line 125 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 128 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { @id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 129 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { @id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 133 "C:\Users\TUAN VI\Desktop\New folder\TodoApp\ToDoApp\ToDoApp\Views\Todo\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TodoApp.Entities.TodoListItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
