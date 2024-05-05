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

            }
        }

        private void btnSelResenia_Click(object sender, EventArgs e)
        {
            if(rbReseniaNormal.Checked || rbReseniaSommelier.Checked || rbReseniaAmigos.Checked)
            {
                pnlRangoFecha.Visible = false;
                pnlTipoResenia.Visible = false;
                pnlExportRanking.Visible = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de reseña");

            }
        }




    }
}
