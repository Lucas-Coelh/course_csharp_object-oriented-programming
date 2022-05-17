using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank_Herdado.Funcionarios
{
    internal abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string nome, double salario, string cpf)
        {
            Nome = nome;
            Salario = salario;
            CPF = cpf;
            Console.WriteLine("Criando Funcionario");
            TotalFuncionarios++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();

    }
}
