using PPAI24.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.Data
{
    public class ProvinciaBD
    {
        public List<Provincia> GetProvinciasPorPais(int idPais)
        {
            RegionVinicolaBD rv = new RegionVinicolaBD();
            List<Provincia> p = new List<Provincia>();
            string consulta = $"select * from provincia p join PROVINCIAXPAIS pp on p.ID_PROVINCIA=pp.ID_PROVINCIA where pp.ID_PAIS = '{idPais}'";
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            foreach (DataRow item in dt.Rows)
            {
                Provincia prov = new Provincia();
                prov.SetNombre(item["nombre"].ToString());
                prov.SetRegiones(rv.GetRegionesVinicolasPorProvincia(Convert.ToInt32(item["id_provincia"])));
                p.Add(prov);
            }
            return p;
        }

        public Provincia GetProvinciaByRegion(string nom)
        {
            RegionVinicolaBD rv = new RegionVinicolaBD();
            Provincia p = new Provincia();
            string consulta = $"SELECT p.* FROM provincia p JOIN REGIONXPROVINCIA rp on p.ID_PROVINCIA = rp.ID_PROVINCIA JOIN region r ON rp.ID_REGION = r.ID_REGION WHERE r.nombre='{nom}'";
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                p.SetNombre(dt.Rows[0]["nombre"].ToString());
                p.SetRegiones(rv.GetRegionesVinicolasPorProvincia(Convert.ToInt32(dt.Rows[0]["id_provincia"])));
            }
            return p;
        }
    }
}
