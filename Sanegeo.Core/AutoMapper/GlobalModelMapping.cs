using AutoMapper;
using Cos.Dominio;
using Cos.Dominio.Modelos;

namespace Cos.Core.AutoMapper
{
    public class GlobalModelMapping : Profile
    {
        public GlobalModelMapping()
        {
            CreateMap<CargoDTO, Cargo>();
            CreateMap<Cargo, CargoDTO>();

            CreateMap<ClienteDTO, Cliente>();
            CreateMap<Cliente, ClienteDTO>();

            CreateMap<OrcamentoDTO, Orcamento>();
            CreateMap<Orcamento, OrcamentoDTO>();

            CreateMap<OrdemDeServicoDTO, OrdemDeServico>();
            CreateMap<OrdemDeServico, OrdemDeServicoDTO>();

            CreateMap<PagamentoDTO, Pagamento>();
            CreateMap<Pagamento, PagamentoDTO>();

            CreateMap<PecaDTO, Peca>();
            CreateMap<Peca, PecaDTO>();

            CreateMap<ServicoDTO, Servico>();
            CreateMap<Servico, ServicoDTO>();

            CreateMap<StatusDTO, Status>();
            CreateMap<Status, StatusDTO>();

            CreateMap<TipoPagamentoDTO, TipoPagamento>();
            CreateMap<TipoPagamento, TipoPagamentoDTO>();

            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<Usuario, UsuarioDTO>();
        }
    }
}
