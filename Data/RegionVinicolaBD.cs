using PPAI24.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.Data
{
    public class RegionVinicolaBD
    {
        public List<RegionVinicola> GetRegionesVinicolasPorProvincia(int idProv)
        {
            List<RegionVinicola> rv = new List<RegionVinicola>();
            string consulta = "select * from region r join REGIONXPROVINCIA rp on r.ID_REGION=rp.ID_REGION where rp.id_Provincia=" + idProv;
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            foreach (DataRow item in dt.Rows)
            {
                RegionVinicola r = new RegionVinicola();
                r.SetNombre(item["nombre"].ToString());
                rv.Add(r);
            }
            return rv;
        }
    }
}
