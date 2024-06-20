using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI24.BE;

namespace PPAI24.Data
{
    public class TipoReseñaBD
    {
        public List<TipoReseña> GetAll()
        {
            List<TipoReseña> l = new List<TipoReseña>();
            string consulta = "select * from tiporesena";
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TipoReseña tipo = new TipoReseña();
                    tipo.SetNombre(dr["nombre"].ToString());
                    l.Add(tipo);

                }
            }
            return l;
        }
    }
}
