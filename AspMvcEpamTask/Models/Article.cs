using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMvcEpamTask.Models
{
    public class Article
    {
        public Article(string articleName, DateTime articlePublishedDate, string articleText)
        {
            ArticleName = articleName ?? throw new ArgumentNullException(nameof(articleName));
            ArticlePublishedDate = articlePublishedDate;
            ArticleText = articleText ?? throw new ArgumentNullException(nameof(articleText));
        }

        public string ArticleName { get; set; }
        public DateTime ArticlePublishedDate { get; set; }
        public string ArticleText { get; set; }
    }
}