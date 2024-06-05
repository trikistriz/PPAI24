namespace PPAI24
{
    partial class PantallaRanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRanking));
            lblTitleRankingVinos = new Label();
            lblRankingInfo = new Label();
            txtBoxDescripcion = new TextBox();
            btnSelRangoFechas = new Button();
            rbReseniaNormal = new RadioButton();
            rbReseniaSommelier = new RadioButton();
            rbReseniaAmigos = new RadioButton();
            pnlRangoFecha = new Panel();
            dtpHasta = new DateTimePicker();
            lblRangoFechaD = new Label();
            dtpDesde = new DateTimePicker();
            lblRangoFechaH = new Label();
            btnCancelar = new Button();
            pnlTipoResenia = new Panel();
            btnVolverAFechas = new Button();
            gpTipoResenia = new GroupBox();
            btnSelResenia = new Button();
            pnlExportRanking = new Panel();
            bntSelExportRanking = new Button();
            gpExportRanking = new GroupBox();
            rbExportPDF = new RadioButton();
            rbExportGrid = new RadioButton();
            rbExportExcel = new RadioButton();
            txtBoxFiltros = new TextBox();
            btnVolverATipoR = new Button();
            pnlRangoFecha.SuspendLayout();
            pnlTipoResenia.SuspendLayout();
            gpTipoResenia.SuspendLayout();
            pnlExportRanking.SuspendLayout();
            gpExportRanking.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleRankingVinos
            // 
            lblTitleRankingVinos.AutoSize = true;
            lblTitleRankingVinos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitleRankingVinos.Location = new Point(11, -1);
            lblTitleRankingVinos.Name = "lblTitleRankingVinos";
            lblTitleRankingVinos.Size = new Size(218, 35);
            lblTitleRankingVinos.TabIndex = 0;
            lblTitleRankingVinos.Text = "Ranking de Vinos";
            // 
            // lblRankingInfo
            // 
            lblRankingInfo.AutoSize = true;
            lblRankingInfo.Location = new Point(11, 99);
            lblRankingInfo.Name = "lblRankingInfo";
            lblRankingInfo.Size = new Size(0, 20);
            lblRankingInfo.TabIndex = 2;
            // 
            // txtBoxDescripcion
            // 
            txtBoxDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxDescripcion.Location = new Point(11, 37);
            txtBoxDescripcion.Multiline = true;
            txtBoxDescripcion.Name = "txtBoxDescripcion";
            txtBoxDescripcion.ReadOnly = true;
            txtBoxDescripcion.Size = new Size(697, 91);
            txtBoxDescripcion.TabIndex = 3;
            txtBoxDescripcion.Text = resources.GetString("txtBoxDescripcion.Text");
            // 
            // btnSelRangoFechas
            // 
            btnSelRangoFechas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelRangoFechas.Location = new Point(174, 187);
            btnSelRangoFechas.Name = "btnSelRangoFechas";
            btnSelRangoFechas.Size = new Size(320, 30);
            btnSelRangoFechas.TabIndex = 7;
            btnSelRangoFechas.Text = "Seleccionar Rango de Fechas";
            btnSelRangoFechas.UseVisualStyleBackColor = true;
            btnSelRangoFechas.Click += btnSelRangoFechas_Click;
            // 
            // rbReseniaNormal
            // 
            rbReseniaNormal.AutoSize = true;
            rbReseniaNormal.Location = new Point(21, 23);
            rbReseniaNormal.Name = "rbReseniaNormal";
            rbReseniaNormal.Size = new Size(80, 24);
            rbReseniaNormal.TabIndex = 10;
            rbReseniaNormal.TabStop = true;
            rbReseniaNormal.Text = "Normal";
            rbReseniaNormal.UseVisualStyleBackColor = true;
            // 
            // rbReseniaSommelier
            // 
            rbReseniaSommelier.AutoSize = true;
            rbReseniaSommelier.Location = new Point(21, 53);
            rbReseniaSommelier.Name = "rbReseniaSommelier";
            rbReseniaSommelier.Size = new Size(102, 24);
            rbReseniaSommelier.TabIndex = 11;
            rbReseniaSommelier.TabStop = true;
            rbReseniaSommelier.Text = "Sommelier";
            rbReseniaSommelier.UseVisualStyleBackColor = true;
            // 
            // rbReseniaAmigos
            // 
            rbReseniaAmigos.AutoSize = true;
            rbReseniaAmigos.Location = new Point(21, 83);
            rbReseniaAmigos.Name = "rbReseniaAmigos";
            rbReseniaAmigos.Size = new Size(81, 24);
            rbReseniaAmigos.TabIndex = 12;
            rbReseniaAmigos.TabStop = true;
            rbReseniaAmigos.Text = "Amigos";
            rbReseniaAmigos.UseVisualStyleBackColor = true;
            // 
            // pnlRangoFecha
            // 
            pnlRangoFecha.Controls.Add(dtpHasta);
            pnlRangoFecha.Controls.Add(lblRangoFechaD);
            pnlRangoFecha.Controls.Add(btnSelRangoFechas);
            pnlRangoFecha.Controls.Add(dtpDesde);
            pnlRangoFecha.Controls.Add(lblRangoFechaH);
            pnlRangoFecha.Location = new Point(11, 163);
            pnlRangoFecha.Name = "pnlRangoFecha";
            pnlRangoFecha.Size = new Size(555, 227);
            pnlRangoFecha.TabIndex = 13;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(131, 81);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(363, 27);
            dtpHasta.TabIndex = 6;
            // 
            // lblRangoFechaD
            // 
            lblRangoFechaD.AutoSize = true;
            lblRangoFechaD.Location = new Point(25, 24);
            lblRangoFechaD.Name = "lblRangoFechaD";
            lblRangoFechaD.Size = new Size(100, 20);
            lblRangoFechaD.TabIndex = 1;
            lblRangoFechaD.Text = "Fecha Desde: ";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(131, 17);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(363, 27);
            dtpDesde.TabIndex = 4;
            // 
            // lblRangoFechaH
            // 
            lblRangoFechaH.AutoSize = true;
            lblRangoFechaH.Location = new Point(25, 88);
            lblRangoFechaH.Name = "lblRangoFechaH";
            lblRangoFechaH.Size = new Size(96, 20);
            lblRangoFechaH.TabIndex = 5;
            lblRangoFechaH.Text = "Fecha Hasta: ";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(604, 350);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 30);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnlTipoResenia
            // 
            pnlTipoResenia.Controls.Add(btnVolverAFechas);
            pnlTipoResenia.Controls.Add(gpTipoResenia);
            pnlTipoResenia.Controls.Add(btnSelResenia);
            pnlTipoResenia.Location = new Point(11, 163);
            pnlTipoResenia.Name = "pnlTipoResenia";
            pnlTipoResenia.Size = new Size(555, 227);
            pnlTipoResenia.TabIndex = 14;
            pnlTipoResenia.Visible = false;
            // 
            // btnVolverAFechas
            // 
            btnVolverAFechas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVolverAFechas.Location = new Point(19, 187);
            btnVolverAFechas.Name = "btnVolverAFechas";
            btnVolverAFechas.Size = new Size(106, 30);
            btnVolverAFechas.TabIndex = 15;
            btnVolverAFechas.Text = "Volver";
            btnVolverAFechas.UseVisualStyleBackColor = true;
            btnVolverAFechas.Click += btnVolverAFechas_Click;
            // 
            // gpTipoResenia
            // 
            gpTipoResenia.Controls.Add(rbReseniaSommelier);
            gpTipoResenia.Controls.Add(rbReseniaAmigos);
            gpTipoResenia.Controls.Add(rbReseniaNormal);
            gpTipoResenia.Location = new Point(19, 17);
            gpTipoResenia.Name = "gpTipoResenia";
            gpTipoResenia.Size = new Size(532, 125);
            gpTipoResenia.TabIndex = 14;
            gpTipoResenia.TabStop = false;
            gpTipoResenia.Text = "Seleccione el tipo de Reseña: ";
            // 
            // btnSelResenia
            // 
            btnSelResenia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelResenia.Location = new Point(311, 187);
            btnSelResenia.Name = "btnSelResenia";
            btnSelResenia.Size = new Size(222, 30);
            btnSelResenia.TabIndex = 13;
            btnSelResenia.Text = "Seleccionar Reseña";
            btnSelResenia.UseVisualStyleBackColor = true;
            btnSelResenia.Click += btnSelResenia_Click;
            // 
            // pnlExportRanking
            // 
            pnlExportRanking.Controls.Add(btnVolverATipoR);
            pnlExportRanking.Controls.Add(bntSelExportRanking);
            pnlExportRanking.Controls.Add(gpExportRanking);
            pnlExportRanking.Location = new Point(11, 163);
            pnlExportRanking.Name = "pnlExportRanking";
            pnlExportRanking.Size = new Size(555, 227);
            pnlExportRanking.TabIndex = 15;
            pnlExportRanking.Visible = false;
            // 
            // bntSelExportRanking
            // 
            bntSelExportRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bntSelExportRanking.Location = new Point(223, 187);
            bntSelExportRanking.Name = "bntSelExportRanking";
            bntSelExportRanking.Size = new Size(310, 30);
            bntSelExportRanking.TabIndex = 2;
            bntSelExportRanking.Text = "Seleccionar Formato Ranking";
            bntSelExportRanking.UseVisualStyleBackColor = true;
            bntSelExportRanking.Click += bntSelExportRanking_Click;
            // 
            // gpExportRanking
            // 
            gpExportRanking.Controls.Add(rbExportPDF);
            gpExportRanking.Controls.Add(rbExportGrid);
            gpExportRanking.Controls.Add(rbExportExcel);
            gpExportRanking.Location = new Point(19, 12);
            gpExportRanking.Name = "gpExportRanking";
            gpExportRanking.Size = new Size(532, 125);
            gpExportRanking.TabIndex = 1;
            gpExportRanking.TabStop = false;
            gpExportRanking.Text = "Seleccione en que formato desea Visualizar el reporte: ";
            // 
            // rbExportPDF
            // 
            rbExportPDF.AutoSize = true;
            rbExportPDF.Location = new Point(6, 51);
            rbExportPDF.Name = "rbExportPDF";
            rbExportPDF.Size = new Size(56, 24);
            rbExportPDF.TabIndex = 2;
            rbExportPDF.TabStop = true;
            rbExportPDF.Text = "PDF";
            rbExportPDF.UseVisualStyleBackColor = true;
            // 
            // rbExportGrid
            // 
            rbExportGrid.AutoSize = true;
            rbExportGrid.Location = new Point(6, 80);
            rbExportGrid.Name = "rbExportGrid";
            rbExportGrid.Size = new Size(157, 24);
            rbExportGrid.TabIndex = 1;
            rbExportGrid.TabStop = true;
            rbExportGrid.Text = "Mostrar en Pantalla";
            rbExportGrid.UseVisualStyleBackColor = true;
            // 
            // rbExportExcel
            // 
            rbExportExcel.AutoSize = true;
            rbExportExcel.Location = new Point(6, 20);
            rbExportExcel.Name = "rbExportExcel";
            rbExportExcel.Size = new Size(64, 24);
            rbExportExcel.TabIndex = 0;
            rbExportExcel.TabStop = true;
            rbExportExcel.Text = "Excel";
            rbExportExcel.UseVisualStyleBackColor = true;
            // 
            // txtBoxFiltros
            // 
            txtBoxFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxFiltros.Location = new Point(572, 163);
            txtBoxFiltros.Multiline = true;
            txtBoxFiltros.Name = "txtBoxFiltros";
            txtBoxFiltros.ReadOnly = true;
            txtBoxFiltros.Size = new Size(136, 165);
            txtBoxFiltros.TabIndex = 16;
            // 
            // btnVolverATipoR
            // 
            btnVolverATipoR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVolverATipoR.Location = new Point(19, 187);
            btnVolverATipoR.Name = "btnVolverATipoR";
            btnVolverATipoR.Size = new Size(106, 30);
            btnVolverATipoR.TabIndex = 17;
            btnVolverATipoR.Text = "Volver";
            btnVolverATipoR.UseVisualStyleBackColor = true;
            btnVolverATipoR.Click += btnVolverATipoR_Click;
            // 
            // PantallaRanking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 400);
            Controls.Add(txtBoxFiltros);
            Controls.Add(btnCancelar);
            Controls.Add(txtBoxDescripcion);
            Controls.Add(lblRankingInfo);
            Controls.Add(lblTitleRankingVinos);
            Controls.Add(pnlExportRanking);
            Controls.Add(pnlTipoResenia);
            Controls.Add(pnlRangoFecha);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(720, 400);
            Name = "PantallaRanking";
            Text = "RankingVinos";
            pnlRangoFecha.ResumeLayout(false);
            pnlRangoFecha.PerformLayout();
            pnlTipoResenia.ResumeLayout(false);
            gpTipoResenia.ResumeLayout(false);
            gpTipoResenia.PerformLayout();
            pnlExportRanking.ResumeLayout(false);
            gpExportRanking.ResumeLayout(false);
            gpExportRanking.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleRankingVinos;
        private Label lblRankingInfo;
        private TextBox txtBoxDescripcion;
        private Button btnSelRangoFechas;
        private RadioButton rbReseniaNormal;
        private RadioButton rbReseniaSommelier;
        private RadioButton rbReseniaAmigos;
        private Panel pnlRangoFecha;
        private DateTimePicker dtpHasta;
        private Label lblRangoFechaD;
        private DateTimePicker dtpDesde;
        private Label lblRangoFechaH;
        private Panel pnlTipoResenia;
        private Button btnSelResenia;
        private Panel pnlExportRanking;
        private Button bntSelExportRanking;
        private GroupBox gpExportRanking;
        private RadioButton rbExportPDF;
        private RadioButton rbExportGrid;
        private RadioButton rbExportExcel;
        private GroupBox gpTipoResenia;
        private Button btnCancelar;
        private TextBox txtBoxFiltros;
        private Button btnVolverAFechas;
        private Button btnVolverATipoR;
    }
}