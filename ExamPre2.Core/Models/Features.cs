using ExamPre2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPre2.Core.Models
{
    public class Features : BaseEntity
    {
        
        public string? IconUrl { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        
        public string Description { get; set; }
    }
}
