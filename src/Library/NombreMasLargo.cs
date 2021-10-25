using System;

namespace Library
{
    public class NombreMasLargo : Visitor
    {
        private int maxNombre = 0;
        public int MaxNombreLen { get {return this.maxNombre;} private set {this.maxNombre = value;} }
        public Persona MaxNombre {get; private set;}
        public override void Visit(Node n)
        {
            if (this.MaxNombreLen <= n.Persona.Nombre.Length)
            {   
                this.MaxNombreLen = n.Persona.Nombre.Length;
                this.MaxNombre = n.Persona;
            }
            foreach (Node child in n.Children)
            {
                child.Accept(this);
            }
        }
    }
}