#pragma checksum "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d2a72172b1840b43f2bebd89ebab01da1d9855a65f5752fa846bf55a0f40d235"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
#line 1 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\_ViewImports.cshtml"
using PizzaOrder;

#line default
#line hidden
#line 2 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\_ViewImports.cshtml"
using PizzaOrder.Models;

#line default
#line hidden
#line 1 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d2a72172b1840b43f2bebd89ebab01da1d9855a65f5752fa846bf55a0f40d235", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c9c8d08cc5416372879a42c3399c39714f397cbbc018788ad1aeb75f6131ee84", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaOrder.Models.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Étlap";

#line default
#line hidden
            BeginContext(120, 171, true);
            WriteLiteral("\r\n<table class=\"categoryTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n\r\n                Kategórák:\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 20 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
         foreach (var item in Model.Category)
        {

#line default
#line hidden
            BeginContext(349, 60, true);
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(409, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a72172b1840b43f2bebd89ebab01da1d9855a65f5752fa846bf55a0f40d2355355", async() => {
                BeginContext(482, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(509, 39, false);
#line 25 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(548, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                                                                        WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(574, 44, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n");
            EndContext();
#line 29 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(629, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 33 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
 foreach (var item in Model.Category)
{
    if (item.ID == Model.ActualCategory)
    {


#line default
#line hidden
            BeginContext(748, 12, true);
            WriteLiteral("        <h3>");
            EndContext();
            BeginContext(761, 9, false);
#line 38 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(770, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 39 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
    }
}

#line default
#line hidden
            BeginContext(787, 28, true);
            WriteLiteral("\r\n\r\n<tr>\r\n    <th>\r\n        ");
            EndContext();
            BeginContext(815, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a72172b1840b43f2bebd89ebab01da1d9855a65f5752fa846bf55a0f40d2359686", async() => {
                BeginContext(904, 67, true);
                WriteLiteral("\r\n            <p>\r\n                <input type=\"text\" name=\"Filter\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 971, "\"", 979, 0);
                EndWriteAttribute();
                BeginContext(980, 91, true);
                WriteLiteral(">\r\n                <input type=\"submit\" value=\"Szűrés névre\" />\r\n            </p>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                                                               WriteLiteral(Model.ActualCategory);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1078, 22, true);
            WriteLiteral("\r\n    </th>\r\n</tr>\r\n\r\n");
            EndContext();
#line 54 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
 if (Model.Menu != null)
{

#line default
#line hidden
            BeginContext(1129, 486, true);
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>

                <th>
                    Név:
                </th>
                <th>
                    Leírás:
                </th>
                <th>
                    Ár:
                </th>
                <th>
                    Csípős:
                </th>
                <th>
                    Vegetáriáus:
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 78 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
             foreach (var item in Model.Menu)
            {

#line default
#line hidden
            BeginContext(1677, 74, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1752, 39, false);
#line 83 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1871, 46, false);
#line 86 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1997, 40, false);
#line 89 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2037, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 91 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                     if (!item.Spicy)
                    {

#line default
#line hidden
            BeginContext(2128, 101, true);
            WriteLiteral("                        <td>\r\n                            <p>nem</p>\r\n                        </td>\r\n");
            EndContext();
#line 96 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2301, 122, true);
            WriteLiteral("                        <td>\r\n                            <font color=\"Red\"> igen </font>\r\n                        </td>\r\n");
            EndContext();
#line 102 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#line 103 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                     if (!item.Vegetarian)
                    {

#line default
#line hidden
            BeginContext(2513, 101, true);
            WriteLiteral("                        <td>\r\n                            <p>nem</p>\r\n                        </td>\r\n");
            EndContext();
#line 108 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2686, 124, true);
            WriteLiteral("                        <td>\r\n                            <font color=\"Green\"> igen </font>\r\n                        </td>\r\n");
            EndContext();
#line 114 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2833, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2883, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a72172b1840b43f2bebd89ebab01da1d9855a65f5752fa846bf55a0f40d23517615", async() => {
                BeginContext(3025, 63, true);
                WriteLiteral("\r\n                            Hozzáad\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 116 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                                                                            WriteLiteral(Model.ActualCategory);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 117 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
                                 WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["foodID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-foodID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["foodID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3092, 54, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 123 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3161, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 126 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
     if (Model.FailNumber == 1)
    {

#line default
#line hidden
            BeginContext(3233, 131, true);
            WriteLiteral("        <script type=\"text/javascript\">\r\n            alert(\"A kosarában maximum 20000 Ft értékű árú lehet\");\r\n\r\n        </script>\r\n");
            EndContext();
#line 132 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"

    }

#line default
#line hidden
#line 134 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
     if (Model.FailNumber == 2)
    {

#line default
#line hidden
            BeginContext(3413, 106, true);
            WriteLiteral("        <script type=\"text/javascript\">\r\n            alert(\"Hozzáadtuk a kosárhoz.\");\r\n        </script>\r\n");
            EndContext();
#line 139 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
    }

#line default
#line hidden
#line 139 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
     
}
else
{

#line default
#line hidden
            BeginContext(3538, 26, true);
            WriteLiteral("   <p>Nincs találat!</p>\r\n");
            EndContext();
#line 144 "C:\Users\milanhorvath\Desktop\alap\kész\DotNETPincer\PizzaOrder\Views\Order\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaOrder.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591