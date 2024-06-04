using PPAI24.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PPAI24
{
    public partial class PantallaRanking : Form
    {
        public PantallaRanking()
        {
            InitializeComponent();

        }

        public DateTime fechaReseñaDesde;
        public DateTime fechaReseñaHasta;
        public bool tipoReseña; 


        private void btnSelRangoFechas_Click(object sender, EventArgs e)
        {
            DateTime fecha_desde = dtpDesde.Value;
            DateTime fecha_hasta = dtpHasta.Value;

            if (fecha_desde > fecha_hasta)
            {
                MessageBox.Show("El rango de fecha ingresado no es valido");
            }
            else
            {
                pnlRangoFecha.Visible = false;
                pnlTipoResenia.Visible = true;
                pnlExportRanking.Visible = false;

                fechaReseñaDesde = fecha_desde;
                fechaReseñaHasta = fecha_hasta;

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
                }
                else
                {
                        
                    tipoReseña = true;
                    
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de reseña");

            }
        }

        //public class Vino
        //{
        //    public int Posicion { get; set; }
        //    public string Nombre { get; set; }
        //    public double CalificacionSommelier { get; set; }
        //    public double CalificacionGeneral { get; set; }
        //    public decimal PrecioSugerido { get; set; }
        //    public string Bodega { get; set; }
        //    public string Varietal { get; set; }
        //    public string Region { get; set; }
        //    public string Pais { get; set; }
        //}

        
        

        private void bntSelExportRanking_Click(object sender, EventArgs e)
        {
            ControladorGenerarRanking controlador_generar_ranking = new ControladorGenerarRanking();

            if (rbExportExcel.Checked || rbExportPDF.Checked || rbExportGrid.Checked)
            {
                MessageBox.Show("Confirma la generación del reporte?");

                if (rbExportExcel.Checked)
                {

                    //Excel.Application excelApp = new Excel.Application();
                    //excelApp.Visible = true;

                    //Excel.Workbook workbook = excelApp.Workbooks.Add();
                    //Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                    //worksheet.Cells[1, 1] = "Posición";
                    //worksheet.Cells[1, 2] = "Nombre";
                    //worksheet.Cells[1, 3] = "Calificación Sommelier";
                    //worksheet.Cells[1, 4] = "Calificación General";
                    //worksheet.Cells[1, 5] = "Precio Sugerido";
                    //worksheet.Cells[1, 6] = "Bodega";
                    //worksheet.Cells[1, 7] = "Varietal";
                    //worksheet.Cells[1, 8] = "Región";
                    //worksheet.Cells[1, 9] = "País";

                    //int fila = 2;
                    //var listVinos = new List<Vino>();
                    //listVinos = GenerarRanking();
                    //foreach (var vino in listVinos)
                    //{
                    //    worksheet.Cells[fila, 1] = vino.Nombre;
                    //    worksheet.Cells[fila, 2] = vino.CalificacionSommelier;
                    //    worksheet.Cells[fila, 3] = vino.CalificacionGeneral;
                    //    worksheet.Cells[fila, 5] = vino.PrecioSugerido;
                    //    worksheet.Cells[fila, 6] = vino.Bodega;
                    //    worksheet.Cells[fila, 7] = vino.Varietal;
                    //    worksheet.Cells[fila, 8] = vino.Region;
                    //    worksheet.Cells[fila, 9] = vino.Pais;
                    //    fila++;
                    //}

                    //// Guardar el archivo de Excel
                    //workbook.SaveAs("D:\\trikiz\\Descargas\\RankingVino.xlsx");
                    //workbook.Close();
                    //excelApp.Quit();
                }
                else
                {
                    if (rbExportPDF.Checked)
                    {
                        //exportPDF
                    }
                    else
                    {
                        //exportGrid
                        //List<object> list = new List<object>();
                        //RankingExportGrid rankingExportGrid = new RankingExportGrid(list);
                        //rankingExportGrid.Show();
                        DataTable ranking = controlador_generar_ranking.GenerarRankingVinos(tipoReseña, fechaReseñaDesde, fechaReseñaHasta);
                        RankingExportGrid rankingExportGrid = new RankingExportGrid(ranking);
                        rankingExportGrid.Show();
                        //dataGridRanking.Visible = true;
                        //dataGridRanking.DataSource = ranking;

                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un formato para mostrar Ranking");
            }
        } 
    }
}
