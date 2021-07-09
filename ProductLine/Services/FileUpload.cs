using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=7oNhDxdZ3u8
//https://www.youtube.com/watch?v=7OudZqyeHxg
namespace ProductLine.Services
{
    //C:\Users\11902098\Desktop\GitHubSources\ProductLine\ProductLine\wwwroot\images\
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;

        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task UploadAsync(IFileListEntry file)
        {
            //Where to upload
            var path = Path.Combine(_environment.ContentRootPath,"wwwroot","images",file.Name);
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            using (FileStream stream=new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(stream);
            }
            
        }
    }
}
