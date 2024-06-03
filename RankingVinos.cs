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
    public partial class RankingVinos : Form
    {
        public RankingVinos()
        {
            InitializeComponent();

        }

        public static DateTime fechaReseniaDesde;
        public static DateTime fechaReseniaHasta;
        public static String tipoResenia; 


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

                fechaReseniaDesde = fecha_desde;
                fechaReseniaHasta = fecha_hasta;

            }
        }

        private void btnSelResenia_Click(object sender, EventArgs e)
        {
            if (rbReseniaNormal.Checked || rbReseniaSommelier.Checked || rbReseniaAmigos.Checked)
            {
                pnlRangoFecha.Visible = false;
                pnlTipoResenia.Visible = false;
                pnlExportRanking.Visible = true;

                if (rbReseniaNormal.Checked)
                {
                    tipoResenia = "N";
                }
                else
                {
                    if (rbReseniaAmigos.Checked)
                    {
                        tipoResenia = "A";
                    }
                    else
                    {
                        tipoResenia = "S";
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de reseña");

            }
        }

        public class Vino
        {
            public int Posicion { get; set; }
            public string Nombre { get; set; }
            public double CalificacionSommelier { get; set; }
            public double CalificacionGeneral { get; set; }
            public decimal PrecioSugerido { get; set; }
            public string Bodega { get; set; }
            public string Varietal { get; set; }
            public string Region { get; set; }
            public string Pais { get; set; }
        }

        private List<Vino> GenerarRanking()
        {
            var listaVinos = new List<Vino>();
            var listVinos = new List<object[]>
            {
                new object[] { "1","Almaviva", "4.50", "4.80", "150.00", "Viña Almaviva", "Cabernet Sauvignon, Carménère", "Valle de Maipo", "Chile" },
                new object[] { "2","Catena Zapata Nicolás Catena Zapata", "4.70", "4.50", "100.00", "Bodega Catena Zapata", "Cabernet Sauvignon, Malbec", "Mendoza", "Argentina" },
                new object[] { "3","Viña Cobos Bramare Malbec Marchiori Vineyard", "4.70", "4.80", "80.00", "Viña Cobos", "Malbec", "Mendoza", "Argentina" },
                new object[] { "4","Lapostolle Clos Apalta", "4.60", "4.70", "120.00", "Viña Lapostolle", "Carmenère, Cabernet Sauvignon, Merlot", "Valle de Colchagua", "Chile" },
                new object[] { "5","Bodega Garzón Single Vineyard Petit Verdot", "4.50", "4.60", "60.00", "Bodega Garzón", "Petit Verdot", "Maldonado", "Uruguay" },
                new object[] { "6","Viña Ventisquero Grey Carmenere", "4.50", "4.60", "30.00", "Viña Ventisquero", "Carmenère", "Valle del Maipo", "Chile" },
                new object[] { "7","Terrazas de los Andes Single Vineyard Las Compuertas Malbec", "4.40", "4.50", "50.00", "Terrazas de los Andes", "Malbec", "Mendoza", "Argentina" },
                new object[] { "8","Casa Silva Microterroir de los Lingues Carmenere", "4.40", "4.50", "40.00", "Casa Silva", "Carmenère", "Valle de Colchagua", "Chile" },
                new object[] { "9","Zuccardi Aluvional Paraje Altamira Malbec", "4.30", "4.40", "70.00", "Zuccardi", "Malbec", "Valle de Uco", "Argentina" },
                new object[] { "10","Concha y Toro Don Melchor", "4.30", "4.40", "80.00", "Viña Concha y Toro", "Cabernet Sauvignon", "Puente Alto", "Chile" }
            };

            foreach (var item in listVinos)
            {
                Vino vino = new Vino
                {
                    Posicion = int.Parse(item[0].ToString()),
                    Nombre = item[1].ToString(),
                    CalificacionSommelier = double.Parse(item[2].ToString()),
                    CalificacionGeneral = double.Parse(item[3].ToString()),
                    PrecioSugerido = decimal.Parse(item[4].ToString()),
                    Bodega = item[5].ToString(),
                    Varietal = item[6].ToString(),
                    Region = item[7].ToString(),
                    Pais = item[8].ToString()
                };

                listaVinos.Add(vino);
            }

            return listaVinos;
        }
        

        private void bntSelExportRanking_Click(object sender, EventArgs e)
        {
            if(rbExportExcel.Checked || rbExportPDF.Checked || rbExportGrid.Checked)
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
                        List<object> list = new List<object>();
                        RankingExportGrid rankingExportGrid = new RankingExportGrid(list);
                        rankingExportGrid.Show();

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
