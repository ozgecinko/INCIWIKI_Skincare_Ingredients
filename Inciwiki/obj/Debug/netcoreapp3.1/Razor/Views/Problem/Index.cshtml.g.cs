#pragma checksum "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01d90b20a0e2f062a81ddaa9cf1de43ce140b586"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Problem_Index), @"mvc.1.0.view", @"/Views/Problem/Index.cshtml")]
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
#line 1 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\_ViewImports.cshtml"
using Inciwiki;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\_ViewImports.cshtml"
using Inciwiki.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d90b20a0e2f062a81ddaa9cf1de43ce140b586", @"/Views/Problem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be25498e2a493b2c5421ae0405af30f89690769", @"/Views/_ViewImports.cshtml")]
    public class Views_Problem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inciwiki.Controllers.IhtiyacDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <p>Adı: ");
#nullable restore
#line 6 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Index.cshtml"
           Write(item.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Icerikler: ");
#nullable restore
#line 7 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Index.cshtml"
                 Write(item.Icerikler);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\ÖZGE ÇİNKO\Desktop\Inciwiki Web Application\Inciwiki\Views\Problem\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inciwiki.Controllers.IhtiyacDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591