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
    
    public partial class GOAL
    {
        public int id { get; set; }
        public string name_ { get; set; }
        public int id_celebration { get; set; }
    
        public virtual CELEBRATION CELEBRATION { get; set; }
    }
}
