using Microsoft.AspNetCore.Http;
using System;

namespace FileUploadControl
{
    public interface IUploadableFile
    {
        void UploadFile(IFormFile file, String folder);
    }
}
