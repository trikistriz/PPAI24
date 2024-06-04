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
            pnlRankingExportGridMove.Margin = new Padding(0);
            pnlRankingExportGridMove.Name = "pnlRankingExportGridMove";
            pnlRankingExportGridMove.Size = new Size(1620, 30);
            pnlRankingExportGridMove.TabIndex = 4;
            pnlRankingExportGridMove.MouseDown += pnlRankingExportGridMove_MouseDown;
            // 
            // dgvRankingVinos
            // 
            dgvRankingVinos.AllowUserToAddRows = false;
            dgvRankingVinos.AllowUserToDeleteRows = false;
            dgvRankingVinos.BackgroundColor = SystemColors.Control;
            dgvRankingVinos.BorderStyle = BorderStyle.None;
            dgvRankingVinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRankingVinos.Columns.AddRange(new DataGridViewColumn[] { nombre, calificacion_sommelier, calificacion_general, precio_sugerido, bodega, varietal, region, pais });
            dgvRankingVinos.Location = new Point(21, 99);
            dgvRankingVinos.Margin = new Padding(0);
            dgvRankingVinos.Name = "dgvRankingVinos";
            dgvRankingVinos.ReadOnly = true;
            dgvRankingVinos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRankingVinos.RowHeadersVisible = false;
            dgvRankingVinos.RowHeadersWidth = 50;
            dgvRankingVinos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRankingVinos.RowTemplate.ReadOnly = true;
            dgvRankingVinos.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvRankingVinos.ScrollBars = ScrollBars.None;
            dgvRankingVinos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRankingVinos.Size = new Size(1468, 333);
            dgvRankingVinos.TabIndex = 5;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nombre.Frozen = true;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 200;
            // 
            // calificacion_sommelier
            // 
            calificacion_sommelier.HeaderText = "Calificación Sommelier";
            calificacion_sommelier.MinimumWidth = 6;
            calificacion_sommelier.Name = "calificacion_sommelier";
            calificacion_sommelier.ReadOnly = true;
            calificacion_sommelier.Width = 182;
            // 
            // calificacion_general
            // 
            calificacion_general.HeaderText = "Calificación General";
            calificacion_general.MinimumWidth = 6;
            calificacion_general.Name = "calificacion_general";
            calificacion_general.ReadOnly = true;
            calificacion_general.Width = 182;
            // 
            // precio_sugerido
            // 
            precio_sugerido.HeaderText = "Precio Sugerido";
            precio_sugerido.MinimumWidth = 6;
            precio_sugerido.Name = "precio_sugerido";
            precio_sugerido.ReadOnly = true;
            precio_sugerido.Width = 182;
            // 
            // bodega
            // 
            bodega.HeaderText = "Bodega";
            bodega.MinimumWidth = 6;
            bodega.Name = "bodega";
            bodega.ReadOnly = true;
            bodega.Width = 182;
            // 
            // varietal
            // 
            varietal.HeaderText = "Varietal";
            varietal.MinimumWidth = 6;
            varietal.Name = "varietal";
            varietal.ReadOnly = true;
            varietal.Width = 182;
            // 
            // region
            // 
            region.HeaderText = "Región";
            region.MinimumWidth = 6;
            region.Name = "region";
            region.ReadOnly = true;
            region.Width = 182;
            // 
            // pais
            // 
            pais.HeaderText = "País";
            pais.MinimumWidth = 6;
            pais.Name = "pais";
            pais.ReadOnly = true;
            pais.Width = 182;
            // 
            // RankingExportGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 525);
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