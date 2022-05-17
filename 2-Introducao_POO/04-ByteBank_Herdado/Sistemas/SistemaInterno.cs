using _04_ByteBank_Herdado.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank_Herdado.Sistemas
{
    internal class SistemaInterno
    {
        public bool Logar(Funcionario funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema!");
                return true;

            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }



        }





    }
}
