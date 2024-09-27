using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public string Language { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Display(Name ="Date Of Published")]
        public DateTime DatePublished { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl  { get; set; }
        
    }
}
