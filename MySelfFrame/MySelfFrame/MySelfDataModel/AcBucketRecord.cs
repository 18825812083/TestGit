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
    
    public partial class AcBucketRecord
    {
        public int ID { get; set; }
        public string Barcode { get; set; }
        public string BusinessTypes { get; set; }
        public string Remark { get; set; }
        public System.DateTime OperateTime { get; set; }
        public int OperatorID { get; set; }
        public byte[] C_T { get; set; }
    }
}
