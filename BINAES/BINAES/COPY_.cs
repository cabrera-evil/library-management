//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BINAES
{
    using System;
    using System.Collections.Generic;
    
    public partial class COPY_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COPY_()
        {
            this.AUTHOR = new HashSet<AUTHOR>();
            this.LABEL_ = new HashSet<LABEL_>();
            this.WORDS_LIST = new HashSet<WORDS_LIST>();
            this.LOAN_BOOKING = new HashSet<LOAN_BOOKING>();
        }
    
        public int id { get; set; }
        public string copy_name { get; set; }
        public string picture { get; set; }
        public System.DateTime release_date { get; set; }
        public int id_collection { get; set; }
        public int id_language { get; set; }
        public int id_format { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUTHOR> AUTHOR { get; set; }
        public virtual COLLECTION_ COLLECTION_ { get; set; }
        public virtual FORMAT_ FORMAT_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABEL_> LABEL_ { get; set; }
        public virtual LANGUAGE_ LANGUAGE_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WORDS_LIST> WORDS_LIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOAN_BOOKING> LOAN_BOOKING { get; set; }
    }
}