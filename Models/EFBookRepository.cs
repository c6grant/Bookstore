using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class EFBookRepository : IProjectRepository
    {

        private ProjectDBContext _context;

        //Constructor
        public EFBookRepository (ProjectDBContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }




}

