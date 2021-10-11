using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Weixight.CExchange.AgricGator.Services
{
    public class FilesService
    {
        [Obsolete]
        private readonly IWebHostEnvironment _hostingEnv;

        public FilesService(IWebHostEnvironment hostingEnv)
        {
            _hostingEnv = hostingEnv;
        }
        public byte[] FileUpload(IFormFileCollection formFiles)
        {
            byte[] p1 = null;
            if (formFiles[0] != null && formFiles[0].Length > 0)
            {

                using (var fs1 = formFiles[0].OpenReadStream())
                {
                    using (var ms1 = new MemoryStream())
                    {
                        fs1.CopyTo(ms1);
                        p1 = ms1.ToArray();

                    }
                }


            }
            return p1;

        }

        public byte[] FileUpload(IFormFile formFile)
        {
            byte[] p1 = null;
            if (formFile != null && formFile.Length > 0)
            {

                using (var fs1 = formFile.OpenReadStream())
                {
                    using (var ms1 = new MemoryStream())
                    {
                        fs1.CopyTo(ms1);
                        p1 = ms1.ToArray();

                    }
                }


            }
            return p1;

        }

    }
}
