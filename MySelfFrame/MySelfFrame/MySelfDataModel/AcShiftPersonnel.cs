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
    
    public partial class AcShiftPersonnel
    {
        public int ShiftID { get; set; }
        public int PersonnelID { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int ProductionLineID { get; set; }
        public byte[] C_T { get; set; }
        public string State { get; set; }
    }
}