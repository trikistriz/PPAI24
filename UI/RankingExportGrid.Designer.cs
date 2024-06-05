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
            btnCerrar = new Button();
            dgvRankingVinos = new DataGridView();
            lblTitleRankingVinos = new Label();
            nombre = new DataGridViewTextBoxColumn();
            calificacion_sommelier = new DataGridViewTextBoxColumn();
            precio_sugerido = new DataGridViewTextBoxColumn();
            bodega = new DataGridViewTextBoxColumn();
            varietal = new DataGridViewTextBoxColumn();
            region = new DataGridViewTextBoxColumn();
            pais = new DataGridViewTextBoxColumn();
            pnlRankingExportGridMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRankingVinos).BeginInit();
            SuspendLayout();
            // 
            // pnlRankingExportGridMove
            // 
            pnlRankingExportGridMove.Controls.Add(btnCerrar);
            pnlRankingExportGridMove.Dock = DockStyle.Top;
            pnlRankingExportGridMove.Location = new Point(0, 0);
            pnlRankingExportGridMove.Margin = new Padding(0);
            pnlRankingExportGridMove.Name = "pnlRankingExportGridMove";
            pnlRankingExportGridMove.Size = new Size(1621, 29);
            pnlRankingExportGridMove.TabIndex = 4;
            pnlRankingExportGridMove.MouseDown += pnlRankingExportGridMove_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.WindowFrame;
            btnCerrar.Location = new Point(1590, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(28, 26);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dgvRankingVinos
            // 
            dgvRankingVinos.AllowUserToAddRows = false;
            dgvRankingVinos.AllowUserToDeleteRows = false;
            dgvRankingVinos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRankingVinos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRankingVinos.BackgroundColor = SystemColors.Control;
            dgvRankingVinos.BorderStyle = BorderStyle.None;
            dgvRankingVinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRankingVinos.Columns.AddRange(new DataGridViewColumn[] { nombre, calificacion_sommelier, precio_sugerido, bodega, varietal, region, pais });
            dgvRankingVinos.Location = new Point(0, 73);
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
            dgvRankingVinos.Size = new Size(1621, 383);
            dgvRankingVinos.TabIndex = 5;
            // 
            // lblTitleRankingVinos
            // 
            lblTitleRankingVinos.AutoSize = true;
            lblTitleRankingVinos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitleRankingVinos.Location = new Point(0, 29);
            lblTitleRankingVinos.Name = "lblTitleRankingVinos";
            lblTitleRankingVinos.Size = new Size(218, 35);
            lblTitleRankingVinos.TabIndex = 6;
            lblTitleRankingVinos.Text = "Ranking de Vinos";
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nombre.DataPropertyName = "nombre";
            nombre.Frozen = true;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.SortMode = DataGridViewColumnSortMode.NotSortable;
            nombre.Width = 200;
            // 
            // calificacion_sommelier
            // 
            calificacion_sommelier.DataPropertyName = "calificacion_sommelier";
            calificacion_sommelier.HeaderText = "Calificación Sommelier";
            calificacion_sommelier.MinimumWidth = 6;
            calificacion_sommelier.Name = "calificacion_sommelier";
            calificacion_sommelier.ReadOnly = true;
            // 
            // precio_sugerido
            // 
            precio_sugerido.DataPropertyName = "precio_sugerido";
            precio_sugerido.HeaderText = "Precio Sugerido";
            precio_sugerido.MinimumWidth = 6;
            precio_sugerido.Name = "precio_sugerido";
            precio_sugerido.ReadOnly = true;
            precio_sugerido.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // bodega
            // 
            bodega.DataPropertyName = "bodega";
            bodega.HeaderText = "Bodega";
            bodega.MinimumWidth = 6;
            bodega.Name = "bodega";
            bodega.ReadOnly = true;
            bodega.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // varietal
            // 
            varietal.DataPropertyName = "varietal";
            varietal.HeaderText = "Varietal";
            varietal.MinimumWidth = 6;
            varietal.Name = "varietal";
            varietal.ReadOnly = true;
            varietal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // region
            // 
            region.DataPropertyName = "region";
            region.HeaderText = "Región";
            region.MinimumWidth = 6;
            region.Name = "region";
            region.ReadOnly = true;
            region.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // pais
            // 
            pais.DataPropertyName = "pais";
            pais.HeaderText = "País";
            pais.MinimumWidth = 6;
            pais.Name = "pais";
            pais.ReadOnly = true;
            pais.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // RankingExportGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 525);
            Controls.Add(lblTitleRankingVinos);
            Controls.Add(dgvRankingVinos);
            Controls.Add(pnlRankingExportGridMove);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RankingExportGrid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RankingExportGrid";
            pnlRankingExportGridMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRankingVinos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlRankingExportGridMove;
        private DataGridView dgvRankingVinos;
        private Button btnCerrar;
        private Label lblTitleRankingVinos;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn calificacion_sommelier;
        private DataGridViewTextBoxColumn precio_sugerido;
        private DataGridViewTextBoxColumn bodega;
        private DataGridViewTextBoxColumn varietal;
        private DataGridViewTextBoxColumn region;
        private DataGridViewTextBoxColumn pais;
    }
}