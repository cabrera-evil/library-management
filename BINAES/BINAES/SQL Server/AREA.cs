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
    
    public partial class AREA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AREA()
        {
            this.ACTIVITY = new HashSet<ACTIVITY>();
        }
    
        public int id { get; set; }
        public string area_name { get; set; }
        public string area_description { get; set; }
        public string schedule { get; set; }
        public Nullable<int> id_manager { get; set; }
        public int id_floor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVITY> ACTIVITY { get; set; }
        public virtual FLOOR_ FLOOR_ { get; set; }
        public virtual MANAGER MANAGER { get; set; }
    }
}
