//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DV.DataProvider
{
    using System;
    using System.Collections.Generic;
    
    public partial class SMSLimitFrequency
    {
        public SMSLimitFrequency()
        {
            this.BusinessUnits = new HashSet<BusinessUnit>();
            this.BusinessUnitTypes = new HashSet<BusinessUnitType>();
        }
    
        public int SMSLimitFrequencyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
        public virtual ICollection<BusinessUnitType> BusinessUnitTypes { get; set; }
    }
}