using PPAI24.BE;
using PPAI24.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24
{
    public class ControladorGenerarRanking
    {
        private DateTime _fechaReseñaDesde;
        private DateTime _fechaReseñaHasta;
        private bool _tipoReseña;
        private List<Vino> _vinos = new List<Vino>();
        private DataTable _dtRanking = new DataTable();
        // private List<Vino> _vinosConReseñasEnPeriodo = new List<Vino>();

        public DataTable buscarVinosConReseñasEnPeriodo(bool tipoReseña, DateTime fechaReseñaDesde, DateTime fechaReseñaHasta)
        {
            _tipoReseña = tipoReseña;
            _fechaReseñaDesde = fechaReseñaDesde;
            _fechaReseñaHasta = fechaReseñaHasta;

            VinoBD vinoBD = new VinoBD();
            _vinos = vinoBD.GetAll();

            foreach (Vino vino in _vinos)
            {
                if (vino.tenesReseñasDelTipoEnPeriodo(_fechaReseñaDesde, _fechaReseñaHasta, _tipoReseña))
                {
                    DataRow newRow = _dtRanking.NewRow();
                    newRow["nombre"] = vino.GetNombre();
                    newRow["precio_sugerido"] = vino.GetPrecio();
                    String[] infoBodega = vino.buscarInfoBodega();
                    newRow["bodega"] = infoBodega[0];
                    newRow["varietal"] = vino.GetVarietal();
                    newRow["region"] = infoBodega[1];
                    newRow["pais"] = infoBodega[2];
                    newRow["calificacion_sommelier"] = calcularPuntajeDeSommelierEnPeriodo(vino);
                    _dtRanking.Rows.Add(newRow);
                }
            }
            ordenarVinos(_dtRanking);
            return _dtRanking;
        }

        //public DataTable GenerarRankingVinos(bool tipoReseña, DateTime fechaReseñaDesde, DateTime fechaReseñaHasta)
        //{
        //    _tipoReseña = tipoReseña;
        //    _fechaReseñaDesde = fechaReseñaDesde;
        //    _fechaReseñaHasta = fechaReseñaHasta;

        //    if (_vinos.Count() == 0)
        //        buscarVinosConReseñasEnPeriodo();

        //    DataTable dtRanking = calcularPuntajeDeSommelierEnPeriodo();
        //    dtRanking = ordenarVinos(dtRanking);
        //    DataTable listaVinos = buscarVinosConReseñasEnRanking(dtRanking);
        //    return listaVinos;
        //}

        private float calcularPuntajeDeSommelierEnPeriodo(Vino vino)
        {
            //DataTable dtRankingVinos = new DataTable();
            //dtRankingVinos.Columns.Add("Vino");
            //dtRankingVinos.Columns.Add("Promedio");

            float promedio = vino.calcularPuntajeDeSommelierEnPeriodo(_tipoReseña, _fechaReseñaDesde, _fechaReseñaHasta);

            //DataRow row = dtRankingVinos.NewRow();
            //row["Vino"] = vino.GetNombre();
            //row["Promedio"] = promedio;
            //dtRankingVinos.Rows.Add(row);
        
            return promedio;
        }
    //private DataTable buscarVinosConReseñasEnRanking(DataTable dt)
    //{
    //    if (!_dtRanking.Columns.Contains("nombre")) _dtRanking.Columns.Add("nombre");
    //    if (!_dtRanking.Columns.Contains("calificacion_sommelier")) _dtRanking.Columns.Add("calificacion_sommelier");
    //    if (!_dtRanking.Columns.Contains("precio_sugerido")) _dtRanking.Columns.Add("precio_sugerido");
    //    if (!_dtRanking.Columns.Contains("bodega")) _dtRanking.Columns.Add("bodega");
    //    if (!_dtRanking.Columns.Contains("varietal")) _dtRanking.Columns.Add("varietal");
    //    if (!_dtRanking.Columns.Contains("region")) _dtRanking.Columns.Add("region");
    //    if (!_dtRanking.Columns.Contains("pais")) _dtRanking.Columns.Add("pais");

    //    foreach (Vino vino in _vinos)
    //    {
    //        DataRow foundRow = dt.AsEnumerable().FirstOrDefault(row => row["Vino"].ToString() == vino.GetNombre());

    //        DataRow newRow = _dtRanking.NewRow();
    //        newRow["nombre"] = vino.GetNombre();
    //        newRow["calificacion_sommelier"] = foundRow["Promedio"];
    //        newRow["precio_sugerido"] = vino.GetPrecio();
    //        String[] infoBodega = vino.buscarInfoBodega();
    //        newRow["bodega"] = infoBodega[0];
    //        newRow["varietal"] = vino.GetVarietal();
    //        newRow["region"] = infoBodega[1];
    //        newRow["pais"] = infoBodega[2];


    //        _dtRanking.Rows.Add(newRow);
    //    }
    //    _dtRanking.DefaultView.Sort = "calificacion_sommelier DESC";
    //    return _dtRanking.DefaultView.ToTable();
    //}

    private DataTable ordenarVinos(DataTable dt)
    {
        dt.DefaultView.Sort = "calificacion_sommelier DESC";
        return dt.DefaultView.ToTable();
    }

    public bool validarFechasDeReseñas(DateTime fechaDesde, DateTime fechaHasta)
    {
        DateTime fechaActual = DateTime.Now;
        if (fechaDesde > fechaHasta)
            return false;
        else
            return true;
    }
}
}
