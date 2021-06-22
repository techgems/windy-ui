using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyUI.Base
{
    public abstract class ChildBase<T> : ComponentBase
        where T : class
    {
        [CascadingParameter]
        public T? Parent { get; set; }

        protected override void OnInitialized()
        {
            if (Parent == null)
                throw new ArgumentNullException(nameof(Parent), $"{this.GetType().Name} must exist within a {typeof(T).Name} component");
            base.OnInitialized();
        }
    }
}
