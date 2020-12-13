  
public class Doctor: Persona
{
    public string CodigoDoctor { get; set; }

    public Doctor(int codigo, string nombre, string codigodoctor)
    {
        Codigo = codigo;
        Nombre = nombre;
        CodigoDoctor = codigodoctor;
    }
}