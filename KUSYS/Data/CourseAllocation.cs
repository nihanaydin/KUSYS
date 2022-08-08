using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KUSYS.Data
{
    public class CourseAllocation : BaseEntity
    {
       

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        public String StudentId { get; set; }

        
    }
}
