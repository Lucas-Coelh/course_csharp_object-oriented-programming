using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    public class ContaCorrente
    {
        public Cliente _titular;
        public int _agencia;
        public int _numero;
        public double _saldo = 100; //valor padrão

        public ContaCorrente(Cliente titular, int agencia, int numero, double saldo)
        {
            _titular = titular;
            _agencia = agencia;
            _numero = numero;
            _saldo = saldo;
        }

        
        public bool Sacar(double valor)
        {

            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }

        }

        public void Depositar(double valor)
        {
            _saldo += valor;

        }

        public bool Tranferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }

        }


    }
}
