namespace ListasDoblementeLigadasCirculares
{
    internal class Lista
    {
        Nodo inicio = new Nodo();
        Nodo fondo = new Nodo();

        public Lista()
        {
            inicio = null;
            fondo = null;
        }

        public void Insertar()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingresar dato del nuevo nodo: ");
            nuevo.dato = int.Parse(Console.ReadLine());
            if (inicio == null)
            {
                inicio = nuevo;
                fondo = nuevo;
                inicio.siguiente = inicio;
                inicio.atras = fondo;
            }
            else
            {
                fondo.siguiente = nuevo;
                nuevo.atras = fondo;
                nuevo.siguiente = inicio;
                fondo = nuevo;
                inicio.atras = fondo;
            }
            Console.WriteLine("\n Nuevo nodo agregado con exito\n\n");
        }
        public void desplegarListaPU()
        {
            Nodo actual = new Nodo();
            actual = inicio;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.siguiente;
                } while (actual != inicio);
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia \n");
            }
        }
        public void desplegarListaUP()
        {
            Nodo actual = new Nodo();
            actual = fondo;
            if(actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.atras;
                } while (actual != fondo);
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia \n");
            }
        }
    }
}
