using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner2.Data.Models;

[Table("Users")]
public class Users
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; }

    [Required, MaxLength(100)]
    public string Email { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    [MaxLength(10)]
    public string Gender { get; set; }

    public decimal Height { get; set; }
    public decimal Weight { get; set; }

    [MaxLength(50)]
    public string ExperienceLevel { get; set; }

    [MaxLength(255)]
    public string Goals { get; set; }

    //public UserCredentials UserCredentials { get; set; }
}
