using AutoMapper;
using Sanegeo.Dominio;
using Sanegeo.Dominio.Modelos;
using Sanegeo.SQL.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanegeo.SQL.AutoMapper
{
    public class GlobalModelMapping:Profile
    {
        public GlobalModelMapping()
        {
            CreateMap<AcaoDTO, SANEGEO_ACAO>();
            CreateMap<SANEGEO_ACAO, AcaoDTO>();

            CreateMap<AjusteDTO, SANEGEO_AJUSTE>();
            CreateMap<SANEGEO_AJUSTE, AjusteDTO>();

            CreateMap<AlarmeDTO, SANEGEO_ALARME>();
            CreateMap<SANEGEO_ALARME, AlarmeDTO>();

            CreateMap<AparelhoDTO, SANEGEO_APARELHO>();
            CreateMap<SANEGEO_APARELHO, AparelhoDTO>();

            CreateMap<AparelhoRegiaoDTO, SANEGEO_APARELHO_REGIAO>();
            CreateMap<SANEGEO_APARELHO_REGIAO, AparelhoRegiaoDTO>();

            CreateMap<AtendimentoDTO, SANEGEO_ATENDIMENTO>();
            CreateMap<SANEGEO_ATENDIMENTO, AtendimentoDTO>();

            CreateMap<BairroDTO, SANEGEO_BAIRRO>();
            CreateMap<SANEGEO_BAIRRO, BairroDTO>();

            CreateMap<CargoDTO, SANEGEO_CARGO>();
            CreateMap<SANEGEO_CARGO, CargoDTO>();

            CreateMap<CategoriaDTO, SANEGEO_CATEGORIA>();
            CreateMap<SANEGEO_CATEGORIA, CategoriaDTO>();

            CreateMap<CategoriaServicoDTO, SANEGEO_CATEGORIA_SERVICO>();
            CreateMap<SANEGEO_CATEGORIA_SERVICO, CategoriaServicoDTO>();

            CreateMap<ClienteDTO, SANEGEO_CLIENTE>();
            CreateMap<SANEGEO_CLIENTE, ClienteDTO>();

            CreateMap<CredencialEmailDTO, SANEGEO_CREDENCIAL_EMAIL>();
            CreateMap<SANEGEO_CREDENCIAL_EMAIL, CredencialEmailDTO>();

            CreateMap<DestinatarioDTO, SANEGEO_DESTINATARIO>();
            CreateMap<SANEGEO_DESTINATARIO, DestinatarioDTO>();

            CreateMap<DestinatarioLimiteDTO, SANEGEO_DESTINATARIO_LIMITE>();
            CreateMap<SANEGEO_DESTINATARIO_LIMITE, DestinatarioLimiteDTO>();

            CreateMap<DistribuicaoDTO, SANEGEO_DISTRIBUICAO>();
            CreateMap<SANEGEO_DISTRIBUICAO, DistribuicaoDTO>();

            CreateMap<DistribuicaoOrigemDTO, SANEGEO_DISTRIBUICAO_ORIGEM>();
            CreateMap<SANEGEO_DISTRIBUICAO_ORIGEM, DistribuicaoOrigemDTO>();

            CreateMap<DistribuicaoServicoSolicitadoDTO, SANEGEO_DISTRIBUICAO_SERVICO_SOLICITADO>();
            CreateMap<SANEGEO_DISTRIBUICAO_SERVICO_SOLICITADO, DistribuicaoServicoSolicitadoDTO>();

            CreateMap<DistribuicaoDestinatarioDTO, SANEGEO_DISTRIBUICAO_DESTINATARIO>();
            CreateMap<SANEGEO_DISTRIBUICAO_DESTINATARIO, DistribuicaoDestinatarioDTO>();

            CreateMap<EmpreendimentoDTO, SANEGEO_EMPREENDIMENTO>();
            CreateMap<SANEGEO_EMPREENDIMENTO, EmpreendimentoDTO>();

            CreateMap<EmpreendimentoPrevisaoDTO, SANEGEO_EMPREENDIMENTO_PREVISAO>();
            CreateMap<SANEGEO_EMPREENDIMENTO_PREVISAO, EmpreendimentoPrevisaoDTO>();

            CreateMap<EquipeDestinatarioDTO, SANEGEO_EQUIPE_DESTINATARIO>();
            CreateMap<SANEGEO_EQUIPE_DESTINATARIO, EquipeDestinatarioDTO>();

            CreateMap<EquipeDTO, SANEGEO_EQUIPE>();
            CreateMap<SANEGEO_EQUIPE, EquipeDTO>();

            CreateMap<EquipeExternaDTO, SANEGEO_EQUIPE_EXTERNA>();
            CreateMap<SANEGEO_EQUIPE_EXTERNA, EquipeExternaDTO>();

            CreateMap<EquipeFuncionarioDTO, SANEGEO_EQUIPE_FUNCIONARIO>();
            CreateMap<SANEGEO_EQUIPE_FUNCIONARIO, EquipeFuncionarioDTO>();

            CreateMap<FiltroDTO, SANEGEO_FILTRO>();
            CreateMap<SANEGEO_FILTRO, FiltroDTO>();

            CreateMap<FiltroEmpreendimentoDTO, SANEGEO_FILTRO_EMPREENDIMENTO>();
            CreateMap<SANEGEO_FILTRO_EMPREENDIMENTO, FiltroEmpreendimentoDTO>();

            CreateMap<FuncionarioDTO, SANEGEO_FUNCIONARIO>();
            CreateMap<SANEGEO_FUNCIONARIO, FuncionarioDTO>();

            CreateMap<FuncionarioModuloDTO, SANEGEO_FUNCIONARIO_MODULO>();
            CreateMap<SANEGEO_FUNCIONARIO_MODULO, FuncionarioModuloDTO>();

            CreateMap<ItemSinalizacaoDTO, SANEGEO_ITEM_SINALIZACAO>();
            CreateMap<SANEGEO_ITEM_SINALIZACAO, ItemSinalizacaoDTO>();

            CreateMap<LeituraAjustadaDTO, SANEGEO_LEITURA_AJUSTADA>();
            CreateMap<SANEGEO_LEITURA_AJUSTADA, LeituraAjustadaDTO>();

            CreateMap<LeituraOriginalDTO, SANEGEO_LEITURA_ORIGINAL>();
            CreateMap<SANEGEO_LEITURA_ORIGINAL, LeituraOriginalDTO>();

            CreateMap<LocalizacaoGeograficaDTO, SANEGEO_LOCALIZACAO_GEOGRAFICA>();
            CreateMap<SANEGEO_LOCALIZACAO_GEOGRAFICA, LocalizacaoGeograficaDTO>();

            CreateMap<LogradouroDTO, SANEGEO_LOG_SISTEMA>();
            CreateMap<SANEGEO_LOG_SISTEMA, LogradouroDTO>();

            CreateMap<LogDTO, SANEGEO_LOG_SISTEMA>();
            CreateMap<SANEGEO_LOGRADOURO, LogDTO>();

            CreateMap<ModuloDTO, SANEGEO_MODULO>();
            CreateMap<SANEGEO_MODULO, ModuloDTO>();

            CreateMap<MaterialOcorrenciaDTO, SANEGEO_OCORRENCIA_MATERIAL>();
            CreateMap<SANEGEO_OCORRENCIA_MATERIAL, MaterialOcorrenciaDTO>();

            CreateMap<OcorrenciaLWDTO, SANEGEO_OCORRENCIA>();
            CreateMap<SANEGEO_OCORRENCIA, OcorrenciaLWDTO>();

            CreateMap<OcorrenciaDTO, SANEGEO_OCORRENCIA>();
            CreateMap<SANEGEO_OCORRENCIA, OcorrenciaDTO>();

            CreateMap<OcorrenciaAtendimentoExternoDTO, SANEGEO_OCORRENCIA_ATENDIMENTO_EXTERNO>();
            CreateMap<SANEGEO_OCORRENCIA_ATENDIMENTO_EXTERNO, OcorrenciaAtendimentoExternoDTO>();

            CreateMap<OcorrenciaImagemDTO, SANEGEO_OCORRENCIA_IMAGEM>();
            CreateMap<SANEGEO_OCORRENCIA_IMAGEM, OcorrenciaImagemDTO>();

            CreateMap<DivergenciaDTO, SANEGEO_OCORRENCIA_DIVERGENCIA>();
            CreateMap<SANEGEO_OCORRENCIA_DIVERGENCIA, DivergenciaDTO>();

            CreateMap<OcorrenciaEquipeDTO, SANEGEO_OCORRENCIA_EQUIPE>();
            CreateMap<SANEGEO_OCORRENCIA_EQUIPE, OcorrenciaEquipeDTO>();

            CreateMap<OcorrenciaFuncionarioDTO, SANEGEO_OCORRENCIA_FUNCIONARIO>();
            CreateMap<SANEGEO_OCORRENCIA_FUNCIONARIO, OcorrenciaFuncionarioDTO>();

            CreateMap<OcorrenciaItemSinalizacaoDTO, SANEGEO_OCORRENCIA_ITEM_SINALIZACAO>();
            CreateMap<SANEGEO_OCORRENCIA_ITEM_SINALIZACAO, OcorrenciaItemSinalizacaoDTO>();

            CreateMap<PerfilDTO, SANEGEO_PERFIL>();
            CreateMap<SANEGEO_PERFIL, PerfilDTO>();

            CreateMap<PosicaoEquipeDTO, SANEGEO_POSICAO_EQUIPE>();
            CreateMap<SANEGEO_POSICAO_EQUIPE, PosicaoEquipeDTO>();

            CreateMap<PrazoDTO, SANEGEO_PRAZO_SERVICO>();
            CreateMap<SANEGEO_PRAZO_SERVICO, PrazoDTO>();

            CreateMap<PreCadastroDestinatarioDTO, SANEGEO_PRE_CADASTRO_DESTINATARIO>();
            CreateMap<SANEGEO_PRE_CADASTRO_DESTINATARIO, PreCadastroDestinatarioDTO>();

            CreateMap<PreCadastroDTO, SANEGEO_PRE_CADASTRO>();
            CreateMap<SANEGEO_PRE_CADASTRO, PreCadastroDTO>();

            CreateMap<PreCadastroModuloDTO, SANEGEO_PRE_CADASTRO_MODULO>();
            CreateMap<SANEGEO_PRE_CADASTRO_MODULO, PreCadastroModuloDTO>();

            CreateMap<ReclamacaoDTO, SANEGEO_RECLAMACAO>();
            CreateMap<SANEGEO_RECLAMACAO, ReclamacaoDTO>();

            CreateMap<RegiaoDTO, SANEGEO_REGIAO>();
            CreateMap<SANEGEO_REGIAO, RegiaoDTO>();

            CreateMap<RegiaoDomasaDTO, SANEGEO_REGIAO_DOMASA>();
            CreateMap<SANEGEO_REGIAO_DOMASA, RegiaoDomasaDTO>();

            CreateMap<RegiaoLocalizacaoDTO, SANEGEO_REGIAO_LOCALIZACAO>();
            CreateMap<SANEGEO_REGIAO_LOCALIZACAO, RegiaoLocalizacaoDTO>();

            CreateMap<SetorDTO, SANEGEO_SETOR>();
            CreateMap<SANEGEO_SETOR, SetorDTO>();

            CreateMap<SetorSolicitanteServicoDTO, SANEGEO_SETOR_SOLICITANTE_SERVICO>();
            CreateMap<SANEGEO_SETOR_SOLICITANTE_SERVICO, SetorSolicitanteServicoDTO>();

            CreateMap<SemComunicacaoDTO, SANEGEO_SEM_COMUNICACAO>();
            CreateMap<SANEGEO_SEM_COMUNICACAO, SemComunicacaoDTO>();

            CreateMap<ServicoExecutadoDTO, SANEGEO_SERVICO_EXECUTADO>();
            CreateMap<SANEGEO_SERVICO_EXECUTADO, ServicoExecutadoDTO>();

            CreateMap<ServicoSolicitadoDTO, SANEGEO_SERVICO_SOLICITADO>();
            CreateMap<SANEGEO_SERVICO_SOLICITADO, ServicoSolicitadoDTO>();

            CreateMap<SetorAbastecimentoDTO, SANEGEO_SETOR_ABASTECIMENTO>();
            CreateMap<SANEGEO_SETOR_ABASTECIMENTO, SetorAbastecimentoDTO>();

            CreateMap<ServicoSolicitadoExecucaoDTO, SANEGEO_SERVICO_SOLICITADO_EXECUCAO>();
            CreateMap<SANEGEO_SERVICO_SOLICITADO_EXECUCAO, ServicoSolicitadoExecucaoDTO>();

            CreateMap<StatusAlarmeDTO, SANEGEO_STATUS_ALARME>();
            CreateMap<SANEGEO_STATUS_ALARME, StatusAlarmeDTO>();

            CreateMap<StatusClienteDTO, SANEGEO_STATUS_CLIENTE>();
            CreateMap<SANEGEO_STATUS_CLIENTE, StatusClienteDTO>();

            CreateMap<StatusEmpreendimentoDTO, SANEGEO_STATUS_EMPREENDIMENTO>();
            CreateMap<SANEGEO_STATUS_EMPREENDIMENTO, StatusEmpreendimentoDTO>();

            CreateMap<StatusOcorrenciaDTO, SANEGEO_STATUS_OCORRENCIA>();
            CreateMap<SANEGEO_STATUS_OCORRENCIA, StatusOcorrenciaDTO>();

            CreateMap<TipoClienteDTO, SANEGEO_TIPO_CLIENTE>();
            CreateMap<SANEGEO_TIPO_CLIENTE, TipoClienteDTO>();

            CreateMap<TipoDTO, SANEGEO_TIPO>();
            CreateMap<SANEGEO_TIPO, TipoDTO>();

            CreateMap<TipoEmpreendimentoDTO, SANEGEO_TIPO_EMPREENDIMENTO>();
            CreateMap<SANEGEO_TIPO_EMPREENDIMENTO, TipoEmpreendimentoDTO>();

            CreateMap<TipoMedidaPavimentoDTO, SANEGEO_TIPO_MEDIDA_PAVIMENTO>();
            CreateMap<SANEGEO_TIPO_MEDIDA_PAVIMENTO, TipoMedidaPavimentoDTO>();

            CreateMap<UsuarioDestinatarioDTO, SANEGEO_USUARIO_DESTINATARIO>();
            CreateMap<SANEGEO_USUARIO_DESTINATARIO, UsuarioDestinatarioDTO>();

            CreateMap<UsuarioDTO, SANEGEO_USUARIO>();
            CreateMap<SANEGEO_USUARIO, UsuarioDTO>();

            CreateMap<UsuarioModuloDTO, SANEGEO_USUARIO_MODULO>();
            CreateMap<SANEGEO_USUARIO_MODULO, UsuarioModuloDTO>();

            CreateMap<VeiculoDTO, SANEGEO_VEICULO>();
            CreateMap<SANEGEO_VEICULO, VeiculoDTO>();

            CreateMap<ArquivoDTO, SANEGEO_ARQUIVOS>();
            CreateMap<SANEGEO_ARQUIVOS, ArquivoDTO>();

            CreateMap<AtorDTO, SANEGEO_ATOR>();
            CreateMap<SANEGEO_ATOR, AtorDTO>();
        }
    }
}
