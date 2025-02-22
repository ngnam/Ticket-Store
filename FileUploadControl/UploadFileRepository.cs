﻿using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace FileUploadControl
{
    public class UploadFileRepository : IUploadableFile
    {
        private IHostingEnvironment hostingEnvironment;

        public UploadFileRepository(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        public async void UploadFile(IFormFile file, string folder)
        {
            string fileName = file.FileName.Trim('"');
            byte[] buffer = new byte[16 << 10]; //16 * 1024 = 16KB
            using (FileStream output = System.IO.File.Create(this.GetPathAndFileName(folder, fileName)))
            {
                using (Stream input = file.OpenReadStream()) 
                {
                    int readBytes;
                    while ((readBytes = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        await output.WriteAsync(buffer, 0, readBytes);
                    }
                }
            }
        }

        private string GetPathAndFileName(string folder, string fileName)
        {
            string path = this.hostingEnvironment.WebRootPath + "\\uploads\\" + folder + "\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path + fileName;
        }
    }
}
