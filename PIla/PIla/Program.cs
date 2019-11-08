using System;
using PIla.proyectopila;
namespace PIla
{
    public class CNodo
    {
       
        private int dato;
        public int Dato
        {
            get { return Dato; }
            set { Dato = value; }
        }
       
        public int siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        

        public override string ToString()
        {
            return string.Format("[{0}]", dato);

        }

        public static implicit operator int(CNodo v)
        {
            throw new NotImplementedException();
        }

        internal class Siguiente
        {
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            pila.push(5);
            pila.push(10);
            pila.push(30);

            Console.WriteLine( pila.Pop());
            
        }
    }
    }

