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
        private AgregadoConcreto<Reseña> _reseñas { get; set; }
        private string _nombre;
        private string _notaDeCataBodega;
        private float _precioARS;
        private int _añada;
        private int _id {  get; set; }


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
        
        public void AddReseña(Reseña res)
        {
            _reseñas.AgregarItem(res);
        }
        public IIterador<Reseña> GetIteradorReseñas() => _reseñas.CrearIterador();
        #endregion

        public Vino() 
        {
            _nombre = "";
            _precioARS = (float)0;
            _bodega = new Bodega();
            _varietal = new Varietal();
            _reseñas = new AgregadoConcreto<Reseña>();
        }

        public float calcularPuntajeDeSommelierEnPeriodo(bool premium, DateTime fechaDesde, DateTime fechaHasta)
        {
            float suma = 0;
            int count = 0;

            IIterador<Reseña> iteradorPuntaje = GetIteradorReseñas();

            iteradorPuntaje.Primero();

            while (!iteradorPuntaje.HaTerminado())
            {
                Reseña reseña = iteradorPuntaje.ElementoActual();

                if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier(premium))
                {
                    suma += reseña.GetPuntaje();
                    count++;
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
            IIterador<Reseña> iteradorReseñas = GetIteradorReseñas();

            iteradorReseñas.Primero();
            
            while (!iteradorReseñas.HaTerminado())
            {
                Reseña reseña = iteradorReseñas.ElementoActual();
                if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier(esSommelier))
                {
                    return true;
                }
                iteradorReseñas.Siguiente(); //itera hasta que encuentra una reseña que sea del periodo actual, sino devuelve false
            }
            return false;
        }
    }
}
