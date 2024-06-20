using PPAI24.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.Data
{
    public class MaridajeBD
    {
        public Maridaje GetMaridajePorNombre(string nom)
        {
            Maridaje m = new Maridaje();
            string consulta = "select * from maridaje where nombre=" + nom;
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                m.SetNombre(dt.Rows[0]["nombre"].ToString());
                RegionVinicola r = new RegionVinicola();
                m.SetDescripcion(dt.Rows[0]["descripcion"].ToString());

            }
            return m;
        }
    }
}
