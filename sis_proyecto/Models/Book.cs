using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sis_proyecto.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string titlet { get; set; }
        [Required]
        public string Autor { get; set; }
        [Required]
        public string User { get; set;}

    }
}
