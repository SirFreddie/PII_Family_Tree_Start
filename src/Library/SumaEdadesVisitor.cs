namespace Library
{
    public class SumaEdadesVisitor : Visitor
    {
        public int Suma {get; private set;}
        public override void Visit(Node n)
        {
            this.Suma += n.Persona.Edad;
            foreach (Node child in n.Children)
            {
                child.Accept(this);
            }
        }
    }
}