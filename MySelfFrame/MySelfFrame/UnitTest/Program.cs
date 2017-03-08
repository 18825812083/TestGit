using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySelft_DataFactory;
using UnitTest.SimpleFactory;
using UnitTest.AbstractFactory;
using System.Data;
namespace UnitTest
{
    class Program
    {
        private static WCFService.ServiceClient service = new UnitTest.WCFService.ServiceClient();
       // public string MyProperty { get; set; }
        static void Main(string[] args)
        {
            //string info = string.Empty;
            //DataSet ds= service.QueryBySql("", out info);
            //DataTable dt = new DataTable();
            //if (ds != null && ds.Tables.Count > 0)
            //{
            //    dt = ds.Tables[0];
            //}

            //foreach (DataRow item in dt.Rows)
            //{


            //}
            List<TestTree> ds = new List<TestTree>()
    {
        new TestTree(){ ID=7, Name="前端开发组1", PID=4},
        new TestTree(){ ID=1, Name="XX公司", PID=0},
        new TestTree(){ ID=2, Name="开发部", PID=1},
         new TestTree(){ ID=8, Name="开发部2", PID=1},
        new TestTree(){ ID=3, Name=".NET开发部门", PID=2},
        new TestTree(){ ID=5, Name=".NET开发组1", PID=3},
        new TestTree(){ ID=4, Name="前端开发部门", PID=2},
        new TestTree(){ ID=6, Name=".NET开发组2", PID=3},
    };
            Console.WriteLine(GetTree(0, ds)); 
            Console.ReadKey();

        }

        static string GetTree(int id,List<TestTree> list)
        {
            
            string info = string.Empty;
            foreach (TestTree item in list)
            {
                if (item.PID==id)
                {
                    info += item.Name + "\n\t";
                    info += GetTree(item.ID, list);
                }
            }
            return info;
        }
    }
    class TestTree
    {
        public int ID { get; set; }

        public int PID { get; set; }
        public string Name { get; set; }


    }
}
