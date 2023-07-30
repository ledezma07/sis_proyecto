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
    public partial class frm_user : Form
    {
        UserController _userController = new UserController();
        public frm_user()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            userBindingSource.AddNew();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            userBindingSource.CancelEdit();

        }

        private void frm_user_Load(object sender, EventArgs e)
        {
            //userBindingSource.DataSource = _userController.GetUsers();
            userBindingSource.DataSource = _userController.GetUsers();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = (User)userBindingSource.Current;
            _userController.create(user);


        }
    }
}
