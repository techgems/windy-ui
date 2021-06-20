using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindyUI.Modals
{
    /// <summary>
    /// Base class for all modals which contains:
    /// -fadein and fadeout animation classes. 
    /// -animation times. 
    /// -basic state for open or closed
    /// -support for internal child content.
    /// ActionModal, Modal and AlertDialog all inherit from this class.
    /// </summary>
    public class ModalBase : ComponentBase
    {
        protected bool IsOpen { get; set; } = false;
        protected bool _previousIsOpen = false;

        protected string OpenCloseAnimationClasses { get; set; } = "hidden";
        protected readonly int _fadeoutAnimationDuration = 400;

        public void Open()
        {
            IsOpen = true;
            OpenCloseAnimationClasses = "animate-fadein-400";
            StateHasChanged();
        }

        public void Close()
        {
            IsOpen = false;
            OpenCloseAnimationClasses = "animate-fadeout-400";
            StateHasChanged();
            _ = new System.Threading.Timer(HideModal, null, _fadeoutAnimationDuration, System.Threading.Timeout.Infinite);
        }

        private void HideModal(object? state)
        {
            OpenCloseAnimationClasses = "hidden";
            StateHasChanged();
        }
    }
}
