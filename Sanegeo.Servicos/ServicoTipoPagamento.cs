﻿using Cos.Dominio.Repositorios.SQL;
using Sanegeo.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.Servicos
{
    public class ServicoTipoPagamento
    {
        private IRepositorioTipoPagamento repositorioTipoPagamento;

        public ServicoTipoPagamento()
        {
            this.repositorioTipoPagamento = new RepositorioTipoPagamento();
        }
    }
}