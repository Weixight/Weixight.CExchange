using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weixight.CExchange.AgricGator.Data;
using Weixight.CExchange.AgricGator.Models;

namespace Weixight.CExchange.AgricGator.IntegratedModules
{
    public class NewsService
    {
        private readonly ApplicationDbContext _db;
        public NewsService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<NewsItems> GetAllNewsItem()
        {
            List<NewsItems> newsItems = new List<NewsItems>();
            newsItems = _db.NewsItems.ToList();
            return newsItems;
        }
        public List<NewsItems> GetAllNewsItemActive()
        {
            List<NewsItems> newsItems = new List<NewsItems>();
            newsItems = _db.NewsItems.Where(K=>K.activate ==true).ToList();
            return newsItems;
        }
        public NewsItems GetANew(int id)
        {
            var News = _db.NewsItems.FirstOrDefault(K => K.id == id);
            return News;
        }
    }
}
