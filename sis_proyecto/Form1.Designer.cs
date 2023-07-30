namespace sis_proyecto
{
    partial class frm_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_usuariuo = new System.Windows.Forms.Button();
            this.btn_libros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_usuariuo
            // 
            this.btn_usuariuo.Location = new System.Drawing.Point(208, 125);
            this.btn_usuariuo.Name = "btn_usuariuo";
            this.btn_usuariuo.Size = new System.Drawing.Size(140, 87);
            this.btn_usuariuo.TabIndex = 0;
            this.btn_usuariuo.Text = "USUARIO";
            this.btn_usuariuo.UseVisualStyleBackColor = true;
            this.btn_usuariuo.Click += new System.EventHandler(this.btn_usuariuo_Click);
            // 
            // btn_libros
            // 
            this.btn_libros.Location = new System.Drawing.Point(354, 130);
            this.btn_libros.Name = "btn_libros";
            this.btn_libros.Size = new System.Drawing.Size(140, 82);
            this.btn_libros.TabIndex = 1;
            this.btn_libros.Text = "LIBROS";
            this.btn_libros.UseVisualStyleBackColor = true;
            this.btn_libros.Click += new System.EventHandler(this.btn_libros_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_libros);
            this.Controls.Add(this.btn_usuariuo);
            this.Name = "frm_principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_usuariuo;
        private System.Windows.Forms.Button btn_libros;
    }
}

