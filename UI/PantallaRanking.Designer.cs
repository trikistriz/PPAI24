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
            textBox1 = new TextBox();
            btnSelRangoFechas = new Button();
            lblTipoResenia = new Label();
            rbReseniaNormal = new RadioButton();
            rbReseniaSommelier = new RadioButton();
            rbReseniaAmigos = new RadioButton();
            pnlRangoFecha = new Panel();
            dtpHasta = new DateTimePicker();
            lblRangoFechaD = new Label();
            dtpDesde = new DateTimePicker();
            lblRangoFechaH = new Label();
            pnlTipoResenia = new Panel();
            btnSelResenia = new Button();
            pnlExportRanking = new Panel();
            bntSelExportRanking = new Button();
            gpExportRanking = new GroupBox();
            rbExportPDF = new RadioButton();
            rbExportGrid = new RadioButton();
            rbExportExcel = new RadioButton();
            lblFormatoReporte = new Label();
            gpTipoResenia = new GroupBox();
            pnlRangoFecha.SuspendLayout();
            pnlTipoResenia.SuspendLayout();
            pnlExportRanking.SuspendLayout();
            gpExportRanking.SuspendLayout();
            gpTipoResenia.SuspendLayout();
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(11, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(516, 125);
            textBox1.TabIndex = 3;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnSelRangoFechas
            // 
            btnSelRangoFechas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelRangoFechas.Location = new Point(231, 173);
            btnSelRangoFechas.Name = "btnSelRangoFechas";
            btnSelRangoFechas.Size = new Size(282, 35);
            btnSelRangoFechas.TabIndex = 7;
            btnSelRangoFechas.Text = "Seleccionar Rango de Fechas";
            btnSelRangoFechas.UseVisualStyleBackColor = true;
            btnSelRangoFechas.Click += btnSelRangoFechas_Click;
            // 
            // lblTipoResenia
            // 
            lblTipoResenia.AutoSize = true;
            lblTipoResenia.Location = new Point(19, 12);
            lblTipoResenia.Name = "lblTipoResenia";
            lblTipoResenia.Size = new Size(206, 20);
            lblTipoResenia.TabIndex = 9;
            lblTipoResenia.Text = "Seleccione el tipo de Reseña: ";
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
            pnlRangoFecha.Size = new Size(517, 227);
            pnlRangoFecha.TabIndex = 13;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(231, 65);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(276, 27);
            dtpHasta.TabIndex = 6;
            // 
            // lblRangoFechaD
            // 
            lblRangoFechaD.AutoSize = true;
            lblRangoFechaD.Location = new Point(43, 17);
            lblRangoFechaD.Name = "lblRangoFechaD";
            lblRangoFechaD.Size = new Size(100, 20);
            lblRangoFechaD.TabIndex = 1;
            lblRangoFechaD.Text = "Fecha Desde: ";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(231, 12);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(276, 27);
            dtpDesde.TabIndex = 4;
            // 
            // lblRangoFechaH
            // 
            lblRangoFechaH.AutoSize = true;
            lblRangoFechaH.Location = new Point(48, 69);
            lblRangoFechaH.Name = "lblRangoFechaH";
            lblRangoFechaH.Size = new Size(96, 20);
            lblRangoFechaH.TabIndex = 5;
            lblRangoFechaH.Text = "Fecha Hasta: ";
            // 
            // pnlTipoResenia
            // 
            pnlTipoResenia.Controls.Add(gpTipoResenia);
            pnlTipoResenia.Controls.Add(btnSelResenia);
            pnlTipoResenia.Controls.Add(lblTipoResenia);
            pnlTipoResenia.Location = new Point(11, 163);
            pnlTipoResenia.Name = "pnlTipoResenia";
            pnlTipoResenia.Size = new Size(517, 227);
            pnlTipoResenia.TabIndex = 14;
            pnlTipoResenia.Visible = false;
            // 
            // btnSelResenia
            // 
            btnSelResenia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelResenia.Location = new Point(310, 173);
            btnSelResenia.Name = "btnSelResenia";
            btnSelResenia.Size = new Size(184, 29);
            btnSelResenia.TabIndex = 13;
            btnSelResenia.Text = "Seleccionar Reseña";
            btnSelResenia.UseVisualStyleBackColor = true;
            btnSelResenia.Click += btnSelResenia_Click;
            // 
            // pnlExportRanking
            // 
            pnlExportRanking.Controls.Add(bntSelExportRanking);
            pnlExportRanking.Controls.Add(gpExportRanking);
            pnlExportRanking.Controls.Add(lblFormatoReporte);
            pnlExportRanking.Location = new Point(11, 163);
            pnlExportRanking.Name = "pnlExportRanking";
            pnlExportRanking.Size = new Size(517, 227);
            pnlExportRanking.TabIndex = 15;
            pnlExportRanking.Visible = false;
            // 
            // bntSelExportRanking
            // 
            bntSelExportRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bntSelExportRanking.Location = new Point(241, 187);
            bntSelExportRanking.Name = "bntSelExportRanking";
            bntSelExportRanking.Size = new Size(272, 29);
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
            gpExportRanking.Location = new Point(19, 55);
            gpExportRanking.Name = "gpExportRanking";
            gpExportRanking.Size = new Size(250, 125);
            gpExportRanking.TabIndex = 1;
            gpExportRanking.TabStop = false;
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
            // lblFormatoReporte
            // 
            lblFormatoReporte.AutoSize = true;
            lblFormatoReporte.Location = new Point(19, 21);
            lblFormatoReporte.Name = "lblFormatoReporte";
            lblFormatoReporte.Size = new Size(373, 20);
            lblFormatoReporte.TabIndex = 0;
            lblFormatoReporte.Text = "Seleccione en que formato desea Visualizar el reporte: ";
            // 
            // gpTipoResenia
            // 
            gpTipoResenia.Controls.Add(rbReseniaSommelier);
            gpTipoResenia.Controls.Add(rbReseniaAmigos);
            gpTipoResenia.Controls.Add(rbReseniaNormal);
            gpTipoResenia.Location = new Point(19, 40);
            gpTipoResenia.Name = "gpTipoResenia";
            gpTipoResenia.Size = new Size(250, 125);
            gpTipoResenia.TabIndex = 14;
            gpTipoResenia.TabStop = false;
            // 
            // RankingVinos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 400);
            Controls.Add(textBox1);
            Controls.Add(lblRankingInfo);
            Controls.Add(lblTitleRankingVinos);
            Controls.Add(pnlExportRanking);
            Controls.Add(pnlTipoResenia);
            Controls.Add(pnlRangoFecha);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(720, 400);
            Name = "RankingVinos";
            Text = "RankingVinos";
            pnlRangoFecha.ResumeLayout(false);
            pnlRangoFecha.PerformLayout();
            pnlTipoResenia.ResumeLayout(false);
            pnlTipoResenia.PerformLayout();
            pnlExportRanking.ResumeLayout(false);
            pnlExportRanking.PerformLayout();
            gpExportRanking.ResumeLayout(false);
            gpExportRanking.PerformLayout();
            gpTipoResenia.ResumeLayout(false);
            gpTipoResenia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleRankingVinos;
        private Label lblRankingInfo;
        private TextBox textBox1;
        private Button btnSelRangoFechas;
        private Label lblTipoResenia;
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
        private Label lblFormatoReporte;
        private Button bntSelExportRanking;
        private GroupBox gpExportRanking;
        private RadioButton rbExportPDF;
        private RadioButton rbExportGrid;
        private RadioButton rbExportExcel;
        private GroupBox gpTipoResenia;
    }
}