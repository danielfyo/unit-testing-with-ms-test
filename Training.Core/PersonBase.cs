namespace Training.Core;

internal abstract class PersonBase
{
    public string Nombre { get; set; }

    public virtual void Crear(string value, string nombre)
    {
        Nombre = nombre;
    }
}