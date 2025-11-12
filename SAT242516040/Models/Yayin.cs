using SAT242516040.Models;
using System.ComponentModel.DataAnnotations;

public class Yayin
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Baslik { get; set; } = string.Empty;

    public DateTime? YayinTarihi { get; set; }   // SQL’de YayinTarihi sütunu

    public string? Dergi { get; set; }

    public int YazarId { get; set; }

    public Yazar? Yazar { get; set; }           // Navigation property
}
