﻿using System.ComponentModel.DataAnnotations;

namespace YtBookStore.Models.Domain
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AuthorName { get; set; }
    }
}
