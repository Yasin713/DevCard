using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        

        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"article 1","this is my first article this is my first article","blog-post-thumb-1.jpg"),
                new Article(2,"article 1","this is my second article this is my second article","blog-post-thumb-2.jpg"),
                new Article(3,"article 1","this is my third article this is my third article","blog-post-thumb-3.jpg"),
                new Article(4,"article 1","this is my forth article this is my forth article","blog-post-thumb-4.jpg"),

            };
            return View("Articles",articles);
        }
    }
}
