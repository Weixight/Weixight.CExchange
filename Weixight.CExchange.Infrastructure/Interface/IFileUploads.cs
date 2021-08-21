using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Weixight.CExchange.Infrastructure.Interface
{
    public  interface IFileUploads
    {
        Task  UploadToFileSystem(List<IFormFile> files, string description);
        Task UploadToDatabase(List<IFormFile> files, string description);
        Task<(byte[] Data, string FileType, string)> DownloadFileFromDatabase(int id);
        Task<(MemoryStream memory, string FileType, string)> DownloadFileFromFileSystem(int id);
        Task<string> DeleteFileFromFileSystem(int id);
        Task DeleteFileFromDatabase(int id);
    }
}
