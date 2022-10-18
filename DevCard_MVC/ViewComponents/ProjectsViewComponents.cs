using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        { 
            var projects = new List<Project>
        { 
                new Project(1,"project1","this is first project","mehdi","project-1.jpg"),
                new Project(1,"project2","this is second project","hamid","project-2.jpg"),
                new Project(1,"project3","this is forth project","reza","project-3.jpg"),
                new Project(1,"project4","this is fifth project","omid","project-4.jpg"),

        };
            return View("_Projects",projects);
        }
    }
}
