using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bookISBN { get; set; }
        public string bookTitle { get; set; }
        public string bookAuthor { get; set; }
        public bool isAvailable { get; set; }
    }
}