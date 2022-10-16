using System.Collections.Generic;

namespace DevCard_MVC.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }

    }
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Description { get; set; }

    }
    public class IndexModel
    {
        public List<Project> Projects { get; set; }
        public List<Article> Articles { get; set; }

    }
}
