using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank_Herdado.Funcionarios
{
    internal class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, double salario, string cpf) : base(nome, 2000, cpf)
        {
            Console.WriteLine("Criando Diretor");

        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
