using sis_proyecto.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace sis_proyecto.Contexto
{
    public partial class ModelSistema : DbContext
    {
        public ModelSistema()
            : base("name=ModelSistema")
        {
        }
        public DbSet<User> Users{get; set;}
        public DbSet<Book> Books{ get; set; }




    }
}
