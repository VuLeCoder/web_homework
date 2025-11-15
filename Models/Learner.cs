using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models;

public class Learner
{
    public int LearnerID { get; set; }
    [Required]
    public string FirstMidName { get; set; }
    [Required]
    public string LastName { get; set; }
    public DateTime EnrollmentDate { get; set; }

    // Khóa ngoại
    public int MajorID { get; set; }
    [ForeignKey("MajorID")]
    public virtual Major? Major { get; set; }
}