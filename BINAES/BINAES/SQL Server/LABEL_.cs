//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BINAES.SQL_Server
{
    using System;
    using System.Collections.Generic;
    
    public partial class LABEL_
    {
        public int id { get; set; }
        public string label_code { get; set; }
        public int id_copy { get; set; }
        public int id_label_type { get; set; }
    
        public virtual COPY_ COPY_ { get; set; }
        public virtual LABEL_TYPE LABEL_TYPE { get; set; }
    }
}
