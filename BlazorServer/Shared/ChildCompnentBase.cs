using BlazorServer.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Shared
{
    public class ChildCompnentBase : ComponentBase
    {
        protected bool DarkThemOn;
        [Inject]
        protected RandomService RandomService { get; set; }

  

        protected string AlertTheme => DarkThemOn ? "dark" : "light";

        [Parameter]
        public RenderFragment ChildContent { get; set; }


        protected override void OnInitialized()
        {
            DarkThemOn = true;
        }
    }
}
