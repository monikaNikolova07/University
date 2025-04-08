using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(University))]
        public int UniversityId { get; set; }

        public UniversityClass University { get; set; } = null!;
        public List<Major> Majors { get; set; } = new List<Major>();
    }
}
