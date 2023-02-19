using System.ComponentModel.DataAnnotations;

namespace YtBookStore.Models.Domain
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PublisherName { get; set; }
    }
}
