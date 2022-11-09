public interface IVisitor
{
    public void visit(Cow animal);
    public void visit(Sheep animal);
    public void visit(Pig animal);
    public void visit(Chicken animal);
    public void visit(Goat animal);
    public void visit(Farm farm);
    public void visit(Barn barn);
    public void visit(Pen pen);
    public void visit(Field field);
    
}
