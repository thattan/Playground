#pragma checksum "A:\Coding\Playground\Views\Pokemon\_pokemon-modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fce621b4d28a2c24add755bcaf1173d2b04a2ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon__pokemon_modal), @"mvc.1.0.view", @"/Views/Pokemon/_pokemon-modal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce621b4d28a2c24add755bcaf1173d2b04a2ab6", @"/Views/Pokemon/_pokemon-modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59166872a529f0d92d23d2469ec007d2ff65e3ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pokemon__pokemon_modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PokeApiNet.Pokemon>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"modal\" tabindex=\"-1\" role=\"dialog\" id=\"pokemon-modal\">\r\n    <div class=\"modal-dialog\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <h5 class=\"modal-title\">");
#nullable restore
#line 7 "A:\Coding\Playground\Views\Pokemon\_pokemon-modal.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""card mb-4 shadow-sm"">
                    <div class=""row d-flex justify-content-center"">
                        <img style=""height: 150px; width: 162.6px; display: block; """);
            BeginWriteAttribute("src", " src=\"", 724, "\"", 757, 1);
#nullable restore
#line 15 "A:\Coding\Playground\Views\Pokemon\_pokemon-modal.cshtml"
WriteAttributeValue("", 730, Model.Sprites.FrontDefault, 730, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img style=\"height: 150px; width: 162.6px; display: block; \"");
            BeginWriteAttribute("src", " src=\"", 845, "\"", 877, 1);
#nullable restore
#line 16 "A:\Coding\Playground\Views\Pokemon\_pokemon-modal.cshtml"
WriteAttributeValue("", 851, Model.Sprites.BackDefault, 851, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"row d-flex justify-content-center\">\r\n                        <img style=\"height: 150px; width: 162.6px; display: block; \"");
            BeginWriteAttribute("src", " src=\"", 1062, "\"", 1093, 1);
#nullable restore
#line 19 "A:\Coding\Playground\Views\Pokemon\_pokemon-modal.cshtml"
WriteAttributeValue("", 1068, Model.Sprites.FrontShiny, 1068, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img style=\"height: 150px; width: 162.6px; display: block; \"");
            BeginWriteAttribute("src", " src=\"", 1181, "\"", 1211, 1);
#nullable restore
#line 20 "A:\Coding\Playground\Views\Pokemon\_pokemon-modal.cshtml"
WriteAttributeValue("", 1187, Model.Sprites.BackShiny, 1187, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <p class=\"card-text\">");
#nullable restore
#line 23 "A:\Coding\Playground\Views\Pokemon\_pokemon-modal.cshtml"
                                        Write(Model.LocationAreaEncounters);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PokeApiNet.Pokemon> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
