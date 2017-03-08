/********************************************************************************
** FileName   :FactoryCreateProduct
** Description:无
** Author     :WK 
** Date       :2017/2/7 15:57:43
** Year       :2017
** Company    :成都新得利
** Version    :V1.0.0
*********************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.SimpleFactory;
namespace UnitTest.SimpleFactory
{
   public static class FactoryCreateProduct
    {
        public static IProduct CreateProduct(string type)
        {
            switch (type)
            {
                case "A":
                    return new ProductA();
                case "B":
                    return new ProductB();
                default:
                    return null;
                    
            }

        }
    }
}
