using System;
using System.Collections.Generic;

namespace WebDominioAPI.Features.ImportarClienteDominio
{

    public class Cliente
    {
        public int Id { get; set; } = 0;
    }

    public class Funcionario
    {
        public string Id { get; set; } = string.Empty;
        public string Chapa { get; set; } = null;
        public string Status { get; set; } = string.Empty;
        public string StatusImportacao { get; set; } = string.Empty;
        public string IdCliente { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public string DataNascimento { get; set; } = string.Empty;
        public string DDDTelefone { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string DDDCelular { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
        public string EmailPrincipal { get; set; } = string.Empty;
        public string EmailAlternativo { get; set; } = string.Empty;
        public string IdAuxiliarEstadoCivil { get; set; } = string.Empty;
        public string IdAuxiliarCorRaca { get; set; } = string.Empty;
        public Int16 IdAuxiliarGrauInstrucao { get; set; } = 0;
        public string NomeSocial { get; set; } = string.Empty;
        public Int16 IdPaisNascimento { get; set; } = 0;
        public Int16 IdNacionalidade { get; set; } = 0;
        public Int16 IdEstadoNatal { get; set; } = 0;
        public Int16 IdNaturalidade { get; set; } = 0;
        public string PaiNome { get; set; } = string.Empty;
        public Int16 PaiCPF { get; set; } = 0;
        public Int16 PaiDataNascimento { get; set; } = 0;
        public string MaeNome { get; set; } = string.Empty;
        public Int16 MaeCPF { get; set; } = 0;
        public Int16 MaeDataNascimento { get; set; } = 0;
        public string ResidenciaCEP { get; set; } = string.Empty;
        public Int16 ResidenciaIdLogradouro { get; set; } = 0;
        public string ResidenciaEndereco { get; set; } = string.Empty;
        public Int32 ResidenciaNumero { get; set; } = int.MaxValue;
        public string ResidenciaComplemento { get; set; } = string.Empty;
        public string ResidenciaBairro { get; set; } = string.Empty;
        public Int16 ResidenciaIdEstado { get; set; } = 0;
        public Int16 ResidenciaIdCidade { get; set; } = 0;
        public Int16 ResidenciaIdPais { get; set; } = 0;
        public string RGNumero { get; set; } = string.Empty;
        public string RGDataEmissao { get; set; } = string.Empty;
        public string RGOrgaoEmissor { get; set; } = string.Empty;
        public Int16 RGIdEstadoEmissor { get; set; } = 0;
        public string EleitorNumero { get; set; } = string.Empty;
        public string EleitorZona { get; set; } = string.Empty;
        public string EleitorSecao { get; set; } = string.Empty;
        public Int16 Reservista { get; set; } = 0;
        public Int16 ReservistaCategoria { get; set; } = 0;
        public string CTPSNumero { get; set; } = string.Empty;
        public string CTPSSerie { get; set; } = string.Empty;
        public Int16 CTPSDataEmissao { get; set; } = 0;
        public Int16 CTPSIdEstadoEmissor { get; set; } = 0;
        public Int16 NISIsReemprego { get; set; } = 0;
        public string NISNumero { get; set; } = string.Empty;
        public string NISDataCadastro { get; set; } = string.Empty;
        public Int16 NISIdBanco { get; set; } = 0;
        public string RICNumero { get; set; } = string.Empty;
        public string RICDataEmissao { get; set; } = string.Empty;
        public string RICOrgaoEmissor { get; set; } = string.Empty;
        public string CNHNumero { get; set; } = string.Empty;
        public Int16 CNHIdAuxiliarTipo { get; set; } = 0;
        public string CNHDataVencimento { get; set; } = string.Empty;
        public string CNHDataEmissao { get; set; } = string.Empty;
        public string CNHOrgaoEmissor { get; set; } = string.Empty;
        public string CNHIdEstadoEmissor { get; set; } = string.Empty;
        public string CNHDataPrimeiraHabilitacao { get; set; } = string.Empty;
        public Int16 HasAposentadoria { get; set; } = 0;
        public string PassaporteNumero { get; set; } = string.Empty;
        public string PassaporteDataEmissao { get; set; } = string.Empty;
        public string PassaporteDataValidade { get; set; } = string.Empty;
        public Int16 PassaporteIdPaisOrigem { get; set; } = 0;
        public Int16 OCNumero { get; set; } = 0;
        public Int16 OCDataEmissao { get; set; } = 0;
        public Int16 OCDataValidade { get; set; } = 0;
        public string OCOrgaoEmissor { get; set; } = string.Empty;
        public string RNENumero { get; set; } = string.Empty;
        public DateTime RNEDataEmissao { get; set; } = DateTime.MinValue;
        public string RNEOrgaoEmissor { get; set; } = string.Empty;
        public DateTime EstrangeiroDataChegada { get; set; } = DateTime.MinValue;
        public DateTime EstrangeiroDataNaturalizacao { get; set; } = DateTime.MinValue;
        public Int16 EstrangeiroIsCasadoBrasileiro { get; set; } = 0;
        public Int16 EstrangeiroHasFilhos { get; set; } = 0;
        public Int16 EstrangeiroIdPaisResidencia { get; set; } = 0;
        public Int16 EstrangeiroEndereco { get; set; } = 0;
        public Int16 EstrangeiroNumero { get; set; } = 0;
        public Int16 EstrangeiroComplemento { get; set; } = 0;
        public Int16 EstrangeiroBairro { get; set; } = 0;
        public Int16 EstrangeiroCidade { get; set; } = 0;
        public Int16 EstrangeiroCodPostal { get; set; } = 0;
        public string EstrangeiroCondicaoIngresso { get; set; } = string.Empty;
        public string IdArquivoFotografia { get; set; } = string.Empty;
        public string IdUsuarioInclusao { get; set; } = string.Empty;
        public string DataInclusao { get; set; } = string.Empty;
        public string IdUsuarioAlteracao { get; set; } = string.Empty;
        public string DataAlteracao { get; set; } = string.Empty;

    }

    public class FuncionarioDto
    {
        public string Chapa { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string StatusImportacao { get; set; } = string.Empty;
        public string IdCliente { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;

        public FuncionarioDto(Funcionario funcionario)
        {
            Chapa = funcionario.Chapa;
            Status = funcionario.Status;
            StatusImportacao = funcionario.StatusImportacao;
            IdCliente = funcionario.IdCliente;
            Nome = funcionario.Nome;
            CPF = funcionario.CPF;
        }
    }

    public class FuncionarioTrabalhista
    {
        public Int16 Id { get; set; } = 0;
        public string IdFuncionario { get; set; } = string.Empty;
        public string DataAdmissao { get; set; } = string.Empty;
        public int PrimeiroPeriodoExperiencia { get; set; } = 0;
        public int SegundoPeriodoExperiencia { get; set; } = 0;
        public int IdCargoCliente { get; set; } = 0;
        public Int16 IdCargoNovoDominio { get; set; } = 0;
        public Int16 IdFuncao { get; set; } = 0;
        public int IdSecao { get; set; } = 0;
        public Int16 IdAuxiliarTipoAdmissao { get; set; } = 0;
        public Int16 IdAuxiliarTipoIndicativoAdmissao { get; set; } = 0;
        public Int16 HasAdiantamento { get; set; } = 0;
        public Int16 HasValeTransporte { get; set; } = 0;
        public string IdBanco { get; set; } = string.Empty;
        public string Agencia { get; set; } = string.Empty;
        public string ContaCorrente { get; set; } = string.Empty;
        public string ContaCorrenteDigito { get; set; } = string.Empty;
        public Int16 IdAuxiliarContribuicaoSindical { get; set; } = 0;
        public Int16 FiliacaoSindicalValor { get; set; } = 0;
        public int FiliacaoSindicalCNPJ { get; set; } = 0;
        public DateTime FiliacaoSindicalDataBase { get; set; } = DateTime.MinValue;
        public Int16 IsOptante { get; set; } = 0;
        public Int16 DataOpcao { get; set; } = 0;
        public string Salario { get; set; } = string.Empty;
        public Int16 IdAuxiliarFormaRecebimento { get; set; } = 0;
        public Int16 IdAuxiliarTipoSalarioContratual { get; set; } = 0;
        public byte IsDeficienteFisico { get; set; } = byte.MinValue;
        public Int16 IsDeficienteVisual { get; set; } = 0;
        public Int16 IsDeficienteFala { get; set; } = 0;
        public Int16 IsDeficienteAuditivo { get; set; } = 0;
        public Int16 IsDeficienteMental { get; set; } = 0;
        public Int16 IsDeficienteIntelectual { get; set; } = 0;
        public Int16 IsReabilitado { get; set; } = 0;
        public bool IsCotaDeficiente { get; set; } = false;
        public Int16 Observacao { get; set; } = 0;
        public Int16 SucessaoVinculoCNPJ { get; set; } = 0;
        public Int16 SucessaoVinculoNumeroMatricula { get; set; } = 0;
        public Int16 SucessaoVinculoDataInicio { get; set; } = 0;
        public Int16 SucessaoVinculoObservacao { get; set; } = 0;
        public Int16 IdAuxiliarTipoRegimeTrabalho { get; set; } = 0;
        public Int16 IdAuxiliarRegimeJornada { get; set; } = 0;
        public Int16 IdCategoriasTrabalhador { get; set; } = 0;
        public Int16 NaturezaAtividade { get; set; } = 0;
        public Int16 IdAuxiliarTipoContrato { get; set; } = 0;
        public Int16 IdAuxiliarTipoContratoTempoParcial { get; set; } = 0;
        public Int16 IdAuxiliarTipoJornada { get; set; } = 0;
        public string ObservacaoTipoJornada { get; set; } = string.Empty;
        public Int16 DataTermino { get; set; } = 0;
        public decimal QuantidadeMediaHoras { get; set; } = 0;
        public Int16 IdAuxiliarMotivoContratacao { get; set; } = 0;
        public Int16 TrabalhadorSubstitutoCPF { get; set; } = 0;
        public Int16 TrabalhadorSubstitutoMatricula { get; set; } = 0;
        public Int16 NumeroProcessoJuridico { get; set; } = 0;
        public int CodigoHorarioDescricao { get; set; } = 0;
        public Int16 IdNovoHorarioDominio { get; set; } = 0;
        public Int16 IsEstagio { get; set; } = 0;
        public Int16 IdAuxiliarNivelEstagiario { get; set; } = 0;
        public Int16 EstagiarioAreaAtuacao { get; set; } = 0;
        public Int16 EstagiarioNumeroApolice { get; set; } = 0;
        public Int16 EstagiarioCPFSupervisor { get; set; } = 0;
        public Int16 EstagiarioNomeSupervisor { get; set; } = 0;
        public Int16 DataAtestadoASO { get; set; } = 0;
        public Int16 MedicoASO { get; set; } = 0;
        public Int16 DDDASO { get; set; } = 0;
        public Int16 TelefoneASO { get; set; } = 0;
        public Int16 NumeroCRMASO { get; set; } = 0;
        public Int16 IdEstadoEmissorASO { get; set; } = 0;
        public Int16 IdAuxiliarHipoteseLegalContratacaoTrabalhadorTemporario { get; set; } = 0;
        public string JustificativaLegalContratacaoTrabalhadorTemporario { get; set; } = string.Empty;
        public Int16 IdAuxiliarTipoInclusaoContratoTrabalhadorTemporario { get; set; } = 0;
        public Int16 IdAuxiliarTipoInscricaoEmpresaContratanteTrabalhadorTemporario { get; set; } = 0;
        public string EmpresaContratanteNumeroInscricaoTrabalhadorTemporario { get; set; } = string.Empty;
        public Int16 IdAuxiliarTipoInscricaoEstabalecimentoVinculadoTrabalhadorTemporario { get; set; } = 0;
        public string EstabalecimentoVinculadoToNumeroInscricaoTrabalhadorTemporario { get; set; } = string.Empty;
        public string ObservacaoProrrogacaoContratoTrabalhoTemporario { get; set; } = string.Empty;
        public Int16 StatusTrabalhista { get; set; } = 0;
        public Int16 EstagiarioDataPrevistaTermino { get; set; } = 0;
        public Int16 HasSeguroDesemprego { get; set; } = 0;
        public Int16 IdUsuarioInclusao { get; set; } = 0;
        public DateTime DataInclusao { get; set; } = DateTime.MinValue;
        public Int16 IdUsuarioAlteracao { get; set; } = 0;
        public DateTime DataAlteracao { get; set; } = DateTime.MinValue;
        public bool HasEmailAdmissaoEmpregadoCadastroUmDiaAntesAdmissao { get; set; } = false;
        public bool HasEnviarEmailAdmissaoEmpregadoModalCadastroDepoisAdmissao { get; set; } = false;
        public bool HasLetsWork { get; set; } = false;
        public Int16 IdCentroCusto { get; set; } = 0;
        public bool HasCargoConfianca { get; set; } = false;
    }

    public class FuncionarioTrabalhistaDto
    {
        public string IdFuncionario { get; set; } = string.Empty;
        public string DataAdmissao { get; set; } = string.Empty ;

        public FuncionarioTrabalhistaDto(FuncionarioTrabalhista funcionarioTrabalhista)
        {
            IdFuncionario = funcionarioTrabalhista.IdFuncionario;
            DataAdmissao = funcionarioTrabalhista.DataAdmissao; 
        }

    }

    public class DependenteFuncionario
    {
        public int Id { get; set; } = int.MinValue;
        public int IdCliente { get; set; } = int.MinValue;
        public string IdFuncionario { get; set; } = String.Empty;
        public string Dependente { get; set; } = String.Empty;
        public string CPF { get; set; } = String.Empty;
        public string Nascimento { get; set; } = String.Empty;
        public int IdCodParent { get; set; } = int.MinValue;
        public Int16 Sexo { get; set; } = short.MinValue;
        public Int16 IdCodEstCivil { get; set; } = short.MinValue;
        public string LocalNascimento { get; set; } = String.Empty;
        public string Registro { get; set; } = String.Empty;
        public string Livro { get; set; } = String.Empty;
        public string Folha { get; set; } = String.Empty;
        public string Cartorio { get; set; } = String.Empty;
        public string IRRF { get; set; } = String.Empty;
        public string SalarioFamilia { get; set; } = String.Empty;
        public Int16 EntregouComprovanteEscolar { get; set; } = short.MinValue;
        public Int16 EntregouCartaoVacina { get; set; } = short.MinValue;
        public Int16 Universitario_CursandoTecnico { get; set; } = short.MinValue;
        public string DataEntregaCertidao { get; set; } = string.Empty;
        public string IncapacidadeFisicaMentalTrabalho { get; set; } = string.Empty;
        public string StatusImportacao { get; set; } = string.Empty;
        public string IdUsuarioInclusao { get; set; } = string.Empty;
        public string DataInclusao { get; set; } = string.Empty;
        public string IdUsuarioAlteracao { get; set; } = string.Empty;
        public string DataAlteracao { get; set; } = string.Empty;
        public string ConvenioMedico { get; set; } = string.Empty;
        public string ConvenioOdontologico { get; set; } = string.Empty;
        public string is_concluido { get; set; } = string.Empty;
    }

    public class DependenteFuncionarioDto
    {
        public int IdCliente { get; set; } = 0;
        public string IdFuncionario { get; set; } = string.Empty;
        public string Dependente { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;

        public DependenteFuncionarioDto(DependenteFuncionario dependenteFuncionario)
        {
            IdCliente = dependenteFuncionario.IdCliente;
            IdFuncionario = dependenteFuncionario.IdFuncionario;
            Dependente = dependenteFuncionario.Dependente;
            CPF = dependenteFuncionario.CPF;
        }
    }

    public class Import
    {
        public List<Funcionario> Funcionario { get; set; } = new List<Funcionario>();
        public List<FuncionarioTrabalhista> FuncionarioTrabalhista { get; set; } = new List<FuncionarioTrabalhista>();
        public List<DependenteFuncionario> DependenteFuncionario { get; set; } = new List<DependenteFuncionario>();
    }

    public class ImportDto
    {
        public List<FuncionarioDto> FuncionarioDto { get; set; } = new List<FuncionarioDto>();
        public List<FuncionarioTrabalhistaDto> FuncionarioTrabalhistaDto { get; set; } = new List<FuncionarioTrabalhistaDto>();
        public List<DependenteFuncionarioDto> DependenteFuncionarioDto { get; set; } = new List<DependenteFuncionarioDto>();

    }

}