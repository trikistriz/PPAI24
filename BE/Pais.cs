﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Pais
    {
        
        private string Nombre { get; set; }
        private List<Provincia> Provincias { get; set; }
        private List<String> _nombresDePaises = new List<String>
        {
            "Chile",
            "Argentina",
            "Uruguay"
        };
        public Pais()
        {
            Nombre = "";
        }
        public Pais(List<Provincia> provincias)
        {
            Nombre = "";
            Provincias = provincias;
        }

        #region Getters and Setters
        public string GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }
        public List<Provincia> GetProvincias()
        {
            return Provincias;
        }
        public void SetProvincias(List<Provincia> provincias)
        {
            Provincias = provincias;
        }
        #endregion

        public string ObtenerNombrePais()
        {
            Random random = new Random();
            string nb = _nombresDePaises[random.Next(_nombresDePaises.Count)];

            return nb;
        }
    }
}
