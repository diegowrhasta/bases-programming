// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;
using DummyLibrary.Extensions;
using DummyLibrary.Interface;

var visitor = new Visitor();

IList<INode> nodeList = new List<INode>()
{
    new City(),
    new Country{ Name = "Bolivia", },
    new State(),
};

nodeList.ForEach(n => n.AcceptVisitor(visitor));
visitor.ReportOnVisits();