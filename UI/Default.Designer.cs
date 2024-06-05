namespace PPAI24
{
    partial class Default
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            pnlDefaultMenu = new Panel();
            btnCerrarSesion = new Button();
            btnRanking = new Button();
            pictureBox1 = new PictureBox();
            pbDefaultMenu = new PictureBox();
            pnlDefaultMove = new Panel();
            btnDefaultMenu = new PictureBox();
            pnlDefaultContainer = new Panel();
            ttGenerarRankingVinos = new ToolTip(components);
            ttCerrarSesion = new ToolTip(components);
            pnlDefaultMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDefaultMenu).BeginInit();
            pnlDefaultMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDefaultMenu).BeginInit();
            SuspendLayout();
            // 
            // pnlDefaultMenu
            // 
            pnlDefaultMenu.BackColor = Color.Black;
            pnlDefaultMenu.Controls.Add(btnCerrarSesion);
            pnlDefaultMenu.Controls.Add(btnRanking);
            pnlDefaultMenu.Controls.Add(pictureBox1);
            pnlDefaultMenu.Controls.Add(pbDefaultMenu);
            pnlDefaultMenu.Dock = DockStyle.Left;
            pnlDefaultMenu.Location = new Point(0, 0);
            pnlDefaultMenu.Name = "pnlDefaultMenu";
            pnlDefaultMenu.Size = new Size(260, 451);
            pnlDefaultMenu.TabIndex = 2;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.AccessibleDescription = "Generar Ranking de Vinos";
            btnCerrarSesion.AccessibleName = "Generar Ranking de Vinos";
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(5, 402);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(251, 49);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesión";
            ttCerrarSesion.SetToolTip(btnCerrarSesion, "Cerrar Sesión");
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnRanking
            // 
            btnRanking.AccessibleDescription = "Generar Ranking de Vinos";
            btnRanking.AccessibleName = "Generar Ranking de Vinos";
            btnRanking.FlatAppearance.BorderSize = 0;
            btnRanking.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnRanking.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnRanking.FlatStyle = FlatStyle.Flat;
            btnRanking.Font = new Font("Segoe UI", 10F);
            btnRanking.ForeColor = Color.White;
            btnRanking.Image = (Image)resources.GetObject("btnRanking.Image");
            btnRanking.ImageAlign = ContentAlignment.MiddleLeft;
            btnRanking.Location = new Point(5, 100);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(251, 49);
            btnRanking.TabIndex = 2;
            btnRanking.Text = "Generar Ranking de Vinos";
            btnRanking.TextAlign = ContentAlignment.MiddleRight;
            ttGenerarRankingVinos.SetToolTip(btnRanking, "Generar Ranking de Vinos");
            btnRanking.UseVisualStyleBackColor = true;
            btnRanking.Click += btnRanking_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, -115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pbDefaultMenu
            // 
            pbDefaultMenu.Image = (Image)resources.GetObject("pbDefaultMenu.Image");
            pbDefaultMenu.Location = new Point(-16, -28);
            pbDefaultMenu.Name = "pbDefaultMenu";
            pbDefaultMenu.Size = new Size(114, 115);
            pbDefaultMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pbDefaultMenu.TabIndex = 0;
            pbDefaultMenu.TabStop = false;
            pbDefaultMenu.Click += pbDefaultMenu_Click;
            // 
            // pnlDefaultMove
            // 
            pnlDefaultMove.Controls.Add(btnDefaultMenu);
            pnlDefaultMove.Dock = DockStyle.Top;
            pnlDefaultMove.Location = new Point(260, 0);
            pnlDefaultMove.Name = "pnlDefaultMove";
            pnlDefaultMove.Size = new Size(540, 51);
            pnlDefaultMove.TabIndex = 3;
            pnlDefaultMove.MouseDown += pnlDefaultMove_MouseDown;
            // 
            // btnDefaultMenu
            // 
            btnDefaultMenu.Image = (Image)resources.GetObject("btnDefaultMenu.Image");
            btnDefaultMenu.Location = new Point(6, 9);
            btnDefaultMenu.Name = "btnDefaultMenu";
            btnDefaultMenu.Size = new Size(35, 35);
            btnDefaultMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnDefaultMenu.TabIndex = 0;
            btnDefaultMenu.TabStop = false;
            btnDefaultMenu.Click += btnDefaultMenu_Click;
            // 
            // pnlDefaultContainer
            // 
            pnlDefaultContainer.Dock = DockStyle.Fill;
            pnlDefaultContainer.Location = new Point(260, 51);
            pnlDefaultContainer.Name = "pnlDefaultContainer";
            pnlDefaultContainer.Size = new Size(540, 400);
            pnlDefaultContainer.TabIndex = 4;
            // 
            // Default
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 451);
            Controls.Add(pnlDefaultContainer);
            Controls.Add(pnlDefaultMove);
            Controls.Add(pnlDefaultMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Default";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BonVino StartPage";
            pnlDefaultMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDefaultMenu).EndInit();
            pnlDefaultMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnDefaultMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDefaultMenu;
        private Panel pnlDefaultMove;
        private Panel pnlDefaultContainer;
        private PictureBox btnDefaultMenu;
        private PictureBox pbDefaultMenu;
        private PictureBox pictureBox1;
        private Button btnRanking;
        private ToolTip ttGenerarRankingVinos;
        private Button btnCerrarSesion;
        private ToolTip ttCerrarSesion;
    }
}