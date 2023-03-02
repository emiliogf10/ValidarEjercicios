namespace Ejercicio2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txtPuertoNuevo = new System.Windows.Forms.TextBox();
            this.txtIPNueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPantiguo = new System.Windows.Forms.Label();
            this.lblIPantigua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(121, 242);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(211, 23);
            this.btnCambiar.TabIndex = 0;
            this.btnCambiar.Text = "Cambiar conexion";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // txtPuertoNuevo
            // 
            this.txtPuertoNuevo.Location = new System.Drawing.Point(168, 169);
            this.txtPuertoNuevo.Name = "txtPuertoNuevo";
            this.txtPuertoNuevo.Size = new System.Drawing.Size(131, 20);
            this.txtPuertoNuevo.TabIndex = 1;
            // 
            // txtIPNueva
            // 
            this.txtIPNueva.Location = new System.Drawing.Point(168, 134);
            this.txtIPNueva.Name = "txtIPNueva";
            this.txtIPNueva.Size = new System.Drawing.Size(131, 20);
            this.txtIPNueva.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP antgua:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puerto antiguo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP nueva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puerto nuevo:";
            // 
            // lblPantiguo
            // 
            this.lblPantiguo.AutoSize = true;
            this.lblPantiguo.Location = new System.Drawing.Point(185, 80);
            this.lblPantiguo.Name = "lblPantiguo";
            this.lblPantiguo.Size = new System.Drawing.Size(0, 13);
            this.lblPantiguo.TabIndex = 7;
            // 
            // lblIPantigua
            // 
            this.lblIPantigua.AutoSize = true;
            this.lblIPantigua.Location = new System.Drawing.Point(185, 52);
            this.lblIPantigua.Name = "lblIPantigua";
            this.lblIPantigua.Size = new System.Drawing.Size(0, 13);
            this.lblIPantigua.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 309);
            this.Controls.Add(this.lblIPantigua);
            this.Controls.Add(this.lblPantiguo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIPNueva);
            this.Controls.Add(this.txtPuertoNuevo);
            this.Controls.Add(this.btnCambiar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txtPuertoNuevo;
        private System.Windows.Forms.TextBox txtIPNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPantiguo;
        private System.Windows.Forms.Label lblIPantigua;
    }
}