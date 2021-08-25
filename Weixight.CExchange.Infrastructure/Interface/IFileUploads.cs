using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.Model;

namespace Weixight.CExchange.Infrastructure.Interface
{
    public  interface IFileUploads
    {
        FileOnFileSystemModel UploadToFileSystem(List<IFormFile> files, string description);
        FileOnDatabaseModel UploadToDatabase(List<IFormFile> files, string description);
        (byte[] Data, string FileType, string) DownloadFileFromDatabase(FileOnDatabaseModel fileOnDatabaseModel);
        (MemoryStream memory, string FileType, string) DownloadFileFromFileSystem(FileOnFileSystemModel fileOnFileSystemModel);
        bool DeleteFileFromFileSystem(FileOnFileSystemModel fileOnFileSystemModel);
        //Task<int> DeleteFileFromDatabase(int id);
    }
}
