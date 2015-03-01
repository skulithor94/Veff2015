using NewsApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApp.Models
{
    public class NewsRepository
    {
        NewsContext m_db = new NewsContext();

        public IEnumerable<NewsItem> GetAllNews()
        {
            var result = from s in m_db.News
                         select s;
            return result;
        }
    }
}