namespace PPAI24
{
    partial class RankingExportGrid
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
            pnlRankingExportGridMove = new Panel();
            dgvRankingVinos = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            calificacion_sommelier = new DataGridViewTextBoxColumn();
            calificacion_general = new DataGridViewTextBoxColumn();
            precio_sugerido = new DataGridViewTextBoxColumn();
            bodega = new DataGridViewTextBoxColumn();
            varietal = new DataGridViewTextBoxColumn();
            region = new DataGridViewTextBoxColumn();
            pais = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRankingVinos).BeginInit();
            SuspendLayout();
            // 
            // pnlRankingExportGridMove
            // 
            pnlRankingExportGridMove.Dock = DockStyle.Top;
            pnlRankingExportGridMove.Location = new Point(0, 0);
            pnlRankingExportGridMove.Name = "pnlRankingExportGridMove";
            pnlRankingExportGridMove.Size = new Size(1620, 51);
            pnlRankingExportGridMove.TabIndex = 4;
            pnlRankingExportGridMove.MouseDown += pnlRankingExportGridMove_MouseDown;
            // 
            // dgvRankingVinos
            // 
            dgvRankingVinos.AllowUserToAddRows = false;
            dgvRankingVinos.AllowUserToDeleteRows = false;
            dgvRankingVinos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRankingVinos.BorderStyle = BorderStyle.None;
            dgvRankingVinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRankingVinos.Columns.AddRange(new DataGridViewColumn[] { nombre, calificacion_sommelier, calificacion_general, precio_sugerido, bodega, varietal, region, pais });
            dgvRankingVinos.Dock = DockStyle.Fill;
            dgvRankingVinos.Location = new Point(0, 51);
            dgvRankingVinos.Margin = new Padding(3, 4, 3, 4);
            dgvRankingVinos.Name = "dgvRankingVinos";
            dgvRankingVinos.ReadOnly = true;
            dgvRankingVinos.RowHeadersWidth = 51;
            dgvRankingVinos.Size = new Size(1620, 449);
            dgvRankingVinos.TabIndex = 5;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // calificacion_sommelier
            // 
            calificacion_sommelier.HeaderText = "Calificación Sommelier";
            calificacion_sommelier.MinimumWidth = 6;
            calificacion_sommelier.Name = "calificacion_sommelier";
            calificacion_sommelier.ReadOnly = true;
            // 
            // calificacion_general
            // 
            calificacion_general.HeaderText = "Calificación General";
            calificacion_general.MinimumWidth = 6;
            calificacion_general.Name = "calificacion_general";
            calificacion_general.ReadOnly = true;
            // 
            // precio_sugerido
            // 
            precio_sugerido.HeaderText = "Precio Sugerido";
            precio_sugerido.MinimumWidth = 6;
            precio_sugerido.Name = "precio_sugerido";
            precio_sugerido.ReadOnly = true;
            // 
            // bodega
            // 
            bodega.HeaderText = "Bodega";
            bodega.MinimumWidth = 6;
            bodega.Name = "bodega";
            bodega.ReadOnly = true;
            // 
            // varietal
            // 
            varietal.HeaderText = "Varietal";
            varietal.MinimumWidth = 6;
            varietal.Name = "varietal";
            varietal.ReadOnly = true;
            // 
            // region
            // 
            region.HeaderText = "Región";
            region.MinimumWidth = 6;
            region.Name = "region";
            region.ReadOnly = true;
            // 
            // pais
            // 
            pais.HeaderText = "País";
            pais.MinimumWidth = 6;
            pais.Name = "pais";
            pais.ReadOnly = true;
            // 
            // RankingExportGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 500);
            Controls.Add(dgvRankingVinos);
            Controls.Add(pnlRankingExportGridMove);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RankingExportGrid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RankingExportGrid";
            ((System.ComponentModel.ISupportInitialize)dgvRankingVinos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRankingExportGridMove;
        private DataGridView dgvRankingVinos;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn calificacion_sommelier;
        private DataGridViewTextBoxColumn calificacion_general;
        private DataGridViewTextBoxColumn precio_sugerido;
        private DataGridViewTextBoxColumn bodega;
        private DataGridViewTextBoxColumn varietal;
        private DataGridViewTextBoxColumn region;
        private DataGridViewTextBoxColumn pais;
    }
}