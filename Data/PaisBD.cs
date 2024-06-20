using PPAI24.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.Data
{
    public class PaisBD
    {
        public Pais GetPaisByNombre(string nom)
        {
            ProvinciaBD pv = new ProvinciaBD();
            Pais p = new Pais();
            string consulta = $"select * from pais where nombre = '{nom}'";
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                p.SetNombre(dt.Rows[0]["nombre"].ToString());
                p.SetProvincias(pv.GetProvinciasPorPais(Convert.ToInt32(dt.Rows[0]["ID_PAIS"])));
            }
            return p;
        }

        public Pais GetPaisByProvincia(string nom)
        {
            ProvinciaBD pv = new ProvinciaBD();
            Pais p = new Pais();
            string consulta = $"select pa.* from pais pa join PROVINCIAXPAIS pp on pa.ID_PAIS = pp.ID_PAIS join provincia pr on pp.ID_PROVINCIA = pr.ID_PROVINCIA where pr.nombre = '{nom}'";
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                p.SetNombre(dt.Rows[0]["nombre"].ToString());
                p.SetProvincias(pv.GetProvinciasPorPais(Convert.ToInt32(dt.Rows[0]["ID_PAIS"])));
            }
            return p;
        }
    }
}
