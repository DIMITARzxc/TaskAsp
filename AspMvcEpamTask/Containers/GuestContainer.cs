using AspMvcEpamTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMvcEpamTask.Containers
{
    public class GuestContainer
    {
        private List<VisitorReview> reviews;

        public GuestContainer()
        {
            DateTime dateTime = new DateTime(2020, 1, 12);
            reviews = new List<VisitorReview>();
            AddReview(new VisitorReview("Anton", dateTime, "Hello nice blog, i love country so much"));
            dateTime = dateTime.AddSeconds(153153);

        }
        public void AddReview(VisitorReview review)
        {
            reviews.Add(review);
        }
        public List<VisitorReview> getReviewsList() => reviews;
    }
}