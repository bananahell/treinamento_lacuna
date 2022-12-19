class Etapa2
{

    public static void Etapa_2()
    {

        Modelo modelo1 = new(nomeModelo: "Pulse", slogan: "Sente o pulse", numPortas: 4);
        Modelo modelo2 = new(nomeModelo: "Corsa", numPortas: 2, slogan: "Incapotável");
        var modelo3 = new Modelo("Onix", 4);

        var primeiroModelo = Modelo.Modelos.ElementAt(0);
        var segundoModelo = Modelo.Modelos[1];

        Carro[] carros = new Carro[] {
            new Carro("14088932303", Carro.CoresIndex.Vermelho, Carro.Opcoes.FreioABS | Carro.Opcoes.ArCondicionado, "Corsa"),
            // new Carro("14018932303", Carro.CoresIndex.Preto, Carro.Opcoes.Tudo, "Pulse"),
            new Carro("14038932303", Carro.CoresIndex.Vermelho, Carro.Opcoes.FreioABS | Carro.Opcoes.ArCondicionado | Carro.Opcoes.SensorEstacionador, "Pulse"),
            new Carro("14048932303", Carro.CoresIndex.Prata, Carro.Opcoes.GPS | Carro.Opcoes.ArCondicionado, "Corsa")
        };

        carros[0].Renavam = "hue";

        if ((carros[0].Adicionais & Carro.Opcoes.FreioABS) == Carro.Opcoes.FreioABS)
        {
            Console.WriteLine("sim senhor");
        }
        if (carros[0].Adicionais.HasFlag(Carro.Opcoes.FreioABS))
        {
            Console.WriteLine("de novo, sim senhor");
        }

        string minhaString = "aBcD";

        if (minhaString.Equals("abcd", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Equals");
        }
        if (minhaString == "aBcD")
        {
            Console.WriteLine("==");
        }
        if (minhaString.CompareTo("aBcD") == 0)
        {
            Console.WriteLine("CompareTo");
        }

        var modeloEncontrado = Modelo.GetModelo("Pulse");
        if (modeloEncontrado != null)
        {
            Console.WriteLine("Procura modelo: " + modeloEncontrado.NomeModelo + " - " + modeloEncontrado.Slogan + ", " + modeloEncontrado.NumPortas + " portas!");
        }
        Console.WriteLine("Modelo do carro de renavam " + carros[0].Renavam + " é " + carros[0].NomeModelo);
        Console.WriteLine("Modelo do carro de renavam " + carros[1].Renavam + " é " + carros[1].NomeModelo);
        foreach (var modelo in Modelo.Modelos)
        {
            Console.WriteLine(modelo.NomeModelo + ": " + modelo.Slogan);
        }

        Carro.ZeraRenavam(out var renavam);
        carros[2].Renavam = renavam;
        Console.WriteLine("O novo renavam do carro[2] é " + carros[2].Renavam);
    }

}
