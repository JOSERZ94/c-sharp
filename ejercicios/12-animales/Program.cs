using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Perro p = new Perro();
            p.Nombre = "Firulais";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);

            Gato g = new Gato();
            g.Nombre = "Garfield";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();

          Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);

            Golondrina j = new Golondrina();
            j.Nombre = "piolin";
            j.Patas = 2;
            j.Plumaje = "Plumas";
            j.Comer();
            j.cantar();
            j.Volar();
            Console.WriteLine(j.Nombre);
            Console.WriteLine(j.Patas);

             Aguila a = new Aguila();
            a.Nombre = "cazadora";
            a.Patas = 2;
            a.Plumaje = "Plumas";
            a.Comer();
            a.cazar();
            a.Volar();
            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.Patas);

            Cocodrilo c = new Cocodrilo();
            c.Nombre = "depredador";
            c.Patas = 4;
            c.Tamano();
            c.Cazar();
            c.Caminar();
            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.Patas);
        
            Tortuga t = new Tortuga();
            t.Nombre = "Donatello";
            t.Patas = 4;
            t.Piel = "escamosa";
            t.Comer();
            t.Caminar();
            t.Nadar();

          Console.WriteLine(t.Nombre);
            Console.WriteLine(t.Patas);

        }
    }
}