using System;
using System.Collections.Generic;
using System.IO;

namespace WebDominioAPI.Features.ImportarClienteDominio
{
    public class ImportarClienteDominioService
    {
        ImportarClienteDominioDAO importarClienteDominioDAO = new ImportarClienteDominioDAO();
        public ImportDto ImportarCliente(Cliente cliente)
        {
            try
            {

                ImportDto importDto = new ImportDto();

                importDto.FuncionarioDto = ImportarFuncionario(cliente);

                importDto.FuncionarioTrabalhistaDto = ImportarFuncionarioTrabalhista(cliente);

                importDto.DependenteFuncionarioDto = ImportarDependenteFuncionario(cliente);
             
                return importDto;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public List<FuncionarioDto> ImportarFuncionario(Cliente cliente)
        {
            try
            {
                List<FuncionarioDto> funcionarioListDto = new List<FuncionarioDto>();

                List<Funcionario> funcionarioList = importarClienteDominioDAO.GetFuncionario(cliente);

                if (funcionarioList.Count > 0)
                {
                    foreach (Funcionario funcionario in funcionarioList)
                    {
                        if (importarClienteDominioDAO.CreateFuncionarioConfirp(funcionario))
                        {
                            funcionarioListDto.Add(new FuncionarioDto(funcionario));
                        }   
                    }
                }

                return funcionarioListDto;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public List<FuncionarioTrabalhistaDto> ImportarFuncionarioTrabalhista(Cliente cliente)
        {
            try
            {
                List<FuncionarioTrabalhistaDto> funcionarioTrabalhistaListDto = new List<FuncionarioTrabalhistaDto>();

                List<FuncionarioTrabalhista> funcionarioTrabalhistaList = importarClienteDominioDAO.GetFuncionarioTrabalhista(cliente);

                if (funcionarioTrabalhistaList.Count > 0)
                {
                    foreach (FuncionarioTrabalhista funcionarioTrabalhista in funcionarioTrabalhistaList)
                    {
                        if (importarClienteDominioDAO.CreateFuncionarioTrabalhistaConfirp(funcionarioTrabalhista))
                        {
                            funcionarioTrabalhistaListDto.Add(new FuncionarioTrabalhistaDto(funcionarioTrabalhista));
                        }

                    }
                }

                return funcionarioTrabalhistaListDto;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<DependenteFuncionarioDto> ImportarDependenteFuncionario(Cliente cliente)
        {
            try
            {
                List<DependenteFuncionarioDto> dependenteFuncionarioListDto = new List<DependenteFuncionarioDto>();

                List<DependenteFuncionario> dependenteFuncionarioList = importarClienteDominioDAO.GetDependenteFuncionario(cliente);

                if (dependenteFuncionarioList.Count > 0)
                {
                    foreach (DependenteFuncionario dependenteFuncionario in dependenteFuncionarioList)
                    {
                        if (importarClienteDominioDAO.CreateDependenteFuncionarioConfirp(dependenteFuncionario))
                        {
                            dependenteFuncionarioListDto.Add(new DependenteFuncionarioDto(dependenteFuncionario));
                        }
                        
                    }
                }

                return dependenteFuncionarioListDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ObterSelectDominio(string pCaminhoArquivoModelo)
        {
            try
            {
                string empty = string.Empty;
                StreamReader streamReader = new StreamReader(pCaminhoArquivoModelo.ToString());
                empty = streamReader.ReadToEnd();
                streamReader.Close();
                return empty;
            }
            catch(Exception ex) 
            { 
                throw ex; 
            }

        }
    }
}