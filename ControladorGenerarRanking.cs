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
        private List<Object> _filtros = new List<object>();
        public void AgregarElemento(Vino vino)
        {
            _vinos.Add(vino);
        }

        public IIterador<Vino> CrearIterador()
        {
            return new IteradorVinos(_vinos,_filtros);
        }

        public DataTable buscarVinosConReseñasEnPeriodo(bool tipoReseña, DateTime fechaReseñaDesde, DateTime fechaReseñaHasta)
        {
            _tipoReseña = tipoReseña;
            _fechaReseñaDesde = fechaReseñaDesde;
            _fechaReseñaHasta = fechaReseñaHasta;
            _filtros.Add(fechaReseñaDesde);
            _filtros.Add(fechaReseñaHasta);
            _filtros.Add(tipoReseña);

            VinoBD vinoBD = new VinoBD();
            List<Vino> listaVinos = vinoBD.GetAll();

            foreach (var vino in listaVinos)
            {
                AgregarElemento(vino);
            }

            if (!_dtRanking.Columns.Contains("nombre")) _dtRanking.Columns.Add("nombre");
            if (!_dtRanking.Columns.Contains("calificacion_sommelier")) _dtRanking.Columns.Add("calificacion_sommelier");
            if (!_dtRanking.Columns.Contains("precio_sugerido")) _dtRanking.Columns.Add("precio_sugerido");
            if (!_dtRanking.Columns.Contains("bodega")) _dtRanking.Columns.Add("bodega");
            if (!_dtRanking.Columns.Contains("varietal")) _dtRanking.Columns.Add("varietal");
            if (!_dtRanking.Columns.Contains("region")) _dtRanking.Columns.Add("region");
            if (!_dtRanking.Columns.Contains("pais")) _dtRanking.Columns.Add("pais");

            IIterador<Vino> iteradorVinos = CrearIterador();

            iteradorVinos.Primero();

            while (!iteradorVinos.HaTerminado())
            {
                if (iteradorVinos.ElementoActual() != null)
                {
                    Vino vino = iteradorVinos.ElementoActual();

                    DataRow newRow = _dtRanking.NewRow();
                    newRow["nombre"] = vino.GetNombre();
                    newRow["precio_sugerido"] = vino.GetPrecio();
                    string[] infoBodega = vino.buscarInfoBodega();
                    newRow["bodega"] = infoBodega[0];
                    newRow["varietal"] = vino.GetVarietal();
                    newRow["region"] = infoBodega[1];
                    newRow["pais"] = infoBodega[2];
                    newRow["calificacion_sommelier"] = calcularPuntajeDeSommelierEnPeriodo(vino);
                    _dtRanking.Rows.Add(newRow);
                }
                iteradorVinos.Siguiente();
            }

            return ordenarVinos(_dtRanking);
        }

         
        private float calcularPuntajeDeSommelierEnPeriodo(Vino vino)
        {
            float promedio = vino.calcularPuntajeDeSommelierEnPeriodo(_tipoReseña, _fechaReseñaDesde, _fechaReseñaHasta);
            return promedio;
        }
        
        private DataTable ordenarVinos(DataTable dt)
        {
            DataTable dtOrdenado = new DataTable();
            dt.DefaultView.Sort = "calificacion_sommelier DESC";
            dtOrdenado = dt.DefaultView.ToTable();
            return dtOrdenado;
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
