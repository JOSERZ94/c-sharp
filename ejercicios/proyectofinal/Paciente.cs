public class Paciente
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public int Existencia { get; set; }

    public Paciente(string codigo, string descripcion, int existencia)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Existencia = existencia;
    }

}