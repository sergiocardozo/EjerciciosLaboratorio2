﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get { return this.nombre;  }
            set { this.nombre = value; }
        }
        public int Numero
        {
            get { return this.numero; }
        }
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre) :this(numero)
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.numero == cliente2.numero;
        }
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }
    }
}
