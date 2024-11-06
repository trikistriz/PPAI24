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
            string consulta = "select v.ID_VINO,v.NOMBRE,v.ID_BODEGA,v.PRECIO, vv.ID_VARIETAL from vino v join VARIETALXVINO vv on v.ID_VINO = vv.ID_VINO";
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
            Vino vino = new Vino();
            vino.setId((int)row["id_vino"]);
            vino.SetNombre(row["nombre"].ToString());      
            vino.SetPrecio(Convert.ToSingle(row["precio"]));       
           
            VarietalBD vd = new VarietalBD();
            vino.SetVarietal(vd.GetVarietalById(int.Parse(row["id_varietal"].ToString())));
           
            BodegaBD bd = new BodegaBD();
            vino.SetBodega(bd.GetBodegaById(int.Parse(row["id_bodega"].ToString())));

            ReseñaBD reseñaBD = new ReseñaBD();
            List<Reseña> reseñas = reseñaBD.GetAllReseñaByVino(vino.getId());
            foreach (Reseña reseña in reseñas)
            {
                vino.AddReseña(reseña);
            }
            return vino;
        }
    }
}
