using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyUI.Navigation
{
    public class NavigationParentBase : ComponentBase
    {
        [Parameter]
        public NavigationColors Color { get; set; }
    }
}
