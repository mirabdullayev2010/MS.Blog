using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MS.Blog.Domain.Entities;

[Table("users")]
public class User : BaseEntity
{
    [Column("full_name"), MaxLength(50)]
    public required string FullName { get; set; }
    [Column("email")]
    public required string Email { get; set; }
    [Column("password")]
    public required string Password { get; set; }
    [Column("role")]
    public required string Role { get; set; }
    public ICollection<Post> Posts { get; set; } = new List<Post>();

}
