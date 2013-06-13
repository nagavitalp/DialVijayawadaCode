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
    
    public partial class BusinessUnit_Flat
    {
        public int BusinessUnitID { get; set; }
        public string Name { get; set; }
        public string NatureofBusiness { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> BusinessUnitTypeID { get; set; }
        public Nullable<int> AdressID { get; set; }
        public Nullable<int> SMSLimitFrequency { get; set; }
        public Nullable<int> SMSLimitCount { get; set; }
        public string PrimaryContactNumber { get; set; }
        public string SMSContactNumber { get; set; }
        public string ContactPersonName { get; set; }
        public string Keywords { get; set; }
        public string AdditionalInfo { get; set; }
        public Nullable<bool> IsSMSEnabled { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> AddressID { get; set; }
        public string DoorNo { get; set; }
        public string BuildingName { get; set; }
        public string Street { get; set; }
        public string Address1 { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Pincode { get; set; }
        public string LandMark { get; set; }
        public string EmailID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string BusinessUnitTypeName { get; set; }
        public Nullable<int> BusinessUnitSMSCountLimit { get; set; }
        public Nullable<int> BusinessUnitSMSLimitFrequencyID { get; set; }
    }
}