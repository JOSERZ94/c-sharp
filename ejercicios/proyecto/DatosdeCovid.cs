using System;
using System.Collections.Generic;
public class DatosdeCovid
{
    public List<Salas> ListadeSalas { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Doctor> ListadeDoctores { get; set; }
    public List<Ingreso> ListaIngresos { get; set; }

    public List<Paciente> ListaPacientes { get; set; }

    public DatosdeCovid()
    {
        ListadeSalas = new List<Salas>();
        cargarSalas();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeDoctores = new List<Doctor>();
        cargarDoctores();

        ListaIngresos = new List<Ingreso>();
    }

    private void cargarSalas()
    {
        Salas p1 = new Salas(1, "Sala covid leve", 250);
        ListadeSalas.Add(p1);

        Salas p2 = new Salas(2, "Sala covid intermedio", 350);
        ListadeSalas.Add(p2);

        Salas p3 = new Salas(3, "Sala covid intensivo", 4000);
        ListadeSalas.Add(p3);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Juan", "77777");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Pedro", "99999");
        ListadeClientes.Add(c2);
    }

    private void cargarDoctores()
    {
        Doctor v1 = new Doctor(1, "Jose Bendana", "V001");
        ListadeDoctores.Add(v1);

        Doctor v2 = new Doctor(2, "Pablo del valle", "V002");
        ListadeDoctores.Add(v2);
    }

    public void ListarSalas()
    {
        Console.Clear();
        Console.WriteLine("Lista de Salas");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var salas in ListadeSalas)
        {
            Console.WriteLine(salas.Codigo + " | " + salas.Descripcion); //+ " | " + salas.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarDoctores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Doctores");
        Console.WriteLine("===================");
        Console.WriteLine("");
        
        foreach (var doctor in ListadeDoctores)
        {
            Console.WriteLine(doctor.Codigo + " | " + doctor.Nombre + " | " + doctor.CodigoDoctor);
        }

        Console.ReadLine();
    }

    public void CrearIngreso()

    {

    
        Console.WriteLine("Creando Ingreso");
        Console.WriteLine("=============");
        Console.WriteLine("");



       Console.WriteLine("Ingrese el ID del cliente: ");
        string codigoCliente = Console.ReadLine();

     Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del doctor: ");
        string codigodoctor = Console.ReadLine();

        Doctor doctor = ListadeDoctores.Find(v => v.Codigo.ToString() == codigodoctor);
        if (doctor == null) 
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Doctor: " + doctor.Nombre);
            Console.WriteLine("");
        }

              int nuevoCodigo = ListaIngresos.Count + 1;

        Ingreso nuevaIngreso = new Ingreso(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, doctor);
        ListaIngresos.Add(nuevaIngreso);

        while(true)
        {
            Console.WriteLine("Ingrese el paciente: ");
            string codigoPaciente = Console.ReadLine();
            Salas salas= ListadeSalas.Find(p => p.Codigo.ToString() == codigoPaciente);        
            if (salas == null)
            {
                Console.WriteLine("Paciente no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + salas.Descripcion + " con precio de: " + salas.Precio);
                nuevaIngreso.AgregarSalas(salas);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Total de la orden es de: " + nuevaIngreso.Total);
        Console.ReadLine();
    }

    public void ListarIngresos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Ingresos");
        Console.WriteLine("===============================================================================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha              |SubTotal | Impuesto | Total | Cliente | Vendedor");
      //  Console.WriteLine("Cliente | Vendedor");
        Console.WriteLine("===============================================================================");
        Console.WriteLine("");  

        foreach (var ingreso in ListaIngresos)
        {
            Console.WriteLine(    ingreso.Codigo +    "    | " + ingreso.Fecha +  " | "+ ingreso.SubTotal + "      | "+ ingreso.Impuesto + "     | " + ingreso.Total + "  |" +ingreso.Cliente.Nombre + "    | " + ingreso.doctor.Nombre);
        //    Console.WriteLine(orden.Cliente.Nombre + " | " + orden.Vendedor.Nombre);
            
            foreach (var detalle in ingreso.ListaIngresoDetalle)
            {
                Console.WriteLine("     " + detalle.Paciente.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}