﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        public enum TipoCompetencia { F1, MotoCross }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get { return cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }
        public TipoCompetencia Tipo
        {
            get { return tipo; }
            set { this.tipo = value; }
        }
        public VehiculoCarrera this[int i]
        {
            get { return competidores[i]; }
        }
        private Competencia()
        {
            this.competidores = new List<VehiculoCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Cantidad Competidores {this.cantidadCompetidores}"));
            sb.AppendLine(string.Format($"Cantidad Vueltas: {this.cantidadVueltas}"));
            foreach (VehiculoCarrera item in competidores)
            {
                sb.AppendLine(string.Format(item.MostrarDatos()));
            }
            return sb.ToString();
        }
        public static bool operator ==(Competencia c, VehiculoCarrera a)
        {
            TipoCompetencia tipo;
            tipo = (a.GetType() == typeof(AutoF1)) ? TipoCompetencia.F1 : TipoCompetencia.MotoCross;
            bool retorno = c.tipo == tipo;
            if (retorno == false)
                throw new CompetenciaNoDisponibleException("El vehiculo no existe en la competencia", "Competencia", "==");
            return retorno;
        }
        public static bool operator !=(Competencia c, VehiculoCarrera a)
        {
            return !(c == a);
        }
        public static bool operator +(Competencia c, VehiculoCarrera a)
        {
            bool retorno;
            try
            {
                retorno = c == a;
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "+", ex);
            }

            if (c.competidores.Count() >= c.CantidadCompetidores)
                return false;
            else
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.CantidadVueltas;
                Random vueltas = new Random();
                a.CantidadCombustible = (short)vueltas.Next(15, 101);
                return true;
            }
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            return c.competidores.Remove(a);
        }
    }
}