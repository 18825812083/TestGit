/********************************************************************************
** FileName   :IDbContext
** Description:数据上下文接口
** Author     :WK 
** Date       :2017/2/9 9:44:10
** Year       :2017
** Company    :成都新得利
** Version    :V1.0.0
*********************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySelfDataModel;
namespace MySelf_DataDAL
{
    public  class DBContext
    {
        private static readonly object _lock = new object();
        private static LGDataBaseEntities _context;
        public static LGDataBaseEntities GetContext()
        {
            if (null == _context)
            {
                lock (_lock)
                {
                    if (null == _context)
                    {
                        _context = new LGDataBaseEntities();
                    }

                }
            }

            return _context;
        }


    }
}
