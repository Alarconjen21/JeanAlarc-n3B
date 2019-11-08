using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PIla.proyectopila
{
    public class Stack
    {
        private CNodo cabeza;
        private CNodo trabajo;
        private CNodo Siguiente;
      
        public CNodo Trabajo { get => trabajo; set => cabeza.siguiente = value; }
        public static  CNodo Cabeza { get => Cabeza; set => Cabeza.siguiente = value; }
        public CNodo siguiente { get => siguiente; set => cabeza.siguiente= value; }
      

        public Stack()
        {
            cabeza = new CNodo();
            cabeza.siguiente = 0;
        }

        public void push(int ndato)
        {
            CNodo temporal = new CNodo();
            temporal.Dato = ndato;
            temporal.siguiente = cabeza.siguiente;
            Cabeza.siguiente = temporal;
        }
          
        public int Pop()
        {

            int valor = 0;
            if ( Cabeza.siguiente != null)
            {
                Trabajo = Cabeza.Siguiente;
                valor = Trabajo.Dato;
                Cabeza.siguiente = Trabajo.siguiente;
                Trabajo.siguiente = 0;
            }
            return valor;
        }
    }
    public int Peek()
    {
        int valor = 0;
        if (cabeza.Siguiente != null)
        {
            Trabajo = cabeza.siguiente;
            valor = Trabajo.dato;
           
        }
        return valor;
    }
}
