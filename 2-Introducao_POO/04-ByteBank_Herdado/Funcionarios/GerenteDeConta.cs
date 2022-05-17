using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank_Herdado.Funcionarios
{
    internal class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string nome, double salario, string cpf) : base(nome, 4000, cpf)
        {
            Console.WriteLine("Criando Gerente de Conta");

        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
