using System;
using System.Collections.Generic;

public class Salas
{
    public List<Paciente> ListadePaciente { get; set; }
    public Salas()
    {
        ListadePaciente = new List<Paciente>();

        Paciente a = new Paciente("01", "Sala Cuidados Leves",1000);
        Paciente b = new Paciente("02", "Sala Cuidados Intermedios",500);
        Paciente c = new Paciente("03", "Sala Cuidados Intensivos",250);


        ListadePaciente.Add(a);
        ListadePaciente.Add(b);
        ListadePaciente.Add(c);

    }

    
    public void listarPacientes() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Pacientes");
        Console.WriteLine("********************");
        Console.WriteLine("Codigo, Descripcion y Existencia");

        foreach (var paciente in ListadePaciente)
        {
            Console.WriteLine(paciente.Codigo + " | " + paciente.Descripcion + " | " + paciente.Existencia.ToString());
        }

        Console.ReadLine();
    }

    private void movimientoSalas(string codigo, int cantidad, string tipoMovimiento) {
        foreach (var paciente in ListadePaciente)
        {
            if (paciente.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    paciente.Existencia = paciente.Existencia + cantidad;
                } else {
                    paciente.Existencia = paciente.Existencia - cantidad;
                }
            }         
        }
    }

    public void ingresoDePruebas() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso  de pruebbas a la sala");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo de la sala: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad de pacientes: ");
        cantidad = Console.ReadLine();

        movimientoSalas(codigo, Int32.Parse(cantidad), "+");
    }

      public void salidaDePacientes() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Pacientes  Recuperado");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo de la sala: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del pacientes: ");
        cantidad = Console.ReadLine();

        movimientoSalas(codigo, Int32.Parse(cantidad), "-");
    }

 
 
}