// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RiderBBS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using RiderBBS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using RiderBBS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using RiderBBS.MyPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using RiderBBS.MyComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\_Imports.razor"
using UEditor.Core.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\Pages\FetchData.razor"
using RiderBBS.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
