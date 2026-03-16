using System.ComponentModel.DataAnnotations.Schema;

namespace MS.Blog.Domain.Entities;

[Table("posts")]

public class Post : BaseEntity
{
    [Column("title")]
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required long AuthorId { get; set; }
}
