namespace Training.Core.Persons;

internal class Employee : PersonBase
{
    public string Code { get; set; }
    
    public override void Crear(string value, string nombre)
    {
        Code = value;
        base.Crear(value, nombre);
    }
}