using System;
public class Aguila: Aves // <- Herencia
{
    public string Plumaje { get; set; }
    public bool No_Es_Domestico { get; set; }

    public Aguila() // <- Polimorfismo
    {
        No_Es_Domestico = true;
    }

    public Aguila(bool no_es_Domestico) // <- Polimorfismo
    {
        No_Es_Domestico = no_es_Domestico;
    }

    public void cazar() // <- Abstraccion
    {
        Console.WriteLine("fiu fiu fiu");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un ave grande");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {

    }
}