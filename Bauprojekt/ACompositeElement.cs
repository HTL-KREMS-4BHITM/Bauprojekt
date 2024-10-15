using System.Text;
using Bauprojekt.Interfaces;
namespace Bauprojekt;

public abstract class ACompositeElement
{
    public List<IProjectComponent>? Children { get; set; }
    public string? Name { get; set; }

    public ACompositeElement()
    {
        throw new NotImplementedException();
        //IDK why tf we have a ctor in an abstract class
    }

    public void Add(IProjectComponent child)
    {
        this.Children!.Add(child);
    }

    public string GetDetails()
    {
        StringBuilder sb = new();
        sb.Append(this.Name + ", Contains" + this.Children!.Count + " Children");
        return sb.ToString();
    }

    public void Remove(IProjectComponent target)
    {
        foreach (IProjectComponent child in Children!.ToList())
        {
            if(child.Equals(target))
                Children!.Remove(child);
        }
    }
}