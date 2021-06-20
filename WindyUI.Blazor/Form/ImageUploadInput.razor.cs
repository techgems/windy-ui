using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WindyUI.Form
{
    public partial class ImageUploadInput : ComponentBase
    {
        public ImageUploadInput()
        {
            var identifier = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5);

            InputIdentifier = $"file-{identifier}";
        }

        private string InputIdentifier { get; set; }

        [Parameter]
        public ImageUploadInputConfig Config { get; set; } = new ImageUploadInputConfig();

        //Get is to be called using a ref to the component. Needed to send data to the server.
        public IReadOnlyList<IBrowserFile> BrowserFiles { get; protected set; } = new List<IBrowserFile>();

        private List<string> Base64Images { get; set; } = new List<string>();

        //TO DO: Image validation must happen here.
        private async Task<bool> HandleChange(InputFileChangeEventArgs e)
        {
            IReadOnlyList<IBrowserFile> fileList;

            //If component supports multiple files.
            if(Config.AllowsMultiple)
            {
                if(Config.MaxFileLimit.HasValue)
                    fileList = e.GetMultipleFiles(Config.MaxFileLimit.Value);
                else
                    fileList = e.GetMultipleFiles();

                BrowserFiles = fileList;
            }
            else //Single file support.
            {
                BrowserFiles = new List<IBrowserFile> { e.File };
            }

            await BrowserFilesToBase64Images();

            return true;
        }

        private async Task<bool> BrowserFilesToBase64Images()
        {
            foreach(var image in BrowserFiles)
            {
                if(image != null)
                {
                    var format = "image/png";
                    var buffer = new byte[image.Size];
                    await image.OpenReadStream().ReadAsync(buffer);
                    Base64Images.Add($"data:{format};base64,{Convert.ToBase64String(buffer)}");
                }
            }

            return true;
        }
    }
}
