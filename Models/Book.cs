using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Book
    {

        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter a Title")]
        public string Title { get; set; }

        public string AuthorFirst { get; set; }

        public string AuthorMiddle { get; set; }

        [Required(ErrorMessage = "Please enter the Authors Last Name")]
        public string AuthorLast { get; set; }

        [Required(ErrorMessage = "Please enter the Publisher")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Please enter the ISBN")]
        [RegularExpression(@"^[0-9]{3}-[0-9]{10}$", ErrorMessage = "Not a Valid ISBN")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Please enter the Classification")]
        public string Classification { get; set; }

        [Required(ErrorMessage = "Please enter the Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter the Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter the page number")]
        public int PageNum { get; set; }

        
    }
}
