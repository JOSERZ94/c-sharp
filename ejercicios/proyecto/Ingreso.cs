using System;
using System.Collections.Generic;

public class Ingreso
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeIngreso { get; set; }
    public Cliente Cliente { get; set; }
    public Doctor doctor { get; set; }
      public Paciente paciente { get; set; }
    public Salas salas { get; set; }
    public List<IngresoDetalle> ListaIngresoDetalle { get; set; }
    public double Total { get; set; }
    public double SubTotal { get; set; }
    public double Impuesto { get; set; }

    public Ingreso(int codigo, DateTime fecha, string numeroIngreso, Cliente cliente, Doctor doctor)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeIngreso = numeroIngreso;
        Cliente = cliente;
      //  Doctor = doctor;
        ListaIngresoDetalle = new List<IngresoDetalle>();
    }

    public void AgregarPaciente(Paciente paciente)
    {
        int nuevoCodigo = ListaIngresoDetalle.Count + 1;
        int cantidad = 1;

       
        IngresoDetalle o = new IngresoDetalle(nuevoCodigo, 1, paciente);
        ListaIngresoDetalle.Add(o);

        SubTotal += cantidad * paciente.Precio;

        Impuesto += 0.15 * paciente.Precio;

        Total = SubTotal + Impuesto;
    }

        public void AgregarSalas(Salas salas)
    {
        int nuevoCodigo = ListaIngresoDetalle.Count + 1;
        int cantidad = 1;

       
        IngresoDetalle o = new IngresoDetalle(nuevoCodigo, 1, paciente);
        ListaIngresoDetalle.Add(o);

        SubTotal += cantidad * salas.Precio;

        Impuesto += 0.15 * salas.Precio;

        Total = SubTotal + Impuesto;
    }
}