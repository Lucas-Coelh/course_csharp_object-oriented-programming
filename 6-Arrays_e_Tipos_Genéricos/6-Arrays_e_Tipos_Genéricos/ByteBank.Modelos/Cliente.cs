using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }



        public override string ToString()
        {
            return $"Nome: {Nome}, CPF: {CPF}, Profissão: {Profissao}";
        }

        public override bool Equals(object obj)
        {

            string maluca = "teste qualquer";
            
            

            

            //Cliente outroCliente = (Cliente)obj  //Lanca uma Exption
            Cliente outroCliente = obj as Cliente; // Retorna Null

            if (outroCliente == null)
            {
                return false;
            }

            return Nome == outroCliente.Nome && CPF == outroCliente.CPF && Profissao == outroCliente.Profissao;
        }
        
    }
}
