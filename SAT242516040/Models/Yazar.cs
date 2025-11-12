using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SAT242516040.Models
{
    public class Yazar
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Ad { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Soyad { get; set; } = string.Empty;

        [Required, StringLength(100)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public List<Yayin>? Yayinlar { get; set; }
    }
}
