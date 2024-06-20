using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using Microsoft.Office.Interop.Excel;
using PPAI24.BE;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PPAI24
{
    public partial class PantallaRanking : Form
    {
        public PantallaRanking()
        {
            InitializeComponent();
        }

        DateTime fechaDesde;
        DateTime fechaHasta;
        public bool tipoReseña;
        ControladorGenerarRanking controlador = new ControladorGenerarRanking();

        private void btnSelRangoFechas_Click(object sender, EventArgs e)
        {
            fechaDesde = dtpDesde.Value;
            fechaHasta = dtpHasta.Value;
            bool fechaValida = controlador.validarFechasDeReseñas(fechaDesde, fechaHasta);

            if (!fechaValida)
                MessageBox.Show("El rango de fechas ingresado no es valido");
            else
            {
                txtBoxFiltros.Text = "Rango de fecha Desde: " + fechaDesde.ToShortDateString() + " Hasta: " + fechaHasta.ToShortDateString();
                pnlExportRanking.Visible = false;
                pnlRangoFecha.Visible = false;
                pnlTipoResenia.Visible = true;
            }
        }

        private void btnSelResenia_Click(object sender, EventArgs e)
        {
            if (rbReseniaNormal.Checked || rbReseniaSommelier.Checked || rbReseniaAmigos.Checked)
            {
                pnlRangoFecha.Visible = false;
                pnlTipoResenia.Visible = false;
                pnlExportRanking.Visible = true;

                if (rbReseniaNormal.Checked || rbReseniaAmigos.Checked)
                {
                    tipoReseña = false;
                    txtBoxFiltros.Text = "Rango de fecha Desde: " + fechaDesde.ToShortDateString() + " Hasta: " + fechaHasta.ToShortDateString() +
                        " Tipo de Reseña: Normal/Amigos";
                }
                else
                {
                    txtBoxFiltros.Text = "Rango de fecha Desde: " + fechaDesde.ToShortDateString() + " Hasta: " + fechaHasta.ToShortDateString() +
                        " Tipo de Reseña: Sommelier";


                    tipoReseña = true;
                }
            }
            else
                MessageBox.Show("Debe seleccionar un tipo de reseña");
        }

        private void bntSelExportRanking_Click(object sender, EventArgs e)
        {
            if (rbExportExcel.Checked || rbExportPDF.Checked || rbExportGrid.Checked)
            {
                DialogResult result = MessageBox.Show("Confirma la generación del reporte seleccionado?", "Generar Reporte", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    System.Data.DataTable ranking = controlador.buscarVinosConReseñasEnPeriodo(tipoReseña, fechaDesde, fechaHasta);
                    Random random = new Random();
                    if (rbExportExcel.Checked)
                    {
                        SLDocument sl_export_excel = new SLDocument();
                        string filePath = "D:\\trikiz\\Descargas\\RankingVino_"+random.Next(1,10000)+".xls";
                        sl_export_excel.ImportDataTable(1, 1, ranking, true);
                        sl_export_excel.SaveAs(filePath);
                        OpenExcelFile(filePath);
                    
                    }
                    else
                    {
                        if (rbExportPDF.Checked)
                        {
                            string filePath = "D:\\trikiz\\Descargas\\RankingVino_" + random.Next(1, 10000) + ".pdf";
                            
                            PdfWriter writer = new PdfWriter(filePath);
                            PdfDocument pdf = new PdfDocument(writer);
                            Document doc_export_pdf = new Document(pdf);

                            Paragraph nombre = new Paragraph("Ranking de Vinos").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20);
                            doc_export_pdf.Add(nombre);

                            LineSeparator ls = new LineSeparator(new SolidLine());
                            doc_export_pdf.Add(ls);

                            Table dt_ranking = new Table(ranking.Columns.Count);

                            foreach (DataColumn columna in ranking.Columns)
                            {
                                dt_ranking.AddHeaderCell(new Cell().Add(new Paragraph(columna.ColumnName)));
                            }

                            foreach (DataRow fila in ranking.Rows)
                            {
                                foreach (var celda in fila.ItemArray)
                                {
                                    dt_ranking.AddCell(new Cell().Add(new Paragraph(celda.ToString())));
                                }
                            }

                            doc_export_pdf.Add(dt_ranking);
                            doc_export_pdf.Close();
                            OpenPdfFile(filePath);
                        }
                        else
                        {
                            //exportGrid
                            RankingExportGrid rankingExportGrid = new RankingExportGrid(ranking);
                            rankingExportGrid.Show();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un formato para mostrar Ranking");
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cancelar la generación del Ranking?", "Volver al Menu Principal", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnVolverAFechas_Click(object sender, EventArgs e)
        {
            pnlRangoFecha.Visible = true;
            pnlTipoResenia.Visible = false;
            pnlExportRanking.Visible = false;
        }

        private void btnVolverATipoR_Click(object sender, EventArgs e)
        {
            pnlRangoFecha.Visible = false;
            pnlTipoResenia.Visible = true;
            pnlExportRanking.Visible = false;
        }

        public void OpenExcelFile(string filePath)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir el archivo: " + ex.Message);
            }
        }

        public void OpenPdfFile(string filePath)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir el archivo: " + ex.Message);
            }
        }
    }
}
