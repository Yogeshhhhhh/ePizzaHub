#pragma checksum "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b2b0834e5b0f833b8101de9193566780b945fb1fb950f5f47071fc3d3cbae26f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.Repositories.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizzaHub.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b2b0834e5b0f833b8101de9193566780b945fb1fb950f5f47071fc3d3cbae26f", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ed0b923b6383c8fca47e496ca6ab3aecc25b0fd1fad0bbdb791ba43726b9e123", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Dashboard_Index : ePizzaHub.WebUI.Helpers.BaseViewPage<PagingListModel<OrderModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Order List</h2>\r\n");
#nullable restore
#line 10 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
 if (Model != null && Model.TotalRows > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Id
                </th>
                <th>
                    PaymentId
                </th>
                <th>
                    Amount
                </th>
                <th>
                    Locality
                </th>
                <th>
                    CreatedDate
                </th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
             foreach (var item in Model.Data)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PaymentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ₹");
#nullable restore
#line 44 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.GrandTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Locality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"6\" style=\"padding-bottom: 10px;\">\r\n                    ");
#nullable restore
#line 59 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(Html.PagedListPager((IPagedList)Model.Data,
                            page => Url.Action("Index", new
                            {
                                page = page,
                                pageSize = Model.PageSize
                             }), PagedListRenderOptions.OnlyShowFivePagesAtATime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 69 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-12 mt-4\">\r\n            <p style=\"min-height:300px\">\r\n                There is no order received!\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 79 "D:\Projects\ePizza\ePizzaHub7-Final\ePizzaHub.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingListModel<OrderModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
