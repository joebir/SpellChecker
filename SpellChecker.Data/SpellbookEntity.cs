using System;
using System.ComponentModel.DataAnnotations;

namespace SpellChecker.Data
{
    public class SpellbookEntity
    {
        [Key]
        public int SpellbookId { get; set; }

        [Required]
        public string SpellbookName { get; set; }

        [Required]
        public Guid UserId { get; set; }
    }
}