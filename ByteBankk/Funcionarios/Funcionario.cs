﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankk.Funcionarios
{
    class Funcionario
    {
        // 0 - funcionario 
        // 1 - diretor
        // 2 - designer
        // 3 - Gerente de  conta corrente
        // 4 - Coordenador
        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }
        public double GetBonificacao()
        {
            if (_tipo == 1)
                return Salario;

            return Salario * 0.10;
        }

    }
}
