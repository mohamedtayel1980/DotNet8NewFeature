public class PersonBefore
{
    private string _name; 
    private int _age;
    public PersonBefore(string name, int age)
    {
        _name = name;
        _age = age;
    }
    public string Info()
    {
        //return $"name =>{name}  Age=>{age}";
        return $"Name =>{_name}  Age=>{_age}";
    }

}
