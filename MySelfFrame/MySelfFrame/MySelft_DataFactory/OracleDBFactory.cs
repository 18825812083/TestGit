/********************************************************************************
** FileName   :OracleDBFactory
** Description:无
** Author     :WK 
** Date       :2017/2/7 14:35:25
** Year       :2017
** Company    :成都新得利
** Version    :V1.0.0
*********************************************************************************/


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySelft_DataFactory
{
    class OracleDBFactory : IDatabaseFactory

    {
        public string conStr
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IDbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public IDbConnection CreateConnection()
        {
            throw new NotImplementedException();
        }

        public IDbConnection CreateConnectionByStr(string connectionStr)
        {
            throw new NotImplementedException();
        }

        public IDbDataAdapter CreateDataAdapter()
        {
            throw new NotImplementedException();
        }

        public IDataReader CreateDataReader(IDbCommand myComm)
        {
            throw new NotImplementedException();
        }

        public IDbTransaction CreateTransaction(IDbConnection myConn)
        {
            throw new NotImplementedException();
        }

        public string Print()
        {
            return "oracle database";
        }
    }
}
