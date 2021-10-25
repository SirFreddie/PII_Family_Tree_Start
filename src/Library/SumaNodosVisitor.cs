namespace Library
{
    public class SumaNodosVisitor : Visitor
    {
        public int Suma {get; private set;}
        public override void Visit(Node n)
        {
            this.Suma += n.Number;
            foreach (Node child in n.Children)
            {
                child.Accept(this);
            }
        }
    }
}