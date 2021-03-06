#pragma checksum "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\MusicPad\PadController.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "395eb29780b46a925c8bdacefe1819329f2ae982"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPad.MusicPad
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\_Imports.razor"
using BlazorPad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\_Imports.razor"
using BlazorPad.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class PadController : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddAttribute(2, "b-5iymetxy3c");
            __builder.AddMarkupContent(3, "<h1 b-5iymetxy3c>BlazorPad</h1>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "surface");
            __builder.AddAttribute(6, "tabindex", "0");
            __builder.AddAttribute(7, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\MusicPad\PadController.razor"
                                                                     OnKeyPressed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "b-5iymetxy3c");
            __builder.AddElementReferenceCapture(9, (__value) => {
#nullable restore
#line 5 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\MusicPad\PadController.razor"
                               surfaceRef = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 6 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\MusicPad\PadController.razor"
         foreach(var pad in pads)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorPad.MusicPad.Pad>(10);
            __builder.AddAttribute(11, "PadModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorPad.MusicPad.PadModel>(
#nullable restore
#line 8 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\MusicPad\PadController.razor"
                                pad

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 9 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\MusicPad\PadController.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\USUARIO\Desktop\Talleres\Blazor_Apps\BlazorPad\BlazorPad\MusicPad\PadController.razor"
       
    private IList<PadModel> pads = new List<PadModel>
    {
        new PadModel("piano", "audio/piano.wav", "r"),
        new PadModel("strings", "audio/strings.wav", "t"),
        new PadModel("bass", "audio/bass.wav", "y"),
        new PadModel("kick", "audio/kick.wav", "f"),
        new PadModel("snare", "audio/snare.wav", "g"),
        new PadModel("hihat", "audio/hihat.wav", "h"),
        new PadModel("fx1", "audio/fx1.wav", "v"),
        new PadModel("fx2", "audio/fx2.wav", "b"),
        new PadModel("fx3", "audio/fx3.wav", "n")
    };

    private ElementReference surfaceRef;

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
            return;

        await surfaceRef.FocusAsync();
    }

    private async void OnKeyPressed(KeyboardEventArgs args)
    {
        await PlaySound(GetPressedPad(args.Key));
    }

    private PadModel GetPressedPad(string key) => pads.SingleOrDefault(p => p.Key == key);

    private async Task PlaySound(PadModel padModel)
    {
        if (padModel == null) return;

        await SoundPlayer.Play(padModel.soundLocation, padModel.Id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISoundPlayer SoundPlayer { get; set; }
    }
}
#pragma warning restore 1591
