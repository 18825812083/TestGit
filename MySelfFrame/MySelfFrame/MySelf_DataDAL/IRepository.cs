/********************************************************************************
** FileName   :IRepository
** Description:泛型仓储接口
** Author     :WK 
** Date       :2017/2/9 9:50:28
** Year       :2017
** Company    :成都新得利
** Version    :V1.0.0
*********************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySelf_DataDAL
{
    public interface IRepository<T> where T:class
    {
        bool AddEntity(T entity,out string info);
        bool DeleteEntity(T entity, out string info);
        bool EditEntity(T entity, out string info);
        T GetEntityByWhere(object id,out string info);
        IEnumerable<T> GetALlEntity();
        void Save();
        void Dispose();


    }
}
