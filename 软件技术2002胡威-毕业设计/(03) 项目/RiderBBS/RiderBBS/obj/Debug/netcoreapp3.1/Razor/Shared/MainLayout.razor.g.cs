#pragma checksum "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb0074c91ee60ddf3fa0ffaecf9d744da20da701"
// <auto-generated/>
#pragma warning disable 1591
namespace RiderBBS.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
        .site-layout-content {
            background: #fff;
            padding: 24px;
            min-height: 280px;
        }

        .logo {
            width: 120px;
            height: 31px;
            background-color: red;
            float: left;
        }

        /*置顶按钮*/
        .ant-back-top-inner {
            height: 40px;
            width: 40px;
            line-height: 40px;
            border-radius: 4px;
            background-color: #1088e9;
            color: #fff;
            text-align: center;
            font-size: 20px;
        }
    </style>

");
            __builder.OpenComponent<AntDesign.Layout>(1);
            __builder.AddAttribute(2, "Class", "layout");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Affix>(5);
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Header>(8);
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(10, "\r\n            ");
                        __builder4.AddMarkupContent(11, "<i><h1 style=\"color:white\">RiderBBS</h1></i>\r\n            ");
                        __builder4.OpenComponent<RiderBBS.Shared.NavMenu>(12);
                        __builder4.AddAttribute(13, "Style", "margin-left: 300px;position:relative;top:-70px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(14, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Content>(17);
                __builder2.AddAttribute(18, "Style", "padding: 0 50px;margin-top:50px");
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenElement(21, "div");
                    __builder3.AddAttribute(22, "class", "site-layout-content");
                    __builder3.AddMarkupContent(23, " \r\n            ");
                    __builder3.OpenComponent<RiderBBS.MyComponent.SearchK>(24);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n            ");
#nullable restore
#line 46 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\Shared\MainLayout.razor"
__builder3.AddContent(26, Body);

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(27, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.BackTop>(29);
                    __builder3.AddAttribute(30, "Style", "margin-bottom:60px");
                    __builder3.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(32, "\r\n            ");
                        __builder4.AddMarkupContent(33, "<div class=\"ant-back-top-inner\">UP</div>\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Footer>(36);
                __builder2.AddAttribute(37, "Style", "text-align: center; ");
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(39, "Ant Design ©2018 Created by Ant UED");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
