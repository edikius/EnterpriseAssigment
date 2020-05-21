#pragma checksum "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de758ded445f21151760b8cec4141427a2764355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ItemOffers), @"mvc.1.0.view", @"/Views/Account/ItemOffers.cshtml")]
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
#line 1 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\_ViewImports.cshtml"
using ItemStoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\_ViewImports.cshtml"
using ItemStoreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de758ded445f21151760b8cec4141427a2764355", @"/Views/Account/ItemOffers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"925ec19d1959473b9dc3d257772118348e9541df", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ItemOffers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemOffersModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Excellent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Good", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Poor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Bad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/account/addItemOffers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
  
    ViewData["Title"] = "Add item for sale";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
 if (Model.errorMessage != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b> ");
#nullable restore
#line 8 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
   Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n");
#nullable restore
#line 9 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Offers:</h1>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de758ded445f21151760b8cec4141427a27643556151", async() => {
                WriteLiteral(@"
    <table cellspacing=""10"">
        <tr>
            <th>
                Product
            </th>
            <th>
                Quantity
            </th>
            <th>
                Quality
            </th>
            <th>
                Price
            </th>
        </tr>

");
#nullable restore
#line 29 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
         foreach (var ItemOffer in Model.ItemOffers)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n");
#nullable restore
#line 33 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
                      
                        var ItemTypeName = "None";
                        foreach (var ItemFindName in Model.ItemTypeList)
                        {
                            if (ItemFindName.ItemTypeId.ToString() == ItemOffer.ItemTypeId) ItemTypeName = ItemFindName.Name;
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
#nullable restore
#line 40 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
               Write(ItemTypeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td> ");
#nullable restore
#line 42 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
                Write(ItemOffer.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </td>\r\n                <td> ");
#nullable restore
#line 43 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
                Write(ItemOffer.Quality);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </td>\r\n                <td> ");
#nullable restore
#line 44 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
                Write(ItemOffer.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <tr>\r\n\r\n            <td>\r\n                <label for=\"ItemType\">Choose a Item Type:</label>\r\n                <select name=\"ItemTypeId\" id=\"ItemType\">\r\n");
#nullable restore
#line 53 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
                     foreach (var ItemType in Model.ItemTypeList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de758ded445f21151760b8cec4141427a27643559375", async() => {
#nullable restore
#line 55 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
                                                        Write(ItemType.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
                           WriteLiteral(ItemType.ItemTypeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\john\Desktop\projekt\ItemStoreProject\Views\Account\ItemOffers.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </td>
            <td> <input type=""text"" name=""Quantity"" placeholder=""Quantity"" /> </td>
            <td>
                <label for=""Quality"">Choose a Quality:</label>
                <select name=""Quality"" id=""Quality"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de758ded445f21151760b8cec4141427a276435511782", async() => {
                    WriteLiteral("Excellent");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de758ded445f21151760b8cec4141427a276435513029", async() => {
                    WriteLiteral("Good");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de758ded445f21151760b8cec4141427a276435514271", async() => {
                    WriteLiteral("Poor");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de758ded445f21151760b8cec4141427a276435515513", async() => {
                    WriteLiteral("Bad");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </td>\r\n            <td> <input type=\"text\" name=\"Price\" placeholder=\"Price\" /> </td>\r\n            <td> <input type=\"submit\" name=\"submit\" value=\"Add\" /> </td>\r\n\r\n        </tr>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemOffersModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
