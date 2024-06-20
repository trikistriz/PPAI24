using PPAI24.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.Data
{
    public class BodegaBD
    {
        public Bodega GetBodegaPorNombre(string nom)
        {
            Bodega b = new Bodega();
            string consulta = "select b.nombre, r.nombre from bodega b" +
                "left join region r on r.ID_REGION=b.ID_REGION " +
                "where b.nombre =" + nom;
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                b.SetNombre(dt.Rows[0]["b.nombre"].ToString());
                RegionVinicola r = new RegionVinicola();
                r.SetNombre(dt.Rows[0]["r.nombre"].ToString());
                b.SetRegionVinicola(r);
            }
            return b;
        }

        public Bodega GetBodegaById(int id)
        {
            Bodega b = new Bodega();
            string consulta = "SELECT b.nombre, r.nombre AS region FROM bodega b " +
                  "LEFT JOIN regionvinicola r ON r.idRegionVinicola = b.idRegionVinicola " +
                  "WHERE b.idBodega = " + id;
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                b.SetNombre(dt.Rows[0]["Nombre"].ToString());
                RegionVinicola r = new RegionVinicola();
                r.SetNombre(dt.Rows[0]["region"].ToString());
                b.SetRegionVinicola(r);
            }
            return b;
        }
    }
}
