﻿using Cos.Dominio.Repositorios.SQL;
using Sanegeo.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.Servicos
{
    public class ServicoPagamento
    {
        private IRepositorioPagamento repositorioPagamento;

        public ServicoPagamento()
        {
            this.repositorioPagamento = new RepositorioPagamento();
        }
    }
}
