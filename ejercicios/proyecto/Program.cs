using System;

namespace proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdeCovid datos = new DatosdeCovid();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de estadistica covid19");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista Salas");
                Console.WriteLine("2 - Ingresar Nuevo Paciente");
                Console.WriteLine("3 - Salida de Pacientes");
                Console.WriteLine("4 - Doctores especialistas");
                Console.WriteLine("5 - Lista de Pacientes");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarSalas();
                        break;
                    case "2":
                        datos.CrearIngreso();
                        break;
                    case "3":
                      //  datos.SalidaPaciente();
                        break;
                    case "4":
                        datos.ListarDoctores();
                        break;
                    case "5":
                      //  datos.ListarPacientes();
                        break;
                    default:
                        break;
                }

                if (opcion == "0")
                {
                    break;
                }
            }
        }
    }
}
