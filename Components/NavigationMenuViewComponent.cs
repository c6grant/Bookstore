using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private IProjectRepository repository;

        public NavigationMenuViewComponent (IProjectRepository r)
        {
            repository = r;
        }


        //Makes NavMenu work and able to fitler on category
        public IViewComponentResult Invoke()
        {

           
            
            ViewBag.SelectedCat = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
