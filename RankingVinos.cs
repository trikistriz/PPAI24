using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        

        private void bntSelExportRanking_Click(object sender, EventArgs e)
        {
            if(rbExportExcel.Checked || rbExportPDF.Checked || rbExportGrid.Checked)
            {
                MessageBox.Show("Confirma la generación del reporte?");

                if (rbExportExcel.Checked)
                {
                    //exportExcel
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
                        RankingExportGrid rankingExportGrid = new RankingExportGrid();
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
