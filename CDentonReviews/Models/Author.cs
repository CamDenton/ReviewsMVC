using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CDentonReviews.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        [Display(Name = "Name:")]
        public string AuthorName { get; set; }

        public virtual ICollection<Review> Review { get; set; }
    }
}