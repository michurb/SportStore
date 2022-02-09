#pragma checksum "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b19c784613885a30ce1010ce9e7e5ce54bfb748f"
// <auto-generated/>
#pragma warning disable 1591
namespace SportStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\_Imports.razor"
using SportStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Products : OwningComponentBase<IStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "<thead><tr><th>ID</th><th>Nazwa</th>\r\n            <th>Kategoria</th><th>Cena</th><td></td></tr></thead>\r\n    ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 13 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
         if (ProductData?.Count() > 0) {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
             foreach (Product p in ProductData) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
#nullable restore
#line 16 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
__builder.AddContent(6, p.ProductID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                    ");
            __builder.OpenElement(8, "td");
#nullable restore
#line 17 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
__builder.AddContent(9, p.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 18 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
__builder.AddContent(12, p.Category);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 19 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
__builder.AddContent(15, p.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 22 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
                                        GetDetailsUrl(p.ProductID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                            Więcej\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 26 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
                                        GetEditUrl(p.ProductID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "\r\n                            Edutuj\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
                                             e => DeleteProduct(p)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n                            Usuń\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
             
        } else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<tr><td colspan=\"5\" class=\"text-center\">Brak produktów</td></tr>");
#nullable restore
#line 40 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddAttribute(38, "href", "/admin/products/create");
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(40, "Dodaj");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Products.razor"
       

    public IStoreRepository Repository => Service;

    public IEnumerable<Product> ProductData { get; set; }

    protected async override Task OnInitializedAsync() {
        await UpdateData();
    }

    public async Task UpdateData() {
        ProductData = await Repository.Products.ToListAsync();
    }

    public async Task DeleteProduct(Product p) {
        Repository.DeleteProduct(p);
        await UpdateData();
    }

    public string GetDetailsUrl(long id) => $"/admin/products/details/{id}";
    public string GetEditUrl(long id) => $"/admin/products/edit/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
