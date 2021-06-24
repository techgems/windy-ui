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
        Secondary
    }

    public class NavigationColorUtils
    {
        public NavigationColors GetSidebarLinkColor(NavigationColors parentColor)
        {
            return NavigationColors.Primary;
        }

        public NavigationColors GetNavbarLinkColor(NavigationColors parentColor)
        {
            return NavigationColors.Primary;
        }
    }
}
