using System;
using System.Data;

namespace Personal.Repository
{
    public class RepositoryBase : IDisposable
    {
        public readonly IDbConnection _connectionPersonal;

        public RepositoryBase(IDbConnection connectionPersonal)
        {
            if(_connectionPersonal == null)
                _connectionPersonal = connectionPersonal;
        }

        public void OpenConnection()
        {
            if (_connectionPersonal.State == ConnectionState.Closed)
                _connectionPersonal.Open();
        }

        public void CloseConnection()
        {
            if (_connectionPersonal.State == ConnectionState.Open)
                _connectionPersonal.Close();
        }

        public void Dispose()
        {
            CloseConnection();
        }
    }
}
