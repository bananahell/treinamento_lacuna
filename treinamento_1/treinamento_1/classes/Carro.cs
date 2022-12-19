class Carro : Modelo
{

    private string renavam;
    public string? Renavam { get { return renavam; } set { renavam = value; } }
    public string? Cor { get; set; }
    public Opcoes Adicionais { get; set; }
    public int MyProperty { get; set; }

    private static readonly Dictionary<CoresIndex, string> Cores = new() {
        { CoresIndex.Branco, "Branco" },
        { CoresIndex.Preto, "Preto" },
        { CoresIndex.Prata, "Prata" },
        { CoresIndex.Vermelho, "Vermelho" }
    };

    public enum CoresIndex
    {
        Branco,
        Preto,
        Prata,
        Vermelho
    }

    [Flags]
    public enum Opcoes
    {
        // Nada = 0b_0000,
        // Tudo = 0b1111,
        FreioABS = 0b_0001,
        SensorEstacionador = 0b_0010,
        ArCondicionado = 0b_0100,
        GPS = 0b_1000
    }

    public Carro() : base()
    {
        Renavam = string.Empty;
        Cor = string.Empty;
        Adicionais = 0;
    }

    public Carro(string renavam, CoresIndex cor, Opcoes adicionais, string nomeModelo) : base(nomeModelo)
    {
        Renavam = renavam;
        if (Cores.TryGetValue(cor, out var corEncontrada))
        {
            Cor = corEncontrada; // Cores.First(corEncontrada => corEncontrada.Key == cor).Value;
        }
        else
        {
            Cor = null;
        }
        Adicionais = adicionais;
    }

    public static void ZeraRenavam(out string renavam)
    {
        renavam = "00000000000";
    }

}
