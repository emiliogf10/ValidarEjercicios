namespace ClienteEjercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bTime = new System.Windows.Forms.Button();
            this.bDate = new System.Windows.Forms.Button();
            this.bAll = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bConexion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblRspuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bTime
            // 
            this.bTime.Location = new System.Drawing.Point(130, 25);
            this.bTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bTime.Name = "bTime";
            this.bTime.Size = new System.Drawing.Size(223, 83);
            this.bTime.TabIndex = 0;
            this.bTime.Text = "Time";
            this.bTime.UseVisualStyleBackColor = true;
            this.bTime.Click += new System.EventHandler(this.bTime_Click);
            // 
            // bDate
            // 
            this.bDate.Location = new System.Drawing.Point(427, 25);
            this.bDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bDate.Name = "bDate";
            this.bDate.Size = new System.Drawing.Size(189, 88);
            this.bDate.TabIndex = 1;
            this.bDate.Text = "Date";
            this.bDate.UseVisualStyleBackColor = true;
            this.bDate.Click += new System.EventHandler(this.bDate_Click);
            // 
            // bAll
            // 
            this.bAll.Location = new System.Drawing.Point(130, 180);
            this.bAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAll.Name = "bAll";
            this.bAll.Size = new System.Drawing.Size(223, 87);
            this.bAll.TabIndex = 2;
            this.bAll.Text = "All";
            this.bAll.UseVisualStyleBackColor = true;
            this.bAll.Click += new System.EventHandler(this.bAll_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(427, 178);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(193, 88);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bConexion
            // 
            this.bConexion.Location = new System.Drawing.Point(130, 465);
            this.bConexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bConexion.Name = "bConexion";
            this.bConexion.Size = new System.Drawing.Size(490, 128);
            this.bConexion.TabIndex = 8;
            this.bConexion.Text = "Cambiar conexion";
            this.bConexion.UseVisualStyleBackColor = true;
            this.bConexion.Click += new System.EventHandler(this.bConexion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(431, 315);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(187, 31);
            this.txtContraseña.TabIndex = 11;
            // 
            // lblRspuesta
            // 
            this.lblRspuesta.AutoSize = true;
            this.lblRspuesta.Location = new System.Drawing.Point(146, 416);
            this.lblRspuesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRspuesta.Name = "lblRspuesta";
            this.lblRspuesta.Size = new System.Drawing.Size(0, 25);
            this.lblRspuesta.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 623);
            this.Controls.Add(this.lblRspuesta);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bConexion);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAll);
            this.Controls.Add(this.bDate);
            this.Controls.Add(this.bTime);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bTime;
        private Button bDate;
        private Button bAll;
        private Button bClose;
        private Button bConexion;
        private Label label3;
        private TextBox txtContraseña;
        private Label lblRspuesta;
    }
}