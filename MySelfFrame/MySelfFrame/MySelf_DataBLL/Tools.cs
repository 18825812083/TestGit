/********************************************************************************
** FileName   :Tools
** Description:公共类
** Author     :WK 
** Date       :2017/2/27 14:58:02
** Year       :2017
** Company    :成都新得利
** Version    :V1.0.0
*********************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MySelf_DataBLL
{
    public static class Tools
    {
        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="obj1">源数据对象</param>
        /// <param name="obj2">目标赋值对象</param>
        public static void AutoValue(object obj1,object obj2)
        {
            Type T = obj1.GetType();//获得该类的类型
            Type T2 = obj2.GetType();//目标赋值类类型
            PropertyInfo[] items = T.GetProperties();
            PropertyInfo [] items2= T2.GetProperties();
            for (int i = 0; i < items.Length; i++)
            {
                string name = items[i].Name;
                //string value = items[i].GetValue(obj1, null).ToString();

                if (null == items2[i].Name || items2[i].GetType() != items[i].GetType()) continue;

                items2[i].SetValue(obj2,items[i].GetValue(obj1,null));
            }
        }

    }
}
