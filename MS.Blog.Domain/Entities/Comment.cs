using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MS.Blog.Domain.Entities;

[Table("comments")]
public class Comment : BaseEntity
{
    [Column("user_name"), MaxLength(50)]
    public required string UserName { get; set; }
    [Column("text"),]
    public required string Text { get; set; }
    [Column("post_id")]
    public long PostId { get; set; }
    [ForeignKey("PostId")]
    public virtual Post Post { get; set; } = null!;
}