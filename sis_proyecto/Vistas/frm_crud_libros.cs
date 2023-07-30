using sis_proyecto.Controllers;
using sis_proyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sis_proyecto.Vistas
{
    public partial class frm_crud_libros : Form
    {
        public frm_crud_libros()
        {
            InitializeComponent();
        }

        BookController _bookController = new BookController();
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            var book = (Book)booksBindingSource.Current;
            _bookController.Create(book);
        }
    }
}
