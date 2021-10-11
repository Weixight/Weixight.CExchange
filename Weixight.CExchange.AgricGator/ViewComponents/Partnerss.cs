using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weixight.CExchange.AgricGator.IntegratedModules;

namespace Weixight.CExchange.AgricGator.ViewComponents
{
    public class Partnerss :ViewComponent
    {
        private readonly NewsService _newsService;
        private readonly FixedChar _fixedChar;
        public Partnerss(NewsService newsService)
        {
            _newsService = newsService;
        }
        public IViewComponentResult Invoke()
        {
            var model = _newsService.GetAllNewsItemActive();
            return View("Default", model);

        }
    }
}
