using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Ned", 88);
            Persona p2 = new Persona("Rob", 60);
            Persona p3 = new Persona("John", 50);
            Persona p4 = new Persona("Arya", 40);
            Persona p5 = new Persona("Sansa", 30);
            Persona p6 = new Persona("Catlyn", 20);
            Persona p7 = new Persona("Daenerys", 10);
            Persona p8 = new Persona("El Cuervo", 1);

            Node n1 = new Node(1, p1);
            Node n2 = new Node(2, p2);
            Node n3 = new Node(3, p3);
            Node n4 = new Node(4, p4);
            Node n5 = new Node(5, p5);
            Node n6 = new Node(6, p6);
            Node n7 = new Node(7, p7);
            Node n8 = new Node(8, p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n4.AddChildren(n8);

            // Suma los valores numericos de los nodos.
            SumaNodosVisitor sumaNodos = new SumaNodosVisitor();
            sumaNodos.Visit(n1);
            Console.WriteLine($"La suma de los valores numericos de los nodos: {sumaNodos.Suma}");

            // Suma las edades de los nodos.
            SumaEdadesVisitor sumaEdades = new SumaEdadesVisitor();
            sumaEdades.Visit(n1);
            Console.WriteLine($"La suma de todas las edades es: {sumaEdades.Suma}");

            // Determina quien es el hijo mayor.
            HijoMasGrandeVisitor elMayor = new HijoMasGrandeVisitor();
            elMayor.Visit(n1);
            Console.WriteLine($"El hijo mayor es: {elMayor.HijoMasGrande.Nombre}");

            // Determina el hijo con el nombre mas largo.
            NombreMasLargo largo = new NombreMasLargo();
            largo.Visit(n1);
            Console.WriteLine($"El nombre mas largo es: '{largo.MaxNombre.Nombre}'");

            /* 
            Reflexion:
            Luego de realizado el ejercicio y de entendido como funciona este patron,
            pude ver la gran utilidad que tiene. Unicamente tuve que extender la clase Node
            de forma minima, para luego poder tener acceso a poder implementar una cantidad
            de funcionalidades utilizando unicamente el Visitor sin la necesidad de modificar
            la clase.
            */
        }
    }
}
