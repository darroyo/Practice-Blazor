using Microsoft.AspNetCore.Components;

namespace WebAssembly.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent {get;set;}
    }
}
