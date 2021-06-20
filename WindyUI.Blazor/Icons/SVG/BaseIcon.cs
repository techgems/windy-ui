using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindyUI.Icons
{
    public class BaseIcon : ComponentBase
    {
        [Parameter]
        public string CssClass { get; set; } = "";
    }
}
