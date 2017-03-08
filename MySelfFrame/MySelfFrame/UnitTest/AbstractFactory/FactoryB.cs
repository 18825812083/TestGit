﻿/********************************************************************************
** FileName   :FactoryB
** Description:无
** Author     :WK 
** Date       :2017/2/7 16:08:40
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

namespace UnitTest.AbstractFactory
{
    class FactoryB : IFactory
    {
        public IProduct Create()
        {
            return new ProductB();
        }
    }
}