using iAnywhere.Data.SQLAnywhere;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using WebDominioAPI.Core;

namespace WebDominioAPI.Features.DemonstrativoPagamento
{
    public class DemonstrativoPagamentoDAO
    {
        public List<DemonstrativoPagamentoGrid> GetDemonstrativoPagamento(DemonstrativoPagamentoFilter pFilter)
        {
            try
            {
                List<DemonstrativoPagamentoGrid> list = new List<DemonstrativoPagamentoGrid>();

                SAConnection conn = new SAConnection((DbConfig.conexao));

                string sqlDominio = ObterSelectDominio(ConfigurationManager.AppSettings["CaminhoSQLDominio"].ToString() + "spSel_DemonstrativoPagamentoEventos.txt");

                sqlDominio = sqlDominio.Replace("@IdCliente", "1278");
                sqlDominio = sqlDominio.Replace("@Chapa", "50079");
                sqlDominio = sqlDominio.Replace("@Mes", "1");
                sqlDominio = sqlDominio.Replace("@Ano", "2024");
                sqlDominio = sqlDominio.Replace("@NroPeriodo", "11");

                SACommand cmd = new SACommand(sqlDominio, conn);

                conn.Open();

                using (IDataReader pDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (pDataReader.Read())
                    {
                        list.Add(PreencherEntidade(pDataReader));
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DemonstrativoPagamentoGrid PreencherEntidade(IDataReader pDataReader)
        {
            DemonstrativoPagamentoGrid demonstrativoPagamentoGrid = new DemonstrativoPagamentoGrid();

            demonstrativoPagamentoGrid.Codigo = PreencherAtributo(pDataReader,0, demonstrativoPagamentoGrid.Codigo);

            return demonstrativoPagamentoGrid;
        }

        public static string PreencherAtributo(IDataReader pDataReader, int pNumeroColuna, string pAtributo)
        {
            if (pDataReader.IsDBNull(pNumeroColuna))
            {
                return string.Empty;
            }

            return pDataReader.GetString(pNumeroColuna);
        }

        public static string ObterSelectDominio(string pCaminhoArquivoModelo)
        {
            string empty = string.Empty;
            StreamReader streamReader = new StreamReader(pCaminhoArquivoModelo.ToString());
            empty = streamReader.ReadToEnd();
            streamReader.Close();
            return empty;
        }
    }
}