using System;
using System.Collections.Generic;
using System.Text;
using Cola.colita;
namespace Cola.colita
{
    class Cola
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();
        private Nodo luego;
        private Nodo cabeza;
        private Nodo antes;
      
        public Cola()
        {
            primero = null;
        }
        public void InsertarNodo (){
            Nodo nuevo = new Nodo();
            Console.WriteLine( "ingrese el dato que contiene el nuevo nodo" );
            nuevo.Dato = int.Parse(Console.ReadLine());
            if (primero==null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;

            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
            Console.WriteLine( "\n Nodo ingresado" );
    }
        public void desplegarcola()
        {
            Nodo Actual = new Nodo();
            Actual = primero;
            if (primero != null)
            {
                while (Actual!= null)
                {
                    Console.WriteLine( "  ",Actual.Dato );
                    Actual = Actual.Siguiente;
                }
            }
                else
                {
                        Console.WriteLine("\n La cola se encuentra vacia");
                }
            }
        public void EliminarDato(int dat)
        {
            
            int ban = 0;
            if (vacia())
            {
                Console.WriteLine("Lista vacía ");
            }
            else
            {
                if (dat < cabeza.Dato)
                {
                    Console.WriteLine("dato no existe en la lista ");
                }
                else
                {
                    if (dat == cabeza.Dato)
                    {
                        cabeza = cabeza.Siguiente;

                    }
                    else
                    {
                        primero = cabeza;
                        ultimo = cabeza;
                        while (ban == 0)
                        {
                            if (dat >luego.Dato)
                            {
                                antes = luego;
                                luego = luego.Siguiente;
                            }
                            else ban = 1;
                            if (luego == null)
                            {
                                ban = 1;
                            }
                            else
                            {
                                if (luego.Dato == dat)
                                    ban = 1;
                            }
                        }
                        if (luego == null)
                        {
                            Console.WriteLine("dato no existe en la Lista ");
                        }
                        else
                        {
                            if (dat == luego.Dato)
                            {
                                antes.Siguiente = luego.Siguiente;
                            }
                            else
                                Console.WriteLine("dato no existe en la Lista ");
                        }
                    }
                }
            }
        }

        private bool vacia()
        {
            throw new NotImplementedException();
        }

        public void VisualizarDatos()
            {
                Nodo Nodo;
                Nodo = cabeza;
                if (!vacia())
                {

                    do
                    {
                        Console.WriteLine (" " + Nodo.Dato + " ");
                        Nodo = Nodo.Siguiente;

                    } while (Nodo != null);
                }
                else
                    Console.WriteLine ("Lista vacía");
            } 
    }
    }
    
    

