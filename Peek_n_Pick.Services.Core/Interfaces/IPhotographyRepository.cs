using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peek_n_Pick.Services.Core.Interfaces
{
    public interface IPhotographyRepository
    {
        void Upload(string path, IFormFile image);
    }
}
