using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.insertarNodo();
            lista.insertarNodo();
            lista.insertarNodo();
            lista.insertarNodo();
            lista.insertarNodo();
            Console.WriteLine("Desplegar de inicio a fondo");
            lista.desplegarListaPU();
            Console.WriteLine("Desplegar de fondo a inicio");
            lista.desplegarListaUP();
            Console.ReadLine();
        }
    }
}
