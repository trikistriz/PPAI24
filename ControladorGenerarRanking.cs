﻿using PPAI24.BE;
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
        private List<Vino> _vinos;

        private void crearVinos()
        {
            for (int i = 0; i < 11; i++)
            {
                Vino vino = new Vino();
                vino.obtenerNombreVino();
                vino.obtenerPrecio();
                vino.obtenerNombreVarietal();

                //String[] infoBodega = vino.buscarInfoBodega();

                _vinos.Add(vino);
            }
        }

        public DataTable GenerarRankingVinos(bool tipoReseña, DateTime fechaReseñaDesde, DateTime fechaReseñaHasta)
        {
            _tipoReseña = tipoReseña;
            _fechaReseñaDesde = fechaReseñaDesde;
            _fechaReseñaHasta = fechaReseñaHasta;
            
            DataTable ranking = calcularPuntajeDeSommelierEnPeriodo();
            ranking = ordenarVinos(ranking);
            DataTable listaVinos = buscarDatosVinos(ranking);
            return listaVinos;
        }

        private DataTable calcularPuntajeDeSommelierEnPeriodo()
        {
            DataTable ranking = new DataTable();
            ranking.Columns.Add("Vino");
            ranking.Columns.Add("Promedio");

            foreach (Vino vino in _vinos)
            {
                // Valido las reseñas
                float promedio = vino.calcularPuntajeDeSommelierEnPeriodo(_tipoReseña, _fechaReseñaDesde, _fechaReseñaHasta);

                DataRow row = ranking.NewRow();
                row["Vino"] = vino.nombre;
                row["Promedio"] = promedio;
                ranking.Rows.Add(row);
            }

            return ranking;
        }
        private DataTable buscarDatosVinos(DataTable dt)
        {
            DataTable dtVinos = new DataTable();
            dtVinos.Columns.Add("Vino");
            dtVinos.Columns.Add("Promedio");
            dtVinos.Columns.Add("Precio");
            dtVinos.Columns.Add("Bodega");
            dtVinos.Columns.Add("Varietal");
            dtVinos.Columns.Add("Region");
            dtVinos.Columns.Add("Pais");

            // Buscamos los datos de los 10 primeros vinos
            for (int i = 0; i < 10; i++)
            {
                Vino vino = new Vino();
                DataRow row = dt.Rows[i];

                DataRow newRow = dtVinos.NewRow();
                newRow["Vino"] = vino.obtenerNombreVino();
                newRow["Promedio"] = row["Promedio"];
                newRow["Precio"] = vino.obtenerPrecio();

                String[] infoBodega = vino.buscarInfoBodega();
                newRow["Bodega"] = infoBodega[0];
                newRow["Region"] = infoBodega[1];
                newRow["Pais"] = infoBodega[2];

                newRow["Varietal"] = vino.obtenerNombreVarietal();

                dtVinos.Rows.Add(newRow);
            }
            return dtVinos;
        }

        private DataTable ordenarVinos(DataTable dt)
        {
            dt.DefaultView.Sort = "Promedio DESC";
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
