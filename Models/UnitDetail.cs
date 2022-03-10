//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnitDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnitDetail()
        {
            this.Commissions = new HashSet<Commission>();
        }
    
        public int Id { get; set; }
        public string UnitName { get; set; }
        public string Furnishing { get; set; }
        public int Bedroom { get; set; }
        public int Bath { get; set; }
        public string FloorArea { get; set; }
        public decimal Net_Price { get; set; }
        public int UnitTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commission> Commissions { get; set; }
        public virtual UnitType UnitType { get; set; }
    }
}