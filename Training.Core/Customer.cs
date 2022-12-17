namespace Training.Core;

internal class Customer : PersonBase
{
    public string Id { get; set; }
    
    public override void Crear(string value, string nombre)
    {
        Id = value;
        base.Crear(value, nombre);
    }
}