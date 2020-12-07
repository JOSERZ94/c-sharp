using System;
public class Cocodrilo: Reptiles 

  
  
 {
    
    
    public bool Es_peligroso { get; set; }

    public Cocodrilo() 
    {
        Es_peligroso = true;
    }

    public Cocodrilo(bool es_peligroso) 
    {
        Es_peligroso = es_peligroso;
    }

    public void Cazar() 
    {
        Console.WriteLine("Cazan en el agua");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("Cocodrilos Son animales entre 6 y 7 metros");
    }

    private void OtroMetodo() 
    {

    }
}