using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank_Herdado.Funcionarios
{
    internal class Desenvolvedor : Funcionario
    {

        public Desenvolvedor(string nome, double salario, string cpf) : base(nome, 4000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
