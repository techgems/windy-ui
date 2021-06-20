using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindyUI.Form
{
    public class ImageUploadInputConfig
    {
        public string? Label { get; set; }
        public IReadOnlyList<IBrowserFile>? ExistingFiles { get; set; }
        public bool AllowsMultiple { get; set; }
        public int? MaxFileLimit { get; set; }
        public List<string> SupportedTypes { get; set; } = new List<string>();
    }
}
