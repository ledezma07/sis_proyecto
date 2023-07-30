using sis_proyecto.Contexto;
using sis_proyecto.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace sis_proyecto
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            //ModelSistema db = new ModelSistema();
            //var users = db.Users.ToList();   
            //var book = db.Books.ToList();

        }

        private void btn_usuariuo_Click(object sender, EventArgs e)
        {
            sis_proyecto.Vistas.frm_user fr = new  sis_proyecto.Vistas.frm_user();
            fr.ShowDialog();

                    


        }

        private void btn_libros_Click(object sender, EventArgs e)
        {
           sis_proyecto.Vistas.frm_crud_libros frm = new sis_proyecto.Vistas.frm_crud_libros();

      frm.ShowDialog();


        }
    }
}
