//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3BHIF_PRE_2Semester_VILIMEK_BREUNIG.modell
{
    using System;
    using System.Collections.Generic;
    
    public partial class Termin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Termin()
        {
            this.TundBvonPs = new HashSet<TundBvonP>();
        }
    
        public System.DateTime Zeit { get; set; }
        public int Nr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TundBvonP> TundBvonPs { get; set; }
    }
}
