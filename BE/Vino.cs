using PPAI24.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Vino
    {
        private Bodega _bodega { get; set; }
        private Varietal _varietal { get; set; }
        private List<Reseña> _reseñas { get; set; }
        private string _nombre;
        private string _notaDeCataBodega;
        private float _precioARS;
        private int _añada;
        private int _id {  get; set; }
        private List<Object> _filtros = new List<object>();

        #region Getters and Setters
        public int getId() { return _id; }
        public void setId(int id) { this._id = id; }
        public string GetNombre()
        {
            return _nombre;
        }
        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }
        public float GetPrecio()
        {
            return _precioARS;
        }
        public void SetPrecio(float precio)
        {
            _precioARS = precio;
        }
        public Bodega GetBodega()
        {
            return _bodega;

        }
        public void SetBodega(Bodega bod)
        {
            _bodega = bod;
        }
        public string GetVarietal()
        {
            return _varietal.GetDescripcion();
        }
        public void SetVarietal(Varietal v)
        {
            _varietal = v;
        }
        #endregion

        public IIterador<Reseña> CrearIterador()
        {
            return new IteradorReseñas(_reseñas, _filtros);
        }

        public void AddReseña(Reseña res)
        {
            _reseñas.Add(res);
        }

        public Vino() 
        {
            _nombre = "";
            _precioARS = (float)0;
            _bodega = new Bodega();
            _varietal = new Varietal();
            _reseñas = new List<Reseña>();
        }

        public float calcularPuntajeDeSommelierEnPeriodo(bool premium, DateTime fechaDesde, DateTime fechaHasta)
        {
            _filtros.Add(fechaDesde);
            _filtros.Add(fechaHasta);
            _filtros.Add(premium);

            float suma = 0;
            int count = 0;

            IIterador<Reseña> iteradorPuntaje = CrearIterador();

            iteradorPuntaje.Primero();

            while (!iteradorPuntaje.HaTerminado())
            {
                Reseña reseña = iteradorPuntaje.ElementoActual();
                if (reseña != null )
                {
                    if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier(premium))
                    {
                        suma += reseña.GetPuntaje();
                        count++;
                    }
                }
                iteradorPuntaje.Siguiente();
            }

            return count == 0 ? 0 : calcularPuntajePromedio(suma, count);
        }
        public float calcularPuntajePromedio(float suma, int count)
        {
            return suma / count;
        }
        
        //incluir dependencia
        public String[] buscarInfoBodega()
        {
            String[] bodega = new string[3];
            bodega[0] = _bodega.GetNombre();
            String[] regionYPais = _bodega.ObtenerRegionYPais();
            bodega[1] = regionYPais[0]; //region
            bodega[2] = regionYPais[1]; //pais

            return bodega;
        }

        public bool tenesReseñasDelTipoEnPeriodo(DateTime fechaDesde, DateTime fechaHasta, bool esSommelier)
        {
            _filtros.Add(fechaDesde);
            _filtros.Add(fechaHasta);
            _filtros.Add(esSommelier);

            IIterador<Reseña> iteradorReseñas = CrearIterador();

            iteradorReseñas.Primero();
            
            while (!iteradorReseñas.HaTerminado())
            {
                Reseña reseña = iteradorReseñas.ElementoActual();
                if (reseña != null)
                {
                    if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier(esSommelier))
                    {
                        return true;
                    }
                }
                iteradorReseñas.Siguiente();
            }
            return false;
        }
    }
}
