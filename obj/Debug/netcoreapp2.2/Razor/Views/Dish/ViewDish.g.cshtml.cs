#pragma checksum "C:\Users\cyxru\Desktop\CSharp\CRUDelicious\Views\Dish\ViewDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a32ab6275accaecb663d696e6a9c1d52c53eaf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_ViewDish), @"mvc.1.0.view", @"/Views/Dish/ViewDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dish/ViewDish.cshtml", typeof(AspNetCore.Views_Dish_ViewDish))]
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
#line 1 "C:\Users\cyxru\Desktop\CSharp\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 1 "C:\Users\cyxru\Desktop\CSharp\CRUDelicious\Views\Dish\ViewDish.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a32ab6275accaecb663d696e6a9c1d52c53eaf1", @"/Views/Dish/ViewDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_ViewDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(48, 10, false);
#line 4 "C:\Users\cyxru\Desktop\CSharp\CRUDelicious\Views\Dish\ViewDish.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(58, 16, true);
            WriteLiteral("</h1>\r\n<p>Chef: ");
            EndContext();
            BeginContext(75, 10, false);
#line 5 "C:\Users\cyxru\Desktop\CSharp\CRUDelicious\Views\Dish\ViewDish.cshtml"
    Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(85, 20, true);
            WriteLiteral("</p>\r\n<p>Tastiness: ");
            EndContext();
            BeginContext(106, 15, false);
#line 6 "C:\Users\cyxru\Desktop\CSharp\CRUDelicious\Views\Dish\ViewDish.cshtml"
         Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(121, 19, true);
            WriteLiteral("</p>\r\n<p>Calories: ");
            EndContext();
            BeginContext(141, 14, false);
#line 7 "C:\Users\cyxru\Desktop\CSharp\CRUDelicious\Views\Dish\ViewDish.cshtml"
        Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(155, 22, true);
            WriteLiteral("</p>\r\n<p>Description: ");
            EndContext();
            BeginContext(178, 17, false);
#line 8 "C:\Users\cyxru\Desktop\CSharp\CRUDelicious\Views\Dish\ViewDish.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(195, 10, true);
            WriteLiteral("</p>\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 205, "\"", 232, 2);
            WriteAttributeValue("", 212, "delete/", 212, 7, true);
#line 10 "C:\Users\cyxru\Desktop\CSharp\CRUDelicious\Views\Dish\ViewDish.cshtml"
WriteAttributeValue("", 219, Model.DishId, 219, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(233, 20, true);
            WriteLiteral(">Delete</a> <br>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 253, "\"", 282, 2);
            WriteAttributeValue("", 260, "editdish/", 260, 9, true);
#line 11 "C:\Users\cyxru\Desktop\CSharp\CRUDelicious\Views\Dish\ViewDish.cshtml"
WriteAttributeValue("", 269, Model.DishId, 269, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(283, 63, true);
            WriteLiteral(">Edit</a> <br>\r\n<a href=\"createdish\">Create a new dish</a> <br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591