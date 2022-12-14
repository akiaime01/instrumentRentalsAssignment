#pragma checksum "/Users/andrew/Projects/instrumentRentals/instrumentRentals/Views/rentalAgreement/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1f21f9342f71c5be17724049009f01da699a321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_rentalAgreement_index), @"mvc.1.0.view", @"/Views/rentalAgreement/index.cshtml")]
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
#line 1 "/Users/andrew/Projects/instrumentRentals/instrumentRentals/Views/_ViewImports.cshtml"
using instrumentRentals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andrew/Projects/instrumentRentals/instrumentRentals/Views/_ViewImports.cshtml"
using instrumentRentals.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f21f9342f71c5be17724049009f01da699a321", @"/Views/rentalAgreement/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ca91fd32a2467886e308295cd76d3021d5bda4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_rentalAgreement_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<instrumentRentals.Models.rentalAgreement>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
#nullable restore
#line 4 "/Users/andrew/Projects/instrumentRentals/instrumentRentals/Views/rentalAgreement/index.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>View</h1>\n\n<div>\n    <h4>Rental Agreement List</h4>\n    <hr />\n    <d1 class=\"row\">\n        Rental Start Date: ");
#nullable restore
#line 14 "/Users/andrew/Projects/instrumentRentals/instrumentRentals/Views/rentalAgreement/index.cshtml"
                      Write(Model.rentalStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </d1>\n    <d2 class =\"row\">\n        Rented Instrument: ");
#nullable restore
#line 17 "/Users/andrew/Projects/instrumentRentals/instrumentRentals/Views/rentalAgreement/index.cshtml"
                      Write(Model.instrument.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </d2>\n    <d3 class=\"row\">\n        Customer Information:  ");
#nullable restore
#line 20 "/Users/andrew/Projects/instrumentRentals/instrumentRentals/Views/rentalAgreement/index.cshtml"
                          Write(Model.customer.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "/Users/andrew/Projects/instrumentRentals/instrumentRentals/Views/rentalAgreement/index.cshtml"
                                                    Write(Model.customer.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </d3>\n</div>\n\n<div>\n    ");
#nullable restore
#line 25 "/Users/andrew/Projects/instrumentRentals/instrumentRentals/Views/rentalAgreement/index.cshtml"
Write(Html.ActionLink("Edit", "Edit", new {/* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1f21f9342f71c5be17724049009f01da699a3215310", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<instrumentRentals.Models.rentalAgreement> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
