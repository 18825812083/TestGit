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
    
    public partial class PfRawInDetail
    {
        public int ID { get; set; }
        public int PID { get; set; }
        public int EquipmentID { get; set; }
        public string ProducingAreas { get; set; }
        public string ProductionDate { get; set; }
        public string Batch { get; set; }
        public int PersonID { get; set; }
        public decimal Amount { get; set; }
        public string LinkProofName { get; set; }
        public string LinkProofNo { get; set; }
        public string Remark { get; set; }
        public bool del { get; set; }
        public byte[] C_T { get; set; }
    }
}
