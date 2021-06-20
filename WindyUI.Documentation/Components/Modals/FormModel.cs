using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WindyUI.Documentation.Components.Modals
{
    public class FormModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string AgeGroup { get; set; }
    }
}
