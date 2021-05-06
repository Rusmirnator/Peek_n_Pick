using Microsoft.AspNetCore.Http;
using Peek_n_Pick.Services.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peek_n_Pick.Services.Repositories
{
    public class PhotographyRepository : IPhotographyRepository
    {
        public void Upload(string path, IFormFile image)
        {
            throw new NotImplementedException();
        }
    }
}
