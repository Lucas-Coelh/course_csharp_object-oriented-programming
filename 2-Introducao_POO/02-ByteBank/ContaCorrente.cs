﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo = 100; //valor padrão


        public bool Sacar(double valor)
        {

            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }

        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
            
        }

        public bool Tranferir(double valor,ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }

        }


    }
}
