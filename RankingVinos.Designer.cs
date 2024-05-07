namespace PPAI24
{
    partial class RankingVinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingVinos));
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
            label1 = new Label();
            pnlRangoFecha.SuspendLayout();
            pnlTipoResenia.SuspendLayout();
            pnlExportRanking.SuspendLayout();
            gpExportRanking.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleRankingVinos
            // 
            lblTitleRankingVinos.AutoSize = true;
            lblTitleRankingVinos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitleRankingVinos.Location = new Point(10, -1);
            lblTitleRankingVinos.Name = "lblTitleRankingVinos";
            lblTitleRankingVinos.Size = new Size(176, 28);
            lblTitleRankingVinos.TabIndex = 0;
            lblTitleRankingVinos.Text = "Ranking de Vinos";
            // 
            // lblRankingInfo
            // 
            lblRankingInfo.AutoSize = true;
            lblRankingInfo.Location = new Point(10, 74);
            lblRankingInfo.Name = "lblRankingInfo";
            lblRankingInfo.Size = new Size(0, 15);
            lblRankingInfo.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(10, 26);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(452, 95);
            textBox1.TabIndex = 3;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnSelRangoFechas
            // 
            btnSelRangoFechas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelRangoFechas.Location = new Point(202, 130);
            btnSelRangoFechas.Margin = new Padding(3, 2, 3, 2);
            btnSelRangoFechas.Name = "btnSelRangoFechas";
            btnSelRangoFechas.Size = new Size(247, 26);
            btnSelRangoFechas.TabIndex = 7;
            btnSelRangoFechas.Text = "Seleccionar Rango de Fechas";
            btnSelRangoFechas.UseVisualStyleBackColor = true;
            btnSelRangoFechas.Click += btnSelRangoFechas_Click;
            // 
            // lblTipoResenia
            // 
            lblTipoResenia.AutoSize = true;
            lblTipoResenia.Location = new Point(17, 9);
            lblTipoResenia.Name = "lblTipoResenia";
            lblTipoResenia.Size = new Size(161, 15);
            lblTipoResenia.TabIndex = 9;
            lblTipoResenia.Text = "Seleccione el tipo de Reseña: ";
            // 
            // rbReseniaNormal
            // 
            rbReseniaNormal.AutoSize = true;
            rbReseniaNormal.Location = new Point(17, 34);
            rbReseniaNormal.Margin = new Padding(3, 2, 3, 2);
            rbReseniaNormal.Name = "rbReseniaNormal";
            rbReseniaNormal.Size = new Size(65, 19);
            rbReseniaNormal.TabIndex = 10;
            rbReseniaNormal.TabStop = true;
            rbReseniaNormal.Text = "Normal";
            rbReseniaNormal.UseVisualStyleBackColor = true;
            // 
            // rbReseniaSommelier
            // 
            rbReseniaSommelier.AutoSize = true;
            rbReseniaSommelier.Location = new Point(17, 56);
            rbReseniaSommelier.Margin = new Padding(3, 2, 3, 2);
            rbReseniaSommelier.Name = "rbReseniaSommelier";
            rbReseniaSommelier.Size = new Size(82, 19);
            rbReseniaSommelier.TabIndex = 11;
            rbReseniaSommelier.TabStop = true;
            rbReseniaSommelier.Text = "Sommelier";
            rbReseniaSommelier.UseVisualStyleBackColor = true;
            // 
            // rbReseniaAmigos
            // 
            rbReseniaAmigos.AutoSize = true;
            rbReseniaAmigos.Location = new Point(17, 79);
            rbReseniaAmigos.Margin = new Padding(3, 2, 3, 2);
            rbReseniaAmigos.Name = "rbReseniaAmigos";
            rbReseniaAmigos.Size = new Size(66, 19);
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
            pnlRangoFecha.Location = new Point(10, 122);
            pnlRangoFecha.Margin = new Padding(3, 2, 3, 2);
            pnlRangoFecha.Name = "pnlRangoFecha";
            pnlRangoFecha.Size = new Size(452, 170);
            pnlRangoFecha.TabIndex = 13;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(202, 49);
            dtpHasta.Margin = new Padding(3, 2, 3, 2);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(242, 23);
            dtpHasta.TabIndex = 6;
            // 
            // lblRangoFechaD
            // 
            lblRangoFechaD.AutoSize = true;
            lblRangoFechaD.Location = new Point(38, 13);
            lblRangoFechaD.Name = "lblRangoFechaD";
            lblRangoFechaD.Size = new Size(79, 15);
            lblRangoFechaD.TabIndex = 1;
            lblRangoFechaD.Text = "Fecha Desde: ";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(202, 9);
            dtpDesde.Margin = new Padding(3, 2, 3, 2);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(242, 23);
            dtpDesde.TabIndex = 4;
            // 
            // lblRangoFechaH
            // 
            lblRangoFechaH.AutoSize = true;
            lblRangoFechaH.Location = new Point(42, 52);
            lblRangoFechaH.Name = "lblRangoFechaH";
            lblRangoFechaH.Size = new Size(77, 15);
            lblRangoFechaH.TabIndex = 5;
            lblRangoFechaH.Text = "Fecha Hasta: ";
            // 
            // pnlTipoResenia
            // 
            pnlTipoResenia.Controls.Add(btnSelResenia);
            pnlTipoResenia.Controls.Add(lblTipoResenia);
            pnlTipoResenia.Controls.Add(rbReseniaNormal);
            pnlTipoResenia.Controls.Add(rbReseniaAmigos);
            pnlTipoResenia.Controls.Add(rbReseniaSommelier);
            pnlTipoResenia.Location = new Point(10, 122);
            pnlTipoResenia.Margin = new Padding(3, 2, 3, 2);
            pnlTipoResenia.Name = "pnlTipoResenia";
            pnlTipoResenia.Size = new Size(452, 170);
            pnlTipoResenia.TabIndex = 14;
            pnlTipoResenia.Visible = false;
            // 
            // btnSelResenia
            // 
            btnSelResenia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelResenia.Location = new Point(271, 130);
            btnSelResenia.Margin = new Padding(3, 2, 3, 2);
            btnSelResenia.Name = "btnSelResenia";
            btnSelResenia.Size = new Size(161, 22);
            btnSelResenia.TabIndex = 13;
            btnSelResenia.Text = "Seleccionar Reseña";
            btnSelResenia.UseVisualStyleBackColor = true;
            btnSelResenia.Click += btnSelResenia_Click;
            // 
            // pnlExportRanking
            // 
            pnlExportRanking.Controls.Add(bntSelExportRanking);
            pnlExportRanking.Controls.Add(gpExportRanking);
            pnlExportRanking.Controls.Add(label1);
            pnlExportRanking.Location = new Point(10, 122);
            pnlExportRanking.Margin = new Padding(3, 2, 3, 2);
            pnlExportRanking.Name = "pnlExportRanking";
            pnlExportRanking.Size = new Size(452, 170);
            pnlExportRanking.TabIndex = 15;
            pnlExportRanking.Visible = false;
            // 
            // bntSelExportRanking
            // 
            bntSelExportRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bntSelExportRanking.Location = new Point(211, 140);
            bntSelExportRanking.Margin = new Padding(3, 2, 3, 2);
            bntSelExportRanking.Name = "bntSelExportRanking";
            bntSelExportRanking.Size = new Size(238, 22);
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
            gpExportRanking.Location = new Point(17, 41);
            gpExportRanking.Margin = new Padding(3, 2, 3, 2);
            gpExportRanking.Name = "gpExportRanking";
            gpExportRanking.Padding = new Padding(3, 2, 3, 2);
            gpExportRanking.Size = new Size(219, 94);
            gpExportRanking.TabIndex = 1;
            gpExportRanking.TabStop = false;
            // 
            // rbExportPDF
            // 
            rbExportPDF.AutoSize = true;
            rbExportPDF.Location = new Point(5, 38);
            rbExportPDF.Margin = new Padding(3, 2, 3, 2);
            rbExportPDF.Name = "rbExportPDF";
            rbExportPDF.Size = new Size(46, 19);
            rbExportPDF.TabIndex = 2;
            rbExportPDF.TabStop = true;
            rbExportPDF.Text = "PDF";
            rbExportPDF.UseVisualStyleBackColor = true;
            // 
            // rbExportGrid
            // 
            rbExportGrid.AutoSize = true;
            rbExportGrid.Location = new Point(5, 60);
            rbExportGrid.Margin = new Padding(3, 2, 3, 2);
            rbExportGrid.Name = "rbExportGrid";
            rbExportGrid.Size = new Size(127, 19);
            rbExportGrid.TabIndex = 1;
            rbExportGrid.TabStop = true;
            rbExportGrid.Text = "Mostrar en Pantalla";
            rbExportGrid.UseVisualStyleBackColor = true;
            // 
            // rbExportExcel
            // 
            rbExportExcel.AutoSize = true;
            rbExportExcel.Location = new Point(5, 15);
            rbExportExcel.Margin = new Padding(3, 2, 3, 2);
            rbExportExcel.Name = "rbExportExcel";
            rbExportExcel.Size = new Size(52, 19);
            rbExportExcel.TabIndex = 0;
            rbExportExcel.TabStop = true;
            rbExportExcel.Text = "Excel";
            rbExportExcel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(292, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione en que formato desea Visualizar el reporte: ";
            // 
            // RankingVinos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 300);
            Controls.Add(pnlExportRanking);
            Controls.Add(pnlTipoResenia);
            Controls.Add(pnlRangoFecha);
            Controls.Add(textBox1);
            Controls.Add(lblRankingInfo);
            Controls.Add(lblTitleRankingVinos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(630, 300);
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
        private Label label1;
        private Button bntSelExportRanking;
        private GroupBox gpExportRanking;
        private RadioButton rbExportPDF;
        private RadioButton rbExportGrid;
        private RadioButton rbExportExcel;
    }
}