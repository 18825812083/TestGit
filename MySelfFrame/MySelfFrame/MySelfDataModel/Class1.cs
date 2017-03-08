using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySelfDataModel;

namespace MySelfData_Model
{
    public class Class1
    {
        public void run()
        {

            LGDataBaseEntities context = new LGDataBaseEntities();
            context.SyUser.Add(new SyUser());

        }
    }
}
