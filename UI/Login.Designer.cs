namespace PPAI24
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtNombreUsuario = new TextBox();
            txtClaveUsuario = new TextBox();
            lblTitleLogin = new Label();
            btnIngresarUsuario = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnlLoginMove = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(232, 75);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.ForeColor = Color.White;
            lblContraseña.Location = new Point(208, 128);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(86, 20);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(321, 72);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(173, 27);
            txtNombreUsuario.TabIndex = 2;
            // 
            // txtClaveUsuario
            // 
            txtClaveUsuario.Location = new Point(321, 125);
            txtClaveUsuario.Name = "txtClaveUsuario";
            txtClaveUsuario.PasswordChar = '•';
            txtClaveUsuario.Size = new Size(173, 27);
            txtClaveUsuario.TabIndex = 3;
            txtClaveUsuario.KeyPress += txtClaveUsuario_KeyPress;
            // 
            // lblTitleLogin
            // 
            lblTitleLogin.AutoSize = true;
            lblTitleLogin.ForeColor = Color.White;
            lblTitleLogin.Location = new Point(370, 25);
            lblTitleLogin.Name = "lblTitleLogin";
            lblTitleLogin.Size = new Size(63, 20);
            lblTitleLogin.TabIndex = 4;
            lblTitleLogin.Text = "Acceder";
            // 
            // btnIngresarUsuario
            // 
            btnIngresarUsuario.BackColor = Color.White;
            btnIngresarUsuario.FlatAppearance.BorderColor = Color.White;
            btnIngresarUsuario.FlatAppearance.BorderSize = 0;
            btnIngresarUsuario.FlatStyle = FlatStyle.Flat;
            btnIngresarUsuario.ForeColor = Color.Black;
            btnIngresarUsuario.Location = new Point(400, 178);
            btnIngresarUsuario.Name = "btnIngresarUsuario";
            btnIngresarUsuario.Size = new Size(94, 29);
            btnIngresarUsuario.TabIndex = 5;
            btnIngresarUsuario.Text = "Ingresar";
            btnIngresarUsuario.UseVisualStyleBackColor = false;
            btnIngresarUsuario.Click += btnIngresarUsuario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 232);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-57, -48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlLoginMove
            // 
            pnlLoginMove.Dock = DockStyle.Top;
            pnlLoginMove.Location = new Point(171, 0);
            pnlLoginMove.Name = "pnlLoginMove";
            pnlLoginMove.Size = new Size(351, 27);
            pnlLoginMove.TabIndex = 7;
            pnlLoginMove.MouseDown += pnlLoginMove_MouseDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(522, 232);
            Controls.Add(pnlLoginMove);
            Controls.Add(panel1);
            Controls.Add(btnIngresarUsuario);
            Controls.Add(lblTitleLogin);
            Controls.Add(txtClaveUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtNombreUsuario;
        private TextBox txtClaveUsuario;
        private Label lblTitleLogin;
        private Button btnIngresarUsuario;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel pnlLoginMove;
    }
}
