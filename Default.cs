using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PPAI24
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pnlDefaultMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDefaultMenu_Click(object sender, EventArgs e)
        {
            if (pnlDefaultMenu.Width == 260)
            {
                pnlDefaultMenu.Width = 80;
                btnRanking.Text = "";
                btnRanking.ImageAlign = ContentAlignment.MiddleCenter;
                btnRanking.Size = new System.Drawing.Size(80, 29);
            }
            else
            {
                pnlDefaultMenu.Width = 260;
                btnRanking.Text = "Generar Ranking de Vinos";
                btnRanking.ImageAlign = ContentAlignment.MiddleLeft;
                btnRanking.Size = new System.Drawing.Size(252, 29);
            }
        }

        private void OpenRankingVinosInDefault(object ChildForm)
        {
            if(this.pnlDefaultContainer.Controls.Count > 0)
            {
                this.pnlDefaultContainer.Controls.RemoveAt(0);
            }
            Form fh = ChildForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlDefaultContainer.Controls.Add(fh);
            this.pnlDefaultContainer.Tag = fh;
            fh.Show();


        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            OpenRankingVinosInDefault(new RankingVinos());
        }
    }
}
