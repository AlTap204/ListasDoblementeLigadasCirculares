﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    class Nodo
    {
        private int Dato;
        private Nodo Siguiente;
        private Nodo 

        public int dato
        {
            get { return Dato; }
            set { Dato = value; }
        }

        public Nodo siguiente
        {
            get { return Siguiente; }
            set { Siguiente = value; }
        }

        public Nodo atras
        {
            get { return Atras; }
            set { Atras = value; }
        }
    }
}
