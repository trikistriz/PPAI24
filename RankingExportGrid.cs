using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI24
{
    public partial class RankingExportGrid : Form
    {
        public RankingExportGrid()
        {
            InitializeComponent();
            CargarRanking();
            foreach (DataGridViewColumn columna in dgvRankingVinos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        //para poder desplazar desde panel superior
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pnlRankingExportGridMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //--------------------------------------------------------------------------------------------


        private void CargarRanking()
        {
            dgvRankingVinos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Establece AutoSizeRowsMode para ajustar automáticamente el alto de las filas
            dgvRankingVinos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Establece Dock para anclar el DataGridView al contenedor padre
            dgvRankingVinos.Dock = DockStyle.Fill;

            //DataGridViewRow fila = new DataGridViewRow();
            //DataGridViewTextBoxCell cNombre = new DataGridViewTextBoxCell();
            //cNombre.Value = "Bianchi";
            //fila.Cells.Add(cNombre);

            //dgvRankingVinos.Rows.Add(fila);

            dgvRankingVinos.Rows.Clear();

            // Definimos los datos de los vinos
            var vinos = new List<object[]>
            {
                new object[] { "Almaviva", "4.50", "4.80", "150.00", "Viña Almaviva", "Cabernet Sauvignon, Carménère", "Valle de Maipo", "Chile" },
                new object[] { "Catena Zapata Nicolás Catena Zapata", "4.70", "4.50", "100.00", "Bodega Catena Zapata", "Cabernet Sauvignon, Malbec", "Mendoza", "Argentina" },
                new object[] { "Viña Cobos Bramare Malbec Marchiori Vineyard", "4.70", "4.80", "80.00", "Viña Cobos", "Malbec", "Mendoza", "Argentina" },
                new object[] { "Lapostolle Clos Apalta", "4.60", "4.70", "120.00", "Viña Lapostolle", "Carmenère, Cabernet Sauvignon, Merlot", "Valle de Colchagua", "Chile" },
                new object[] { "Bodega Garzón Single Vineyard Petit Verdot", "4.50", "4.60", "60.00", "Bodega Garzón", "Petit Verdot", "Maldonado", "Uruguay" },
                new object[] { "Viña Ventisquero Grey Carmenere", "4.50", "4.60", "30.00", "Viña Ventisquero", "Carmenère", "Valle del Maipo", "Chile" },
                new object[] { "Terrazas de los Andes Single Vineyard Las Compuertas Malbec", "4.40", "4.50", "50.00", "Terrazas de los Andes", "Malbec", "Mendoza", "Argentina" },
                new object[] { "Casa Silva Microterroir de los Lingues Carmenere", "4.40", "4.50", "40.00", "Casa Silva", "Carmenère", "Valle de Colchagua", "Chile" },
                new object[] { "Zuccardi Aluvional Paraje Altamira Malbec", "4.30", "4.40", "70.00", "Zuccardi", "Malbec", "Valle de Uco", "Argentina" },
                new object[] { "Concha y Toro Don Melchor", "4.30", "4.40", "80.00", "Viña Concha y Toro", "Cabernet Sauvignon", "Puente Alto", "Chile" }
            };

            // Iteramos sobre la lista de vinos y agregamos cada uno al DataGridView
            foreach (var vino in vinos)
            {
                DataGridViewRow fila = new DataGridViewRow();

                foreach (var valor in vino)
                {
                    DataGridViewTextBoxCell celda = new DataGridViewTextBoxCell();
                    celda.Value = valor;
                    fila.Cells.Add(celda);
                }

                dgvRankingVinos.Rows.Add(fila);
            }


        }

    }
}
