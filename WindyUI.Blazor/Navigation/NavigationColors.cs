using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyUI.Navigation
{
    public enum NavigationColors
    {
        Primary,
        PrimaryLight,
        PrimaryDark,
        Secondary,
        SecondaryLight,
        SecondaryDark
    }

    public static class ColorSelector
    {
        public static string GetLinkColorFromBackground(NavigationColors backgroundColor)
        {
            var colorClass = "";

            switch (backgroundColor)
            {
                case NavigationColors.Primary:
                    colorClass = $"text-primary-text hover:bg-primary-dark";
                    break;
                case NavigationColors.PrimaryDark:
                case NavigationColors.PrimaryLight:
                    colorClass = "text-primary-text hover:bg-primary";
                    break;
                case NavigationColors.Secondary:
                    colorClass = $"text-secondary-text hover:bg-secondary-dark";
                    break;
                case NavigationColors.SecondaryDark:
                case NavigationColors.SecondaryLight:
                    colorClass = "text-secondary-text hover:bg-secondary";
                    break;
            }

            return colorClass;
        }

        public static string GetBackgroundColor(NavigationColors color)
        {
            var colorClass = "";

            switch (color)
            {
                case NavigationColors.Primary:
                    colorClass = $"bg-primary";
                    break;
                case NavigationColors.PrimaryDark:
                    colorClass = "bg-primary-dark";
                    break;
                case NavigationColors.PrimaryLight:
                    colorClass = "bg-primary-light";
                    break;
                case NavigationColors.Secondary:
                    colorClass = "bg-secondary";
                    break;
                case NavigationColors.SecondaryDark:
                    colorClass = "bg-secondary-dark";
                    break;
                case NavigationColors.SecondaryLight:
                    colorClass = "bg-primary-light";
                    break;
            }

            return colorClass;
        }
    }

}

