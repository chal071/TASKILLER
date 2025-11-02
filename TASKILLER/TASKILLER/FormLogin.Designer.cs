namespace TASKILLER
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelIniciaSesion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelConTuCuenta = new System.Windows.Forms.Label();
            this.labelTaskiller = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.linkLabelCredenciales = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelIniciaSesion
            // 
            this.labelIniciaSesion.AutoSize = true;
            this.labelIniciaSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelIniciaSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciaSesion.Location = new System.Drawing.Point(39, 154);
            this.labelIniciaSesion.Name = "labelIniciaSesion";
            this.labelIniciaSesion.Size = new System.Drawing.Size(132, 25);
            this.labelIniciaSesion.TabIndex = 1;
            this.labelIniciaSesion.Text = "Inicia sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // labelConTuCuenta
            // 
            this.labelConTuCuenta.AutoSize = true;
            this.labelConTuCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConTuCuenta.Location = new System.Drawing.Point(39, 190);
            this.labelConTuCuenta.Name = "labelConTuCuenta";
            this.labelConTuCuenta.Size = new System.Drawing.Size(156, 25);
            this.labelConTuCuenta.TabIndex = 3;
            this.labelConTuCuenta.Text = "con tu cuenta de";
            // 
            // labelTaskiller
            // 
            this.labelTaskiller.AutoSize = true;
            this.labelTaskiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskiller.Location = new System.Drawing.Point(39, 226);
            this.labelTaskiller.Name = "labelTaskiller";
            this.labelTaskiller.Size = new System.Drawing.Size(129, 25);
            this.labelTaskiller.TabIndex = 4;
            this.labelTaskiller.Text = "TASKILLER";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(258, 177);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(259, 22);
            this.textBoxMail.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(258, 234);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(259, 22);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.BackColor = System.Drawing.SystemColors.Control;
            this.buttonIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarSesion.Location = new System.Drawing.Point(398, 306);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(119, 40);
            this.buttonIniciarSesion.TabIndex = 7;
            this.buttonIniciarSesion.Text = "Iniciar sesión";
            this.buttonIniciarSesion.UseVisualStyleBackColor = false;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.ButtonIniciarSesion_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(255, 154);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(139, 16);
            this.labelMail.TabIndex = 8;
            this.labelMail.Text = "Correo electrónico:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(255, 211);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(90, 16);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Contraseña:";
            // 
            // linkLabelCredenciales
            // 
            this.linkLabelCredenciales.AutoSize = true;
            this.linkLabelCredenciales.Location = new System.Drawing.Point(255, 271);
            this.linkLabelCredenciales.Name = "linkLabelCredenciales";
            this.linkLabelCredenciales.Size = new System.Drawing.Size(185, 16);
            this.linkLabelCredenciales.TabIndex = 10;
            this.linkLabelCredenciales.TabStop = true;
            this.linkLabelCredenciales.Text = "¿Has olvidado tu contraseña?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(534, 267);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 646);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.linkLabelCredenciales);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelTaskiller);
            this.Controls.Add(this.labelConTuCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIniciaSesion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TASKILLER - Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelIniciaSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConTuCuenta;
        private System.Windows.Forms.Label labelTaskiller;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.LinkLabel linkLabelCredenciales;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}