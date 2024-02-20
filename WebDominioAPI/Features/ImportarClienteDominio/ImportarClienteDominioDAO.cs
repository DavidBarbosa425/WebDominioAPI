using Dapper;
using iAnywhere.Data.SQLAnywhere;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WebDominioAPI.Core;

namespace WebDominioAPI.Features.ImportarClienteDominio
{
    public class ImportarClienteDominioDAO
    {
        public List<Funcionario> GetFuncionario(Cliente cliente)
        {
            int loop = 0;

            try
            {
                ImportarClienteDominioService service = new ImportarClienteDominioService();

                List<Funcionario> list = new List<Funcionario>();

                SAConnection conn = new SAConnection((DbConfig.conexao));

                string sqlDominio = service.ObterSelectDominio(ConfigurationManager.AppSettings["CaminhoSQLDominio"].ToString() + "tbFuncionario.txt");
                sqlDominio = sqlDominio.Replace("@IdCliente",cliente.Id.ToString());

                SACommand cmd = new SACommand(sqlDominio, conn);

                conn.Open();

                using (IDataReader pDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (pDataReader.Read())
                    {
                        if (pDataReader.FieldCount > 0)
                        {
                            loop++;
                            Funcionario funcionario = new Funcionario();

                            funcionario.Chapa = pDataReader[0] != DBNull.Value ? (string)pDataReader[0] : "";
                            funcionario.Status = pDataReader[1] != DBNull.Value ? (string)pDataReader[1] : "";
                            funcionario.StatusImportacao = pDataReader[2] != DBNull.Value ? (string)pDataReader[2] : "";
                            funcionario.IdCliente = pDataReader[3] != DBNull.Value ? (string)pDataReader[3] : "";
                            funcionario.Nome = pDataReader[4] != DBNull.Value ? (string)pDataReader[4] : "";
                            funcionario.CPF = pDataReader[5] != DBNull.Value ? (string)pDataReader[5] : "";
                            funcionario.Sexo = pDataReader[6] != DBNull.Value ? (string)pDataReader[6] : "";
                            funcionario.DataNascimento = pDataReader[7] != DBNull.Value ? (string)pDataReader[7] : "";
                            funcionario.DDDTelefone = pDataReader[8] != DBNull.Value ? (string)pDataReader[8] : "";
                            funcionario.Telefone = pDataReader[9] != DBNull.Value ? (string)pDataReader[9] : "";
                            funcionario.DDDCelular = pDataReader[10] != DBNull.Value ? (string)pDataReader[10] : "";
                            funcionario.Celular = pDataReader[11] != DBNull.Value ? (string)pDataReader[11] : "";
                            funcionario.EmailPrincipal = pDataReader[12] != DBNull.Value ? (string)pDataReader[12] : "";
                            funcionario.EmailAlternativo = pDataReader[13] != DBNull.Value ? (string)pDataReader[13] : "";
                            funcionario.IdAuxiliarEstadoCivil = pDataReader[14] != DBNull.Value ? (string)pDataReader[14] : "";
                            funcionario.IdAuxiliarCorRaca = pDataReader[15] != DBNull.Value ? (string)pDataReader[15] : "";
                            funcionario.IdAuxiliarGrauInstrucao = pDataReader[16] != DBNull.Value ? (Int16)pDataReader[16] : short.MinValue;
                            funcionario.IdPaisNascimento = pDataReader[17] != DBNull.Value ? (Int16)pDataReader[17] : short.MinValue;
                            funcionario.IdNacionalidade = pDataReader[18] != DBNull.Value ? (Int16)pDataReader[18] : short.MinValue;
                            funcionario.IdEstadoNatal = pDataReader[19] != DBNull.Value ? (Int16)pDataReader[19] : short.MinValue;
                            funcionario.IdNaturalidade = pDataReader[20] != DBNull.Value ? (Int16)pDataReader[20] : short.MinValue;
                            funcionario.PaiNome = pDataReader[21] != DBNull.Value ? (string)pDataReader[21] : "";
                            funcionario.PaiCPF = pDataReader[22] != DBNull.Value ? (Int16)pDataReader[22] : short.MinValue;
                            funcionario.PaiDataNascimento = pDataReader[23] != DBNull.Value ? (Int16)pDataReader[23] : short.MinValue;
                            funcionario.MaeNome = pDataReader[24] != DBNull.Value ? (string)pDataReader[24] : "";
                            funcionario.MaeCPF = pDataReader[25] != DBNull.Value ? (Int16)pDataReader[25] : short.MinValue;
                            funcionario.MaeDataNascimento = pDataReader[26] != DBNull.Value ? (Int16)pDataReader[26] : short.MinValue;
                            funcionario.ResidenciaCEP = pDataReader[27] != DBNull.Value ? (string)pDataReader[27] : "";
                            funcionario.ResidenciaIdLogradouro = pDataReader[28] != DBNull.Value ? (Int16)pDataReader[28] : short.MinValue;
                            funcionario.ResidenciaEndereco = pDataReader[29] != DBNull.Value ? (string)pDataReader[29] : "";
                            funcionario.ResidenciaNumero = pDataReader[30] != DBNull.Value ? (Int32)pDataReader[30] : short.MinValue;
                            funcionario.ResidenciaComplemento = pDataReader[31] != DBNull.Value ? (string)pDataReader[31] : "";
                            funcionario.ResidenciaBairro = pDataReader[32] != DBNull.Value ? (string)pDataReader[32] : "";
                            funcionario.ResidenciaIdEstado = pDataReader[33] != DBNull.Value ? (Int16)pDataReader[33] : short.MinValue;
                            funcionario.ResidenciaIdCidade = pDataReader[34] != DBNull.Value ? (Int16)pDataReader[34] : short.MinValue;
                            funcionario.ResidenciaIdPais = pDataReader[35] != DBNull.Value ? (Int16)pDataReader[35] : short.MinValue;
                            funcionario.RGNumero = pDataReader[36] != DBNull.Value ? (string)pDataReader[36] : "";
                            funcionario.RGDataEmissao = pDataReader[37] != DBNull.Value ? (string)pDataReader[37] : "";
                            funcionario.RGOrgaoEmissor = pDataReader[38] != DBNull.Value ? (string)pDataReader[38] : "";
                            funcionario.RGIdEstadoEmissor = pDataReader[39] != DBNull.Value ? (Int16)pDataReader[39] : short.MinValue;
                            funcionario.EleitorNumero = pDataReader[40] != DBNull.Value ? (string)pDataReader[40] : "";
                            funcionario.EleitorZona = pDataReader[41] != DBNull.Value ? (string)pDataReader[41] : "";
                            funcionario.EleitorSecao = pDataReader[42] != DBNull.Value ? (string)pDataReader[42] : "";
                            funcionario.Reservista = pDataReader[43] != DBNull.Value ? (Int16)pDataReader[43] : short.MinValue;
                            funcionario.ReservistaCategoria = pDataReader[44] != DBNull.Value ? (Int16)pDataReader[44] : short.MinValue;
                            funcionario.CTPSNumero = pDataReader[45] != DBNull.Value ? (string)pDataReader[45] : "";
                            funcionario.CTPSSerie = pDataReader[46] != DBNull.Value ? (string)pDataReader[46] : "";
                            funcionario.CTPSDataEmissao = pDataReader[47] != DBNull.Value ? (Int16)pDataReader[47] : short.MinValue;
                            funcionario.CTPSIdEstadoEmissor = pDataReader[48] != DBNull.Value ? (Int16)pDataReader[48] : short.MinValue;
                            funcionario.NISIsReemprego = pDataReader[49] != DBNull.Value ? (Int16)pDataReader[49] : short.MinValue;
                            funcionario.NISNumero = pDataReader[50] != DBNull.Value ? (string)pDataReader[50] : "";
                            funcionario.NISDataCadastro = pDataReader[51] != DBNull.Value ? (string)pDataReader[51] : "";
                            funcionario.NISIdBanco = pDataReader[52] != DBNull.Value ? (Int16)pDataReader[52] : short.MinValue;
                            funcionario.RICNumero = pDataReader[53] != DBNull.Value ? (string)pDataReader[53] : "";
                            funcionario.RICDataEmissao = pDataReader[54] != DBNull.Value ? (string)pDataReader[54] : "";
                            funcionario.RICOrgaoEmissor = pDataReader[55] != DBNull.Value ? (string)pDataReader[55] : "";
                            funcionario.CNHNumero = pDataReader[56] != DBNull.Value ? (string)pDataReader[56] : "";
                            funcionario.CNHIdAuxiliarTipo = pDataReader[57] != DBNull.Value ? (Int16)pDataReader[57] : short.MinValue;
                            funcionario.CNHDataVencimento = pDataReader[58] != DBNull.Value ? (string)pDataReader[58] : "";
                            funcionario.CNHDataEmissao = pDataReader[59] != DBNull.Value ? (string)pDataReader[59] : "";
                            funcionario.CNHOrgaoEmissor = pDataReader[60] != DBNull.Value ? (string)pDataReader[60] : "";
                            funcionario.HasAposentadoria = pDataReader[61] != DBNull.Value ? (Int16)pDataReader[61] : short.MinValue;
                            funcionario.PassaporteNumero = pDataReader[62] != DBNull.Value ? (string)pDataReader[62] : "";
                            funcionario.PassaporteDataEmissao = pDataReader[63] != DBNull.Value ? (string)pDataReader[63] : "";
                            funcionario.PassaporteDataValidade = pDataReader[64] != DBNull.Value ? (string)pDataReader[64] : "";
                            funcionario.PassaporteIdPaisOrigem = pDataReader[65] != DBNull.Value ? (Int16)pDataReader[65] : short.MinValue;
                            funcionario.OCNumero = pDataReader[66] != DBNull.Value ? (Int16)pDataReader[66] : short.MinValue;
                            funcionario.OCDataEmissao = pDataReader[67] != DBNull.Value ? (Int16)pDataReader[67] : short.MinValue;
                            funcionario.OCDataValidade = pDataReader[68] != DBNull.Value ? (Int16)pDataReader[68] : short.MinValue;
                            funcionario.OCOrgaoEmissor = pDataReader[69] != DBNull.Value ? (string)pDataReader[69] : "";
                            funcionario.RNENumero = pDataReader[70] != DBNull.Value ? (string)pDataReader[70] : "";
                            funcionario.RNEDataEmissao = pDataReader[71] != DBNull.Value ? (pDataReader[71] is DateTime ? (DateTime)pDataReader[71] : DateTime.MinValue) : DateTime.MinValue;
                            funcionario.RNEOrgaoEmissor = pDataReader[72] != DBNull.Value ? (string)pDataReader[72] : "";
                            funcionario.EstrangeiroDataChegada = pDataReader[73] != DBNull.Value ? (pDataReader[73] is DateTime ? (DateTime)pDataReader[73] : DateTime.MinValue) : DateTime.MinValue;
                            funcionario.EstrangeiroDataNaturalizacao = pDataReader[74] != DBNull.Value ? (pDataReader[74] is DateTime ? (DateTime)pDataReader[74] : DateTime.MinValue) : DateTime.MinValue;
                            funcionario.EstrangeiroIsCasadoBrasileiro = pDataReader[75] != DBNull.Value ? (Int16)pDataReader[75] : short.MinValue;
                            funcionario.EstrangeiroHasFilhos = pDataReader[76] != DBNull.Value ? (Int16)pDataReader[76] : short.MinValue;
                            funcionario.EstrangeiroIdPaisResidencia = pDataReader[77] != DBNull.Value ? (Int16)pDataReader[77] : short.MinValue;
                            funcionario.EstrangeiroEndereco = pDataReader[78] != DBNull.Value ? (Int16)pDataReader[78] : short.MinValue;
                            funcionario.EstrangeiroNumero = pDataReader[79] != DBNull.Value ? (Int16)pDataReader[79] : short.MinValue;
                            funcionario.EstrangeiroComplemento = pDataReader[80] != DBNull.Value ? (Int16)pDataReader[80] : short.MinValue;
                            funcionario.EstrangeiroBairro = pDataReader[81] != DBNull.Value ? (Int16)pDataReader[81] : short.MinValue;
                            funcionario.EstrangeiroCidade = pDataReader[82] != DBNull.Value ? (Int16)pDataReader[82] : short.MinValue;
                            funcionario.EstrangeiroCodPostal = pDataReader[83] != DBNull.Value ? (Int16)pDataReader[83] : short.MinValue;


                            list.Add(funcionario);
                        }

                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(loop);
                throw ex;
            }
        }

        public List<FuncionarioTrabalhista> GetFuncionarioTrabalhista(Cliente cliente)
        {
            int loop = 0;

            try
            {
                ImportarClienteDominioService service = new ImportarClienteDominioService();

                List<FuncionarioTrabalhista> list = new List<FuncionarioTrabalhista>();

                SAConnection conn = new SAConnection((DbConfig.conexao));

                string sqlDominio = service.ObterSelectDominio(ConfigurationManager.AppSettings["CaminhoSQLDominio"].ToString() + "tbFuncionarioTrabalhista.txt");
                sqlDominio = sqlDominio.Replace("@IdCliente", cliente.Id.ToString());

                SACommand cmd = new SACommand(sqlDominio, conn);

                conn.Open();

                using (IDataReader pDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (pDataReader.Read())
                    {
                        if (pDataReader.FieldCount > 0)
                        {
                            loop++;
                            FuncionarioTrabalhista funcionarioTrabalhista = new FuncionarioTrabalhista();
                            funcionarioTrabalhista.IdFuncionario = pDataReader[0] != DBNull.Value ? (string)pDataReader[0] : "";
                            funcionarioTrabalhista.DataAdmissao = pDataReader[1] != DBNull.Value ? (string)pDataReader[1] : "";
                            funcionarioTrabalhista.PrimeiroPeriodoExperiencia = pDataReader[2] != DBNull.Value ? (int)pDataReader[2] : int.MinValue;
                            funcionarioTrabalhista.SegundoPeriodoExperiencia = pDataReader[3] != DBNull.Value ? (int)pDataReader[3] : int.MinValue;
                            funcionarioTrabalhista.IdCargoCliente = pDataReader[4] != DBNull.Value ? (int)pDataReader[4] : int.MinValue;
                            funcionarioTrabalhista.IdFuncao = pDataReader[5] != DBNull.Value ? (Int16)pDataReader[5] : short.MinValue;
                            funcionarioTrabalhista.IdSecao = pDataReader[6] != DBNull.Value ? (int)pDataReader[6] : int.MinValue;
                            funcionarioTrabalhista.IdAuxiliarTipoAdmissao = pDataReader[7] != DBNull.Value ? (Int16)pDataReader[7] : short.MinValue;
                            funcionarioTrabalhista.IdAuxiliarTipoIndicativoAdmissao = pDataReader[8] != DBNull.Value ? (Int16)pDataReader[8] : short.MinValue;
                            funcionarioTrabalhista.HasAdiantamento = pDataReader[9] != DBNull.Value ? (Int16)pDataReader[9] : short.MinValue;
                            funcionarioTrabalhista.HasValeTransporte = pDataReader[10] != DBNull.Value ? (Int16)pDataReader[10] : short.MinValue;
                            funcionarioTrabalhista.IdBanco = pDataReader[11] != DBNull.Value ? (string)pDataReader[11] : "";
                            funcionarioTrabalhista.Agencia = pDataReader[12] != DBNull.Value ? (string)pDataReader[12] : "";
                            funcionarioTrabalhista.ContaCorrente = pDataReader[13] != DBNull.Value ? (string)pDataReader[13] : "";
                            funcionarioTrabalhista.ContaCorrenteDigito = pDataReader[14] != DBNull.Value ? (string)pDataReader[14] : "";
                            funcionarioTrabalhista.IdAuxiliarContribuicaoSindical = pDataReader[15] != DBNull.Value ? (Int16)pDataReader[15] : short.MinValue;
                            funcionarioTrabalhista.FiliacaoSindicalValor = pDataReader[16] != DBNull.Value ? (Int16)pDataReader[16] : short.MinValue;
                            funcionarioTrabalhista.FiliacaoSindicalCNPJ = pDataReader[17] != DBNull.Value ? (int)pDataReader[17] : int.MinValue;
                            funcionarioTrabalhista.IsOptante = pDataReader[18] != DBNull.Value ? (Int16)pDataReader[18] : short.MinValue;
                            funcionarioTrabalhista.DataOpcao = pDataReader[19] != DBNull.Value ? (Int16)pDataReader[19] : short.MinValue;
                            funcionarioTrabalhista.Salario = pDataReader[20] != DBNull.Value ? (string)pDataReader[20] : "";
                            funcionarioTrabalhista.IdAuxiliarFormaRecebimento = pDataReader[21] != DBNull.Value ? (Int16)pDataReader[21] : short.MinValue;
                            funcionarioTrabalhista.IdAuxiliarTipoSalarioContratual = pDataReader[22] != DBNull.Value ? (Int16)pDataReader[22] : short.MinValue;
                            funcionarioTrabalhista.IsDeficienteFisico = pDataReader[23] != DBNull.Value ? (byte)pDataReader[23] : byte.MinValue;
                            funcionarioTrabalhista.IsDeficienteVisual = pDataReader[24] != DBNull.Value ? (Int16)pDataReader[24] : short.MinValue;
                            funcionarioTrabalhista.IsDeficienteFala = pDataReader[25] != DBNull.Value ? (Int16)pDataReader[25] : short.MinValue;
                            funcionarioTrabalhista.IsDeficienteAuditivo = pDataReader[26] != DBNull.Value ? (Int16)pDataReader[26] : short.MinValue;
                            funcionarioTrabalhista.IsDeficienteMental = pDataReader[27] != DBNull.Value ? (Int16)pDataReader[27] : short.MinValue;
                            funcionarioTrabalhista.IsDeficienteIntelectual = pDataReader[28] != DBNull.Value ? (Int16)pDataReader[28] : short.MinValue;
                            funcionarioTrabalhista.IsReabilitado = pDataReader[29] != DBNull.Value ? (Int16)pDataReader[29] : short.MinValue;
                            funcionarioTrabalhista.Observacao = pDataReader[30] != DBNull.Value ? (Int16)pDataReader[30] : short.MinValue;
                            funcionarioTrabalhista.SucessaoVinculoCNPJ = pDataReader[31] != DBNull.Value ? (Int16)pDataReader[31] : short.MinValue;
                            funcionarioTrabalhista.SucessaoVinculoNumeroMatricula = pDataReader[32] != DBNull.Value ? (Int16)pDataReader[32] : short.MinValue;
                            funcionarioTrabalhista.SucessaoVinculoDataInicio = pDataReader[33] != DBNull.Value ? (Int16)pDataReader[33] : short.MinValue;
                            funcionarioTrabalhista.SucessaoVinculoObservacao = pDataReader[34] != DBNull.Value ? (Int16)pDataReader[34] : short.MinValue;
                            funcionarioTrabalhista.IdAuxiliarTipoRegimeTrabalho = pDataReader[35] != DBNull.Value ? (Int16)pDataReader[35] : short.MinValue;
                            funcionarioTrabalhista.IdAuxiliarTipoJornada = pDataReader[36] != DBNull.Value ? (Int16)pDataReader[36] : short.MinValue;
                            //pular IdAuxiliarRegimeJornada
                            funcionarioTrabalhista.IdCategoriasTrabalhador = pDataReader[38] != DBNull.Value ? (Int16)pDataReader[38] : short.MinValue;
                            funcionarioTrabalhista.IdAuxiliarTipoContrato = pDataReader[39] != DBNull.Value ? (Int16)pDataReader[39] : short.MinValue;
                            funcionarioTrabalhista.DataTermino = pDataReader[40] != DBNull.Value ? (Int16)pDataReader[40] : short.MinValue;
                            funcionarioTrabalhista.QuantidadeMediaHoras = pDataReader[41] != DBNull.Value ? (Int16)pDataReader[41] : short.MinValue;
                            funcionarioTrabalhista.IdAuxiliarMotivoContratacao = pDataReader[42] != DBNull.Value ? (Int16)pDataReader[42] : short.MinValue;
                            funcionarioTrabalhista.TrabalhadorSubstitutoCPF = pDataReader[43] != DBNull.Value ? (Int16)pDataReader[43] : short.MinValue;
                            funcionarioTrabalhista.TrabalhadorSubstitutoMatricula = pDataReader[44] != DBNull.Value ? (Int16)pDataReader[44] : short.MinValue;
                            funcionarioTrabalhista.NumeroProcessoJuridico = pDataReader[45] != DBNull.Value ? (Int16)pDataReader[45] : short.MinValue;
                            funcionarioTrabalhista.CodigoHorarioDescricao = pDataReader[46] != DBNull.Value ? (int)pDataReader[46] : int.MinValue;
                            funcionarioTrabalhista.IsEstagio = pDataReader[47] != DBNull.Value ? (Int16)pDataReader[47] : short.MinValue;
                            funcionarioTrabalhista.IdAuxiliarNivelEstagiario = pDataReader[48] != DBNull.Value ? (Int16)pDataReader[48] : short.MinValue;
                            funcionarioTrabalhista.EstagiarioAreaAtuacao = pDataReader[49] != DBNull.Value ? (Int16)pDataReader[49] : short.MinValue;
                            funcionarioTrabalhista.EstagiarioNumeroApolice = pDataReader[50] != DBNull.Value ? (Int16)pDataReader[50] : short.MinValue;
                            funcionarioTrabalhista.EstagiarioCPFSupervisor = pDataReader[51] != DBNull.Value ? (Int16)pDataReader[51] : short.MinValue;
                            funcionarioTrabalhista.EstagiarioNomeSupervisor = pDataReader[52] != DBNull.Value ? (Int16)pDataReader[52] : short.MinValue;
                            funcionarioTrabalhista.DataAtestadoASO = pDataReader[53] != DBNull.Value ? (Int16)pDataReader[53] : short.MinValue;
                            funcionarioTrabalhista.MedicoASO = pDataReader[54] != DBNull.Value ? (Int16)pDataReader[54] : short.MinValue;
                            funcionarioTrabalhista.DDDASO = pDataReader[55] != DBNull.Value ? (Int16)pDataReader[55] : short.MinValue;
                            funcionarioTrabalhista.TelefoneASO = pDataReader[56] != DBNull.Value ? (Int16)pDataReader[56] : short.MinValue;
                            funcionarioTrabalhista.NumeroCRMASO = pDataReader[57] != DBNull.Value ? (Int16)pDataReader[57] : short.MinValue;
                            funcionarioTrabalhista.IdEstadoEmissorASO = pDataReader[58] != DBNull.Value ? (Int16)pDataReader[58] : short.MinValue;
                            funcionarioTrabalhista.StatusTrabalhista = pDataReader[59] != DBNull.Value ? (Int16)pDataReader[59] : short.MinValue;
                            funcionarioTrabalhista.EstagiarioDataPrevistaTermino = pDataReader[60] != DBNull.Value ? (Int16)pDataReader[60] : short.MinValue;
                            funcionarioTrabalhista.HasSeguroDesemprego = pDataReader[61] != DBNull.Value ? (Int16)pDataReader[61] : short.MinValue;

                            list.Add(funcionarioTrabalhista);
                        }

                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(loop);
                throw ex;
            }
        }

        public List<DependenteFuncionario> GetDependenteFuncionario(Cliente cliente)
        {
            int loop = 0;

            try
            {
                ImportarClienteDominioService service = new ImportarClienteDominioService();

                List<DependenteFuncionario> list = new List<DependenteFuncionario>();

                SAConnection conn = new SAConnection((DbConfig.conexao));

                string sqlDominio = service.ObterSelectDominio(ConfigurationManager.AppSettings["CaminhoSQLDominio"].ToString() + "tbDependente.txt");
                sqlDominio = sqlDominio.Replace("@IdCliente", cliente.Id.ToString());

                SACommand cmd = new SACommand(sqlDominio, conn);

                conn.Open();

                using (IDataReader pDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (pDataReader.Read())
                    {
                        if (pDataReader.FieldCount > 0)
                        {
                            loop++;

                            DependenteFuncionario dependenteFuncionario = new DependenteFuncionario();
                            dependenteFuncionario.IdCliente = pDataReader[0] != DBNull.Value ? (int)pDataReader[0] : int.MinValue;
                            dependenteFuncionario.IdFuncionario = pDataReader[1] != DBNull.Value ? (string)pDataReader[1] : "";
                            dependenteFuncionario.Dependente = pDataReader[2] != DBNull.Value ? (string)pDataReader[2] : "";
                            dependenteFuncionario.CPF = pDataReader[3] != DBNull.Value ? (string)pDataReader[3] : "";
                            dependenteFuncionario.Nascimento = pDataReader[4] != DBNull.Value ? (string)pDataReader[4] : "";
                            dependenteFuncionario.IdCodParent = pDataReader[5] != DBNull.Value ? (int)pDataReader[5] : int.MinValue;
                            dependenteFuncionario.Sexo = pDataReader[6] != DBNull.Value ? (Int16)pDataReader[6] : short.MinValue;
                            dependenteFuncionario.IdCodEstCivil = pDataReader[7] != DBNull.Value ? (Int16)pDataReader[7] : short.MinValue;
                            dependenteFuncionario.LocalNascimento = pDataReader[8] != DBNull.Value ? (string)pDataReader[8] : "";
                            dependenteFuncionario.Registro = pDataReader[9] != DBNull.Value ? (string)pDataReader[9] : "";
                            dependenteFuncionario.Livro = pDataReader[10] != DBNull.Value ? (string)pDataReader[10] : "";
                            dependenteFuncionario.Folha = pDataReader[11] != DBNull.Value ? (string)pDataReader[11] : "";
                            dependenteFuncionario.Cartorio = pDataReader[12] != DBNull.Value ? (string)pDataReader[12] : "";
                            dependenteFuncionario.IRRF = pDataReader[13] != DBNull.Value ? (string)pDataReader[13] : "";
                            dependenteFuncionario.SalarioFamilia = pDataReader[14] != DBNull.Value ? (string)pDataReader[14] : "";
                            dependenteFuncionario.EntregouComprovanteEscolar = pDataReader[15] != DBNull.Value ? (Int16)pDataReader[15] : short.MinValue;
                            dependenteFuncionario.EntregouCartaoVacina = pDataReader[16] != DBNull.Value ? (Int16)pDataReader[16] : short.MinValue;
                            dependenteFuncionario.Universitario_CursandoTecnico = pDataReader[17] != DBNull.Value ? (Int16)pDataReader[17] : short.MinValue;
                            dependenteFuncionario.DataEntregaCertidao = pDataReader[18] != DBNull.Value ? (string)pDataReader[18] : "";
                            dependenteFuncionario.StatusImportacao = pDataReader[19] != DBNull.Value ? (string)pDataReader[19] : "";

                            list.Add(dependenteFuncionario);
                        }

                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(loop);
                throw ex;
            }
        }

        public bool CreateFuncionarioConfirp(Funcionario funcionario)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(DbConfig.conexaoConfirp))
                {
                    string script = $@"IF EXISTS
                                            (SELECT * FROM ClienteOnline..tbFuncionario 
                                             WHERE Chapa = { funcionario.Chapa}
                                             AND IdCliente = {funcionario.IdCliente} )
                                       BEGIN
                                          SELECT 1
                                       END
                                       ELSE
                                       BEGIN
                                          SELECT 0
                                       END";

                    bool funcionarioExiste = db.Query<bool>(script).First();

                    int linhasAfetadas = 0;

                    if (!funcionarioExiste)
                    {
                        string scriptInsert = $@"
                                INSERT INTO ClienteOnline..tbFuncionario VALUES 
                                (
                                    {funcionario.Chapa},
                                    {funcionario.Status},
                                    {short.Parse(funcionario.StatusImportacao.Replace("'","").ToString())},
                                    {int.Parse(funcionario.IdCliente.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.Nome) || funcionario.Nome.Length > 60 ? "''": funcionario.Nome.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.CPF) ? "null" : funcionario.CPF.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.Sexo) ? "''" : funcionario.Sexo.ToString()) },
                                    {(string.IsNullOrEmpty(funcionario.DataNascimento)  ? "null" : (funcionario.DataNascimento.Length > 8 ? "null": funcionario.DataNascimento.ToString()))},
                                    {(string.IsNullOrEmpty(funcionario.DDDTelefone) ? "''" : funcionario.DDDTelefone.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.Telefone) ? "''" : funcionario.Telefone.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.DDDCelular) ? "''" : funcionario.DDDCelular.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.Celular) ? "''" : funcionario.Celular.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.EmailPrincipal) ? "''" : funcionario.EmailPrincipal.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.EmailAlternativo) ? "''" : funcionario.EmailAlternativo.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.IdAuxiliarEstadoCivil) ? "null" : funcionario.IdAuxiliarEstadoCivil.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.IdAuxiliarCorRaca) ? "null" : funcionario.IdAuxiliarCorRaca.ToString())},
                                    {(funcionario.IdAuxiliarGrauInstrucao == short.MinValue ? "null" : funcionario.IdAuxiliarGrauInstrucao.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.NomeSocial) ? "''" : funcionario.NomeSocial.ToString())},
                                    {(funcionario.IdPaisNascimento == short.MinValue ? "null" : funcionario.IdPaisNascimento.ToString())},
                                    {(funcionario.IdNacionalidade == short.MinValue ? "null" : funcionario.IdNacionalidade.ToString())},
                                    {(funcionario.IdEstadoNatal == short.MinValue ? "null" : funcionario.IdEstadoNatal.ToString())},
                                    {(funcionario.IdNaturalidade == short.MinValue ? "null" : funcionario.IdNaturalidade.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.PaiNome) ? "''" : funcionario.PaiNome.ToString())},
                                    {(funcionario.PaiCPF == short.MinValue ? "null" : funcionario.PaiCPF.ToString())},
                                    {(funcionario.PaiDataNascimento  == short.MinValue ? "null" : funcionario.PaiDataNascimento.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.MaeNome) ? "''" : funcionario.MaeNome.ToString())},
                                    {(funcionario.MaeCPF == short.MinValue ? "null" : funcionario.MaeCPF.ToString())},
                                    {(funcionario.MaeDataNascimento == short.MinValue ? "null" : funcionario.MaeDataNascimento.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.ResidenciaCEP.Trim()) ? "''" : funcionario.ResidenciaCEP.ToString())},
                                    {(funcionario.ResidenciaIdLogradouro == short.MinValue ? "null" : funcionario.ResidenciaIdLogradouro.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.ResidenciaEndereco) || funcionario.ResidenciaEndereco.Length > 80 ? "''" : funcionario.ResidenciaEndereco.ToString())},
                                    {(funcionario.ResidenciaNumero == int.MinValue ? "null" : funcionario.ResidenciaNumero.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.ResidenciaComplemento) ? "''" : funcionario.ResidenciaComplemento.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.ResidenciaBairro) ? "''" : funcionario.ResidenciaBairro.ToString())},
                                    {(funcionario.ResidenciaIdEstado == short.MinValue ? "null" : funcionario.ResidenciaIdEstado.ToString())},
                                    {(funcionario.ResidenciaIdCidade == short.MinValue ? "null" : funcionario.ResidenciaIdCidade.ToString())},
                                    {(funcionario.ResidenciaIdPais == short.MinValue ? "null" : funcionario.ResidenciaIdPais.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.RGNumero) ? "''" : funcionario.RGNumero.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.RGDataEmissao) ? "null" : funcionario.RGDataEmissao.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.RGOrgaoEmissor) ? "''" : funcionario.RGOrgaoEmissor.ToString())},
                                    {(funcionario.RGIdEstadoEmissor == short.MinValue ? "null" : funcionario.RGIdEstadoEmissor.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.EleitorNumero) ? "''" : funcionario.EleitorNumero.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.EleitorZona) ? "''" : funcionario.EleitorZona.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.EleitorSecao) ? "''" : funcionario.EleitorSecao.ToString())},
                                    {(funcionario.Reservista == short.MinValue ? "''" : funcionario.Reservista.ToString())},
                                    {(funcionario.ReservistaCategoria == short.MinValue ? "''" : funcionario.ReservistaCategoria.ToString())},
                                    '{(string.IsNullOrEmpty(funcionario.CTPSNumero) ? "" : funcionario.CTPSNumero.ToString())}',
                                    '{(string.IsNullOrEmpty(funcionario.CTPSSerie) ? "" : funcionario.CTPSSerie.ToString())}',
                                    {(funcionario.CTPSDataEmissao == short.MinValue ? "''" : funcionario.CTPSDataEmissao.ToString())},
                                    {(funcionario.CTPSIdEstadoEmissor == short.MinValue ? "null" : funcionario.CTPSIdEstadoEmissor.ToString())},
                                    {(funcionario.NISIsReemprego == 1 ? 1 : 0)},
                                    {(string.IsNullOrEmpty(funcionario.NISNumero) ? "null" : funcionario.NISNumero.ToString())},
                                    {(string.IsNullOrEmpty( funcionario.NISDataCadastro) ? "null" : funcionario.NISDataCadastro.ToString())},
                                    {(funcionario.NISIdBanco == short.MinValue ? "null" : funcionario.NISIdBanco.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.RICNumero) ? "null" : funcionario.RICNumero.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.RICDataEmissao) ? "null" : funcionario.RICDataEmissao.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.RICOrgaoEmissor) ? "''" : funcionario.RICOrgaoEmissor.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.CNHNumero) ? "null" : funcionario.CNHNumero.ToString())},
                                    {(funcionario.CNHIdAuxiliarTipo == short.MinValue ? "null" : funcionario.CNHIdAuxiliarTipo.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.CNHDataVencimento) ? "null" : funcionario.CNHDataVencimento.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.CNHDataEmissao) ? "null" : funcionario.CNHDataEmissao.ToString())},
                                    '{(string.IsNullOrEmpty(funcionario.CNHOrgaoEmissor) ? "" : funcionario.CNHOrgaoEmissor.ToString())}',
                                    {(string.IsNullOrEmpty(funcionario.CNHIdEstadoEmissor) ? "null" : funcionario.CNHIdEstadoEmissor.ToString() )},
                                    {(string.IsNullOrEmpty(funcionario.CNHDataPrimeiraHabilitacao) ? "null" : funcionario.CNHDataPrimeiraHabilitacao.ToString())},
                                    {(funcionario.HasAposentadoria == 1 ? 1 : 0)}, 
                                    {(string.IsNullOrEmpty(funcionario.PassaporteNumero) ? "''" : funcionario.PassaporteNumero.ToString())},
                                    '{(string.IsNullOrEmpty(funcionario.PassaporteDataEmissao) ? null : funcionario.PassaporteDataEmissao.ToString())}',
                                    '{(string.IsNullOrEmpty(funcionario.PassaporteDataValidade) ? null : funcionario.PassaporteDataValidade.ToString()) }',
                                    {(funcionario.PassaporteIdPaisOrigem == short.MinValue ? "null" : funcionario.PassaporteIdPaisOrigem.ToString())},
                                    {(funcionario.OCNumero == short.MinValue ? "null" : funcionario.OCNumero.ToString())},
                                    {(funcionario.OCDataEmissao == short.MinValue ? "null" : funcionario.OCDataEmissao.ToString())},
                                    {(funcionario.OCDataValidade == short.MinValue ? "null" : funcionario.OCDataValidade.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.OCOrgaoEmissor) ? "''" : funcionario.OCOrgaoEmissor)},
                                    {(string.IsNullOrEmpty(funcionario.RNENumero) ? "''" : funcionario.RNENumero.ToString())},
                                    {(funcionario.RNEDataEmissao == DateTime.MinValue ? "null" : funcionario.RNEDataEmissao.ToString("yyyy/MM/dd"))},
                                    '{(string.IsNullOrEmpty(funcionario.RNEOrgaoEmissor) ? "" : funcionario.RNEOrgaoEmissor.ToString())}',
                                    {(funcionario.EstrangeiroDataChegada == DateTime.MinValue ? "null" : funcionario.EstrangeiroDataChegada.ToString("yyyy/MM/dd"))},
                                    {(funcionario.EstrangeiroDataNaturalizacao == DateTime.MinValue ? "null" : funcionario.EstrangeiroDataNaturalizacao.ToString("yyyy/MM/dd"))},
                                    {(funcionario.EstrangeiroIsCasadoBrasileiro == 1 ? 1 : 0)},
                                    {(funcionario.EstrangeiroHasFilhos == 1 ? 1 : 0)},
                                    {(funcionario.EstrangeiroIdPaisResidencia == short.MinValue ? "null" : funcionario.EstrangeiroIdPaisResidencia.ToString())},
                                    {(funcionario.EstrangeiroEndereco == short.MinValue ? "''" : funcionario.EstrangeiroEndereco.ToString())},
                                    {(funcionario.EstrangeiroNumero == short.MinValue ? "null" : funcionario.EstrangeiroNumero.ToString())},
                                    {(funcionario.EstrangeiroComplemento == short.MinValue ? "''" : funcionario.EstrangeiroComplemento.ToString())},
                                    {(funcionario.EstrangeiroBairro == short.MinValue ? "''" : funcionario.EstrangeiroBairro.ToString())},
                                    {(funcionario.EstrangeiroCidade == short.MinValue ? "''" : funcionario.EstrangeiroCidade.ToString())},
                                    {(funcionario.EstrangeiroCodPostal == short.MinValue ? "''" : funcionario.EstrangeiroCodPostal.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.EstrangeiroCondicaoIngresso) ? "null" : funcionario.EstrangeiroCondicaoIngresso.ToString())},
                                    {(string.IsNullOrEmpty(funcionario.IdArquivoFotografia) ? "null" : funcionario.IdArquivoFotografia.ToString())},
                                    {1},
                                    GETDATE(),
                                    '',
                                    null
                                )";

                        linhasAfetadas = db.Execute(scriptInsert);

                    }

                    if (linhasAfetadas == 1)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CreateFuncionarioTrabalhistaConfirp(FuncionarioTrabalhista funcionarioTrabalhista)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(DbConfig.conexaoConfirp))
                {

                    string script = $@"IF EXISTS
                                            (SELECT * FROM ClienteOnline..tbFuncionarioTrabalhista 
                                             WHERE IdFuncionario = {funcionarioTrabalhista.IdFuncionario})
                                       BEGIN
                                          SELECT 1
                                       END
                                       ELSE
                                       BEGIN
                                          SELECT 0
                                       END";

                    bool funcionarioTrabalhistaExiste = db.Query<bool>(script).First();

                    int linhasAfetadas = 0;

                    if (!funcionarioTrabalhistaExiste)
                    {
                        string scriptInsert = $@"
                               INSERT INTO ClienteOnline..tbFuncionarioTrabalhista VALUES 
                                (
                                    {funcionarioTrabalhista.IdFuncionario},
                                    {funcionarioTrabalhista.DataAdmissao},
                                    {(funcionarioTrabalhista.PrimeiroPeriodoExperiencia <= 0 ? "null": funcionarioTrabalhista.PrimeiroPeriodoExperiencia.ToString())},
                                    {(funcionarioTrabalhista.SegundoPeriodoExperiencia <= 0 ? "null" : funcionarioTrabalhista.SegundoPeriodoExperiencia.ToString())},
                                    {(funcionarioTrabalhista.IdCargoCliente == int.MinValue ? "null" : funcionarioTrabalhista.IdCargoCliente.ToString())},
                                    {(funcionarioTrabalhista.IdCargoNovoDominio == short.MinValue ? "null" : funcionarioTrabalhista.IdCargoNovoDominio.ToString())},
                                    {(funcionarioTrabalhista.IdFuncao == short.MinValue ? "null" : funcionarioTrabalhista.IdFuncao.ToString())},
                                    {(funcionarioTrabalhista.IdSecao == int.MinValue ? "null" : funcionarioTrabalhista.IdSecao.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarTipoAdmissao == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarTipoAdmissao.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarTipoIndicativoAdmissao == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarTipoIndicativoAdmissao.ToString())},
                                    {(funcionarioTrabalhista.HasAdiantamento == short.MinValue ? 0 : 1)},
                                    {(funcionarioTrabalhista.HasValeTransporte == short.MinValue ? 0 : 1)},
                                    {(string.IsNullOrEmpty(funcionarioTrabalhista.IdBanco) ? "null" : funcionarioTrabalhista.IdBanco)},
                                    {(string.IsNullOrEmpty(funcionarioTrabalhista.Agencia) ? "null" : funcionarioTrabalhista.Agencia)},
                                    {(string.IsNullOrEmpty(funcionarioTrabalhista.ContaCorrente) ? "null" : funcionarioTrabalhista.ContaCorrente)},
                                    {(string.IsNullOrEmpty(funcionarioTrabalhista.ContaCorrenteDigito) ? "null" : funcionarioTrabalhista.ContaCorrenteDigito)},
                                    {(funcionarioTrabalhista.IdAuxiliarContribuicaoSindical == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarContribuicaoSindical.ToString())},
                                    {(funcionarioTrabalhista.FiliacaoSindicalValor == short.MinValue ? "null" : funcionarioTrabalhista.FiliacaoSindicalValor.ToString())},
                                    {(funcionarioTrabalhista.FiliacaoSindicalCNPJ == int.MinValue ? "null" : funcionarioTrabalhista.FiliacaoSindicalCNPJ.ToString())},
                                    {(funcionarioTrabalhista.FiliacaoSindicalDataBase == DateTime.MinValue ? "null" : funcionarioTrabalhista.FiliacaoSindicalDataBase.ToString())},
                                    {(funcionarioTrabalhista.IsOptante == short.MinValue ? 0 : 1)},
                                    {(funcionarioTrabalhista.DataOpcao == short.MinValue ? "null" : funcionarioTrabalhista.DataOpcao.ToString())},
                                    {(string.IsNullOrEmpty(funcionarioTrabalhista.Salario) ? "null" : funcionarioTrabalhista.Salario)},
                                    {(funcionarioTrabalhista.IdAuxiliarFormaRecebimento == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarFormaRecebimento.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarTipoSalarioContratual == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarTipoSalarioContratual.ToString())},
                                    {(funcionarioTrabalhista.IsDeficienteFisico == byte.MinValue ? 0 : 1)},
                                    {(funcionarioTrabalhista.IsDeficienteVisual == short.MinValue ? 0 : 1)},
                                    {(funcionarioTrabalhista.IsDeficienteFala == short.MinValue ? 0 : 1)},
                                    {(funcionarioTrabalhista.IsDeficienteAuditivo == short.MinValue ? 0 :1)},
                                    {(funcionarioTrabalhista.IsDeficienteMental == short.MinValue ? 0 : 1)},
                                    {(funcionarioTrabalhista.IsDeficienteIntelectual == short.MinValue ? 0 : 1)},
                                    {(funcionarioTrabalhista.IsReabilitado == short.MinValue ? 0 : 1)},
                                    {(funcionarioTrabalhista.IsCotaDeficiente == true ? 1 : 0)},
                                    {(funcionarioTrabalhista.Observacao == short.MinValue ? "null" : funcionarioTrabalhista.Observacao.ToString())},
                                    {(funcionarioTrabalhista.SucessaoVinculoCNPJ == short.MinValue ? "null" : funcionarioTrabalhista.SucessaoVinculoCNPJ.ToString())},
                                    {(funcionarioTrabalhista.SucessaoVinculoNumeroMatricula == short.MinValue ? "null" : funcionarioTrabalhista.SucessaoVinculoNumeroMatricula.ToString())},
                                    {(funcionarioTrabalhista.SucessaoVinculoDataInicio == short.MinValue ? "null" : funcionarioTrabalhista.SucessaoVinculoDataInicio.ToString())},
                                    {(funcionarioTrabalhista.SucessaoVinculoObservacao == short.MinValue ? "null" : funcionarioTrabalhista.SucessaoVinculoObservacao.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarTipoRegimeTrabalho ==  short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarTipoRegimeTrabalho.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarRegimeJornada <= 0  ? "null" : funcionarioTrabalhista.IdAuxiliarRegimeJornada.ToString())},
                                    {(funcionarioTrabalhista.IdCategoriasTrabalhador == short.MinValue ? "null" : funcionarioTrabalhista.IdCategoriasTrabalhador.ToString())},
                                    {(funcionarioTrabalhista.NaturezaAtividade == short.MinValue ? "null" : funcionarioTrabalhista.NaturezaAtividade.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarTipoContrato == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarTipoContrato.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarTipoContratoTempoParcial == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarTipoContratoTempoParcial.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarTipoJornada ==  short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarTipoJornada.ToString())},
                                    {(string.IsNullOrEmpty(funcionarioTrabalhista.ObservacaoTipoJornada) ? "null" : funcionarioTrabalhista.ObservacaoTipoJornada)},
                                    {(funcionarioTrabalhista.DataTermino == short.MinValue ? "null" : funcionarioTrabalhista.DataTermino.ToString())},
                                    {(funcionarioTrabalhista.QuantidadeMediaHoras == decimal.MinValue ? "null" : funcionarioTrabalhista.QuantidadeMediaHoras.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarMotivoContratacao == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarMotivoContratacao.ToString())},
                                    {(funcionarioTrabalhista.TrabalhadorSubstitutoCPF == short.MinValue ? "null" : funcionarioTrabalhista.TrabalhadorSubstitutoCPF.ToString())},
                                    {(funcionarioTrabalhista.TrabalhadorSubstitutoMatricula == short.MinValue ? "null" : funcionarioTrabalhista.TrabalhadorSubstitutoMatricula.ToString())},
                                    {(funcionarioTrabalhista.NumeroProcessoJuridico == short.MinValue ? "null" : funcionarioTrabalhista.NumeroProcessoJuridico.ToString())},
                                    {(funcionarioTrabalhista.CodigoHorarioDescricao == int.MinValue ? "null" : funcionarioTrabalhista.CodigoHorarioDescricao.ToString())},
                                    {(funcionarioTrabalhista.IdNovoHorarioDominio == short.MinValue ? "null" : funcionarioTrabalhista.IdNovoHorarioDominio.ToString())},
                                    {(funcionarioTrabalhista.IsEstagio == short.MinValue ? "null" : funcionarioTrabalhista.IsEstagio.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarNivelEstagiario == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarNivelEstagiario.ToString())},
                                    {(funcionarioTrabalhista.EstagiarioAreaAtuacao == short.MinValue ? "null" : funcionarioTrabalhista.EstagiarioAreaAtuacao.ToString())},
                                    {(funcionarioTrabalhista.EstagiarioNumeroApolice == short.MinValue ? "null" : funcionarioTrabalhista.EstagiarioNumeroApolice.ToString())},
                                    {(funcionarioTrabalhista.EstagiarioCPFSupervisor == short.MinValue ? "null" : funcionarioTrabalhista.EstagiarioCPFSupervisor.ToString())},
                                    {(funcionarioTrabalhista.EstagiarioNomeSupervisor == short.MinValue ? "null" : funcionarioTrabalhista.EstagiarioNomeSupervisor.ToString())},
                                    {(funcionarioTrabalhista.DataAtestadoASO == short.MinValue ? "null" : funcionarioTrabalhista.DataAtestadoASO.ToString())},
                                    {(funcionarioTrabalhista.MedicoASO == short.MinValue ? "null" : funcionarioTrabalhista.MedicoASO.ToString())},
                                    {(funcionarioTrabalhista.DDDASO == short.MinValue ? "null" : funcionarioTrabalhista.DDDASO.ToString())},
                                    {(funcionarioTrabalhista.TelefoneASO == short.MinValue ? "null" : funcionarioTrabalhista.TelefoneASO.ToString())},
                                    {(funcionarioTrabalhista.NumeroCRMASO == short.MinValue ? "null" : funcionarioTrabalhista.NumeroCRMASO.ToString())},
                                    {(funcionarioTrabalhista.IdEstadoEmissorASO == short.MinValue ? "null" : funcionarioTrabalhista.IdEstadoEmissorASO.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarHipoteseLegalContratacaoTrabalhadorTemporario == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarHipoteseLegalContratacaoTrabalhadorTemporario.ToString())},
                                    {(string.IsNullOrEmpty(funcionarioTrabalhista.JustificativaLegalContratacaoTrabalhadorTemporario) ? "null" : funcionarioTrabalhista.JustificativaLegalContratacaoTrabalhadorTemporario)},
                                    {(funcionarioTrabalhista.IdAuxiliarTipoInclusaoContratoTrabalhadorTemporario == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarTipoInclusaoContratoTrabalhadorTemporario.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarTipoInscricaoEmpresaContratanteTrabalhadorTemporario == short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarTipoInscricaoEmpresaContratanteTrabalhadorTemporario.ToString())},
                                    {(string.IsNullOrEmpty(funcionarioTrabalhista.EmpresaContratanteNumeroInscricaoTrabalhadorTemporario) ? "null" : funcionarioTrabalhista.EmpresaContratanteNumeroInscricaoTrabalhadorTemporario.ToString())},
                                    {(funcionarioTrabalhista.IdAuxiliarTipoInscricaoEstabalecimentoVinculadoTrabalhadorTemporario ==  short.MinValue ? "null" : funcionarioTrabalhista.IdAuxiliarTipoInscricaoEstabalecimentoVinculadoTrabalhadorTemporario.ToString())},
                                    {(string.IsNullOrEmpty(funcionarioTrabalhista.EstabalecimentoVinculadoToNumeroInscricaoTrabalhadorTemporario) ? "null" : funcionarioTrabalhista.EstabalecimentoVinculadoToNumeroInscricaoTrabalhadorTemporario.ToString())},
                                    {(string.IsNullOrEmpty(funcionarioTrabalhista.ObservacaoProrrogacaoContratoTrabalhoTemporario) ? "null" : funcionarioTrabalhista.ObservacaoProrrogacaoContratoTrabalhoTemporario.ToString())},
                                    {(funcionarioTrabalhista.StatusTrabalhista == short.MinValue ? "null" : funcionarioTrabalhista.StatusTrabalhista.ToString())},
                                    {(funcionarioTrabalhista.EstagiarioDataPrevistaTermino == short.MinValue ? "null" : funcionarioTrabalhista.EstagiarioDataPrevistaTermino.ToString())},
                                    {(funcionarioTrabalhista.HasSeguroDesemprego == short.MinValue ? "null" : funcionarioTrabalhista.HasSeguroDesemprego.ToString())},
                                    {1},
                                    GETDATE(),
                                    null,
                                    null,
                                    {(funcionarioTrabalhista.HasEmailAdmissaoEmpregadoCadastroUmDiaAntesAdmissao == true ? 1 : 0)},
                                    {(funcionarioTrabalhista.HasEnviarEmailAdmissaoEmpregadoModalCadastroDepoisAdmissao == true? 1 : 0)},
                                    {(funcionarioTrabalhista.HasLetsWork == true ? 1 : 0)},
                                    {(funcionarioTrabalhista.IdCentroCusto == short.MinValue ? "null" : funcionarioTrabalhista.IdCentroCusto.ToString())},
                                    {(funcionarioTrabalhista.HasCargoConfianca == true ? 1 : 0)}
                                )";

                        linhasAfetadas = db.Execute(scriptInsert);
                    }


                    if (linhasAfetadas == 1)
                        return true;
                    else
                        return false;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CreateDependenteFuncionarioConfirp(DependenteFuncionario dependenteFuncionario)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(DbConfig.conexaoConfirp))
                {
                    string script = $@"IF EXISTS
                                            (SELECT * FROM ClienteOnline..tbDependente
                                             WHERE IdFuncionario = {dependenteFuncionario.IdFuncionario}
                                             AND CPF = {(string.IsNullOrEmpty(dependenteFuncionario.CPF.Trim()) ? "0" : dependenteFuncionario.CPF)}
                                            )
                                       BEGIN
                                          SELECT 1
                                       END
                                       ELSE
                                       BEGIN
                                          SELECT 0
                                       END";

                    bool dependenteFuncionarioExiste = db.Query<bool>(script).FirstOrDefault();

                    int linhasAfetadas = 0;

                    if (!dependenteFuncionarioExiste)
                    {
                        string scriptInsert = $@"
                                        INSERT INTO ClienteOnline..tbDependente VALUES 
                                        (
                                            {dependenteFuncionario.IdCliente},
                                            {dependenteFuncionario.IdFuncionario},
                                            {dependenteFuncionario.Dependente},
                                            {dependenteFuncionario.CPF},
                                            {dependenteFuncionario.Nascimento},
                                            {(dependenteFuncionario.IdCodParent <= 0 ? "null" : dependenteFuncionario.IdCodParent.ToString())},
                                            {(dependenteFuncionario.Sexo <= 0 ? "null" : dependenteFuncionario.Sexo.ToString())},
                                            {(dependenteFuncionario.IdCodEstCivil <= 0 ? "null" : dependenteFuncionario.IdCodEstCivil.ToString())},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.LocalNascimento) ? "null" : dependenteFuncionario.LocalNascimento)},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.Registro) ? "null" : dependenteFuncionario.Registro)},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.Livro) ? "null" : dependenteFuncionario.Livro)},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.Folha) ? "null" : dependenteFuncionario.Folha)},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.Cartorio) ? "null" : dependenteFuncionario.Cartorio)},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.IRRF) ? "null" : dependenteFuncionario.IRRF)},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.SalarioFamilia) ? "null" : dependenteFuncionario.SalarioFamilia)},
                                            {(dependenteFuncionario.EntregouComprovanteEscolar <= 0 ? "null" : dependenteFuncionario.EntregouComprovanteEscolar.ToString())},
                                            {(dependenteFuncionario.EntregouCartaoVacina <= 0 ? "null" : dependenteFuncionario.EntregouCartaoVacina.ToString())},
                                            {(dependenteFuncionario.Universitario_CursandoTecnico <= 0 ? "null" : dependenteFuncionario.Universitario_CursandoTecnico.ToString())},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.DataEntregaCertidao) ? "null" : dependenteFuncionario.DataEntregaCertidao)},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.IncapacidadeFisicaMentalTrabalho) ? "null" : dependenteFuncionario.IncapacidadeFisicaMentalTrabalho)},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.StatusImportacao) ? "null" : dependenteFuncionario.StatusImportacao)},
                                            {1},
                                            GETDATE(),
                                            null,
                                            null,
                                            {(string.IsNullOrEmpty(dependenteFuncionario.ConvenioMedico) ? "null" : dependenteFuncionario.ConvenioMedico)},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.ConvenioOdontologico) ? "null" : dependenteFuncionario.ConvenioOdontologico)},
                                            {(string.IsNullOrEmpty(dependenteFuncionario.is_concluido) ? "null" : dependenteFuncionario.is_concluido)}
                                        )";

                        linhasAfetadas = db.Execute(scriptInsert);
                    }

                    if (linhasAfetadas == 1)
                        return true;
                    else
                        return false;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}