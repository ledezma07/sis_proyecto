using sis_proyecto.Contexto;
using sis_proyecto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sis_proyecto.Controllers
{
    internal class UserController
    {
        ModelSistema _context = new ModelSistema();
        public List<User> GetUsers()
        { 
            return _context.Users.ToList();
        }
            
        public List<User> Search(string para)
        {
            if (string.IsNullOrEmpty(para))
                return GetUsers();
            else
                return _context.Users.Where(x => x.Cuenta.Contains(para) || x.FullName.Contains(para)).ToList();
        }
        public bool create(User user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges()>0;

        }

        public bool Update(User user)
        {
            _context.Users.Attach(user);
            _context.Entry(user).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public bool Delete(User user)
        { 
            _context.Users.Remove(user);
            return _context.SaveChanges()>0;
        }

     }
}
