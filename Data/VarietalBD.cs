using PPAI24.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.Data
{
    public class VarietalBD
    {
        public Varietal GetVarietalById(int id)
        {
            Varietal v = new Varietal();
            string consulta = "select * from varietal v left join tipo_uva t on t.id_Tipo_Uva=v.id_Tipo_Uva where id_Varietal=" + id;
            DataTable dt = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                // el varietal tiene el mismo nombre que la uva, lo que cambia es el porcentaje 
                TipoUva tu = new TipoUva();
                tu.SetNombre(dt.Rows[0]["nombre"].ToString());
                v.SetTipoUva(tu);
                v.SetPorcentajeComposicion((int)dt.Rows[0]["porcentaje_composicion"]);
                v.SetNombre(dt.Rows[0]["nombre"].ToString());
            }
            return v;
        }
    }
}
