using System.Linq;

class Modelo
{

    public string NomeModelo { get; set; }
    public string? Slogan { get; set; }
    public int NumPortas { get; set; }
    public static List<Modelo> modelos = new();

    public static Modelo? GetModelo(string nomeModelo)
    {
        return modelos.Find(modelo => modelo.NomeModelo == nomeModelo);
    }

    public Modelo()
    {
        NomeModelo = string.Empty;
        Slogan = string.Empty;
        NumPortas = 4;
    }

    public Modelo(string nomeModelo, int numPortas, string slogan = "")
    {
        NomeModelo = nomeModelo;
        Slogan = slogan;
        NumPortas = numPortas;
        InsertModelo(this);
    }

    public Modelo(string nomeModelo)
    {
        var modelo = FindModelo(nomeModelo);
        InsertModelo(modelo);
        NomeModelo = modelo.NomeModelo;
        Slogan = modelo.Slogan;
        NumPortas = modelo.NumPortas;
    }

    private static void InsertModelo(Modelo modeloIn)
    {
        var modeloEncontrado = modelos.Find(modelo => modelo.NomeModelo == modeloIn.NomeModelo);
        if (modeloEncontrado != null && modeloEncontrado.NomeModelo != "")
        {
            modelos.Add(modeloIn);
        }
    }

    private static Modelo FindModelo(string nomeModelo)
    {
        var modeloEncontrado = modelos.Find(modelo => modelo.NomeModelo == nomeModelo);
        if (modeloEncontrado == null)
        {
            return new Modelo();
        }
        if (modeloEncontrado.NomeModelo == "")
        {
            modeloEncontrado.NomeModelo = nomeModelo;
        }
        return modeloEncontrado;
    }

}

