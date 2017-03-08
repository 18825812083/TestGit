/********************************************************************************
** FileName   :IDatabaseFactory
** Description:无
** Author     :WK 
** Date       :2017/2/7 14:18:10
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
    public interface IDatabaseFactory
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        string conStr { get; set; }
        /// <summary>
        /// 测试方法
        /// </summary>
        string Print();
        /// <summary>
        /// 生成连接对象
        /// </summary>
        /// <returns>Connection对象</returns>
        IDbConnection CreateConnection();
        /// <summary>
        /// 生成连接对象
        /// </summary>
        /// <param name="connectionStr">连接字符串</param>
        /// <returns>Connection对象</returns>
        IDbConnection CreateConnectionByStr(string connectionStr);
        /// <summary>  
        /// 建立Command对象  
        /// </summary>  
        /// <returns>Command对象</returns>  
        IDbCommand CreateCommand();

        /// <summary>  
        /// 建立DataAdapter对象  
        /// </summary>  
        /// <returns>DataAdapter对象</returns>  
        IDbDataAdapter CreateDataAdapter();

        /// <summary>  
        /// 根据Connection建立Transaction  
        /// </summary>  
        /// <param name="myConn">Connection对象</param>  
        /// <returns>Transaction对象</returns>  
        IDbTransaction CreateTransaction(IDbConnection myConn);

        /// <summary>  
        /// 根据Command对象建立DataReader  
        /// </summary>  
        /// <param name="myComm">Command对象</param>  
        /// <returns>DataReader对象</returns>  
        IDataReader CreateDataReader(IDbCommand myComm);

    }
}
