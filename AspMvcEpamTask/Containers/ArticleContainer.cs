using AspMvcEpamTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMvcEpamTask.Containers
{
    public class ArticleContainer
    {
        private List<Article> articles;

        public ArticleContainer()
        {
            DateTime dateTime = new DateTime(2020, 1, 1, 10, 20, 24);
            articles = new List<Article>(10);
            articles.Add(new Article("Rock music", dateTime,
                "Rock music is a broad genre of popular music that originated as 'rock and roll'" +
                " the United States in the early 1950s, and developed into a range of different styles in" +
                "the 1960s and later, particularly in the United States and the United Kingdom."));
            dateTime = dateTime.AddSeconds(333333);

            articles.Add(new Article("Pop music", dateTime,
                "Pop music is a genre of popular music that originated in" +
                " its modern forms in the US and the UK during the mid-" +
                " 1950s. The terms 'popular music' and 'pop music' are" +
                "often used interchangeably, although the former describes" +
                "all music that is popular and includes many diverse styles."));
            dateTime = dateTime.AddSeconds(335555);

            articles.Add(new Article("Jazz music", dateTime,
                "Jazz is a music genre that originated in the African-American communities of New Orleans," +
                " United States. It originated in the late 19th and early 20th centuries, and developed from roots in" +
                " blues and ragtime. Jazz is seen by many as 'America's' classical music."));
            dateTime = dateTime.AddSeconds(335555);

            articles.Add(new Article("Hip-Hop music", dateTime,
                "The term hip hop music is sometimes used synonymously with the term rap music," +
                " though rapping is not a required component of hip hop music; the genre may also" +
                " incorporate other elements of hip hop culture, including DJing, turntablism," +
                "scratching, beatboxing, and instrumental tracks."));
            dateTime = dateTime.AddSeconds(335555);

            articles.Add(new Article("Electronic music", dateTime,
                "Electronic music is music that employs electronic musical instruments, digitalz`" +
                "instruments and circuitry-based music technology. ... Pure electronic instruments do" +
                "not have vibrating strings, hammers, or other sound-producing mechanisms. Devices" +
                "such as the theremin, synthesizer, and computer can produce electronic sounds."));
            dateTime = dateTime.AddSeconds(335555);

            articles.Add(new Article("Country music", dateTime,
                "Country music, also known as country and western (or simply country)," +
                " and hillbilly music, is a genre of popular music that originated in the Southern United States in the early 1920s." +
                " term country music is used today to describe many styles and subgenres."));
            dateTime = dateTime.AddSeconds(335555);

        }
        public List<Article> getArticles() => articles;
    }

}