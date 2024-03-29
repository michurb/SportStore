// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/orders")]
    public partial class Orders : OwningComponentBase<IOrderRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\urban\source\repos\SportStore\SportStore\Pages\Admin\Orders.razor"
       

    public IOrderRepository Repository => Service;

    public IEnumerable<Order> AllOrders { get; set; }
    public IEnumerable<Order> UnshippedOrders { get; set; }
    public IEnumerable<Order> ShippedOrders { get; set; }

    protected async override Task OnInitializedAsync() {
        await UpdateData();
    }

    public async Task UpdateData() {
        AllOrders = await Repository.Orders.ToListAsync();
        UnshippedOrders = AllOrders.Where(o => !o.Shipped);
        ShippedOrders = AllOrders.Where(o => o.Shipped);
    }

    public void ShipOrder(int id) => UpdateOrder(id, true);
    public void ResetOrder(int id) => UpdateOrder(id, false);
    
    private void UpdateOrder(int id, bool shipValue) {
        Order o = Repository.Orders.FirstOrDefault(o => o.OrderID == id);
        o.Shipped = shipValue;
        Repository.SaveOrder(o);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
