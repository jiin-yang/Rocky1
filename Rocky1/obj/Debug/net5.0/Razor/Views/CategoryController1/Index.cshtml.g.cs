#pragma checksum "C:\Users\glb90082739\source\repos\Rocky1\Rocky1\Views\CategoryController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "663f5d622ff28c946552f9f3723e969f71d87924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryController1_Index), @"mvc.1.0.view", @"/Views/CategoryController1/Index.cshtml")]
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
#line 1 "C:\Users\glb90082739\source\repos\Rocky1\Rocky1\Views\_ViewImports.cshtml"
using Rocky1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\glb90082739\source\repos\Rocky1\Rocky1\Views\_ViewImports.cshtml"
using Rocky1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663f5d622ff28c946552f9f3723e969f71d87924", @"/Views/CategoryController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00326ea78d24b8f85adc54bed0cba42929d806e2", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoryController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rocky1.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container p-3"">
    <div class=""row pt-4"">
        <div class=""col-6"">
            <h2 class=""text-primary"">Category List</h2>
        </div>
        <div class=""col-6"">
            Create New Category
        </div>
    </div>

    <br /><br />

");
#nullable restore
#line 15 "C:\Users\glb90082739\source\repos\Rocky1\Rocky1\Views\CategoryController1\Index.cshtml"
     if(Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        Category Name
                    </th>
                    <th>
                        Display Order
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "C:\Users\glb90082739\source\repos\Rocky1\Rocky1\Views\CategoryController1\Index.cshtml"
                 foreach(var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\"50%\">");
#nullable restore
#line 33 "C:\Users\glb90082739\source\repos\Rocky1\Rocky1\Views\CategoryController1\Index.cshtml"
                               Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"30%\">");
#nullable restore
#line 34 "C:\Users\glb90082739\source\repos\Rocky1\Rocky1\Views\CategoryController1\Index.cshtml"
                               Write(obj.DisplayOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td></td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\glb90082739\source\repos\Rocky1\Rocky1\Views\CategoryController1\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 40 "C:\Users\glb90082739\source\repos\Rocky1\Rocky1\Views\CategoryController1\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No category exists.</p>\r\n");
#nullable restore
#line 44 "C:\Users\glb90082739\source\repos\Rocky1\Rocky1\Views\CategoryController1\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rocky1.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591