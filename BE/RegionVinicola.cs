﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using PPAI24.Data;

namespace PPAI24.BE
{
    public class RegionVinicola
    {
        private string _nombre { get; set; }
        public RegionVinicola()
        {
            _nombre = "";
        }

        #region Getters and Setters
        public string GetNombre()
        {
            return _nombre;
        }
        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }
        #endregion

        public string ObtenerNombrePais(string nombre)
        {
            ProvinciaBD pd = new ProvinciaBD();
            Provincia p = pd.GetProvinciaByRegion(nombre);
            return p.GetPais();
        }
    }
}
