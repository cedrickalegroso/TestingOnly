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
    
    public partial class Commission
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public string AgentNumber { get; set; }
        public int UnitSold { get; set; }
        public decimal CommissionAmount { get; set; }
    
        public virtual UnitDetail UnitDetail { get; set; }
    }
}
