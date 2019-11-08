using System;
using System.Collections.Generic;
using System.Text;

namespace Cola.colita
{
    class ClasesPrincipal
    {
        static void Main(String[] args)
        {
            Cola c = new Cola();
            c.InsertarNodo();
            c.InsertarNodo();
            c.InsertarNodo();
            c.InsertarNodo();
            c.InsertarNodo();
            c.InsertarNodo();
            Console.WriteLine("\n Cola ingresada");
            c.desplegarcola();
            Console.WriteLine( );
        }

    }
}
