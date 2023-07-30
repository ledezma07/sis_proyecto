using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sis_proyecto.Models
{
    public class User
    {
        [Key]
        [Required]
        public string Cuenta { get; set; }
        [Required]
        public string Password { get; set; }
        public string FullName { get; set; }

        public List<Book> Books { get; set; }



    }
}
