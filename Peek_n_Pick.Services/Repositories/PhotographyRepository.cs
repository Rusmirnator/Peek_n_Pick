using Microsoft.AspNetCore.Http;
using Peek_n_Pick.Services.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peek_n_Pick.Services.Repositories
{
    public class PhotographyRepository : IPhotographyRepository
    { 
        public void Upload(string path, IFormFile image)
        {
            IFormFile Image = image;

            string uploadsFolder = Path.Combine(path, "Uploads");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + Image.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using var fileStream = new FileStream(filePath, FileMode.Create);
            image.CopyTo(fileStream);

        }
    }
}
