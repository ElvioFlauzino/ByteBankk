using ByteBankk.Funcionarios;
using System;


namespace ByteBankk
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao = GerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "623.534.264.26";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.
                

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.ReadLine();
        }
    }
}
