namespace Bauprojekt;

public class ALeafElement
{
    public string Name { get; set; }

    public ALeafElement()
    {
        
    }
    /*
     
    public ALeafElement()
    {
        Überladung   
    }
     */
    
    public string GetDetails()
    {
        return this.Name;
    }
}