using System;

class Program
{
    static void Main()
    {
        var aluno = new Aluno
        {
            Nome = "Pedro",
            Ano = AnoEscolar.Setimo,
            DataNascimento = new DateTime(2010, 5, 20),
            Documento = "123456789",
            Endereco = new Endereco
            {
                Rua = "Rua A",
                Numero = 123
            }
        };

        var serializer = new MiniSerializer();
        var resultado = serializer.Serializar(aluno);

        Console.WriteLine(resultado);
        Console.ReadLine();
    }
}
