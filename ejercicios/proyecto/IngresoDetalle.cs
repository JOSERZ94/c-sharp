public class IngresoDetalle
{
    public int Codigo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public Paciente Paciente { get; set; }

    public IngresoDetalle(int codigo, int cantidad, Paciente paciente)
    {
        Codigo = codigo;
        Cantidad = cantidad;
        Paciente = paciente;
        Precio = paciente.Precio;
    }
}