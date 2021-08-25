using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Infrastructure.Interface;
using Weixight.CExchange.Persistence;

namespace Weixight.CExchange.Infrastructure.Implemetation
{
    class FileUploadService : IFileUploads
    {
        private readonly ApplicationDbContext _db;

        public FileUploadService(ApplicationDbContext db)
        {
            _db = db;
        }

      

        public bool DeleteFileFromFileSystem(FileOnFileSystemModel file)
        {
            {
                if (file == null)
                {

                };
                if (System.IO.File.Exists(file.FilePath))
                {
                    System.IO.File.Delete(file.FilePath);
                }
                // _db.FilesOnFileSystem.Remove(file);
                // _db.SaveChanges();

            }
            return true;
        }

        public (byte[] Data, string FileType, string) DownloadFileFromDatabase(FileOnDatabaseModel file)
        {
            if (file == null)
            {
                //return null;
            }
            return (file.Data, file.FileType, file.Name + file.Extension);
        }

        public (MemoryStream memory, string FileType, string) DownloadFileFromFileSystem(FileOnFileSystemModel file)
        {
            if (file == null)
            {
            }

            var memory = new MemoryStream();
            using (var stream = new FileStream(file.FilePath, FileMode.Open))
            {
                 stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return (memory, file.FileType, file.Name + file.Extension);
        }


        public FileOnDatabaseModel UploadToDatabase(List<IFormFile> files, string description)
        {
            FileOnDatabaseModel fileOnDatabaseModel = new FileOnDatabaseModel();
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new FileOnDatabaseModel
                {
                    CreatedOn = DateTime.UtcNow,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    Description = description
                };
                using (var dataStream = new MemoryStream())
                {
                    file.CopyToAsync(dataStream);
                    fileModel.Data = dataStream.ToArray();
                }
                fileOnDatabaseModel = fileModel;
                //  _db.FilesOnDatabase.Add(fileModel);
                //   _db.SaveChanges();
            }
            // TempData["Message"] = "File successfully uploaded to Database";
            return fileOnDatabaseModel;
        }

        public FileOnFileSystemModel UploadToFileSystem(List<IFormFile> files, string description)
        {
            FileOnFileSystemModel fileOnFileSystemModel = new FileOnFileSystemModel();
            foreach (var file in files)
            {
                var basePath = Path.Combine(Directory.GetCurrentDirectory() + "\\Files\\");
                bool basePathExists = System.IO.Directory.Exists(basePath);
                if (!basePathExists) Directory.CreateDirectory(basePath);
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var filePath = Path.Combine(basePath, file.FileName);
                var extension = Path.GetExtension(file.FileName);
                if (!System.IO.File.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyToAsync(stream);
                    }
                    var fileModel = new FileOnFileSystemModel
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = description,
                        FilePath = filePath
                    };
                    fileOnFileSystemModel = fileModel;
                    //  _db.FilesOnFileSystem.Add(fileModel);
                    // _db.SaveChanges();
                }
            }
            // TempData["Message"] = "File successfully uploaded to File System.";
            return fileOnFileSystemModel;
        }

        

      
       

      
    }


        
}

