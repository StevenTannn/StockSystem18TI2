//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stock
{
    using System;
    using System.Collections.Generic;
    
    public partial class tableCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tableCustomer()
        {
            this.tableStockKeluars = new HashSet<tableStockKeluar>();
        }
    
        public int idCustomer { get; set; }
        public string namaCustomer { get; set; }
        public string alamat { get; set; }
        public string noTelp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tableStockKeluar> tableStockKeluars { get; set; }
    }
}