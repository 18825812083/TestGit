/********************************************************************************
** FileName   :DatabaseFactory
** Description:无
** Author     :WK 
** Date       :2017/2/7 14:40:28
** Year       :2017
** Company    :成都新得利
** Version    :V1.0.0
*********************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySelft_DataFactory
{
    public static class DatabaseFactory
    {

        public static IDatabaseFactory CreateDatabaseFactory(DataBaseType type)
        {
            switch (type)
            {
                case DataBaseType.SQLSERVER:
                    return new SqlserverDBFactory();


                case DataBaseType.ORACLE:
                    return new OracleDBFactory();

                case DataBaseType.MYSQL:
                    return null;
                case DataBaseType.ACCESS:
                    return null;
                default:
                    throw new Exception(type + "数据库访问层未实现!");

            }
        }
    }
}
