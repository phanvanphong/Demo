#pragma checksum "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa7d2aba6fdec03a454fdd6bcfd991f45a1193e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\_ViewImports.cshtml"
using DemoDotNet5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\_ViewImports.cshtml"
using DemoDotNet5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa7d2aba6fdec03a454fdd6bcfd991f45a1193e9", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"906744715971c90226ceeb223efdb4d38725c44e", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemoDotNet5.ViewModel.CategoryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure ?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"    <style>
        /*Css pagination*/
        .page-item.active .page-link {
            color: #fff;
            background-color: #343a40;
            border-color: #343a40;
        }
        .page-link {
            color: #343a40;
            background-color: #fff;
        }
    </style>
");
            WriteLiteral("\r\n<div class=\"container p-3\">\r\n    <div class=\"row pt-4\">\r\n        <div class=\"col-8\">\r\n            <h2 class=\"text-dark\">Category List</h2>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            <div class=\"form-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa7d2aba6fdec03a454fdd6bcfd991f45a1193e97243", async() => {
                WriteLiteral("\r\n                    <div class=\"input-group\">\r\n                        <input type=\"text\" name=\"search\" class=\"form-control\" placeholder=\"Search Category Name\">\r\n                        <input type=\"hidden\" name=\"pageSize\"");
                BeginWriteAttribute("value", " value=\"", 881, "\"", 906, 1);
#nullable restore
#line 28 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 889, ViewBag.pageSize, 889, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        <div class=""input-group-append"">
                            <button class=""btn btn-secondary"" type=""submit"">
                                Search
                            </button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
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
    </div>

    <br /><br />
    <table class=""table"">
        <thead>
            <tr>
                <th>Category Name</th>
                <th>Description</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 50 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
             if (Model.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 55 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                       Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                       Write(obj.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa7d2aba6fdec03a454fdd6bcfd991f45a1193e911143", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                                                           WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa7d2aba6fdec03a454fdd6bcfd991f45a1193e913613", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                                                                                                      WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 62 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr colspan=\"3\">No Category exists.</tr>\r\n");
#nullable restore
#line 67 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <div class=\"row\">\r\n    <div class=\"col-2\">\r\n        <div class=\"form-group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa7d2aba6fdec03a454fdd6bcfd991f45a1193e917057", async() => {
                WriteLiteral("\r\n                <div class=\"input-group\">\r\n                    <input type=\"number\" name=\"pageSize\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2570, "\"", 2595, 1);
#nullable restore
#line 76 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 2578, ViewBag.pageSize, 2578, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\">\r\n                    <input type=\"hidden\" name=\"search\"");
                BeginWriteAttribute("value", " value=\"", 2661, "\"", 2684, 1);
#nullable restore
#line 77 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 2669, ViewBag.search, 2669, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    <div class=""input-group-append"">
                        <button class=""btn btn-dark"" type=""submit"">
                            OK
                        </button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-9\">\r\n         <ul class=\"pagination justify-content-end\">\r\n");
#nullable restore
#line 90 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
          
            int totalPages = ViewBag.totalPages;
            int currentPage = ViewBag.currentPage;
            string search = ViewBag.search;
            int pageSize = ViewBag.pageSize;
            int totalItems = ViewBag.totalItems;
            
            
            // Hiển thị nút < nếu pageCurrent lớn hơn 1 và ngược lại thỳ sẽ gán thuộc tính disabled
            if (currentPage > 1)
            {
                int previousPage = currentPage - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link active\"");
            BeginWriteAttribute("href", " href=\"", 3613, "\"", 3680, 6);
            WriteAttributeValue("", 3620, "?currentPage=", 3620, 13, true);
#nullable restore
#line 102 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 3633, previousPage, 3633, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3646, "&search=", 3646, 8, true);
#nullable restore
#line 102 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 3654, search, 3654, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3661, "&pageSize=", 3661, 10, true);
#nullable restore
#line 102 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 3671, pageSize, 3671, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">❮</a></li>\r\n");
#nullable restore
#line 103 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link active\" disabled>❮</a></li>\r\n");
#nullable restore
#line 107 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
            }

            // Hiển thị các page nếu page nào đang hiển thị sẽ để trạng thái active
            int i;
            for (i = 1; i <= totalPages; i++)
            {
                if (i == currentPage)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4140, "\"", 4196, 6);
            WriteAttributeValue("", 4147, "?currentPage=", 4147, 13, true);
#nullable restore
#line 115 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 4160, i, 4160, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4162, "&search=", 4162, 8, true);
#nullable restore
#line 115 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 4170, search, 4170, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4177, "&pageSize=", 4177, 10, true);
#nullable restore
#line 115 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 4187, pageSize, 4187, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 115 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 116 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><a");
            BeginWriteAttribute("id", " id=\"", 4315, "\"", 4320, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4339, "\"", 4395, 6);
            WriteAttributeValue("", 4346, "?currentPage=", 4346, 13, true);
#nullable restore
#line 119 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 4359, i, 4359, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4361, "&search=", 4361, 8, true);
#nullable restore
#line 119 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 4369, search, 4369, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4376, "&pageSize=", 4376, 10, true);
#nullable restore
#line 119 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 4386, pageSize, 4386, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 119 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 120 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                }
            }

            // Hiển thị nút > nếu pageCurrent lớn hơn 0 và pageCurrent < totalPages ngược lại thỳ sẽ gán thuộc tính disabled
            if (currentPage > 0 && currentPage < totalPages)
            {
                int nextPage = currentPage + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link active\"");
            BeginWriteAttribute("href", " href=\"", 4763, "\"", 4826, 6);
            WriteAttributeValue("", 4770, "?currentPage=", 4770, 13, true);
#nullable restore
#line 127 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 4783, nextPage, 4783, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4792, "&search=", 4792, 8, true);
#nullable restore
#line 127 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 4800, search, 4800, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4807, "&pageSize=", 4807, 10, true);
#nullable restore
#line 127 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
WriteAttributeValue("", 4817, pageSize, 4817, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">❯</a></li>\r\n");
#nullable restore
#line 128 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link active\" disabled>❯</a></li>\r\n");
#nullable restore
#line 132 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n         <div>\r\n         </div>\r\n    </div>\r\n    <div class=\"col-sm-1\">\r\n        <button class=\"btn btn-warning\" disabled>Total ");
#nullable restore
#line 139 "D:\ASP.NETCORE5\AspNetMvc\DemoDotNet5\Views\Category\Index.cshtml"
                                                  Write(totalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa7d2aba6fdec03a454fdd6bcfd991f45a1193e928084", async() => {
                WriteLiteral("\r\n            Insert\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DemoDotNet5.ViewModel.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591