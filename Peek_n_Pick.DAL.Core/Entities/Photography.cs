using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peek_n_Pick.DAL.Core.Entities
{
    public class Photography
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string Path { get; set; } = "default.png";
        public bool IsPicked { get; set; } = false;
        public string OwnerKey { get; set; }
    }
}
