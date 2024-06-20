using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Reseña
    {
        private string _comentario { get; set; }
        private bool _esPremium { get; set; }
        private DateTime _fechaReseña { get; set; }
        private int _puntaje { get; set; }
        private int id { get; set; }

        public Reseña()
        {
            _fechaReseña = DateTime.Now;
            _puntaje = obtenerPuntajeRandom();
            _comentario = "";
            _esPremium = true;

        }
        public Reseña(DateTime fecha, int puntaje, string com, bool premium)
        {
            _fechaReseña = fecha;
            _puntaje = puntaje;
            _comentario = com;
            _esPremium = premium;
        }
        public bool sosDeSommelier(bool tipoReseña)
        {
            if (tipoReseña)
                return _esPremium;
            else
                return false;

        }
        //patron experto
        public bool sosDePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _fechaReseña >= fechaDesde && _fechaReseña <= fechaHasta;
        }

        private int obtenerPuntajeRandom()
        {
            Random rnd = new Random();
            int minValue = 0;
            int maxValue = 11;

            int puntaje = rnd.Next(minValue, maxValue);

            return puntaje;
        }

        #region Getters and Setters

        public int GetId() { return id; }
        public void SetId(int id) { this.id = id; }

        public DateTime GetFechaReseña()
        {
            return _fechaReseña;
        }
        public int GetPuntaje()
        {
            return _puntaje;
        }
        public string GetComentario()
        {
            return _comentario;
        }

        public void SetFechaReseña(DateTime fecha)
        {
            _fechaReseña = fecha;
        }
        public void SetPuntaje(int puntaje)
        {
            _puntaje = puntaje;
        }
        public void SetComentario(string com)
        {
            _comentario = com;
        }
        public void SetPremium(bool premium)
        {
            _esPremium = premium;
        }
        #endregion
    }
}
