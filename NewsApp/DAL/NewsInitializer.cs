using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApp.DAL
{
    public class NewsInitializer : System.Data.Entity.DropCreateDatabaseAlways<NewsContext>
    {
        protected override void Seed(NewsContext context)
        {
            var news = new List<NewsItem>
            {
                new NewsItem{
                    Title="Msjamjamajamamssjadajaj GHR",
                    Text="What?!?!??!?!GFS?!!?",
                    Category="Education",
                    DateCreated=DateTime.Parse("2014-02-20 14:30:00")
                },
                new NewsItem{
                    Title=" GHR",
                    Text="What?!?!??!?!GFS?!!?",
                    Category="Education",
                    DateCreated=DateTime.Parse("2014-02-20 14:30:00")
                
                },
                new NewsItem{
                    Title="Msc-nám i kliniskri sálfalks hefsasda adfaj GHR",
                    Text="What?!?!??!?!GFS?!!?",
                    Category="Education",
                    DateCreated=DateTime.Parse("2014-02-20 14:30:00")
                }
            };

            news.ForEach(s => context.News.Add(s));
            context.SaveChanges();

        }
    }
}