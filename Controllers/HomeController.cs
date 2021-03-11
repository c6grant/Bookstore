﻿using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models.ViewModels;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IProjectRepository _repository;

        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IProjectRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //Filtering Data
        public IActionResult Index(string category, int pageNum = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books
                        .Where(b => category == null || b.Category == category)
                        .OrderBy(b => b.BookId)
                        .Skip((pageNum - 1) * PageSize)
                        .Take(PageSize),

                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = pageNum,
                        ItemsPerPage = PageSize,
                        TotalNumItems = category == null ? _repository.Books.Count() :
                        _repository.Books.Where (x => x.Category == category).Count()
                    },

                    Category = category
            });
                
                
        
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
