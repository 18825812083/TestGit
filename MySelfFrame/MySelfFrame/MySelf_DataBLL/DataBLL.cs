/********************************************************************************
** FileName   :DataBLL
** Description:无
** Author     :WK 
** Date       :2017/2/23 15:33:07
** Year       :2017
** Company    :成都新得利
** Version    :V1.0.0
*********************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySelfData_Model;
using MySelfDataModel;
using MySelf_DataDAL;
namespace MySelf_DataBLL
{
    public static class DataBLL
    {
        public static IRepository<SyUser> userModel = new Repository<SyUser>(DBContext.GetContext());

        public static SyUser GetAllUser(object id, out string info)
        {
            return userModel.GetEntityByWhere(id, out info);
        }
        public static List<SyUser> GetAllUser()
        {
            return (List<SyUser>)userModel.GetALlEntity();
        }

        public static bool AddSyUser(SyUser model,out string info)
        {
           return userModel.AddEntity(model, out info);
           
        }

        public static SyUser GetUserById(int? id)
        {
            SyUser user = new SyUser();
            string info = string.Empty;
            user = userModel.GetEntityByWhere(id, out info);
            return user;
        }

        public static bool delete(int? id)
        {
            SyUser user = new SyUser();
            string info = string.Empty;
            user = userModel.GetEntityByWhere(id, out info);
            return userModel.DeleteEntity(user, out info);
            
        }

        public static bool Edit(SyUser model)
        {
            string info = string.Empty;
           
            return userModel.EditEntity(model, out info);
        }
    }
}
