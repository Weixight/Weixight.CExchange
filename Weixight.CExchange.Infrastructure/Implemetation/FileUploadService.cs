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

        public async Task DeleteFileFromDatabase(int id)
        {
            {
                        var file = await _db.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
                       if (file == null)
                       {

                       };
                       if (System.IO.File.Exists(file.FilePath))
                       {
                           System.IO.File.Delete(file.FilePath);
                       }
                      _db.FilesOnFileSystem.Remove(file);
                      _db.SaveChanges();
                   }

         }


            public async Task<string> DeleteFileFromFileSystem(int id)
        {
            {
                var file = await _db.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
                if (file == null)
                {

                };
                if (System.IO.File.Exists(file.FilePath))
                {
                    System.IO.File.Delete(file.FilePath);
                }
                _db.FilesOnFileSystem.Remove(file);
                _db.SaveChanges();

            }
            return "";
        }

        public async Task<(byte[] Data, string FileType, string)> DownloadFileFromDatabase(int id)
          {
              var file = await _db.FilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
                 if (file == null) 
               {
                //return null;
               }
               return (file.Data, file.FileType, file.Name + file.Extension);
         }

        public async Task<(MemoryStream memory, string FileType, string)> DownloadFileFromFileSystem(int id)
        {
            var file = await _db.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (file == null)
            {
            }

            var memory = new MemoryStream();
            using (var stream = new FileStream(file.FilePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return (memory, file.FileType, file.Name + file.Extension);
        }


        public Task UploadToDatabase(List<IFormFile> files, string description)
        {
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
                _db.FilesOnDatabase.Add(fileModel);
                _db.SaveChanges();
            }
           // TempData["Message"] = "File successfully uploaded to Database";
            return null;
        }

        public Task UploadToFileSystem(List<IFormFile> files, string description)
        {
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
                    _db.FilesOnFileSystem.Add(fileModel);
                    _db.SaveChanges();
                }
            }
           // TempData["Message"] = "File successfully uploaded to File System.";
            return null;
        }
    }


        //    public async Task DeleteFileFromFileSystem(int id)
        //    {
        //        var file = await _db.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
        //        if (file == null)
        //        {

        //        };
        //        if (System.IO.File.Exists(file.FilePath))
        //        {
        //            System.IO.File.Delete(file.FilePath);
        //        }
        //        _db.FilesOnFileSystem.Remove(file);
        //        _db.SaveChanges();
        //       // TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from File System.";
        //       // return RedirectToAction("Index");
        //    }

        //    public async Task<(byte[] Data, string FileType, string)> DownloadFileFromDatabase(int id)
        //    {
        //        var file = await _db.FilesOnDatabase.Where(x => x.Id == id).FirstOrDefaultAsync();
        //        if (file == null) 
        //        {
        //        }
        //        return (file.Data, file.FileType, file.Name + file.Extension);
        //    }

        //    public async Task<(MemoryStream memory, string FileType, string)> DownloadFileFromFileSystem(int id)
        //    {
        //        var file = await _db.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
        //        if (file == null)
        //        {
        //        }

        //        var memory = new MemoryStream();
        //        using (var stream = new FileStream(file.FilePath, FileMode.Open))
        //        {
        //            await stream.CopyToAsync(memory);
        //        }
        //        memory.Position = 0;
        //        return (memory, file.FileType, file.Name + file.Extension);
        //    }

        //    public async Task UploadToDatabase(List<IFormFile> files, string description)
        //    {
        //        foreach (var file in files)
        //        {
        //            var fileName = Path.GetFileNameWithoutExtension(file.FileName);
        //            var extension = Path.GetExtension(file.FileName);
        //            var fileModel = new FileOnDatabaseModel
        //            {
        //                CreatedOn = DateTime.UtcNow,
        //                FileType = file.ContentType,
        //                Extension = extension,
        //                Name = fileName,
        //                Description = description
        //            };
        //            using (var dataStream = new MemoryStream())
        //            {
        //                await file.CopyToAsync(dataStream);
        //                fileModel.Data = dataStream.ToArray();
        //            }
        //            _db.FilesOnDatabase.Add(fileModel);
        //            _db.SaveChanges();
        //        }
        //       // TempData["Message"] = "File successfully uploaded to Database";
        //        //return RedirectToAction("Index");
        //    }

        //    public async Task UploadToFileSystem(List<IFormFile> files, string description)
        //    {
        //        foreach (var file in files)
        //        {
        //            var basePath = Path.Combine(Directory.GetCurrentDirectory() + "\\Files\\");
        //            bool basePathExists = System.IO.Directory.Exists(basePath);
        //            if (!basePathExists) Directory.CreateDirectory(basePath);
        //            var fileName = Path.GetFileNameWithoutExtension(file.FileName);
        //            var filePath = Path.Combine(basePath, file.FileName);
        //            var extension = Path.GetExtension(file.FileName);
        //            if (!System.IO.File.Exists(filePath))
        //            {
        //                using (var stream = new FileStream(filePath, FileMode.Create))
        //                {
        //                    await file.CopyToAsync(stream);
        //                }
        //                var fileModel = new FileOnFileSystemModel
        //                {
        //                    CreatedOn = DateTime.UtcNow,
        //                    FileType = file.ContentType,
        //                    Extension = extension,
        //                    Name = fileName,
        //                    Description = description,
        //                    FilePath = filePath
        //                };
        //                 _db.FilesOnFileSystem.Add(fileModel);
        //                 _db.SaveChanges();
        //            }
        //        }
        //       // TempData["Message"] = "File successfully uploaded to File System.";
        //    }
}

