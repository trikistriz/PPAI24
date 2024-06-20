using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI24.BE;

namespace PPAI24.Data
{
    public class ReseñaBD
    {
        public List<Reseña> GetAll()
        {
            List<Reseña> l = new List<Reseña>();
            string consulta = "select r.id_reseña, r.es_premium, t.nombre, r.id_vino, r.fecha_reseña, r.puntaje, r.comentario from reseña r";
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Reseña r = new Reseña();
                    r.SetPremium((bool)dr["es_premium"]);
                    r.SetFechaReseña((DateTime)dr["r.fecha_reseña"]);
                    r.SetId((int)dr["r.id_reseña"]);
                    r.SetPuntaje((int)dr["r.puntaje"]);
                    r.SetComentario(dr["r.comentario"].ToString());
                    l.Add(r);

                }

            }
            return l;
        }
        public List<Reseña> GetAllReseñaByVino(int vinoId)
        {
            List<Reseña> l = new List<Reseña>();
            string consulta = "SELECT r.id_reseña, r.es_premium, r.id_vino, r.fecha_reseña, r.puntaje, r.comentario " +
                  "FROM reseña r " +
                  "JOIN vino v ON r.id_vino = v.id_vino " +
                  "WHERE r.id_vino = " + vinoId;
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Reseña r = new Reseña();
                    r.SetPremium((bool)dr["es_premium"]);
                    r.SetFechaReseña((DateTime)dr["fecha_reseña"]);
                    r.SetId((int)dr["id_reseña"]);
                    r.SetPuntaje((int)dr["puntaje"]);
                    r.SetComentario(dr["comentario"].ToString());
                    l.Add(r);
                }
            }
            return l;

        }
    }
}
