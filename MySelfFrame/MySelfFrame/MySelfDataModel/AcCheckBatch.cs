//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySelfDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class AcCheckBatch
    {
        public int ID { get; set; }
        public int ShiftID { get; set; }
        public int ProductionLineID { get; set; }
        public int ProductID { get; set; }
        public int CreaterID { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Conclusion { get; set; }
        public int CheckerID { get; set; }
        public System.DateTime CheckTime { get; set; }
        public string Remark { get; set; }
        public byte[] C_T { get; set; }
        public string State { get; set; }
    }
}