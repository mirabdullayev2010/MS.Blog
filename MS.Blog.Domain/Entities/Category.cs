using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MS.Blog.Domain.Entities;

[Table("categories")]
public class Category : BaseEntity
{
    [Column("name"), MaxLength(50)]
    public required string Name { get; set; }
    [Column("description"), MaxLength(500)]
    public string? Description { get; set; }
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}
