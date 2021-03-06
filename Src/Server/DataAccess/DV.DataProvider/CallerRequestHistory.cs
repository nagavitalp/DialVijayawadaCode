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
    
    public partial class CallerRequestHistory
    {
        public CallerRequestHistory()
        {
            this.SMSHistories = new HashSet<SMSHistory>();
        }
    
        public int CallerRequestHistoryID { get; set; }
        public int CallerID { get; set; }
        public System.DateTime CallDateTime { get; set; }
        public string RequestedDetails { get; set; }
        public int TeleCallerID { get; set; }
        public int CallDurationinSecs { get; set; }
    
        public virtual Caller Caller { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<SMSHistory> SMSHistories { get; set; }
    }
}
