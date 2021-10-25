using System;

namespace Library
{
    public class HijoMasGrandeVisitor : Visitor
    {
        private int maxEdad = 0;
        public int MaxEdad { get {return this.maxEdad;} private set {this.maxEdad = value;} }
        public Persona HijoMasGrande {get; private set;}
        public override void Visit(Node n)
        {
            if (this.MaxEdad <= n.Persona.Edad)
            {   
                this.MaxEdad = n.Persona.Edad;
                this.HijoMasGrande = n.Persona;
            }
            foreach (Node child in n.Children)
            {
                child.Accept(this);
            }
        }
    }
}