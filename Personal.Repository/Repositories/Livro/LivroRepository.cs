using Dapper;
using Personal.Domain.Interfaces.Repositories.Personal;
using Personal.Domain.ViewModel.Persona.Livro;
using System;
using System.Collections.Generic;
using System.Data;

namespace Personal.Repository.Repositories.Livro
{
    public class LivroRepository : RepositoryBase, ILivroRepository
    {
                    
        public LivroRepository(IDbConnection connectionPersonal) : base(connectionPersonal)
        {
        }

        public int Add(Domain.Entities.Personal.Livro livro)
        {
            try
            {
                if (livro == null)
                    throw new ArgumentException("Livro invalido");

                OpenConnection();

                var parameter = new DynamicParameters();

                parameter.Add("Titulo", livro.Titulo, DbType.String);
                parameter.Add("Editora", livro.Editora, DbType.String);
                parameter.Add("Escritor", livro.Escritor, DbType.String);
                parameter.Add("CreatedBy", livro.CreatedBy, DbType.Int64);
                parameter.Add("CreatedDate", livro.CreatedDate, DbType.DateTime);
                parameter.Add("LastUpdatedBy", livro.LastUpdatedBy, DbType.Int64);
                parameter.Add("LastUpdatedDate", livro.LastUpdatedDate, DbType.DateTime);

                var livroId = _connectionPersonal.ExecuteScalar<int>(
                    sql: "Livro_Add",
                    param: parameter,
                    commandType: CommandType.StoredProcedure);

                return livroId;
               
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Domain.Entities.Personal.Livro livro)
        {
            try
            {
                if (livro == null)
                    throw new ArgumentException("Livro invalido");

                OpenConnection();

                var parameter = new DynamicParameters();
                parameter.Add("LivroId", livro.LivrosId, DbType.Int64);
                parameter.Add("Titulo", livro.Titulo, DbType.String);
                parameter.Add("Editora", livro.Editora, DbType.String);
                parameter.Add("Escritor", livro.Escritor, DbType.String);
                parameter.Add("LastUpdatedBy", livro.LastUpdatedBy, DbType.Int64);
                parameter.Add("LastUpdatedDate", livro.LastUpdatedDate, DbType.DateTime);

                _connectionPersonal.Execute(
                    sql: "Livro_Update",
                    param: parameter,
                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public IEnumerable<LivroToQueryVM> GetAll()
        {
            try
            {
                OpenConnection();

                var livros = _connectionPersonal.Query<LivroToQueryVM>(
                    sql: "Livro_GetAll",
                    commandType: CommandType.StoredProcedure);

                return livros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public LivroToQueryVM GetById(int livroId)
        {
            try
            {
                if (livroId == 0)
                    throw new ArgumentException("LivroId invalido");

                OpenConnection();

                var parameter = new DynamicParameters();
                parameter.Add("LivroId", livroId, DbType.Int64);

                var livro = _connectionPersonal.QueryFirstOrDefault<LivroToQueryVM>(
                    sql: "Livro_GetById",
                    param: parameter,
                    commandType: CommandType.StoredProcedure);

                return livro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Delete(int livroId)
        {
            try
            {
                if (livroId == 0)
                    throw new ArgumentException("LivroId invalido");

                OpenConnection();

                var parameter = new DynamicParameters();
                parameter.Add("LivroId", livroId, DbType.Int64);

                _connectionPersonal.Execute(
                    sql: "Livro_Delete",
                    param: parameter,
                    commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
