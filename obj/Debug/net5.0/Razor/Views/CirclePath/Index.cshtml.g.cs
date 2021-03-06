#pragma checksum "A:\Coding\Playground\Views\CirclePath\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a775e746f2ce29a3dad4f748484fa19e5c6e74a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CirclePath_Index), @"mvc.1.0.view", @"/Views/CirclePath/Index.cshtml")]
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
#line 1 "A:\Coding\Playground\Views\_ViewImports.cshtml"
using Playground;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Coding\Playground\Views\_ViewImports.cshtml"
using Playground.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a775e746f2ce29a3dad4f748484fa19e5c6e74a", @"/Views/CirclePath/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59166872a529f0d92d23d2469ec007d2ff65e3ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CirclePath_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<title>Line Draw</title>

<style>
    body {
        width: 100%;
    }

    .line-area {
        position: relative;
        background-color: #fff;
        height: 850px;
        border: 2px solid #212529;
        border-radius: 12px;
        padding: 5px;
    }

/*    .line {
        background-color: black;
        position: absolute;
        height: 2px;
    }*/

</style>

<div class=""row"">
    <div class=""btn-group ml-1 mb-2"">
        <button class=""btn btn-primary"" id=""draw-btn"">Draw</button>
        <button class=""btn btn-secondary ml-2 clear-btn"">Clear</button>
        <button class=""btn btn-primary ml-2"" id=""exp-btn"">Explosion</button>        
    </div>
</div>
<div class=""row"">
    <div class=""col-12 line-area"">
");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/js/CirclePath.js\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
