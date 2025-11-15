using System.ComponentModel.DataAnnotations;

namespace Lab5.Models;

public class Major
{
        public int MajorID { get; set; }
        [Required]
        public string MajorName { get; set; }

        public ICollection<Learner>? Learners { get; set; }
}