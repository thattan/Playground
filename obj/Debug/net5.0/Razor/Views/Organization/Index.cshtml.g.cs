#pragma checksum "C:\Users\tyler\Desktop\Coding2021\Playground\Views\Organization\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1deaa2de4fe366f5a6f1f3a38422d738a4638d1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organization_Index), @"mvc.1.0.view", @"/Views/Organization/Index.cshtml")]
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
#line 1 "C:\Users\tyler\Desktop\Coding2021\Playground\Views\_ViewImports.cshtml"
using Playground;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tyler\Desktop\Coding2021\Playground\Views\_ViewImports.cshtml"
using Playground.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1deaa2de4fe366f5a6f1f3a38422d738a4638d1f", @"/Views/Organization/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59166872a529f0d92d23d2469ec007d2ff65e3ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Organization_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script src=""../Scripts/Organization.js""></script>

<h1>Organizations</h1>

<div class=""row"">
    <div class=""col"">
        <table id=""OrganizationTable"" class=""display"" style=""width:100%"">
            <thead>
                <tr>
                    <th>OrganizationId</th>
                    <th>Name</th>
                    <th>Mission</th>
                    <th>Created Date</th>
                </tr>
            </thead>
        </table>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
