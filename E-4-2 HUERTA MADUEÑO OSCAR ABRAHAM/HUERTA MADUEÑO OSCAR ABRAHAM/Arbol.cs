using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuertaAbraham
{
    class Arbol
    {
        //Variables
        int A = 0;
        int B = 2;
        int Altura1 = 0;
        int Nivel1 = 0;

        public void Menu() //Menu
        {
            Console.WriteLine("Ingresa una opcion: ");
            Console.WriteLine("1) Arbol 1");
            Console.WriteLine("2) Arbol 2");
            Console.WriteLine("3) Arbol 3");

            string Arbol = Console.ReadLine().ToUpper();

            if (Arbol == "1" || Arbol == "A")
            {
                ArbolA();
            }
            else if (Arbol == "2" || Arbol == "B")
            {
                ArbolB();
            }
            else if (Arbol == "3" || Arbol == "C")
            {
                ArbolC();
            }
        }

        public void ArbolNodo(Nodo Nodo2, string Nombre, string[] Nombre2) //Metodo 1
        {
            if (Nodo2.Arreglo != null)
            {
                foreach (Nodo item in Nodo2.Arreglo)
                {
                    ArbolNodo(item, Nombre, Nombre2);
                }
            }
            else
            {
                if (Nodo2.Name == Nombre)
                {
                    Nodo2.Arreglo = new Nodo[Nombre2.Length];
                    for (int i = 0; i < Nombre2.Length; i++)
                    {
                        Nodo2.Arreglo[i] = new Nodo(Nombre2[i]);
                    }
                }
            }
        }
        
        public void ImprimirNodo(Nodo Nodo1) //Imprimir nodo
        {

            if (Nodo1.Arreglo != null)
            {
                Console.SetCursorPosition(A, B);
                Console.Write(Nodo1.Name);
                A = A + 5;
                ++B;
                for (int i = 0; i < Nodo1.Arreglo.Length; i++)
                {
                    ImprimirNodo(Nodo1.Arreglo[i]);
                }
                A += 5;
            }
            else
            {
                Console.SetCursorPosition(A, B);
                Console.Write(Nodo1.Name);

                ++B;

            }
            Altura1 = (B - 2) / 2;
            Nivel1 = Altura1;
        }
        
        
        public void ArbolA() // Metodo 1
        {
            Console.Clear();
            Console.WriteLine("Arbol 1");
            Nodo RaizNodo = new Nodo("G");
            ArbolNodo(RaizNodo, "G", new string[] { "F", "A" });
            ArbolNodo(RaizNodo, "A", new string[] { "B", "C", "D" });
            ImprimirNodo(RaizNodo);
            ImprimirA();
            Console.ReadKey();
        }
        
        public void ArbolB() // Metodo 2
        {
            Console.Clear();
            Console.WriteLine("Arbol 2");
            Nodo NodoRaiz = new Nodo("C");
            ArbolNodo(NodoRaiz, "C", new string[] { "D", "F", "G", "A" });
            ArbolNodo(NodoRaiz, "A", new string[] { "B" });
            ArbolNodo(NodoRaiz, "B", new string[] { "E" });
            ImprimirNodo(NodoRaiz);
            ImprimirB();
            Console.ReadKey();
        }

        public void ArbolC() // Metodo 3
        {
            Console.Clear();
            Console.WriteLine("Arbol 3");
            Nodo NodoRaiz = new Nodo("K");
            ArbolNodo(NodoRaiz, "K", new string[] { "B", "A", "C", "D" });
            ArbolNodo(NodoRaiz, "D", new string[] { "I    J", "E", });
            ArbolNodo(NodoRaiz, "E", new string[] { "F", "G" });
            ArbolNodo(NodoRaiz, "G", new string[] { "H" });
            ImprimirNodo(NodoRaiz);
            ImprimirC();
            Console.ReadKey();
        }

        //---------------------------------------------

        //Imprimir
        public void ImprimirA()
        {
            Console.WriteLine(" ");
            Console.WriteLine("La altura es: {0} ", Altura1 - 1);
            Console.WriteLine("El nivel es: {0}", Nivel1 - 1);
            Console.WriteLine("G -Hasta-> B, C o D es= G > A > B, C o D");
            Console.WriteLine("G ---> C es: G > A > C");
            Console.WriteLine("G ---> H es: Ninguno ");
            Console.WriteLine("G ---> J es: Ninguno ");
        }

        public void ImprimirB()
        {
            Console.WriteLine(" ");
            Console.WriteLine("La altura es: {0}", Altura1);
            Console.WriteLine("El nivel es: {0}", Nivel1);
            Console.WriteLine("C -Hasta-> E es: C > A > B > E");
            Console.WriteLine("C ---> C es: C");
            Console.WriteLine("C ---> H es: Ninguno");
            Console.WriteLine("C ---> J es: Ninguno");
        }

        public void ImprimirC()
        {
            Console.WriteLine(" ");
            Console.WriteLine("La altura es: {0}", Altura1 - 1);
            Console.WriteLine("El nivel es: {0}", Nivel1 - 1);
            Console.WriteLine("K -Hasta-> H es: K > D > E > G > H");
            Console.WriteLine("K ---> C es: K > C");
            Console.WriteLine("K ---> H es: K > D > E > G > H");
            Console.WriteLine("K ---> J es: K > D > I > J");
        }

    }
}
