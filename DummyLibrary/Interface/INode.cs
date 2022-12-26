namespace DummyLibrary.Interface;

public interface INode
{
    void AcceptVisitor(IVisitor visitor);
}