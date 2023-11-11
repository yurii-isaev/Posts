using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesCrm.Domains.Identities;

namespace SalesCrm.Domains.Entities;

public class News
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public DateTime Date { get; set; }

    [ForeignKey("Author")]
    public string? AuthorId { get; set; }
    public User? Author { get; set; }

    public DateTime CreateDate { get; set; }

    public bool IsActive { get; set; }
}
