class Etapa3
{
    public static void Etapa_3()
    {
        var usuarios = new List<Usuario>() {
            new Usuario() { Id = 5, Grupo = "Diretoria", Nome = "Carlos" },
            new Usuario() { Id = 21, Grupo = "Diretoria", Nome = "José" },
            new Usuario() { Id = 3, Grupo = "RH", Nome = "Camila" },
            new Usuario() { Id = 42, Grupo = "RH", Nome = "Joana" },
            new Usuario() { Id = 102, Grupo = "", Nome = "Joaquim" },
            new Usuario() { Id = 7, Grupo = "RH", Nome = "Camila" },
            new Usuario() { Id = 105, Grupo = "Operações", Nome = "Vitor" }
        };
        var novosUsuarios = new List<Usuario>() {
            new Usuario() { Id = 300, Grupo = "DevOp", Nome = "André" },
            new Usuario() { Id = 420, Grupo = "DevOp", Nome = "Pedro" }
        };
        var pessoas = new List<Pessoa> { };

        var usuariosEncontrados = new List<Usuario> { };
        Usuario usuarioEncontrado;
        IEnumerable<Usuario> queryUsuario;

        // 1 - Concatenar
        Console.WriteLine("Concatenar:");
        usuarios.AddRange(novosUsuarios);
        foreach (Usuario usuario in usuarios)
        {
            Console.WriteLine(usuario.Id + " " + usuario.Grupo + " " + usuario.Nome);
        }

        // 2 - Encontrar todos
        // 2.1
        Console.WriteLine("\nEncontrar todos (1):");
        usuariosEncontrados = usuarios.FindAll(usuario => usuario.Grupo == "Diretoria");
        foreach (Usuario usuario in usuariosEncontrados)
        {
            Console.WriteLine(usuario.Id + " " + usuario.Grupo + " " + usuario.Nome);
        }
        // 2.2
        Console.WriteLine("\nEncontrar todos (2):");
        queryUsuario = usuarios.Where(usuario => usuario.Grupo == "Diretoria");
        foreach (Usuario usuario in queryUsuario)
        {
            Console.WriteLine(usuario.Id + " " + usuario.Grupo + " " + usuario.Nome);
        }

        // 3 - Encontrar sem grupo
        Console.WriteLine("\nEncontrar sem grupo:");
        usuarioEncontrado = usuarios.FirstOrDefault(usuario => usuario.Grupo == "");
        if (usuarioEncontrado != null)
        {
            Console.WriteLine("Usuário " + usuarioEncontrado.Nome + " encontrado sem grupo!");
        }
        else
        {
            Console.WriteLine("Nenhum usuário encontrado sem grupo!");
        }

        // 4 - Encontrar alguém
        Console.WriteLine("\nEncontrar alguém:");
        usuarioEncontrado = usuarios.Find(usuario => usuario.Nome == "Camila");
        if (usuarioEncontrado != null)
        {
            Console.WriteLine(usuarioEncontrado.Id + " " + usuarioEncontrado.Grupo + " " + usuarioEncontrado.Nome);
        }
        else
        {
            Console.WriteLine("Nenhum usuário encontrado com o nome Camila!");
        }

        // 5 - Ids crescentes
        Console.WriteLine("\nIds crescentes:");
        queryUsuario = usuarios.OrderBy(usuario => usuario.Id);
        foreach (Usuario usuario in queryUsuario)
        {
            Console.WriteLine(usuario.Id + " " + usuario.Grupo + " " + usuario.Nome);
        }

        // 6 - Ids decrescentes
        Console.WriteLine("\nIds decrescentes:");
        queryUsuario = usuarios.OrderByDescending(usuario => usuario.Id);
        foreach (Usuario usuario in queryUsuario)
        {
            Console.WriteLine(usuario.Id + " " + usuario.Grupo + " " + usuario.Nome);
        }

        // 7 - Agrupar
        Console.WriteLine("\nAgrupar:");
        var queryGrupoUsuario = usuarios.GroupBy(usuario => usuario.Grupo);
        foreach (var grupo in queryGrupoUsuario)
        {
            if (grupo.Key != "")
            {
                Console.Write(grupo.Key + " - ");
            }
            else
            {
                Console.Write("Sem grupo - ");
            }
            foreach (Usuario usuario in grupo)
            {
                Console.Write(usuario.Nome + " ");
            }
            Console.WriteLine();
        }

        // 8 - Lista de pessoas
        // 8.1
        Console.WriteLine("\nLista de pessoas (1):");
        pessoas = usuarios.ConvertAll(usuario => new Pessoa() { Nome = usuario.Nome });
        foreach (Pessoa pessoa in pessoas)
        {
            Console.WriteLine(pessoa.Nome);
        }
        // 8.2
        Console.WriteLine("\nLista de pessoas (2):");
        var pessoasSelect = usuarios.Select(usuario => new Pessoa() { Nome = usuario.Nome });
        foreach (Pessoa pessoa in pessoasSelect)
        {
            Console.WriteLine(pessoa.Nome);
        }
    }
}
