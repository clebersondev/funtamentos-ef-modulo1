using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEF.Models;
[Table("Tag")]
public class Tag
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Slug { get; set; } = String.Empty;
}