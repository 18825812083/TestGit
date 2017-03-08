/********************************************************************************
** FileName   :ProductA
** Description:无
** Author     :WK 
** Date       :2017/2/7 15:55:32
** Year       :2017
** Company    :成都新得利
** Version    :V1.0.0
*********************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.SimpleFactory
{
    class ProductA : IProduct
    {
        public void CreateProduct()
        {
            Console.WriteLine("生产了一个产品A");
        }
    }
}
