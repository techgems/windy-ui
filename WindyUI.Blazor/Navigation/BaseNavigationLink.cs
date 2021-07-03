using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindyUI.Base;

namespace WindyUI.Navigation
{
    public class BaseNavigationLink : ChildBase<NavigationParentBase>
    {
        protected override void OnInitialized()
        {
            if(Parent is not null && Color == NavigationColors.Inherit)
            {
                Color = Parent.Color;
            }
        }

        [Parameter]
        public NavigationColors Color { get; set; } = NavigationColors.Inherit;

        [Parameter]
        public string CssClass { get; set; } = "";

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public string Route { get; set; } = "";

        protected string InactiveColorClass
        {
            get
            {
                var colorClass = "";

                switch (Color)
                {
                    case NavigationColors.Primary:
                        colorClass = "bg-primary hover:bg-primary-dark text-primary-text";
                        break;
                    case NavigationColors.PrimaryDark:
                        colorClass = "bg-primary-dark hover:bg-primary text-primary-text";
                        break;
                    case NavigationColors.PrimaryLight:
                        colorClass = "bg-primary-light hover:bg-primary text-primary-text";
                        break;
                    case NavigationColors.Secondary:
                        colorClass = "bg-secondary hover:bg-secondary-dark text-secondary-text";
                        break;
                    case NavigationColors.SecondaryDark:
                        colorClass = "bg-secondary-dark hover:bg-secondary text-secondary-text";
                        break;
                    case NavigationColors.SecondaryLight:
                        colorClass = "bg-secondary-light hover:bg-secondary text-secondary-text";
                        break;
                }

                return colorClass;
            }
        }

        public string ActiveColorClass
        {
            get
            {
                var colorClass = "";

                switch (Color)
                {
                    case NavigationColors.Primary:
                        colorClass = "bg-primary-dark";
                        break;
                    case NavigationColors.PrimaryDark:
                    case NavigationColors.PrimaryLight:
                        colorClass = "bg-primary";
                        break;
                    case NavigationColors.Secondary:
                        colorClass = "bg-secondary-dark";
                        break;
                    case NavigationColors.SecondaryDark:
                    case NavigationColors.SecondaryLight:
                        colorClass = "bg-secondary";
                        break;
                }

                return colorClass;
            }
        }
    }
}
