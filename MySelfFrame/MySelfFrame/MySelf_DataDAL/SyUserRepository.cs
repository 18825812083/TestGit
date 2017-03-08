/********************************************************************************
** FileName   :SyUserRepository
** Description:无
** Author     :WK 
** Date       :2017/2/20 15:27:14
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
using MySelfData_Model;
using System.Data.Entity;

namespace MySelf_DataDAL
{
    class SyUserRepository 
    {
        
        public void run()
        {
            IRepository<SyUser> db = new Repository<SyUser>(DBContext.GetContext());
            db.GetALlEntity();

        }
    }
}
