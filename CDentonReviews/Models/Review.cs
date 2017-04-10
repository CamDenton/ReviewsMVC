using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDentonReviews.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Display(Name = "Title:")]
        public string ReviewTitle { get; set; }
        [Display(Name = "Rating Out of 10:")]
        public int Rating { get; set; }
        [Display(Name = "Content")]
        public string ReviewContent { get; set; }
        [Display(Name = "Date Added:")]
        public DateTime PublishedDate { get; set; }

        public virtual ICollection<Category> Category { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
    }
}