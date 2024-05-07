using System.Xml.Linq;
public class PersonAfter(string Name, int Age)
{
    public string Info()
    {
        return $"name =>{Name}  Age=>{Age}";
    }
}
