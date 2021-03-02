#pragma checksum "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82a953592d5e17349546c9da5ce6061c5870f398"
// <auto-generated/>
#pragma warning disable 1591
namespace TigerHRM.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using TigerHRM.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using TigerHRM.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using TigerHRM.App.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{employeeId}")]
    public partial class EmployeeDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, "Details for ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                    Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 4 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                        Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12 row");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-2");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 8 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                    $"https://localhost:44379/Images/{Employee.EmployeeId}-small.jpg"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "img-responsive rounded-circle employee-detail-img");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-10 row");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-xs-12 col-sm-8");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group row");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.AddMarkupContent(27, "<label class=\"col-sm-4 col-form-label\">Employee ID</label>\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-sm-8");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "label");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "class", "form-control-plaintext");
            __builder.AddContent(34, 
#nullable restore
#line 15 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                       Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group row");
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.AddMarkupContent(41, "<label class=\"col-sm-4 col-form-label\">First name</label>\r\n                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-sm-8");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "label");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "readonly", true);
            __builder.AddAttribute(48, "class", "form-control-plaintext");
            __builder.AddContent(49, 
#nullable restore
#line 21 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                                Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group row");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.AddMarkupContent(56, "<label class=\"col-sm-4 col-form-label\">Last name</label>\r\n                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-sm-8");
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "label");
            __builder.AddAttribute(61, "type", "text");
            __builder.AddAttribute(62, "readonly", true);
            __builder.AddAttribute(63, "class", "form-control-plaintext");
            __builder.AddContent(64, 
#nullable restore
#line 28 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                                Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-group row");
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.AddMarkupContent(74, "<label class=\"col-sm-4 col-form-label\">Birthdate</label>\r\n    ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col-sm-8");
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.OpenElement(78, "label");
            __builder.AddAttribute(79, "type", "text");
            __builder.AddAttribute(80, "readonly", true);
            __builder.AddAttribute(81, "class", "form-control-plaintext");
            __builder.AddContent(82, 
#nullable restore
#line 37 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                    Employee.BirthDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group row");
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.AddMarkupContent(89, "<label class=\"col-sm-4 col-form-label\">Email</label>\r\n    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-sm-8");
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.OpenElement(93, "label");
            __builder.AddAttribute(94, "type", "text");
            __builder.AddAttribute(95, "readonly", true);
            __builder.AddAttribute(96, "class", "form-control-plaintext");
            __builder.AddContent(97, 
#nullable restore
#line 44 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                    Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\r\n");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "form-group row");
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.AddMarkupContent(104, "<label class=\"col-sm-4 col-form-label\">Street</label>\r\n    ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "col-sm-8");
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.OpenElement(108, "label");
            __builder.AddAttribute(109, "type", "text");
            __builder.AddAttribute(110, "readonly", true);
            __builder.AddAttribute(111, "class", "form-control-plaintext");
            __builder.AddContent(112, 
#nullable restore
#line 51 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                    Employee.Street

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "form-group row");
            __builder.AddMarkupContent(118, "\r\n    ");
            __builder.AddMarkupContent(119, "<label class=\"col-sm-4 col-form-label\">Postcode</label>\r\n    ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "col-sm-8");
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.OpenElement(123, "label");
            __builder.AddAttribute(124, "type", "text");
            __builder.AddAttribute(125, "readonly", true);
            __builder.AddAttribute(126, "class", "form-control-plaintext");
            __builder.AddContent(127, 
#nullable restore
#line 58 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                    Employee.Postcode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "form-group row");
            __builder.AddMarkupContent(133, "\r\n    ");
            __builder.AddMarkupContent(134, "<label class=\"col-sm-4 col-form-label\">City</label>\r\n    ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "col-sm-8");
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.OpenElement(138, "label");
            __builder.AddAttribute(139, "type", "text");
            __builder.AddAttribute(140, "readonly", true);
            __builder.AddAttribute(141, "class", "form-control-plaintext");
            __builder.AddContent(142, 
#nullable restore
#line 65 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                    Employee.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n\r\n");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "form-group row");
            __builder.AddMarkupContent(148, "\r\n    ");
            __builder.AddMarkupContent(149, "<label class=\"col-sm-4 col-form-label\">Phone number</label>\r\n    ");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "class", "col-sm-8");
            __builder.AddMarkupContent(152, "\r\n        ");
            __builder.OpenElement(153, "label");
            __builder.AddAttribute(154, "type", "text");
            __builder.AddAttribute(155, "readonly", true);
            __builder.AddAttribute(156, "class", "form-control-plaintext");
            __builder.AddContent(157, 
#nullable restore
#line 72 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                    Employee.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n\r\n");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "form-group row");
            __builder.AddMarkupContent(163, "\r\n    ");
            __builder.AddMarkupContent(164, "<label class=\"col-sm-4 col-form-label\">Smoker</label>\r\n    ");
            __builder.OpenElement(165, "div");
            __builder.AddAttribute(166, "class", "col-sm-8");
            __builder.AddMarkupContent(167, "\r\n\r\n");
#nullable restore
#line 80 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
         if (Employee.Smoker)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(168, "            ");
            __builder.AddMarkupContent(169, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>\r\n");
#nullable restore
#line 83 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(170, "            ");
            __builder.AddMarkupContent(171, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>\r\n");
#nullable restore
#line 87 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(172, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n\r\n");
            __builder.OpenElement(175, "div");
            __builder.AddAttribute(176, "class", "form-group row");
            __builder.AddMarkupContent(177, "\r\n    ");
            __builder.AddMarkupContent(178, "<label class=\"col-sm-4 col-form-label\">Joined us</label>\r\n    ");
            __builder.OpenElement(179, "div");
            __builder.AddAttribute(180, "class", "col-sm-8");
            __builder.AddMarkupContent(181, "\r\n        ");
            __builder.OpenElement(182, "label");
            __builder.AddAttribute(183, "type", "text");
            __builder.AddAttribute(184, "readonly", true);
            __builder.AddAttribute(185, "class", "form-control-plaintext");
            __builder.AddContent(186, 
#nullable restore
#line 95 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                    Employee.JoinedDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n\r\n");
            __builder.OpenElement(190, "div");
            __builder.AddAttribute(191, "class", "form-group row");
            __builder.AddMarkupContent(192, "\r\n    ");
            __builder.AddMarkupContent(193, "<label class=\"col-sm-4 col-form-label\">Left us</label>\r\n    ");
            __builder.OpenElement(194, "div");
            __builder.AddAttribute(195, "class", "col-sm-8");
            __builder.AddMarkupContent(196, "\r\n        ");
            __builder.OpenElement(197, "label");
            __builder.AddAttribute(198, "type", "text");
            __builder.AddAttribute(199, "readonly", true);
            __builder.AddAttribute(200, "class", "form-control-plaintext");
            __builder.AddContent(201, 
#nullable restore
#line 102 "C:\Users\hil_w\source\repos\TigerHRM.App\Pages\EmployeeDetail.razor"
                                                                    Employee.ExitDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591