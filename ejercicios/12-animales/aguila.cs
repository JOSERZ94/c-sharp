using System;
public class Aguila: Aves 
{
    public string Plumaje { get; set; }
    public bool No_Es_Domestico { get; set; }

    public Aguila() 
    {
        No_Es_Domestico = true;
    }

    public Aguila(bool no_es_Domestico) 
    {
        No_Es_Domestico = no_es_Domestico;
    }

    public void cazar() 
    {
        Console.WriteLine("fiu fiu fiu");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("Es un ave grande");
    }

    private void OtroMetodo() 
    {

    }
}