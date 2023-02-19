using System.ComponentModel.DataAnnotations;

namespace YtBookStore.Models.Domain
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
