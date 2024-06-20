using PPAI24.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.Data
{
    public class VinoBD
    {
        public Vino GetVinoById(int id)
        {
            VarietalBD varietalBD = new VarietalBD();
            BodegaBD bodegaBD = new BodegaBD();
            Vino v = new Vino();
            string consutla = "select * from vino where id_vino=" + id;
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consutla);
            if (dt.Rows.Count > 0)
            {
                v = nuevoVino(dt.Rows[0]);
            }
            return v;
        }

        public List<Vino> GetAll()
        {
            List<Vino> l = new List<Vino>();
            string consulta = "select * from vino";
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Vino v = nuevoVino(row);
                    l.Add(v);
                }
            }
            return l;
        }
        private Vino nuevoVino(DataRow row)
        {
            Vino v = new Vino();
            v.setId((int)row["id_vino"]);
            v.SetNombre(row["nombre"].ToString());      // Nombre
            v.SetPrecio((float)row["precio"]);        // Precio

            // Varietal
            VarietalBD vd = new VarietalBD();
            v.SetVarietal(vd.GetVarietalById(int.Parse(row["id_varietal"].ToString())));

            // Bodega
            BodegaBD bd = new BodegaBD();
            v.SetBodega(bd.GetBodegaById(int.Parse(row["id_bodega"].ToString())));

            // Reseñas
            ReseñaBD reseñaBD = new ReseñaBD();
            List<Reseña> reseñas = reseñaBD.GetAllReseñaByVino(v.getId());
            v.SetReseñas(reseñas);
            return v;
        }
    }
}
