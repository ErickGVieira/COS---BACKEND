using AutoMapper;
using Cos.Dominio;
using Cos.Dominio.Modelos;
using Sanegeo.Dominio;

namespace Cos.Core.AutoMapper
{
    public class GlobalModelMapping : Profile
    {
        public GlobalModelMapping()
        {
            CreateMap<AeronaveDTO, Aeronave>();
            CreateMap<Aeronave, AeronaveDTO>();

            CreateMap<ModeloDTO, Modelo>();
            CreateMap<Modelo, ModeloDTO>();
        }
    }
}
