namespace ClienteEjercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIpNueva = new System.Windows.Forms.TextBox();
            this.txtPuertoNuevo = new System.Windows.Forms.TextBox();
            this.lblIPantigua = new System.Windows.Forms.Label();
            this.lblPuertoAntiguo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP antigua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto antiguo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puerto nuevo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "IP nueva";
            // 
            // txtIpNueva
            // 
            this.txtIpNueva.Location = new System.Drawing.Point(155, 156);
            this.txtIpNueva.Name = "txtIpNueva";
            this.txtIpNueva.Size = new System.Drawing.Size(224, 23);
            this.txtIpNueva.TabIndex = 5;
            // 
            // txtPuertoNuevo
            // 
            this.txtPuertoNuevo.Location = new System.Drawing.Point(155, 204);
            this.txtPuertoNuevo.Name = "txtPuertoNuevo";
            this.txtPuertoNuevo.Size = new System.Drawing.Size(224, 23);
            this.txtPuertoNuevo.TabIndex = 6;
            // 
            // lblIPantigua
            // 
            this.lblIPantigua.AutoSize = true;
            this.lblIPantigua.Location = new System.Drawing.Point(155, 47);
            this.lblIPantigua.Name = "lblIPantigua";
            this.lblIPantigua.Size = new System.Drawing.Size(0, 15);
            this.lblIPantigua.TabIndex = 7;
            // 
            // lblPuertoAntiguo
            // 
            this.lblPuertoAntiguo.AutoSize = true;
            this.lblPuertoAntiguo.Location = new System.Drawing.Point(155, 106);
            this.lblPuertoAntiguo.Name = "lblPuertoAntiguo";
            this.lblPuertoAntiguo.Size = new System.Drawing.Size(0, 15);
            this.lblPuertoAntiguo.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cambiar conexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPuertoAntiguo);
            this.Controls.Add(this.lblIPantigua);
            this.Controls.Add(this.txtPuertoNuevo);
            this.Controls.Add(this.txtIpNueva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIpNueva;
        private TextBox txtPuertoNuevo;
        private Label lblIPantigua;
        private Label lblPuertoAntiguo;
        private Button button1;
    }
}