using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KUSYS.Data
{
    public partial class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
