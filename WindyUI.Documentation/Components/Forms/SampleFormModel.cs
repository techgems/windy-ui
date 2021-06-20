using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WindyUI.Documentation.Components.Forms
{
    public class SampleFormModel
    {
        [Required]
        [MaxLength(3)]
        public string Name { get; set; }

        [Required]
        public string TextArea { get; set; }

        [Required]
        [MaxLength(3)]
        public string SelectValue { get; set; }

        [Required]
        public string RadioButton { get; set; }

        public bool Checkbox { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
