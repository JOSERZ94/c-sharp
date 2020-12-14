using System;

namespace proyectofinal
{
    class Program
    {        
        static void Main(string[] args)
        {
            string opcion = "";
            Salas salas = new Salas();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema Estadistica Covid19");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Tipos de Sala");
                Console.WriteLine("2 - Ingreso de Pacientes");
                Console.WriteLine("3 - Pacientes Recuperados");
              //  Console.WriteLine("4 - Ajuste negativo de Inventario");
                //Console.WriteLine("5 - Ajuste positivo de Inventario");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        salas.listarPacientes();
                        break;
                    case "2":
                        salas.ingresoDePruebas();
                        break;  
                    case "3":
                        salas.salidaDePacientes();
                        break;    
                    //case "4":
                      //  inventario.ajustenegativoDeInventario(); 
                      //  break;  
                    // case "5":
                      //  inventario.ajustepositivoDeInventario(); 
                       // break;                         
                    default:
                    break;
                }

                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}