using sis_proyecto.Contexto;
using sis_proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace sis_proyecto.Controllers
{
    internal class BookController
    {
        ModelSistema _context = new ModelSistema(); 
        public List<Book> GetBook()
        {
            return _context.Books.ToList();
        }
        public bool Create(Book book)
        { 
            _context.Books.Add(book);   
            return _context.SaveChanges()>0;
        }
        



    }
}
