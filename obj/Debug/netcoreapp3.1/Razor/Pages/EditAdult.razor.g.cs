#pragma checksum "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d405801a3d16b620cbd5aca4c770d742151e036"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\simon\Desktop\temp2\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\Desktop\temp2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\Desktop\temp2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simon\Desktop\temp2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\simon\Desktop\temp2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\simon\Desktop\temp2\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\simon\Desktop\temp2\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\simon\Desktop\temp2\Assignment1\_Imports.razor"
using Assignment2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\simon\Desktop\temp2\Assignment1\_Imports.razor"
using Assignment2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
using Assignment2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditAdult")]
    public partial class EditAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit adult</h3>\r\n");
            __builder.AddMarkupContent(1, "<label>Fill in all of the fields</label>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "\r\n    Adult id: ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "number");
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                               (arg) => GetAdultToEdit(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "style", "width:50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                  adultToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                               UpdateAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "\r\n        First name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                adultToEdit.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.FirstName = __value, adultToEdit.FirstName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\r\n        Last name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                adultToEdit.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.LastName = __value, adultToEdit.LastName))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n        Job title:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                adultToEdit.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.JobTitle = __value, adultToEdit.JobTitle))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.JobTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    \r\n    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "\r\n        Monthly salary:<br>\r\n        ");
                __Blazor.Assignment2.Pages.EditAdult.TypeInference.CreateInputNumber_0(__builder2, 49, 50, 
#nullable restore
#line 32 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                  adultToEdit.MonthlySalary

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.MonthlySalary = __value, adultToEdit.MonthlySalary)), 52, () => adultToEdit.MonthlySalary);
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n    \r\n    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "\r\n        Hair color:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                adultToEdit.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.HairColor = __value, adultToEdit.HairColor))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.HairColor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "\r\n        Eye color:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                adultToEdit.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.EyeColor = __value, adultToEdit.EyeColor))));
                __builder2.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultToEdit.EyeColor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.AddMarkupContent(75, "\r\n        Age:<br>\r\n        ");
                __Blazor.Assignment2.Pages.EditAdult.TypeInference.CreateInputNumber_1(__builder2, 76, 77, 
#nullable restore
#line 45 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                  adultToEdit.Age

#line default
#line hidden
#nullable disable
                , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Age = __value, adultToEdit.Age)), 79, () => adultToEdit.Age);
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group");
                __builder2.AddMarkupContent(84, "\r\n        Weight:<br>\r\n        ");
                __Blazor.Assignment2.Pages.EditAdult.TypeInference.CreateInputNumber_2(__builder2, 85, 86, 
#nullable restore
#line 49 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                  adultToEdit.Weight

#line default
#line hidden
#nullable disable
                , 87, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Weight = __value, adultToEdit.Weight)), 88, () => adultToEdit.Weight);
                __builder2.AddMarkupContent(89, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n    ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group");
                __builder2.AddMarkupContent(93, "\r\n        Height:<br>\r\n        ");
                __Blazor.Assignment2.Pages.EditAdult.TypeInference.CreateInputNumber_3(__builder2, 94, 95, 
#nullable restore
#line 53 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                  adultToEdit.Height

#line default
#line hidden
#nullable disable
                , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Height = __value, adultToEdit.Height)), 97, () => adultToEdit.Height);
                __builder2.AddMarkupContent(98, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n    ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group");
                __builder2.AddMarkupContent(102, "\r\n        Sex:<br>\r\n        ");
                __Blazor.Assignment2.Pages.EditAdult.TypeInference.CreateInputSelect_4(__builder2, 103, 104, 
#nullable restore
#line 57 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
                                  adultToEdit.Sex

#line default
#line hidden
#nullable disable
                , 105, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Sex = __value, adultToEdit.Sex)), 106, () => adultToEdit.Sex, 107, (__builder3) => {
                    __builder3.AddMarkupContent(108, "\r\n            ");
                    __builder3.AddMarkupContent(109, "<option value>Select sex ...</option>\r\n            ");
                    __builder3.AddMarkupContent(110, "<option value=\"M\">Male</option>\r\n            ");
                    __builder3.AddMarkupContent(111, "<option value=\"F\">Female</option>\r\n        ");
                }
                );
                __builder2.AddMarkupContent(112, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n    ");
                __builder2.AddMarkupContent(114, "<p class=\"actions\">\r\n        <button class=\"btn btn-outline-dark\" type=\"submit\">Update</button>\r\n    </p>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\simon\Desktop\temp2\Assignment1\Pages\EditAdult.razor"
       
    private Adult adultToEdit = new Adult();
    private IList<Adult> allAdults = new List<Adult>();
    private int? id;

    protected override async Task OnInitializedAsync()
    {
        allAdults = await Persistence.ReadAllAdults();
    }
    
    private async void UpdateAdult()
    {
        await Persistence.UpdateAdult(adultToEdit);
        NavigationManager.NavigateTo("/ViewAdults");
    }

    private void GetAdultToEdit(ChangeEventArgs eventArgs)
    {
        id = null;
        try
        {
            id = int.Parse(eventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        adultToEdit = new Adult();
        foreach (var adult in allAdults)
        {
            if (adult.Id == id)
            {
                adultToEdit = adult;
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService Persistence { get; set; }
    }
}
namespace __Blazor.Assignment2.Pages.EditAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
