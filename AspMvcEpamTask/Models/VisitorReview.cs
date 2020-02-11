using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMvcEpamTask.Models
{
    public class VisitorReview
    {
        public VisitorReview(string authorName, DateTime dateOfReview, string reviewText)
        {
            AuthorName = authorName ?? throw new ArgumentNullException(nameof(authorName));
            DateOfReview = dateOfReview;
            ReviewText = reviewText ?? throw new ArgumentNullException(nameof(reviewText));
        }

        public string AuthorName { get; set; }
        public DateTime DateOfReview { get; set; }
        public string ReviewText { get; set; }
    }
}
