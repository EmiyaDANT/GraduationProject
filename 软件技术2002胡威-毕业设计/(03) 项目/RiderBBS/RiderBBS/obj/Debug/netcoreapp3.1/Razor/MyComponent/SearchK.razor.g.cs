#pragma checksum "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\MyComponent\SearchK.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95475a981fc1a15ef5163ab3ddf9d4748ced58c"
// <auto-generated/>
#pragma warning disable 1591
namespace RiderBBS.MyComponent
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
    public partial class SearchK : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.RiderBBS.MyComponent.SearchK.TypeInference.CreateForm_0(__builder, 0, 1, 
#nullable restore
#line 1 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\MyComponent\SearchK.razor"
              model

#line default
#line hidden
#nullable disable
            , 2, (context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<AntDesign.FormItem>(4);
                __builder2.AddAttribute(5, "Class", "col-md-6");
                __builder2.AddAttribute(6, "Style", "margin:0 auto;");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Search>(9);
                    __builder3.AddAttribute(10, "Placeholder", "input search text");
                    __builder3.AddAttribute(11, "Size", "large");
                    __builder3.AddAttribute(12, "EnterButton", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.Boolean, System.String>>(
#nullable restore
#line 3 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\MyComponent\SearchK.razor"
                                                                                                        "搜索"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\MyComponent\SearchK.razor"
                                                             context.Title

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Title = __value, context.Title))));
                    __builder3.AddAttribute(15, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => context.Title));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "D:\project\asp.net_core\GraduationProject\软件技术2002胡威-毕业设计\(03) 项目\RiderBBS\RiderBBS\MyComponent\SearchK.razor"
       
    public class SeachModel
    {
        public string Title { get; set; }
    }

    SeachModel model = new SeachModel();

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.RiderBBS.MyComponent.SearchK
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateForm_0<TModel>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TModel __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TModel> __arg1)
        {
        __builder.OpenComponent<global::AntDesign.Form<TModel>>(seq);
        __builder.AddAttribute(__seq0, "Model", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
