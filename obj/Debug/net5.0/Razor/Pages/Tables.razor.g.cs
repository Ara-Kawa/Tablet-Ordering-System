#pragma checksum "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc56b63dc4732bf7d5714705cfba57832060e7a3"
// <auto-generated/>
#pragma warning disable 1591
namespace tablet_blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\_Imports.razor"
using tablet_blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\_Imports.razor"
using tablet_blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tables")]
    public partial class Tables : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row table");
            __builder.AddAttribute(2, "style", "height:90vh; width:100%; margin-top:5vh; margin-bottom:5vh;");
            __builder.AddAttribute(3, "b-yewhptq46g");
            __builder.AddMarkupContent(4, "<div class=\"col-sm-2  text-center\" b-yewhptq46g></div>\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-8 ");
            __builder.AddAttribute(7, "style", "background-color:#f1f1f1; border: solid 1px black;align-items:center; padding:0; margin:0;");
            __builder.AddAttribute(8, "b-yewhptq46g");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddAttribute(11, "style", "height:100%;");
            __builder.AddAttribute(12, "b-yewhptq46g");
            __builder.OpenElement(13, "tr");
            __builder.AddAttribute(14, "b-yewhptq46g");
            __builder.AddMarkupContent(15, "<td style=\"width:33%; text-align:center; vertical-align:middle\" b-yewhptq46g><h3 style=\"font-size:0.8rem;\" b-yewhptq46g>Table Number</h3></td>\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "style", "width:33%");
            __builder.AddAttribute(18, "b-yewhptq46g");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "runat", "server");
            __builder.AddAttribute(21, "style", "box-sizing:border-box; width:100%; height:100%; font-size:2rem; text-align:center;");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "name", "txt_no");
            __builder.AddAttribute(24, "id", "txt_no");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                                                                                                                                                                                    table_number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => table_number = __value, table_number));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(27, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "style", "width:33%");
            __builder.AddAttribute(31, "b-yewhptq46g");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "runat", "server");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                                                      OpenTable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "id", "Button2");
            __builder.AddAttribute(36, "class", "btn btn-success");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "name", "btn_order");
            __builder.AddAttribute(39, "value", "Open");
            __builder.AddAttribute(40, "style", "width:100%; height:100%;  font-size:2rem;");
            __builder.AddAttribute(41, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n            ");
            __builder.OpenElement(43, "tr");
            __builder.AddAttribute(44, "b-yewhptq46g");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "b-yewhptq46g");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                       () => write_number("1")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "id", "Button3");
            __builder.AddAttribute(50, "class", "btn btn-info");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "name", "btn_order");
            __builder.AddAttribute(53, "value", "1");
            __builder.AddAttribute(54, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(55, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "b-yewhptq46g");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                       () => write_number("2")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "id", "Button4");
            __builder.AddAttribute(62, "class", "btn btn-info");
            __builder.AddAttribute(63, "type", "button");
            __builder.AddAttribute(64, "name", "btn_order");
            __builder.AddAttribute(65, "value", "2");
            __builder.AddAttribute(66, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(67, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "td");
            __builder.AddAttribute(70, "b-yewhptq46g");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                       () => write_number("3")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "id", "Button5");
            __builder.AddAttribute(74, "class", "btn btn-info");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "name", "btn_order");
            __builder.AddAttribute(77, "value", "3");
            __builder.AddAttribute(78, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(79, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\r\n            ");
            __builder.OpenElement(81, "tr");
            __builder.AddAttribute(82, "b-yewhptq46g");
            __builder.OpenElement(83, "td");
            __builder.AddAttribute(84, "b-yewhptq46g");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                       () => write_number("4")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "id", "Button6");
            __builder.AddAttribute(88, "class", "btn btn-info");
            __builder.AddAttribute(89, "type", "button");
            __builder.AddAttribute(90, "name", "btn_order");
            __builder.AddAttribute(91, "value", "4");
            __builder.AddAttribute(92, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(93, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.OpenElement(95, "td");
            __builder.AddAttribute(96, "b-yewhptq46g");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                       () => write_number("5")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "id", "Button7");
            __builder.AddAttribute(100, "class", "btn btn-info");
            __builder.AddAttribute(101, "type", "button");
            __builder.AddAttribute(102, "name", "btn_order");
            __builder.AddAttribute(103, "value", "5");
            __builder.AddAttribute(104, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(105, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "b-yewhptq46g");
            __builder.OpenElement(109, "input");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                       () => write_number("6")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "id", "Button8");
            __builder.AddAttribute(112, "class", "btn btn-info");
            __builder.AddAttribute(113, "type", "button");
            __builder.AddAttribute(114, "name", "btn_order");
            __builder.AddAttribute(115, "value", "6");
            __builder.AddAttribute(116, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(117, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n            ");
            __builder.OpenElement(119, "tr");
            __builder.AddAttribute(120, "b-yewhptq46g");
            __builder.OpenElement(121, "td");
            __builder.AddAttribute(122, "b-yewhptq46g");
            __builder.OpenElement(123, "input");
            __builder.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                       () => write_number("7")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "id", "Button9");
            __builder.AddAttribute(126, "class", "btn btn-info");
            __builder.AddAttribute(127, "type", "button");
            __builder.AddAttribute(128, "name", "btn_order");
            __builder.AddAttribute(129, "value", "7");
            __builder.AddAttribute(130, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(131, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                ");
            __builder.OpenElement(133, "td");
            __builder.AddAttribute(134, "b-yewhptq46g");
            __builder.OpenElement(135, "input");
            __builder.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                       () => write_number("8")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "id", "Button10");
            __builder.AddAttribute(138, "class", "btn btn-info");
            __builder.AddAttribute(139, "type", "button");
            __builder.AddAttribute(140, "name", "btn_order");
            __builder.AddAttribute(141, "value", "8");
            __builder.AddAttribute(142, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(143, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                ");
            __builder.OpenElement(145, "td");
            __builder.AddAttribute(146, "b-yewhptq46g");
            __builder.OpenElement(147, "input");
            __builder.AddAttribute(148, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                       () => write_number("9")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(149, "id", "Button11");
            __builder.AddAttribute(150, "class", "btn btn-info");
            __builder.AddAttribute(151, "type", "button");
            __builder.AddAttribute(152, "name", "btn_order");
            __builder.AddAttribute(153, "value", "9");
            __builder.AddAttribute(154, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(155, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n\r\n            ");
            __builder.OpenElement(157, "tr");
            __builder.AddAttribute(158, "b-yewhptq46g");
            __builder.OpenElement(159, "td");
            __builder.AddAttribute(160, "b-yewhptq46g");
            __builder.OpenElement(161, "input");
            __builder.AddAttribute(162, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                       () => write_number("0")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(163, "id", "Button12");
            __builder.AddAttribute(164, "class", "btn btn-info");
            __builder.AddAttribute(165, "type", "button");
            __builder.AddAttribute(166, "name", "btn_order");
            __builder.AddAttribute(167, "value", "0");
            __builder.AddAttribute(168, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(169, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                ");
            __builder.OpenElement(171, "td");
            __builder.AddAttribute(172, "colspan", "2");
            __builder.AddAttribute(173, "b-yewhptq46g");
            __builder.OpenElement(174, "input");
            __builder.AddAttribute(175, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                                   () => write_number("undo")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(176, "id", "Button13");
            __builder.AddAttribute(177, "type", "button");
            __builder.AddAttribute(178, "name", "btn_order");
            __builder.AddAttribute(179, "value", "Undo");
            __builder.AddAttribute(180, "style", "width:100%; height:100%; font-size:2rem;");
            __builder.AddAttribute(181, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n\r\n            ");
            __builder.OpenElement(183, "tr");
            __builder.AddAttribute(184, "b-yewhptq46g");
            __builder.OpenElement(185, "td");
            __builder.AddAttribute(186, "colspan", "3");
            __builder.AddAttribute(187, "b-yewhptq46g");
            __builder.OpenElement(188, "input");
            __builder.AddAttribute(189, "runat", "server");
            __builder.AddAttribute(190, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                                    LogOut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(191, "id", "Button14");
            __builder.AddAttribute(192, "type", "button");
            __builder.AddAttribute(193, "name", "btn_back");
            __builder.AddAttribute(194, "value", "Back");
            __builder.AddAttribute(195, "style", "width:49%; height:100%; font-size:2rem;");
            __builder.AddAttribute(196, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n                    ");
            __builder.OpenElement(198, "input");
            __builder.AddAttribute(199, "runat", "server");
            __builder.AddAttribute(200, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
                                                    about_tables

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(201, "onserverclick", "table_info_ServerClick");
            __builder.AddAttribute(202, "id", "Button15");
            __builder.AddAttribute(203, "type", "button");
            __builder.AddAttribute(204, "name", "btn_about_table");
            __builder.AddAttribute(205, "value", "Table Info");
            __builder.AddAttribute(206, "style", "width:50%; height:100%; font-size:2rem;");
            __builder.AddAttribute(207, "b-yewhptq46g");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Ara\source\repos\tablet_blazor\tablet_blazor\Pages\Tables.razor"
       



    protected async override Task OnInitializedAsync()




    {
        try

        {
            var res = await session.GetAsync<int>("ID");
            if (!res.Success)
            {
                NavigationManager.NavigateTo("/");
            }
        }
        catch(Exception ex) { NavigationManager.NavigateTo("/"); }
    }

    string table_number = "";
    void write_number(string s)
    {
        if (s == "undo")
        {
            try
            {
                table_number = table_number.Remove(table_number.Length - 1);
            }
            catch (Exception)
            {


            }
            return;
        }
        table_number = table_number + s;
        if (Convert.ToInt16(table_number) > 99) table_number = "99";


    }
    async Task OpenTable()
    {
        if(table_number != "")
        {
            await session.SetAsync("tbl_number", table_number);
            NavigationManager.NavigateTo("orders");
        }
    }

    async Task LogOut() {
        await session.DeleteAsync("ID");
        await session.DeleteAsync("PER");
        NavigationManager.NavigateTo("/");
    }
    void about_tables()
    {


        NavigationManager.NavigateTo("about_table");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage session { get; set; }
    }
}
#pragma warning restore 1591
