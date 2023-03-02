namespace Ejercicio2
{
    partial class Form1
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
            this.cambiarConexion = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cambiarConexion
            // 
            this.cambiarConexion.Location = new System.Drawing.Point(50, 282);
            this.cambiarConexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cambiarConexion.Name = "cambiarConexion";
            this.cambiarConexion.Size = new System.Drawing.Size(378, 100);
            this.cambiarConexion.TabIndex = 0;
            this.cambiarConexion.Text = "Cambiar Conexion";
            this.cambiarConexion.UseVisualStyleBackColor = true;
            this.cambiarConexion.Click += new System.EventHandler(this.cambiarConexion_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(50, 40);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(146, 91);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(285, 40);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(156, 91);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Lista";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(140, 183);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(286, 26);
            this.txtUsuario.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(500, 40);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ReadOnly = true;
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuesta.Size = new System.Drawing.Size(583, 339);
            this.txtRespuesta.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 483);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.cambiarConexion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cambiarConexion;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRespuesta;
    }
}

